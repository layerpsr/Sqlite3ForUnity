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
            var (script, types) = GenTypes();
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
            TableMapping Create(Type type, TableConfigAttribute config)
            {
                //Name
                var table_name = config?.Name ?? type.Name;
                //Colums
                var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty);
                var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetField | BindingFlags.GetField);
                var cols = new List<Column>();
                Column pk = null;

                PropertyInfo prop_pk = typeof(Column).GetProperty("IsPK");
                PropertyInfo prop_autoinc = typeof(Column).GetProperty("IsAutoInc");
                PropertyInfo prop_unique = typeof(Column).GetProperty("IsUnique");
                PropertyInfo prop_def = typeof(Column).GetProperty("DefaultValue");
                PropertyInfo prop_max_len = typeof(Column).GetProperty("MaxLength");
                foreach (var prop in props)
                {
                    var name = prop.Name;
                    if (!prop.CanWrite || config.Ignores != null && config.Ignores.Contains(name))
                        continue;

                    var c = new ColumnProp(prop);
                    prop_pk.SetValue(c, config.PK == name);
                    prop_autoinc.SetValue(c, config.PK == name && config.AutoInc);
                    prop_unique.SetValue(c, config.Uniques != null && config.Uniques.Contains(name));
                    prop_def.SetValue(c, config.DefaultValues != null && config.DefaultValues.ContainsKey(name) ? config.DefaultValues[name] : null);
                    prop_max_len.SetValue(c, config.MaxLengths != null && config.MaxLengths.ContainsKey(name) ? config.MaxLengths[name] : null);

                    cols.Add(c);
                    if (c.IsPK) pk = c;
                }
                foreach (var field in fields)
                {
                    var name = field.Name;
                    if (!field.IsPublic || config.Ignores != null && config.Ignores.Contains(name))
                        continue;
                    var c = new ColumnField(field);
                    prop_pk.SetValue(c, config.PK == name);
                    prop_autoinc.SetValue(c, config.PK == name && config.AutoInc);
                    prop_unique.SetValue(c, config.Uniques != null && config.Uniques.Contains(name));
                    prop_def.SetValue(c, config.DefaultValues != null && config.DefaultValues.ContainsKey(name) ? config.DefaultValues[name] : null);
                    prop_max_len.SetValue(c, config.MaxLengths != null && config.MaxLengths.ContainsKey(name) ? config.MaxLengths[name] : null);

                    cols.Add(c);
                    if (c.IsPK) pk = c;
                }

                var mapping = new TableMapping(type, table_name, cols.ToArray(), pk);
                //PK
                var pk_prop = typeof(TableMapping).GetProperty("GetByPrimaryKeySql");
                if (pk != null)
                    pk_prop.SetValue(mapping, string.Format("SELECT * FROM \"{0}\" WHERE \"{1}\" = ?", mapping.TableName, pk.Name));
                else
                    pk_prop.SetValue(mapping, string.Format("SELECT * FROM \"{0}\" LIMIT 1", mapping.TableName));

                return mapping;
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
                //静态类(抽象类丶密封类)
                if (type.IsAbstract && type.IsSealed)
                {
                    foreach (var field in type.GetFields(BindingFlags.GetField))
                    {
                        var attr = (TableConfigAttribute)type.GetCustomAttributes(typeof(TableConfigAttribute), false).FirstOrDefault();
                        if (attr != null && field.IsPublic)
                        {
                            //添加到列表
                            dict.Add(type, Create(type, attr));
                        }
                    }
                    foreach (var prop in type.GetProperties(BindingFlags.GetProperty))
                    {
                        var attr = (TableConfigAttribute)type.GetCustomAttributes(typeof(TableConfigAttribute), false).FirstOrDefault();
                        if (attr != null && prop.CanRead)
                        {
                            //添加到列表
                            dict.Add(type, Create(type, attr));
                        }
                    }
                }
                else
                {
                    var attrs = type.GetCustomAttributes(typeof(TableAttribute), false);
                    if (attrs.Length > 0)
                    {
                        //添加到列表
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
                    int? max_len)
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
            }}
            {2}
            {3}
        }}
    }}";
            return string.Format(script,
                name, //mapping.MappedType.Name + "MappingGen",
                gen_ctor,
                gen_set,
                gen_get);
        }

        static string _GenCtor(TableMapping mapping)
        {
            //Columns
            var pk = "null";
            var columns = "";
            foreach (var col in mapping.Columns)
            {
                var str = string.Format(@"new Column(""{0}"", typeof({1}), ""{2}"", {3}, {4}, {5}, {6}, {7}, {8})",
                    col.PropertyName,
                    col.ColumnType.FullName,
                    col.Name,
                    col.IsPK ? "true" : "false",
                    col.IsAutoInc ? "true" : "false",
                    col.IsUnique ? "true" : "false",
                    col.IsNotNull ? "true" : "false",
                    col.DefaultValue == null ? "null" : ("\"" + col.DefaultValue + "\""),
                    !col.MaxLength.HasValue ? "null" : col.MaxLength.Value.ToString()
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
                columns += string.Format(
@"                  case ""{0}"":
                        _obj.{0}=({1})val;
                        break;
",
                    col.PropertyName,
                    col.ColumnType.FullName);
            }

            return string.Format(
@"public override void SetValue(object obj, object val)
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
    }
}