namespace Sqlite3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Sqlite3.Attribute;
    using UnityEngine;

    /// <summary>
    /// 表结构映射
    /// </summary>
    public class TableMapping
    {
        public Type MappedType { get; protected set; }
        public string TableName { get; protected set; }
        public Column PK { get; protected set; }
        public Column[] Columns { get; protected set; }
        public Column[] InsertColumns
        {
            get
            {
                if (_insertColumns == null)
                    _insertColumns = this.Columns.Where(col => !col.IsAutoInc).ToArray();
                return _insertColumns;
            }
        }
        public Column[] InsertOrReplaceColumns
        {
            get
            {
                if (_insertOrReplaceColumns == null)
                    _insertOrReplaceColumns = this.Columns.ToArray();
                return _insertOrReplaceColumns;
            }
        }
        //主键查询语句
        public string GetByPrimaryKeySql { get; protected set; }
        //字段信息
        private Column[] _insertColumns;
        private Column[] _insertOrReplaceColumns;
        //插入命令行
        private DBInsertCommand _insertCommand;
        private string _insertCommandExtra;


        protected TableMapping() { }
        public TableMapping(Type type, string table_name, Column[] cols, Column pk)
        {
            this.MappedType = type;
            this.TableName = table_name;
            this.Columns = cols;
            this.PK = pk;

            if (this.PK != null)
                this.GetByPrimaryKeySql = string.Format("SELECT * FROM \"{0}\" WHERE \"{1}\" = ?", this.TableName, this.PK.Name);
            else
                this.GetByPrimaryKeySql = string.Format("SELECT * FROM \"{0}\" LIMIT 1", this.TableName);
        }

        public Column FindColumn(string col_name)
        {
            return this.Columns.FirstOrDefault(col => col.Name == col_name);
        }
        public Column FindColumnWithPropertyName(string col_name)
        {
            return this.Columns.FirstOrDefault(col => col.PropertyName == col_name);
        }

        public void Dispose()
        {
            if (_insertCommand != null)
                _insertCommand.Dispose();
        }
        public DBInsertCommand GetInsertCommand(DBConnection conn, string extra)
        {
            if (_insertCommand == null)
            {
                _insertCommand = CreateInsertCommand(conn, extra);
                _insertCommandExtra = extra;
            }
            else if (_insertCommandExtra != extra)
            {
                _insertCommand.Dispose();
                _insertCommand = CreateInsertCommand(conn, extra);
                _insertCommandExtra = extra;
            }

            return _insertCommand;
        }
        private DBInsertCommand CreateInsertCommand(DBConnection conn, string extra)
        {
            Column[] cols = this.InsertColumns;
            string insertSql;
            if (!cols.Any() && this.Columns.Count() == 1 && this.Columns[0].IsAutoInc)
            {
                insertSql = string.Format("INSERT {1} INTO \"{0}\" DEFAULT VALUES", this.TableName, extra);
            }
            else
            {
                bool replacing = string.Compare(extra, "OR REPLACE", StringComparison.OrdinalIgnoreCase) == 0;

                if (replacing) cols = this.InsertOrReplaceColumns;

                insertSql = string.Format("INSERT {3} INTO \"{0}\"({1}) VALUES ({2})", this.TableName,
                    string.Join(",", (from c in cols select "\"" + c.Name + "\"").ToArray()),
                    string.Join(",", (from c in cols select "?").ToArray()), extra);
            }
            var cmd = new DBInsertCommand(conn);
            cmd.CommandText = insertSql;
            return cmd;
        }
    }

    public class TableMemMapping : TableMapping
    {
        public TableMemMapping(Type type)
        {
            this.MappedType = type;
            //Name
            var attr = (TableAttribute)type.GetCustomAttributes(typeof(TableAttribute), true).FirstOrDefault();
            this.TableName = attr?.Name ?? type.FullName.Replace(".", "_").Replace("+", "_");
            if (attr == null)
            {
                Debug.LogWarning(string.Format("Type '{0}' is undefined as TableAttribute", type.FullName));
            }
            //Colums
            var props = this.MappedType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty);
            var fields = this.MappedType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetField | BindingFlags.GetField);
            var cols = new List<Column>();
            foreach (var prop in props)
            {
                if (!prop.CanWrite || Orm.Ignore(prop))
                    continue;
                var c = new ColumnProp(prop);
                cols.Add(c);
                if (c.IsPK) this.PK = c;
            }
            foreach (var field in fields)
            {
                if (!field.IsPublic || Orm.Ignore(field))
                    continue;
                var c = new ColumnField(field);
                cols.Add(c);
                if (c.IsPK) this.PK = c;
            }
            this.Columns = cols.ToArray();
            //PK
            if (this.PK != null)
                this.GetByPrimaryKeySql = string.Format("SELECT * FROM \"{0}\" WHERE \"{1}\" = ?", this.TableName, this.PK.Name);
            else
                this.GetByPrimaryKeySql = string.Format("SELECT * FROM \"{0}\" LIMIT 1", this.TableName);
        }
    }
}