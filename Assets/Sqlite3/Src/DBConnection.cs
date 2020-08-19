namespace Sqlite3
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using Mono.Data.Sqlite;
    using UnityEngine;
    using Random = System.Random;

    public class DBConnection
    {
        //Mapping
        private Dictionary<string, TableMapping> _mappings;

        //连接实例
        public SqliteConnection handle { get; private set; }
        //连接信息
        public string databasePath { get; private set; }
        public string databaseSource { get; set; } = "DATA SOURCE={0}";
        private bool open = false;
        //Trace
        public bool Trace { get; set; } = false;
        //事务
        private int _transactionDepth;

        public DBConnection(string path)
        {
            this.open = false;
            this.databasePath = path;
            //File Exception
            if (!File.Exists(path))
                throw new System.IO.FileNotFoundException(path);
        }
        ~DBConnection()
        {
            Dispose(false);
        }
        public void Open()
        {
            if (!this.open || this.handle == null)
            {
                //File Exception
                if (!File.Exists(this.databasePath))
                    throw new System.IO.FileNotFoundException(this.databasePath);

                this.handle = new SqliteConnection(string.Format(databaseSource, this.databasePath));
                this.handle.Open();
                this.open = true;
            }
        }
        public void Close()
        {
            if (open && this.handle != null)
            {
                try
                {
                    this.handle.Close();
                }
                finally
                {
                    this.open = false;
                    this.handle = null;
                }
            }
        }
        public void Dispose(bool disposing)
        {
            Close();
        }


        #region 创建表丶删除表丶清空表
        /// <summary> 删除表 </summary>
        public int DropTable<T>()
        {
            return DropTable(typeof(T));
        }
        /// <summary> 删除表 </summary>
        public int DropTable(Type type)
        {
            var table = GetMappingForce(type);
            var query = string.Format("DROP TABLE IF EXISTS \"{0}\"", table.TableName);
            return ExecuteUpdate(query);
        }
        /// <summary> 创建表 </summary>
        public int CreateTable<T>()
        {
            return CreateTable(typeof(T));
        }
        /// <summary> 创建表 </summary>
        public int CreateTable(Type type)
        {
            var table = GetMappingForce(type);

            string query = "CREATE TABLE IF NOT EXISTS \"" + table.TableName + "\"(\n";

            IEnumerable<string> decls = table.Columns.Select(p => Orm.SqlDecl(p));
            query += string.Join(",\n", decls.ToArray());
            query += ")";

            return ExecuteUpdate(query);
        }
        /// <summary>清空表 </summary>
        public int ClearTable<T>()
        {
            return ClearTable(typeof(T));
        }
        /// <summary>清空表 </summary>
        public int ClearTable(Type type)
        {
            var table = GetMapping(type);
            var query = string.Format("DELETE FROM \"{0}\"", table.TableName);
            return ExecuteUpdate(query);
        }
        #endregion


        #region 事务处理
        /// <summary>在事务中执行</summary>
        public void RunInTransaction(Action action)
        {
            try
            {
                string savePoint = SaveTransactionPoint();
                action();
                Release(savePoint);
            }
            catch (Exception)
            {
                Rollback();
                throw;
            }
        }
        /// <summary>开始事务</summary>
        public void BeginTransaction()
        {
            if (Interlocked.CompareExchange(ref _transactionDepth, 1, 0) == 0)
                try
                {
                    ExecuteUpdate("BEGIN TRANSACTION;");
                }
                catch (Exception)
                {
                    Interlocked.Decrement(ref _transactionDepth);
                    throw;
                }
            else
                throw new InvalidOperationException("Cannot begin a transaction while already in a transaction.");
        }
        /// <summary>提交事务</summary>
        public void Commit()
        {
            if (Interlocked.Exchange(ref _transactionDepth, 0) != 0)
                ExecuteUpdate("commit");
        }
        /// <summary>保存"快照"</summary>
        public string SaveTransactionPoint()
        {
            int depth = Interlocked.Increment(ref _transactionDepth) - 1;
            string ret_val = "S" + new Random().Next(short.MaxValue) + "D" + depth;
            try
            {
                ExecuteUpdate("SAVEPOINT " + ret_val);
            }
            catch (Exception)
            {
                Interlocked.Decrement(ref _transactionDepth);
                throw;
            }
            return ret_val;
        }
        /// <summary>回滚事务</summary>
        public void Rollback()
        {
            RollbackTo(null, false);
        }
        private void RollbackTo(string savepoint, bool no_throw)
        {
            try
            {
                if (string.IsNullOrEmpty(savepoint))
                {
                    if (Interlocked.Exchange(ref _transactionDepth, 0) > 0)
                        ExecuteUpdate("ROLLBACK;");
                }
                else
                    DoSavePointExecute(savepoint, "ROLLBACK TO ");
            }
            catch (SqliteException)
            {
                if (!no_throw)
                    throw;
            }
        }
        public void Release(string savepoint)
        {
            DoSavePointExecute(savepoint, "RELEASE ");
        }
        /// <summary>回滚到"快照"</summary>
        private void DoSavePointExecute(string savepoint, string cmd)
        {
            // Validate the savepoint
            int first_len = savepoint.IndexOf('D');
            if (first_len >= 2 && savepoint.Length > first_len + 1)
            {
                int depth;
                if (int.TryParse(savepoint.Substring(first_len + 1), out depth))
                    if (0 <= depth && depth < _transactionDepth)
                    {
#if NETFX_CORE
						Volatile.Write (ref _transactionDepth, depth);
#elif SILVERLIGHT
						_transactionDepth = depth;
#else
                        Thread.VolatileWrite(ref _transactionDepth, depth);
#endif
                        ExecuteUpdate(cmd + savepoint);
                        return;
                    }
            }

            throw new ArgumentException(
                "savePoint is not valid, and should be the result of a call to SaveTransactionPoint.", "savePoint");
        }
        #endregion


        #region 查询记录
        public TableQuery<T> Table<T>() where T : new()
        {
            return new TableQuery<T>(this);
        }
        public T Get<T>(object pk) where T : new()
        {
            var table = GetMapping(typeof(T));
            return Query<T>(table.GetByPrimaryKeySql, pk).FirstOrDefault();
        }
        public T Get<T>(Expression<Func<T, bool>> predicate) where T : new()
        {
            return Table<T>().Where(predicate).FirstOrDefault();
        }
        private object LastInserRowid(TableMapping map)
        {
            var cmd = CreateCommand("");
            return cmd.LastInserRowid(map);
        }
        #endregion


        #region  插入记录
        public int Insert(object obj)
        {
            return Insert(obj, "", obj?.GetType());
        }
        public int Insert(object obj, string extra)
        {
            return Insert(obj, extra, obj?.GetType());
        }
        public int Insert(object obj, Type obj_type)
        {
            return Insert(obj, "", obj_type);
        }
        public int InsertOrReplace(object obj)
        {
            return Insert(obj, "OR REPLACE", obj?.GetType());
        }
        public int InsertOrReplace(object obj, Type objType)
        {
            return Insert(obj, "OR REPLACE", objType);
        }
        public int InsertAll(IEnumerable objs)
        {
            Type type = null;
            foreach (object obj in objs)
            {
                type = obj?.GetType();
                if (type != null) break;
            }
            return InsertAll(objs, "", type);
        }
        public int InsertAll(IEnumerable objs, string extra)
        {
            Type type = null;
            foreach (object obj in objs)
            {
                type = obj?.GetType();
                if (type != null) break;
            }
            return InsertAll(objs, extra, type);
        }
        public int InsertAll(IEnumerable objs, Type type)
        {
            return InsertAll(objs, "", type);
        }
        private int InsertAll(IEnumerable objs, string extra, Type type)
        {
            if (type == null)
                return 0;

            var table = GetMapping(type);
            if (table == null)
                return 0;

            int ret = 0;
            try
            {
                RunInTransaction(() =>
                {
                    foreach (object obj in objs)
                        ret += Insert(obj, extra, table);
                });
            }
            finally
            {
                table.Dispose();
            }
            return ret;
        }
        private int Insert(object obj, string extra, Type obj_type)
        {
            var table = GetMapping(obj_type);
            try
            {
                return Insert(obj, extra, table);
            }
            finally
            {
                table?.Dispose();
            }
        }
        private int Insert(object obj, string extra, TableMapping table)
        {
            if (obj == null || table == null)
                return 0;

            var has_autoinc_pk = table.PK != null && table.PK.IsAutoInc;
            if (has_autoinc_pk && table.PK.ColumnType == typeof(Guid))
            {
                if (Guid.Empty.Equals(table.PK.GetValue(obj)))
                    table.PK.SetValue(obj, Guid.NewGuid());
            }

            var replacing = string.Compare(extra, "OR REPLACE", StringComparison.OrdinalIgnoreCase) == 0;

            var cols = replacing ? table.InsertOrReplaceColumns : table.InsertColumns;
            var vals = new object[cols.Length];
            for (int i = 0; i < vals.Length; i++)
                vals[i] = cols[i].GetValue(obj);

            var cmd = table.GetInsertCommand(this, extra);
            var count = cmd.ExecuteUpdate(vals);

            if (has_autoinc_pk)
            {
                var id = LastInserRowid(table);
                table.PK.SetValue(obj, id);
            }
            return count;
        }
        #endregion


        #region 更新记录
        public int Update(object obj)
        {
            return Update(obj, obj?.GetType());
        }
        public int Update(object obj, Type obj_type)
        {
            if (obj == null || obj_type == null)
                return 0;

            var table = GetMapping(obj_type);
            var pk = table.PK;
            if (pk == null)
                throw new NotSupportedException("Cannot update " + table.TableName + ": it has no PK");

            var cols = from col in table.Columns where col != pk select col;
            var vals = from col in cols select col.GetValue(obj);
            List<object> ps = new List<object>(vals);
            ps.Add(pk.GetValue(obj));

            string query = string.Format("UPDATE \"{0}\" SET {1} WHERE {2} = ? ",
                table.TableName,
                string.Join(",", (from c in cols select "\"" + c.Name + "\" = ? ")),
                pk.Name);
            return ExecuteUpdate(query, ps.ToArray());
        }
        public int UpdateAll(IEnumerable objs)
        {
            int ret = 0;
            RunInTransaction(() =>
            {
                foreach (object obj in objs) ret += Update(obj);
            });
            return ret;
        }
        #endregion


        #region 删除记录
        public int Delete(object obj)
        {
            if (obj == null)
                return 0;

            var table = GetMapping(obj.GetType());
            var pk = table.PK;
            if (pk == null)
                throw new NotSupportedException("Cannot update " + table.TableName + ": it has no PK");

            string query = string.Format("DELETE FROM \"{0}\" WHERE \"{1}\" = ?", table.TableName, pk.Name);
            return ExecuteUpdate(query, pk.GetValue(obj));
        }
        public int Delete<T>(object primary_key)
        {
            if (primary_key == null)
                return 0;
            var table = GetMapping(typeof(T));
            var pk = table.PK;
            if (pk == null)
                throw new NotSupportedException("Cannot update " + table.TableName + ": it has no PK");

            string query = string.Format("DELETE FROM \"{0}\" WHERE \"{1}\" = ?", table.TableName, pk.Name);
            return ExecuteUpdate(query, primary_key);
        }
        public int DeleteAll<T>()
        {
            var table = GetMapping(typeof(T));
            string query = string.Format("DELETE FROM \"{0}\"", table.TableName);
            return ExecuteUpdate(query);
        }
        #endregion


        /// <summary>
        /// 执行Update Sql
        /// </summary>
        public int ExecuteUpdate(string query, params object[] args)
        {
            var cmd = CreateCommand(query, args);
            return cmd.ExecuteUpdate();
        }
        /// <summary>
        /// Query Sql
        /// </summary>
        public List<T> Query<T>(string query, params object[] args) where T : new()
        {
            var cmd = CreateCommand(query, args);
            return cmd.ExecuteQuery<T>();
        }
        /// <summary>
        /// 执行Query Sql, 返回一个迭代器
        /// </summary>
        public IEnumerable<T> QueryDeferred<T>(string query, params object[] args) where T : new()
        {
            var cmd = CreateCommand(query, args);
            return cmd.ExecuteQueryDeferred<T>();
        }
        public DBCommand NewCommand() { return new DBCommand(this); }
        public DBCommand CreateCommand(string query, params object[] args)
        {
            if (!open)
                throw new SqliteException("Cannot create commands from unopened database");

            var cmd = NewCommand();
            cmd.CommandText = query;
            foreach (var obj in args)
                cmd.Bind(obj);
            return cmd;
        }

        public TableMapping GetMappingForce(Type type)
        {
            return MappingMgr.GetMapping(type) ?? new TableMemMapping(type); ;
        }
        public TableMapping GetMapping(Type type)
        {
            if (_mappings == null) _mappings = new Dictionary<string, TableMapping>();
            TableMapping table;
            if (!_mappings.TryGetValue(type.FullName, out table))
            {
                table = GetMappingForce(type);
                //校验当前数据库的表
                if (ProofTestTable(table))
                    _mappings[type.FullName] = table;
            }
            return table;
        }

        public static bool CreateFile(string path, bool del_exists = false)
        {
            var exists = File.Exists(path);
            if (!exists || del_exists)
            {
                if (exists) File.Delete(path);
                SqliteConnection.CreateFile(path);
                return true;
            }
            return false;
        }

        //校验当前数据表, 当与实际表
        private bool ProofTestTable(TableMapping table)
        {
            //先尝试创建表
            var create_sql = "CREATE TABLE IF NOT EXISTS \"" + table.TableName + "\"(\n";
            create_sql += string.Join(",\n", (table.Columns.Select(p => Orm.SqlDecl(p))));
            create_sql += ")";
            var create_lst = Dict(create_sql);
            ExecuteUpdate(create_sql);
            //从数据库拉取表的信息
            var command = CreateCommand("SELECT sql FROM sqlite_master WHERE type = \"table\" AND name = ? ;", table.TableName);
            var exists_sql = command.ExecuteScalar<string>();
            var exists_lst = Dict(exists_sql);
            //比对表的差异性
            bool rebuild = create_lst.Count < exists_lst.Count;
            var add_cols = new List<string>();
            for (int i = 0; i < create_lst.Count && !rebuild; i++)
            {
                var col1 = create_lst[i];
                if (i < exists_lst.Count)
                {
                    var col2 = exists_lst[i];
                    if (!col1.Item1.Equals(col2.Item1) || !col1.Item2.Equals(col2.Item2)) rebuild = true;
                }
                else add_cols.Add(col1.Item2);
            }
            if (rebuild)
            {
                var same_cols = new List<string>();
                for (int i = 0; i < create_lst.Count; i++)
                    for (int j = 0; j < exists_lst.Count; j++)
                        if (create_lst[i].Item1.Equals(exists_lst[j].Item1))
                        {
                            same_cols.Add(create_lst[i].Item1);
                            break;
                        }
                //重建数据表(创建临时表->迁移相同字段的数据->删除临时表)
                RunInTransaction(() =>
                {
                    var table_name = table.TableName;
                    var table_temp = table_name + "_temp";
                    ExecuteUpdate("PRAGMA foreign_keys = off;");
                    ExecuteUpdate(string.Format("DROP TABLE IF EXISTS \"{0}\" ;", table_temp));
                    ExecuteUpdate(string.Format("CREATE TABLE \"{1}\" AS SELECT * FROM \"{0}\" ;", table_name, table_temp));
                    ExecuteUpdate(string.Format("DROP TABLE \"{0}\" ;", table_name));
                    ExecuteUpdate(create_sql);
                    if (same_cols.Count > 0)
                    {
                        var fields = string.Join(",", same_cols);
                        //ExecuteUpdate("INSERT INTO \"{0}\" ( {2} ) SELECT {2} FROM \"{0}_temp_table\";");
                        ExecuteUpdate(string.Format("INSERT INTO \"{0}\" ( {2} ) SELECT {2} FROM \"{1}\";", table_name, table_temp, fields));
                    }
                    ExecuteUpdate(string.Format("DROP TABLE \"{0}\" ;", table_temp));
                    ExecuteUpdate("PRAGMA foreign_keys = on;");
                    Debug.LogWarning(string.Format("column exception, rebuild sql: {0}\n{1}", table_name, create_sql));
                });
            }
            else if (add_cols != null && add_cols.Count > 0)
            {
                //追加新的字段
                RunInTransaction(() =>
                {
                    var table_name = table.TableName;
                    foreach (var field in add_cols)
                    {
                        ExecuteUpdate(string.Format("ALTER TABLE \"{0}\" ADD COLUMN {1};", table_name, field));
                        Debug.LogWarning(string.Format("Alter table add column {0}:{1}", table_name, field));
                    }
                });
            }

            return true;
        }
        static List<(string, string)> Dict(string sql)
        {
            if (string.IsNullOrEmpty(sql))
                throw new Exception("Can't create a TableMapping instance, sql: " + sql);

            var i1 = sql.IndexOf("(") + 1;
            var i2 = sql.IndexOf(")");
            sql = sql.Substring(i1, i2 - i1).Replace("\n", "").Replace("\r", "");

            //Debug.Log(sql);
            var lst = new List<(string, string)>();
            foreach (var c in sql.Split(','))
            {
                var col = c.Trim();
                if (col.StartsWith("\""))
                {
                    i2 = col.IndexOf("\" ");
                    col = col.Substring(1, i2 - 1) + col.Substring(i2 + 1);
                }
                i2 = col.IndexOf(" ");
                lst.Add((col.Substring(0, i2), col));
            }
            return lst;
        }
    }
}