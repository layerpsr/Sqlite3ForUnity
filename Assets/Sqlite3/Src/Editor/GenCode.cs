namespace Sqlite3.Editor
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using Sqlite3;
    using Sqlite3.Attribute;
    using UnityEditor;
    using UnityEngine;

    /// <summary>
    /// 为TableMapping生成脚本
    /// </summary>
    public static class GenCode
    {
        public static readonly string mgrPath = Application.dataPath + "/Sqlite3/Gen/MappingMgr.cs";
        public static readonly string codePath = Application.dataPath + "/Sqlite3/Gen/Gen.cs";
        public static readonly string minCodePath = Application.dataPath + "/Sqlite3/Gen/Gen.min.cs";

        [MenuItem("Tools/Sqlite3/Gen Code")]
        public static void GenCode_()
        {
            //Delete
            if (File.Exists(codePath)) File.Delete(codePath);
            if (File.Exists(minCodePath)) File.Delete(minCodePath);
            File.WriteAllText(mgrPath, GenMgr(null));
            //构建脚本
            var (script, types) = GenTypes();
            File.WriteAllText(codePath, script);
            File.WriteAllText(mgrPath, GenMgr(types));
            //Refresh
            AssetDatabase.Refresh();
        }
        [MenuItem("Tools/Sqlite3/Gen MiniCode")]
        public static void GenMiniCode_()
        {
            //Delete
            if (File.Exists(codePath)) File.Delete(codePath);
            if (File.Exists(minCodePath)) File.Delete(minCodePath);
            File.WriteAllText(mgrPath, GenMgr(null));
            //构建脚本
            var (script, types) = GenTypesMini();
            File.WriteAllText(minCodePath, script);
            File.WriteAllText(mgrPath, GenMgr(types));
            //Refresh
            AssetDatabase.Refresh();
        }
        [MenuItem("Tools/Sqlite3/Clear Code")]
        public static void ClearCode_()
        {
            //Delete
            if (File.Exists(codePath)) File.Delete(codePath);
            if (File.Exists(minCodePath)) File.Delete(minCodePath);
            File.WriteAllText(mgrPath, GenMgr(null));
            //Refresh
            AssetDatabase.Refresh();
        }


        /// <summary>
        /// 获取所有需要生成文件的类型
        /// </summary>
        static Dictionary<Type, TableMapping> GetTypes()
        {
            var exclude = new List<string>
            {
                "UnityEngine",
                "UnityEngine.UI",
            };
            bool IsExcluded(Type type)
            {
                var fullName = type.FullName;
                for (int i = 0; i < exclude.Count; i++)
                {
                    if (fullName.Contains(exclude[i]))
                    {
                        return true;
                    }
                }
                return false;
            }
            //获取所有(非委托丶非接口丶非枚举)类型
            var types = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                         where !(assembly.ManifestModule is System.Reflection.Emit.ModuleBuilder)
                         from type in assembly.GetExportedTypes()
                         where !IsExcluded(type) && type.BaseType != typeof(MulticastDelegate) && !type.IsInterface && !type.IsEnum
                         select type);

            //遍历, 生成代码信息
            var dict = new Dictionary<Type, TableMapping>();
            foreach (var type in types)
            {
                if (!type.IsPublic && !type.IsNestedPublic)
                    continue;
                if (type.IsAbstract && type.IsSealed)
                {
                    //静态类(抽象类丶密封类)
                    var configs = new List<Config>();
                    foreach (var field in type.GetFields())
                    {
                        var attr = (TableConfigAttribute)field.GetCustomAttributes(typeof(TableConfigAttribute), false).FirstOrDefault();
                        if (attr != null)
                        {
                            var v = field.GetValue(null) as IEnumerable<Config>;
                            configs.AddRange(v);
                        }
                    }
                    foreach (var prop in type.GetProperties())
                    {
                        var attr = (TableConfigAttribute)prop.GetCustomAttributes(typeof(TableConfigAttribute), false).FirstOrDefault();
                        if (attr != null)
                        {
                            var v = prop.GetValue(null) as IEnumerable<Config>;
                            configs.AddRange(v);
                        }
                    }
                    //生成
                    var prop_pk = typeof(Column).GetProperty("IsPK");
                    var prop_autoinc = typeof(Column).GetProperty("IsAutoInc");
                    var prop_unique = typeof(Column).GetProperty("IsUnique");
                    var prop_def = typeof(Column).GetProperty("DefaultValue");
                    var prop_max_len = typeof(Column).GetProperty("MaxLength");
                    var prop_auto_create = typeof(Column).GetProperty("IsAutoCreateIns");
                    var prop_pk_sql = typeof(TableMapping).GetProperty("GetByPrimaryKeySql");

                    foreach (var c in configs)
                    {
                        //Name
                        var c_type = c.Type;
                        var table_name = c?.Name ?? c_type.FullName.Replace(".", "_").Replace("+", "_");
                        //Colums
                        var props = c_type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty);
                        var fields = c_type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetField | BindingFlags.GetField);
                        var cols = new List<Column>();
                        Column pk = null;

                        foreach (var prop in props)
                        {
                            var name = prop.Name;
                            if (!prop.CanWrite || c.Ignores != null && c.Ignores.Contains(name))
                                continue;

                            var col = new ColumnProp(prop);
                            prop_pk.SetValue(col, c.PK == name);
                            prop_autoinc.SetValue(col, c.PK == name && c.AutoInc);
                            prop_unique.SetValue(col, c.Uniques != null && c.Uniques.Contains(name));
                            prop_def.SetValue(col, c.DefaultValues != null && c.DefaultValues.ContainsKey(name) ? c.DefaultValues[name] : null);
                            prop_max_len.SetValue(col, c.MaxLengths != null && c.MaxLengths.ContainsKey(name) ? c.MaxLengths[name] : null);
                            prop_auto_create.SetValue(col, c.AllAutoCreateIns);

                            cols.Add(col);
                            if (col.IsPK) pk = col;
                        }
                        foreach (var field in fields)
                        {
                            var name = field.Name;
                            if (!field.IsPublic || c.Ignores != null && c.Ignores.Contains(name))
                                continue;
                            var col = new ColumnField(field);
                            prop_pk.SetValue(col, c.PK == name);
                            prop_autoinc.SetValue(col, c.PK == name && c.AutoInc);
                            prop_unique.SetValue(col, c.Uniques != null && c.Uniques.Contains(name));
                            prop_def.SetValue(col, c.DefaultValues != null && c.DefaultValues.ContainsKey(name) ? c.DefaultValues[name] : null);
                            prop_max_len.SetValue(col, c.MaxLengths != null && c.MaxLengths.ContainsKey(name) ? c.MaxLengths[name] : null);
                            prop_auto_create.SetValue(col, c.AllAutoCreateIns);

                            cols.Add(col);
                            if (col.IsPK) pk = col;
                        }

                        var mapping = new TableMapping(c_type, table_name, cols.ToArray(), pk);
                        //PK
                        if (pk != null)
                            prop_pk_sql.SetValue(mapping, string.Format("SELECT * FROM \"{0}\" WHERE \"{1}\" = ?", mapping.TableName, pk.Name));
                        else
                            prop_pk_sql.SetValue(mapping, string.Format("SELECT * FROM \"{0}\" LIMIT 1", mapping.TableName));

                        //添加到列表
                        if (dict.ContainsKey(c_type))
                        {
                            dict.Remove(c_type);
                            Debug.LogWarning(string.Format("Type '{0}' has multiple config", c_type));
                        }
                        dict.Add(c_type, mapping);
                    }
                }
                else
                {
                    //实例类
                    var attrs = type.GetCustomAttributes(typeof(TableAttribute), false);
                    if (attrs.Length > 0)
                    {
                        //添加到列表
                        if (dict.ContainsKey(type))
                        {
                            Debug.LogWarning(string.Format("Type '{0}' has multiple config", type));
                            dict.Remove(type);
                        }
                        dict.Add(type, new TableMemMapping(type));
                    }
                }
            }

            return dict;
        }
        /// <summary>
        /// 构建所有类型
        /// </summary>
        /// <returns></returns>
        static (string, List<(string, string)>) GenTypes()
        {
            var script = "";
            var types = new List<(string, string)>();
            foreach (var obj in GetTypes())
            {
                var fullname = obj.Key.FullName;
                var gen_name = fullname.Replace("+", "").Replace(".", "") + "MappingWarp";
                types.Add((fullname.Replace("+", "."), gen_name));
                script += "\r" + GenMapping(gen_name, obj.Value);
            }
            script = "namespace Sqlite3.Gen\n{\n" + script + "\n}";
            return (script, types);
        }
        /// <summary>
        /// 构建所有类型 (Mini)
        /// </summary>
        static (string, List<(string, string)>) GenTypesMini()
        {
            //构建脚本
            var (script, types) = GenTypes();
            //转为Mini脚本
            var script_min = "";
            foreach (var line in script.Replace("\n", "\r").Split('\r'))
            {
                var s = line.Trim();
                if (!string.IsNullOrEmpty(s) && !s.StartsWith("//")) script_min += s;
            }
            return (script_min, types);
        }
        /// <summary>
        /// 构建Mgr脚本
        /// </summary>
        static string GenMgr(List<(string, string)> types)
        {
            var mappings = "";
            if (types != null)
            {
                for (int i = 0; i < types.Count; i++)
                {
                    mappings += string.Format("{{ typeof({0}), new Sqlite3.Gen.{1}() }}", types[i].Item1, types[i].Item2);
                    if (i < types.Count - 1)
                        mappings += ",\n";
                }
            }
            return string.Format(
@"namespace Sqlite3
{{
    using System;
    using System.Collections.Generic;

    public static class MappingMgr
    {{
        static Dictionary<Type, TableMapping> _mapping;
        static MappingMgr()
        {{
            _mapping = new Dictionary<Type, TableMapping>()
            {{
                {0}
            }};
        }}
        public static TableMapping GetMapping<T>()
        {{
            return GetMapping(typeof(T));
        }}
        public static TableMapping GetMapping(Type type)
        {{
            if (_mapping.ContainsKey(type))
            {{
                return _mapping[type];
            }}
            UnityEngine.Debug.LogWarning(string.Format(""Type '{{0}}' not gen mapping code"", type.FullName));
            return null;
        }}
    }}
}}", mappings);
        }
        /// <summary>
        /// 构建Mapping脚本
        /// </summary>
        static string GenMapping(string name, TableMapping mapping)
        {
            //构建Columns
            var gen_ctor = _GenCtor(mapping);
            //构建Column SetValue
            var gen_set = _GenColumnSet(mapping);
            //构建Column GetValue\
            var gen_get = _GenColumnGet(mapping);
            //构建默认Ins创建
            var gen_auto_ins = _GenAutoIns(mapping);

            var script =
@"
    public class {0} : Sqlite3.TableMapping
    {{
        //Ctor
        public {0}()
        {{
            {1}
        }}
        //Column Ctor
        public class Column : Sqlite3.Column
        {{
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {{
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }}
            {2}
            {3}
            {4}
        }}
    }}";
            return string.Format(script,
                name,
                gen_ctor,
                gen_set,
                gen_get,
                gen_auto_ins);
        }

        static string _GenCtor(TableMapping mapping)
        {
            //Columns
            var pk = "null";
            var columns = "";
            foreach (var col in mapping.Columns)
            {
                var str = string.Format(@"new Column(""{0}"", typeof({1}), ""{2}"", {3}, {4}, {5}, {6}, {7}, {8}, {9})",
                    col.PropertyName,
                    SupportExtend.GetNormalFullName(col.ColumnType),
                    col.Name,
                    col.IsPK ? "true" : "false",
                    col.IsAutoInc ? "true" : "false",
                    col.IsUnique ? "true" : "false",
                    col.IsNotNull ? "true" : "false",
                    col.DefaultValue == null ? "null" : ("\"" + col.DefaultValue + "\""),
                    !col.MaxLength.HasValue ? "null" : col.MaxLength.Value.ToString(),
                    col.IsAutoCreateIns ? "true" : "false"
                    );
                if (col.IsPK)
                {
                    pk = str;
                    columns += "this.PK,\n";
                }
                else
                    columns += str + ",\n";
            }
            //GetByPrimaryKeySql
            var pk_sql = "";
            if (mapping.PK != null)
                pk_sql = string.Format("SELECT * FROM \"{0}\" WHERE \"{1}\" = ?", mapping.TableName, mapping.PK.Name);
            else
                pk_sql = string.Format("SELECT * FROM \"{0}\" LIMIT 1", mapping.TableName);

            return string.Format(
@"
            this.MappedType = typeof({0});
            this.TableName = ""{1}"";
            //Columns
            this.PK = {2};
            this.Columns = new[]
            {{
                {3}
            }};

            this.GetByPrimaryKeySql = ""{4}"";
",
                mapping.MappedType.FullName.Replace("+", "."),
                mapping.TableName,
                pk,
                columns,
                pk_sql.Replace("\"", "\\\""));
        }
        static string _GenColumnSet(TableMapping mapping)
        {
            //Columns
            var columns = "";
            foreach (var col in mapping.Columns)
            {
                var normal_fullnam = SupportExtend.GetNormalFullName(col.ColumnType);
                //Gen switch case
                columns += string.Format(
@"                  case ""{0}"":
                        _obj.{0}=({1})val;
                        break;
",
                    col.PropertyName,
                    normal_fullnam);
            }

            return string.Format(
@"public override void SetValue(object obj, object val)
            {{
                var _obj = ({0})obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {{
 {1}
                    default:
                        throw new System.NotSupportedException(""Error prop name: "" + this.PropertyName);
                }}
            }}",
                mapping.MappedType.FullName.Replace("+", "."),
                columns);
        }
        static string _GenColumnGet(TableMapping mapping)
        {
            //Columns
            var columns = "";
            foreach (var col in mapping.Columns)
            {
                columns += string.Format(
@"                  case ""{0}"":
                        return _obj.{0};
",
                    col.PropertyName);
            }

            return string.Format(
@"public override object GetValue(object obj)
            {{
                var _obj = ({0})obj;
                switch (this.PropertyName)
                {{
 {1}
                    default:
                        throw new System.NotSupportedException(""Error prop name: "" + this.PropertyName);
                }}
            }}",
                mapping.MappedType.FullName.Replace("+", "."),
                columns);
        }
        static string _GenAutoIns(TableMapping mapping)
        {
            //Columns
            var columns = "";
            foreach (var col in mapping.Columns)
            {
                //Auto Create Ins
                var is_object_type = !col.ColumnType.IsValueType && col.ColumnType.FullName != "System.String";
                if (!is_object_type)
                    continue;

                var normal_fullnam = SupportExtend.GetNormalFullName(col.ColumnType);
                var is_array = normal_fullnam.IndexOf("[]") >= 0;
                //Gen switch case
                columns += string.Format(
@"                  case ""{0}"":
                        return new {1};
",
                    col.PropertyName,
                    is_array ? normal_fullnam.Replace("[]", "[0]") : (normal_fullnam + "()"));
            }

            return string.Format(
@"private object AutoCreateIns()
            {{
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {{
 {0}
                    default:
                        return null;
                }}
            }}",
                columns);
        }
    }
}

namespace Sqlite3.Attribute
{
    using System;
    using System.Collections.Generic;
    /**
    * 定义一个表配置(仅在Editor下, Gen Code时有效)
    */
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class TableConfigAttribute : TableAttribute
    {
    }
    public class Config
    {
        //目标类型
        public Type Type { get; set; }
        public string Name { get; set; }
        //主键字段名
        public string PK { get; set; }
        public bool AutoInc { get; set; } = false;
        //唯一约束字段名称
        public string[] Uniques { get; set; }
        //不为空字段名称
        public string[] NotNulls { get; set; }
        //默认值信息
        public Dictionary<string, string> DefaultValues { get; set; }
        //长度信息
        public Dictionary<string, int?> MaxLengths { get; set; }
        //忽略字段
        public string[] Ignores { get; set; }

        //自动创建对象,当 SetValue 为null时, 为其创建默认对象
        public bool AllAutoCreateIns { get; set; }

        public Config(Type type)
        {
            this.Type = type;
        }
        public Config(Type type, string name)
        {
            this.Type = type;
            this.Name = name;
        }
        public Config Clone()
        {
            return MemberwiseClone() as Config;
        }
    }
}