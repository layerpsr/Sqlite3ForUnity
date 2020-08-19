namespace Sqlite3
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Mono.Data.Sqlite;
    using UnityEngine;

    public class DBCommand
    {
        public string CommandText { get; set; }
        private readonly DBConnection _conn;
        private readonly List<object> _bindings;

        internal DBCommand(DBConnection conn)
        {
            _conn = conn;
            _bindings = new List<object>();
            this.CommandText = "";
        }

        public int ExecuteUpdate()
        {
            if (_conn.Trace) Debug.Log(this);

            var command = Prepare();
            try
            {
                return command.ExecuteNonQuery();
            }
            finally
            {
                Finally(command);
            }
        }

        public List<T> ExecuteQuery<T>()
        {
            return ExecuteQueryDeferred<T>(_conn.GetMapping(typeof(T))).ToList();
        }

        public List<T> ExecuteQuery<T>(TableMapping table)
        {
            return ExecuteQueryDeferred<T>(table).ToList();
        }
        public IEnumerable<T> ExecuteQueryDeferred<T>()
        {
            return ExecuteQueryDeferred<T>(_conn.GetMapping(typeof(T)));
        }
        public IEnumerable<T> ExecuteQueryDeferred<T>(TableMapping table)
        {
            if (_conn.Trace) Debug.Log(this);

            SqliteCommand command = Prepare();
            SqliteDataReader reader = null;
            try
            {
                var cols = table.Columns;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object obj = Activator.CreateInstance(table.MappedType);
                    for (int i = 0; i < cols.Length; i++)
                    {
                        cols[i].SetValue(obj, ReadValue(reader, cols[i].Name, cols[i].ColumnType));
                    }
                    yield return (T)obj;
                }
            }
            finally
            {
                Finally(command, reader);
            }
        }

        public T ExecuteScalar<T>()
        {
            if (_conn.Trace) Debug.Log(this);

            T val = default(T);

            SqliteCommand command = Prepare();
            SqliteDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    val = (T)ReadValue(reader, 0, typeof(T));
                }
            }
            finally
            {
                Finally(command, reader);
            }

            return val;
        }

        public object LastInserRowid<T>()
        {
            return LastInserRowid(this._conn.GetMapping(typeof(T)));
        }

        public object LastInserRowid(TableMapping table)
        {
            var query = "SELECT last_insert_rowid() FROM \"" + table.TableName + "\";";
            if (_conn.Trace) Debug.Log(query);

            SqliteCommand command = new SqliteCommand(this._conn.handle);
            command.CommandText = query;
            command.Prepare();
            SqliteDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return ReadValue(reader, 0, table.PK.ColumnType);
                }
            }
            finally
            {
                Finally(command, reader);
            }
            return -1;
        }

        public void Bind(object val)
        {
            _bindings.Add(val);
        }
        private void BindAll(SqliteCommand command)
        {
            foreach (var obj in _bindings)
            {
                BindParameter(command, obj);
            }
        }
        private SqliteCommand Prepare()
        {
            var command = new SqliteCommand(this.CommandText, this._conn.handle);
            command.Prepare();
            BindAll(command);
            return command;
        }

        private void Finally(SqliteCommand command, SqliteDataReader reader = null)
        {
            command.Cancel();
            command.Dispose();
            reader?.Close();
        }
        public override string ToString()
        {
            var binding = new List<string>();
            for (int i = 0; i < _bindings.Count; i++)
            {
                var fullname = _bindings[i]?.GetType().FullName;
                var is_ie_obj = fullname != null &&
                    (fullname.StartsWith("System.Collections.Generic.List") || fullname.IndexOf("[]") >= 0);
                if (is_ie_obj)
                {
                    string ss = null;
                    foreach (object o in (IEnumerable)_bindings[i])
                    {
                        if (ss != null) ss += ",";
                        ss += o ?? "";
                    }
                    binding.Add(string.Format("{0}:\t[{1}] ", i, ss));
                }
                else
                    binding.Add(string.Format("{0}:\t{1} ", i, _bindings[i]));
            }
            return string.Format("{0}\nBinding:\n{1}", this.CommandText, string.Join("\n", binding));
        }

        public static int BindParameter(SqliteCommand command, object value)
        {
            //SqliteParameter(DbType dbType, object value)构造函数可正常使用
            //SqliteParameter(DbType dbType, string value)将不能插入数值
            ///我也不知道为什么会这样 (笑)
            if (value == null)
                return command.Parameters.Add(new SqliteParameter(DbType.String, (object)""));

            if (value is int)
                return command.Parameters.Add(new SqliteParameter(DbType.Int32, value));
            if (value is string)
                return command.Parameters.Add(new SqliteParameter(DbType.String, value));
            if (value is byte || value is ushort || value is sbyte || value is short)
                return command.Parameters.Add(new SqliteParameter(DbType.Int32, value));
            if (value is bool)
                return command.Parameters.Add(new SqliteParameter(DbType.Int32, (object)((bool)value ? 1 : 0)));
            if (value is uint || value is long)
                return command.Parameters.Add(new SqliteParameter(DbType.Int64, value));
            if (value is float || value is double || value is decimal)
                return command.Parameters.Add(new SqliteParameter(DbType.Double, value));

            if (value.GetType().IsEnum)
                return command.Parameters.Add(new SqliteParameter(DbType.Int64, (object)Convert.ToInt32(value)));
            if (value is byte[])
                return command.Parameters.Add(new SqliteParameter(DbType.Binary, value));
            if (value is Guid)
                return command.Parameters.Add(new SqliteParameter(DbType.String, (object)((Guid)value).ToString()));

            if (value is TimeSpan)
                return command.Parameters.Add(new SqliteParameter(DbType.Int64, value));
            if (value is DateTime)
                return command.Parameters.Add(new SqliteParameter(DbType.String, (object)((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")));
            if (value is DateTimeOffset)
                return command.Parameters.Add(new SqliteParameter(DbType.Int64, value));

            //数据扩展支持(Array/List/Dict)
            var normal_fullnam = SupportExtend.GetNormalFullName(value.GetType());
            if (SupportExtend.IsSupportType(normal_fullnam))
                return command.Parameters.Add(new SqliteParameter(DbType.String, (object)SupportExtend.ToString(value, normal_fullnam)));
            //自定义接口实现
            if (SupportExtend.IsSupportIDataText(value.GetType()))
                return command.Parameters.Add(new SqliteParameter(DbType.String, (object)((IDataText)value).Save()));
            if (SupportExtend.IsSupportIDataBytes(value.GetType()))
                return command.Parameters.Add(new SqliteParameter(DbType.Binary, (object)((IDataBytes)value).Save()));

            throw new NotSupportedException("Cannot store type: " + value.GetType());

        }
        private static object ReadValue(SqliteDataReader reader, string col_name, Type col_type)
        {
            var index = reader.GetOrdinal(col_name);
            return ReadValue(reader, index, col_type);
        }
        private static object ReadValue(SqliteDataReader reader, int index, Type col_type)
        {
            if (reader.IsDBNull(index))
                return null;

            if (col_type == typeof(string))
                return reader.GetString(index);
            if (col_type == typeof(int))
                return reader.GetInt32(index);
            if (col_type == typeof(bool))
                return reader.GetInt32(index) == 1;
            if (col_type == typeof(float))
                return (float)reader.GetDouble(index);
            if (col_type == typeof(double))
                return reader.GetDouble(index);
            if (col_type == typeof(decimal))
                return (decimal)reader.GetDouble(index);
            if (col_type == typeof(long))
                return reader.GetInt64(index);
            if (col_type == typeof(uint))
                return (uint)reader.GetInt64(index);

            if (col_type == typeof(byte))
                return (byte)reader.GetInt32(index);
            if (col_type == typeof(ushort))
                return (ushort)reader.GetInt32(index);
            if (col_type == typeof(short))
                return (short)reader.GetInt32(index);
            if (col_type == typeof(sbyte))
                return (sbyte)reader.GetInt32(index);

            if (col_type.IsEnum)
                return reader.GetInt32(index);
            if (col_type == typeof(Guid))
                return new Guid(reader.GetString(index));
            if (col_type == typeof(byte[]))
            {
                var blob = new byte[reader.GetBytes(index, 0, null, 0, int.MaxValue)];
                reader.GetBytes(index, 0, blob, 0, blob.Length);
                return blob;
            }

            if (col_type == typeof(TimeSpan))
                return new TimeSpan(reader.GetInt64(index));
            if (col_type == typeof(DateTime))
                return DateTime.Parse(reader.GetString(index));
            if (col_type == typeof(DateTimeOffset))
                return new TimeSpan(reader.GetInt64(index));

            //数据扩展支持(Array/List/Dict)
            var normal_fullnam = SupportExtend.GetNormalFullName(col_type);
            if (SupportExtend.IsSupportType(normal_fullnam))
            {
                var text = reader.GetString(index);
                return SupportExtend.ToObject(text, normal_fullnam);
            }
            //自定义接口实现
            if (SupportExtend.IsSupportIDataText(col_type))
            {
                var text = reader.GetString(index);
                var obj = (IDataText)Activator.CreateInstance(col_type);
                obj.Load(text);
                return obj;
            }
            if (SupportExtend.IsSupportIDataBytes(col_type))
            {
                var blob = new byte[reader.GetBytes(index, 0, null, 0, int.MaxValue)];
                reader.GetBytes(index, 0, blob, 0, blob.Length);
                var obj = (IDataBytes)Activator.CreateInstance(col_type);
                obj.Load(blob);
                return obj;
            }

            throw new NotSupportedException("Don't know how to read " + col_type);
        }
    }
}