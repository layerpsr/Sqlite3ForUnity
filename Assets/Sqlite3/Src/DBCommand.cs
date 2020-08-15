
namespace Sqlite3
{
    using System;
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

        public int ExecuteNonQuery()
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
            return ExecuteDeferredQuery<T>(_conn.GetMapping(typeof(T))).ToList();
        }

        public List<T> ExecuteQuery<T>(TableMapping table)
        {
            return ExecuteDeferredQuery<T>(table).ToList();
        }
        public IEnumerable<T> ExecuteDeferredQuery<T>()
        {
            return ExecuteDeferredQuery<T>(_conn.GetMapping(typeof(T)));
        }
        public IEnumerable<T> ExecuteDeferredQuery<T>(TableMapping table)
        {
            if (_conn.Trace) Debug.Log(this);

            var command = Prepare();
            try
            {
                var cols = table.Columns;
                var reader = command.ExecuteReader();
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
                Finally(command);
            }
        }

        public T ExecuteScalar<T>()
        {
            if (_conn.Trace) Debug.Log(this);

            T val = default(T);

            var command = Prepare();

            try
            {
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    val = (T)ReadValue(reader, 0, typeof(T));
                }
            }
            finally
            {
                Finally(command);
            }

            return val;
        }

        public object LastInserRowid<T>()
        {
            return LastInserRowid(this._conn.GetMapping(typeof(T)));
        }

        public object LastInserRowid(TableMapping table)
        {
            if (_conn.Trace) Debug.Log("SELECT last_insert_rowid() FROM \"" + table.TableName + "\";");

            var command = new SqliteCommand(this._conn.handle);
            command.CommandText = "SELECT last_insert_rowid() FROM \"" + table.TableName + "\";";
            command.Prepare();
            try
            {
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return ReadValue(reader, 0, table.PK.ColumnType);
                }
            }
            finally
            {
                Finally(command);
            }
            return -1;
        }

        public void Bind(object val)
        {
            _bindings.Add(val);
        }

        private SqliteCommand Prepare()
        {
            var command = new SqliteCommand(this.CommandText, this._conn.handle);
            command.Prepare();
            BindAll(command);
            return command;
        }

        private void Finally(SqliteCommand command)
        {
            command.Cancel();
            command.Dispose();
        }

        private void BindAll(SqliteCommand command)
        {
            foreach (var obj in _bindings)
            {
                BindParameter(command, obj);
            }
        }

        internal static int BindParameter(SqliteCommand command, object value)
        {
            if (value == null)
                return command.Parameters.Add(new SqliteParameter(DbType.Binary, value));

            if (value is int)
                return command.Parameters.Add(new SqliteParameter(DbType.Int32, value));
            if (value is string)
                return command.Parameters.Add(new SqliteParameter(DbType.String, value));
            if (value is byte || value is ushort || value is sbyte || value is short)
                return command.Parameters.Add(new SqliteParameter(DbType.Int32, value));
            if (value is bool)
                return command.Parameters.Add(new SqliteParameter(DbType.Int32, (bool)value ? 1 : 0));
            if (value is uint || value is long)
                return command.Parameters.Add(new SqliteParameter(DbType.Int64, value));
            if (value is float || value is double || value is decimal)
                return command.Parameters.Add(new SqliteParameter(DbType.Double, value));

            if (value is TimeSpan)
                return command.Parameters.Add(new SqliteParameter(DbType.Int64, value));
            if (value is DateTime)
                return command.Parameters.Add(new SqliteParameter(DbType.String, ((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")));
            if (value is DateTimeOffset)
                return command.Parameters.Add(new SqliteParameter(DbType.Int64, value));

            if (value.GetType().IsEnum)
                return command.Parameters.Add(new SqliteParameter(DbType.Int64, Convert.ToInt32(value)));
            if (value is byte[])
                return command.Parameters.Add(new SqliteParameter(DbType.Binary, value));
            if (value is Guid)
                return command.Parameters.Add(new SqliteParameter(DbType.String, ((Guid)value).ToString()));

            throw new NotSupportedException("Cannot store type: " + value.GetType());

        }

        private object ReadValue(SqliteDataReader reader, string col_name, Type col_type)
        {
            var index = reader.GetOrdinal(col_name);
            return ReadValue(reader, index, col_type);
        }
        private object ReadValue(SqliteDataReader reader, int index, Type col_type)
        {
            if (col_type == typeof(string))
                return reader.GetString(index);
            if (col_type == typeof(int))
                return reader.GetInt32(index);
            if (col_type == typeof(bool))
                return reader.GetInt32(index) == 1;
            if (col_type == typeof(double))
                return reader.GetDouble(index);
            if (col_type == typeof(float))
                return reader.GetDouble(index);

            if (col_type == typeof(TimeSpan))
                return new TimeSpan(reader.GetInt64(index));
            if (col_type == typeof(DateTime))
                return DateTime.Parse(reader.GetString(index));
            if (col_type == typeof(DateTimeOffset))
                return new TimeSpan(reader.GetInt64(index));

            if (col_type.IsEnum)
                return reader.GetInt32(index);

            if (col_type == typeof(long))
                return reader.GetInt64(index);
            if (col_type == typeof(uint))
                return (uint)reader.GetInt64(index);
            if (col_type == typeof(decimal))
                return (decimal)reader.GetDouble(index);
            if (col_type == typeof(byte))
                return (byte)reader.GetInt32(index);
            if (col_type == typeof(ushort))
                return (ushort)reader.GetInt32(index);
            if (col_type == typeof(short))
                return (short)reader.GetInt32(index);
            if (col_type == typeof(sbyte))
                return (sbyte)reader.GetInt32(index);

            if (col_type == typeof(byte[]))
            {
                var blob = new byte[reader.GetBytes(index, 0, null, 0, int.MaxValue)];
                return reader.GetBytes(index, 0, blob, 0, blob.Length);
            }

            if (col_type == typeof(Guid))
            {
                string text = reader.GetString(index);
                return new Guid(text);
            }

            throw new NotSupportedException("Don't know how to read " + col_type);
        }

        public override string ToString()
        {
            int i = 0;
            var binding = (from obj in _bindings select string.Format(" {0}:{1} ", i++, obj));
            return string.Format("{0}\nBinding: [{1}]", this.CommandText, string.Join(",", binding));
        }
    }
}