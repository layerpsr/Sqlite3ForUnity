
namespace Sqlite3
{
    using System;
    using System.Linq;
    using Mono.Data.Sqlite;
    using UnityEngine;

    public class DBInsertCommand
    {
        public bool Initialized { get; set; }
        public string CommandText { get; set; }
        private DBConnection _conn { get; set; }
        private SqliteCommand command { get; set; }

        internal DBInsertCommand(DBConnection conn)
        {
            this._conn = conn;
        }
        ~DBInsertCommand()
        {
            Dispose(false);
        }

        public int ExecuteNonQuery(object[] source)
        {
            if (_conn.Trace)
            {
                int i = 0;
                var binding = (from obj in source select string.Format(" {0}:{1} ", i++, obj));
                Debug.Log(string.Format("{0}\nBinding: [{1}]", this.CommandText, string.Join(",", binding)));
            }

            if (!this.Initialized)
            {
                this.command = Prepare();
                this.Initialized = true;
            }
            //bind the values.
            this.command.Parameters.Clear();
            if (source != null)
            {
                for (int i = 0; i < source.Length; i++)
                    DBCommand.BindParameter(this.command, source[i]);
            }

            return this.command.ExecuteNonQuery();
        }

        protected virtual SqliteCommand Prepare()
        {
            var command = new SqliteCommand(this.CommandText, this._conn.handle);
            command.Prepare();
            return command;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (this.command != null)
            {
                try
                {
                    command.Cancel();
                    command.Dispose();
                }
                finally
                {
                    this.command = null;
                    this._conn = null;
                }
            }
        }
    }
}