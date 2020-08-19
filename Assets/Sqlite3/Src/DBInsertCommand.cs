
namespace Sqlite3
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Mono.Data.Sqlite;
    using UnityEngine;

    public class DBInsertCommand
    {
        public string CommandText { get; set; }
        private DBConnection _conn { get; set; }
        private SqliteCommand command { get; set; }

        internal DBInsertCommand(DBConnection conn)
        {
            this._conn = conn;
        }

        public int ExecuteUpdate(object[] objs)
        {
            if (_conn.Trace)
            {
                var binding = new List<string>();
                for (int i = 0; i < objs.Length; i++)
                {
                    var fullname = objs[i]?.GetType().FullName;
                    var is_ie_obj = fullname != null &&
                        (fullname.StartsWith("System.Collections.Generic.List") || fullname.IndexOf("[]") >= 0);
                    if (is_ie_obj)
                    {
                        string ss = null;
                        foreach (object o in (IEnumerable)objs[i])
                        {
                            if (ss != null) ss += ",";
                            ss += o ?? "";
                        }
                        binding.Add(string.Format("{0}:\t[{1}]", i, ss));
                    }
                    else
                        binding.Add(string.Format("{0}:\t{1} ", i, objs[i]));
                }
                Debug.Log(string.Format("{0}\nBinding:\n{1}", this.CommandText, string.Join("\n", binding)));
            }
            if (this.command == null)
                this.command = Prepare();
            //bind the values.
            this.command.Parameters.Clear();
            if (objs != null)
            {
                for (int i = 0; i < objs.Length; i++)
                    DBCommand.BindParameter(this.command, objs[i]);
            }
            return this.command.ExecuteNonQuery();
        }
        public void Dispose()
        {
            var cmd = this.command;
            this.command = null;
            if (cmd != null)
            {
                cmd.Cancel();
                cmd.Dispose();
            }
        }
        private SqliteCommand Prepare()
        {
            var command = new SqliteCommand(this.CommandText, this._conn.handle);
            command.Prepare();
            return command;
        }

    }
}