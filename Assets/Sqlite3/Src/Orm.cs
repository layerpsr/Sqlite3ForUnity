
namespace Sqlite3
{
    using System;
    using System.Reflection;
    using Sqlite3.Attribute;

    public static class Orm
    {
        public static string SqlDecl(Column col)
        {
            string decl = "\"" + col.Name + "\" " + SqlType(col) + " ";

            if (col.IsPK) decl += "PRIMARY KEY ";
            if (col.IsAutoInc) decl += "AUTOINCREMENT ";
            if (col.IsUnique) decl += "UNIQUE ";
            if (col.IsNotNull) decl += "NOT NULL ";
            if (!string.IsNullOrEmpty(col.DefaultValue)) decl += "DEFAULT \"" + col.DefaultValue + "\" ";
            return decl.Trim();
        }
        public static string SqlType(Column col)
        {
            var type = col.ColumnType;

            if (type == typeof(bool) || type == typeof(byte) || type == typeof(ushort) ||
                type == typeof(sbyte) || type == typeof(short) || type == typeof(int))
                return "INTEGER";
            if (type == typeof(uint) || type == typeof(long))
                return "BIGINT";
            if (type == typeof(float) || type == typeof(double) || type == typeof(decimal))
                return "REAL";
            if (type == typeof(string))
            {
                int? len = col.MaxLength;
                if (len.HasValue)
                    return "VARCHAR (" + len.Value + ")";
                return "VARCHAR";
            }
            if (type == typeof(TimeSpan) || type == typeof(DateTimeOffset))
                return "BIGINT";
            if (type == typeof(DateTime))
                return "DATE";
            if (type.IsEnum)
            {
                return "INTEGER";
            }
            if (type == typeof(byte[]))
                return "BLOB";
            if (type == typeof(Guid))
                return "VARCHAR(36)";

            throw new NotSupportedException("Don't know about " + type);
        }

        public static bool IsPK(MemberInfo prop)
        {
            object[] attrs = prop.GetCustomAttributes(typeof(PrimaryKeyAttribute), true);
            return attrs.Length > 0;
        }
        public static bool IsAutoInc(MemberInfo prop)
        {
            object[] attrs = prop.GetCustomAttributes(typeof(AutoIncrementAttribute), true);
            return attrs.Length > 0;
        }
        public static bool IsUnique(MemberInfo prop)
        {
            object[] attrs = prop.GetCustomAttributes(typeof(UniqueAttribute), true);
            return attrs.Length > 0;
        }
        public static bool IsNotNull(MemberInfo prop)
        {
            object[] attrs = prop.GetCustomAttributes(typeof(NotNullAttribute), true);
            return attrs.Length > 0;
        }
        public static string DefaultValue(MemberInfo prop)
        {
            object[] attrs = prop.GetCustomAttributes(typeof(DefaultValueAttribute), true);
            if (attrs.Length > 0)
                return ((DefaultValueAttribute)attrs[0]).Value;
            return null;
        }
        public static int? MaxLength(MemberInfo prop)
        {
            object[] attrs = prop.GetCustomAttributes(typeof(MaxLengthAttribute), true);
            if (attrs.Length > 0)
                return ((MaxLengthAttribute)attrs[0]).Value;
            return null;
        }
        public static bool Ignore(MemberInfo prop)
        {
            object[] attrs = prop.GetCustomAttributes(typeof(IgnoreAttribute), true);
            return attrs.Length > 0;
        }
    }
}