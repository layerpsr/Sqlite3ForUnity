using System;
using System.Collections.Generic;

namespace Sqlite3.Attribute
{
    /**
    * 定义一个数据表
    */
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TableAttribute : System.Attribute
    {
        public string Name { get; set; }
        public TableAttribute() { }
        public TableAttribute(string name)
        {
            this.Name = name;
        }
    }

#if UNITY_EDITOR
    /**
    * 定义一个表配置(仅在Editor下, Gen Code时有效)
    */
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class TableConfigAttribute : TableAttribute
    {
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
        //忽略字段信息
        public string[] Ignores { get; set; }

        public TableConfigAttribute() { }
        public TableConfigAttribute(string name)
        {
            this.Name = name;
        }
    }
#endif

    /**
    * 定义一个字段别名
    */
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class ColumnAttribute : System.Attribute
    {
        public string Name { get; set; }
        public ColumnAttribute(string name)
        {
            this.Name = name;
        }
    }

    /**
    * 定义表主键
    */
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class PrimaryKeyAttribute : System.Attribute
    {
    }

    /**
    * 定义主键自增
    */
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class AutoIncrementAttribute : System.Attribute
    {
    }

    /**
    * 唯一键约束
    */
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class UniqueAttribute : System.Attribute
    {
    }

    /**
    * 不允许空值
    */
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class NotNullAttribute : System.Attribute
    {
    }

    /**
    * 字段默认值
    */
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class DefaultValueAttribute : System.Attribute
    {
        public string Value { get; }
        public DefaultValueAttribute(string value)
        {
            this.Value = value;
        }
    }

    /**
    * 字段最大长度
    */
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class MaxLengthAttribute : System.Attribute
    {
        public int Value { get; }
        public MaxLengthAttribute(int length)
        {
            this.Value = length;
        }
    }
    /**
    * 忽略此字段
    */
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class IgnoreAttribute : System.Attribute
    {
    }
}