namespace Sqlite3
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Text;

    public abstract class BaseQuery
    {
        protected class CompileResult
        {
            public string CommandText { get; set; }
            public object Value { get; set; }
        }
        protected class Ordering
        {
            public string ColumnName { get; set; }
            public bool Ascending { get; set; }
        }
    }

    public class TableQuery<T> : BaseQuery, IEnumerable<T>
    {
        public TableMapping Table { get; private set; }

        private bool _deferred;
        private readonly DBConnection _conn;

        private int? _limit;
        private int? _offset;
        private List<Ordering> _orderBys;
        private Expression _where;
        //Select
        private Expression _selector;
        //Join
        private BaseQuery _joinInner;
        private Expression _joinInnerKeySelector;
        private BaseQuery _joinOuter;
        private Expression _joinOuterKeySelector;
        private Expression _joinSelector;

        public TableQuery(DBConnection conn) : this(conn, conn.GetMapping(typeof(T))) { }
        private TableQuery(DBConnection conn, TableMapping table)
        {
            this._conn = conn;
            this.Table = table;
        }

        public TableQuery<U> Clone<U>()
        {
            TableQuery<U> ins = new TableQuery<U>(this._conn, this.Table);
            ins._where = _where;
            ins._deferred = _deferred;
            if (_orderBys != null) ins._orderBys = new List<Ordering>(_orderBys);
            ins._limit = _limit;
            ins._offset = _offset;
            //Select
            ins._selector = _selector;
            //Join
            ins._joinInner = _joinInner;
            ins._joinInnerKeySelector = _joinInnerKeySelector;
            ins._joinOuter = _joinOuter;
            ins._joinOuterKeySelector = _joinOuterKeySelector;
            ins._joinSelector = _joinSelector;

            return ins;
        }


        #region 条件方法
        public TableQuery<T> Where(Expression<Func<T, bool>> predExpr)
        {
            if (predExpr.NodeType == ExpressionType.Lambda)
            {
                LambdaExpression lambda = predExpr;
                Expression pred = lambda.Body;
                TableQuery<T> q = Clone<T>();
                q.AddWhere(pred);
                return q;
            }
            throw new NotSupportedException("Must be a predicate");
        }
        public TableQuery<T> Take(int n)
        {
            TableQuery<T> q = Clone<T>();
            q._limit = n;
            return q;
        }
        public TableQuery<T> Skip(int n)
        {
            TableQuery<T> q = Clone<T>();
            q._offset = n;
            return q;
        }
        public TableQuery<T> Deferred()
        {
            TableQuery<T> q = Clone<T>();
            q._deferred = true;
            return q;
        }
        public TableQuery<T> OrderBy<U>(Expression<Func<T, U>> orderExpr)
        {
            return AddOrderBy(orderExpr, true);
        }
        public TableQuery<T> OrderByDescending<U>(Expression<Func<T, U>> orderExpr)
        {
            return AddOrderBy(orderExpr, false);
        }
        public TableQuery<T> ThenBy<U>(Expression<Func<T, U>> orderExpr)
        {
            return AddOrderBy(orderExpr, true);
        }
        public TableQuery<T> ThenByDescending<U>(Expression<Func<T, U>> orderExpr)
        {
            return AddOrderBy(orderExpr, false);
        }
        private TableQuery<T> AddOrderBy<U>(Expression<Func<T, U>> orderExpr, bool asc)
        {
            if (orderExpr.NodeType == ExpressionType.Lambda)
            {
                LambdaExpression lambda = orderExpr;

                MemberExpression mem = null;

                UnaryExpression unary = lambda.Body as UnaryExpression;
                if (unary != null && unary.NodeType == ExpressionType.Convert)
                    mem = unary.Operand as MemberExpression;
                else
                    mem = lambda.Body as MemberExpression;

                if (mem != null && mem.Expression.NodeType == ExpressionType.Parameter)
                {
                    TableQuery<T> q = Clone<T>();
                    if (q._orderBys == null) q._orderBys = new List<Ordering>();
                    q._orderBys.Add(new Ordering
                    {
                        ColumnName = this.Table.FindColumnWithPropertyName(mem.Member.Name).Name,
                        Ascending = asc
                    });
                    return q;
                }

                throw new NotSupportedException("Order By does not support: " + orderExpr);
            }

            throw new NotSupportedException("Must be a predicate");
        }
        private void AddWhere(Expression pred)
        {
            if (_where == null)
                _where = pred;
            else
                _where = Expression.AndAlso(_where, pred);
        }
        public TableQuery<TResult> Select<TResult>(Expression<Func<T, TResult>> selector)
        {
            TableQuery<TResult> q = Clone<TResult>();
            q._selector = selector;
            return q;
        }
        public TableQuery<TResult> Join<TInner, TKey, TResult>(
           TableQuery<TInner> inner,
           Expression<Func<T, TKey>> outerKeySelector,
           Expression<Func<TInner, TKey>> innerKeySelector,
           Expression<Func<T, TInner, TResult>> resultSelector)
        {
            TableQuery<TResult> q =
                new TableQuery<TResult>(this._conn, this._conn.GetMapping(typeof(TResult)))
                {
                    _joinOuter = this,
                    _joinOuterKeySelector = outerKeySelector,
                    _joinInner = inner,
                    _joinInnerKeySelector = innerKeySelector,
                    _joinSelector = resultSelector
                };
            return q;
        }

        #endregion


        #region 删/改/查 方法
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            if (!_deferred)
                return GenerateQuery("*").ExecuteQuery<T>().GetEnumerator();

            return GenerateQuery("*").ExecuteDeferredQuery<T>().GetEnumerator();
        }
        public List<T> Query(string select_list = "*")
        {
            return GenerateQuery(select_list).ExecuteQuery<T>(); ;
        }
        public int Update(object obj)
        {
            if (obj == null || _where == null)
                return 0;
            var table = this._conn.GetMapping(typeof(T));
            return GenerateUpdate(obj, table).ExecuteNonQuery();
        }
        public int Delete()
        {
            if (_where == null)
                return 0;
            var table = this._conn.GetMapping(typeof(T));
            return GenerateDelete(table).ExecuteNonQuery();
        }
        public int Count()
        {
            return GenerateQuery("count(*)").ExecuteScalar<int>();
        }
        public int Count(Expression<Func<T, bool>> predExpr)
        {
            return Where(predExpr).Count();
        }
        public T First()
        {
            TableQuery<T> query = Take(1);
            return query.ToList().First();
        }
        public T FirstOrDefault()
        {
            TableQuery<T> query = Take(1);
            return query.ToList().FirstOrDefault();
        }
        public T ElementAt(int index)
        {
            return Skip(index).Take(1).First();
        }
        #endregion


        #region 构建DBCommand实例
        private DBCommand GenerateQuery(string select_list)
        {
            string query = "SELECT " + select_list + " FROM \"" + this.Table.TableName + "\"";
            List<object> args = new List<object>();
            if (_where != null)
            {
                CompileResult w = CompileExpr(_where, args);
                query += " WHERE " + w.CommandText;
            }

            if (_orderBys != null && _orderBys.Count > 0)
            {
                string t = string.Join(", ",
                    _orderBys.Select(o => "\"" + o.ColumnName + "\"" + (o.Ascending ? "" : " DESC")).ToArray());
                query += " ORDER BY " + t;
            }

            if (_limit.HasValue) query += " LIMIT " + _limit.Value;
            if (_offset.HasValue)
            {
                if (!_limit.HasValue) query += " LIMIT -1 ";
                query += " OFFSET " + _offset.Value;
            }

            return this._conn.CreateCommand(query, args.ToArray());
        }
        private DBCommand GenerateUpdate(object obj, TableMapping table)
        {
            var pk = table.PK;

            var cols = from col in table.Columns where col != pk select col;
            var vals = (from col in cols select col.GetValue(obj)).ToList();
            //Query Sql
            string query = string.Format("UPDATE \"{0}\" SET {1}",
                            table.TableName,
                            string.Join(",", (from c in cols select "\"" + c.Name + "\" = ? ")));
            //Where
            if (_where != null)
            {
                var args = new List<object>();
                CompileResult w = CompileExpr(_where, args);
                query += " WHERE " + w.CommandText;
                vals.AddRange(args);
            }

            return this._conn.CreateCommand(query, vals.ToArray());
        }
        private DBCommand GenerateDelete(TableMapping table)
        {
            //Query Sql
            string query = string.Format("DELETE FROM \"{0}\"", table.TableName);
            //Where
            List<object> args = new List<object>();
            if (_where != null)
            {
                CompileResult w = CompileExpr(_where, args);
                query += " WHERE " + w.CommandText;
            }

            return this._conn.CreateCommand(query, args.ToArray());
        }
        #endregion


        #region  构建条件语句(使用Lambda表达式<反射>)
        private CompileResult CompileExpr(Expression expr, List<object> queryArgs)
        {
            if (expr == null)
                throw new NotSupportedException("Expression is NULL");

            if (expr is BinaryExpression)
            {
                BinaryExpression bin = (BinaryExpression)expr;

                CompileResult leftr = CompileExpr(bin.Left, queryArgs);
                CompileResult rightr = CompileExpr(bin.Right, queryArgs);

                //If either side is a parameter and is null, then handle the other side specially (for "is null"/"is not null")
                string text;
                if (leftr.CommandText == "?" && leftr.Value == null)
                    text = CompileNullBinaryExpression(bin, rightr);
                else if (rightr.CommandText == "?" && rightr.Value == null)
                    text = CompileNullBinaryExpression(bin, leftr);
                else
                    text = "(" + leftr.CommandText + " " + GetSqlName(bin) + " " + rightr.CommandText + ")";
                return new CompileResult { CommandText = text };
            }

            if (expr.NodeType == ExpressionType.Call)
            {
                MethodCallExpression call = (MethodCallExpression)expr;
                CompileResult[] args = new CompileResult[call.Arguments.Count];
                CompileResult obj = call.Object != null ? CompileExpr(call.Object, queryArgs) : null;

                for (int i = 0; i < args.Length; i++) args[i] = CompileExpr(call.Arguments[i], queryArgs);

                string sqlCall = "";

                if (call.Method.Name == "Like" && args.Length == 2)
                {
                    sqlCall = "(" + args[0].CommandText + " LIKE " + args[1].CommandText + ")";
                }
                else if (call.Method.Name == "Contains" && args.Length == 2)
                {
                    sqlCall = "(" + args[1].CommandText + " IN " + args[0].CommandText + ")";
                }
                else if (call.Method.Name == "Contains" && args.Length == 1)
                {
                    if (call.Object != null && call.Object.Type == typeof(string))
                        sqlCall = "(" + obj.CommandText + " LIKE ('%' || " + args[0].CommandText + " || '%'))";
                    else
                        sqlCall = "(" + args[0].CommandText + " in " + obj.CommandText + ")";
                }
                else if (call.Method.Name == "StartsWith" && args.Length == 1)
                {
                    sqlCall = "(" + obj.CommandText + " LIKE (" + args[0].CommandText + " || '%'))";
                }
                else if (call.Method.Name == "EndsWith" && args.Length == 1)
                {
                    sqlCall = "(" + obj.CommandText + " LIKE ('%' || " + args[0].CommandText + "))";
                }
                else if (call.Method.Name == "Equals" && args.Length == 1)
                {
                    sqlCall = "(" + obj.CommandText + " = (" + args[0].CommandText + "))";
                }
                else if (call.Method.Name == "ToLower")
                {
                    sqlCall = "(LOWER(" + obj.CommandText + "))";
                }
                else if (call.Method.Name == "ToUpper")
                {
                    sqlCall = "(UPPER(" + obj.CommandText + "))";
                }
                else
                {
                    sqlCall = call.Method.Name.ToLower() + "(" +
                              string.Join(",", args.Select(a => a.CommandText).ToArray()) + ")";
                }

                return new CompileResult { CommandText = sqlCall };
            }

            if (expr.NodeType == ExpressionType.Constant)
            {
                ConstantExpression c = (ConstantExpression)expr;
                queryArgs.Add(c.Value);
                return new CompileResult
                {
                    CommandText = "?",
                    Value = c.Value
                };
            }

            if (expr.NodeType == ExpressionType.Convert)
            {
                UnaryExpression u = (UnaryExpression)expr;
                Type ty = u.Type;
                CompileResult valr = CompileExpr(u.Operand, queryArgs);
                return new CompileResult
                {
                    CommandText = valr.CommandText,
                    Value = valr.Value != null ? ConvertTo(valr.Value, ty) : null
                };
            }

            if (expr.NodeType == ExpressionType.MemberAccess)
            {
                MemberExpression mem = (MemberExpression)expr;

                if (mem.Expression != null && mem.Expression.NodeType == ExpressionType.Parameter)
                {
                    //
                    // This is a column of our table, output just the column name
                    // Need to translate it if that column name is mapped
                    //
                    string columnName = this.Table.FindColumnWithPropertyName(mem.Member.Name).Name;
                    return new CompileResult { CommandText = "\"" + columnName + "\"" };
                }

                object obj = null;
                if (mem.Expression != null)
                {
                    CompileResult r = CompileExpr(mem.Expression, queryArgs);
                    if (r.Value == null) throw new NotSupportedException("Member access failed to compile expression");
                    if (r.CommandText == "?") queryArgs.RemoveAt(queryArgs.Count - 1);
                    obj = r.Value;
                }

                //
                // Get the member value
                //
                object val = null;

                if (mem.Member.MemberType == MemberTypes.Property)
                {
                    PropertyInfo m = (PropertyInfo)mem.Member;
                    val = m.GetValue(obj, null);
                }
                else if (mem.Member.MemberType == MemberTypes.Field)
                {
                    FieldInfo m = (FieldInfo)mem.Member;
                    val = m.GetValue(obj);
                }
                else
                {
                    throw new NotSupportedException("MemberExpr: " + mem.Member.MemberType);
                }

                //
                // Work special magic for enumerables
                //
                if (val != null && val is IEnumerable && !(val is string) && !(val is IEnumerable<byte>))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("(");
                    string head = "";
                    foreach (object a in (IEnumerable)val)
                    {
                        queryArgs.Add(a);
                        sb.Append(head);
                        sb.Append("?");
                        head = ",";
                    }

                    sb.Append(")");
                    return new CompileResult
                    {
                        CommandText = sb.ToString(),
                        Value = val
                    };
                }

                queryArgs.Add(val);
                return new CompileResult
                {
                    CommandText = "?",
                    Value = val
                };
            }

            throw new NotSupportedException("Cannot compile: " + expr.NodeType);
        }
        private static object ConvertTo(object obj, Type t)
        {
            if (obj == null)
                return null;

            Type nut = Nullable.GetUnderlyingType(t);
            if (nut == null)
                return Convert.ChangeType(obj, t);
            return Convert.ChangeType(obj, nut);
        }
        private static string CompileNullBinaryExpression(BinaryExpression expression, CompileResult parameter)
        {
            switch (expression.NodeType)
            {
                case ExpressionType.Equal:
                    return "(" + parameter.CommandText + " IS ?)";
                case ExpressionType.NotEqual:
                    return "(" + parameter.CommandText + " IS NOT ?)";
                default:
                    throw new NotSupportedException("Cannot compile Null-BinaryExpression with type " +
                                                    expression.NodeType);
            }
        }
        private string GetSqlName(Expression expr)
        {
            ExpressionType n = expr.NodeType;

            switch (n)
            {
                case ExpressionType.GreaterThan:
                    return ">";
                case ExpressionType.GreaterThanOrEqual:
                    return ">=";
                case ExpressionType.LessThan:
                    return "<";
                case ExpressionType.LessThanOrEqual:
                    return "<=";
                case ExpressionType.And:
                    return "&";
                case ExpressionType.AndAlso:
                    return "AND";
                case ExpressionType.Or:
                    return "|";
                case ExpressionType.OrElse:
                    return "OR";
                case ExpressionType.Equal:
                    return "=";
                case ExpressionType.NotEqual:
                    return "!=";
                default:
                    throw new NotSupportedException("Cannot get SQL for: " + n);
            }
        }
        #endregion
    }
}