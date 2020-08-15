namespace Sqlite3
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Sqlite3.Attribute;

    /// <summary>
    /// 字段映射
    /// </summary>
    public class Column
    {
        public virtual string PropertyName { get; protected set; }
        public Type ColumnType { get; protected set; }

        //字段名称
        public string Name { get; protected set; }

        //是否为主键
        public bool IsPK { get; protected set; }
        //主键自增
        public bool IsAutoInc { get; protected set; }
        //唯一约束键
        public bool IsUnique { get; protected set; }

        //不允许为空
        public bool IsNotNull { get; protected set; }
        //字段默认值
        public string DefaultValue { get; protected set; }

        //最大长度
        public int? MaxLength { get; protected set; }

        protected Column() { }

        public void SetPropertyName(string name)
        {
            this.PropertyName = name;
        }

        public virtual void SetValue(object obj, object val)
        {
            throw new System.NotImplementedException();
        }
        public virtual object GetValue(object obj)
        {
            throw new System.NotImplementedException();
        }
    }

    /**
    * 使用反射读写字段与其属性
    */
    public class ColumnProp : Column
    {
        protected readonly PropertyInfo _prop;
        public override string PropertyName { get { return _prop.Name; } }
        private string s;

        public ColumnProp(PropertyInfo prop)
        {
            this._prop = prop;
            this.ColumnType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
            //Name
            var attr = (ColumnAttribute)prop.GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault();
            this.Name = attr?.Name ?? prop.Name;
            //State
            this.IsPK = Orm.IsPK(prop);
            this.IsAutoInc = this.IsPK && Orm.IsAutoInc(prop);
            this.IsUnique = Orm.IsUnique(prop);
            this.IsNotNull = Orm.IsNotNull(prop);
            this.DefaultValue = Orm.DefaultValue(prop);
            this.MaxLength = Orm.MaxLength(prop);
        }

        public override void SetValue(object obj, object val)
        {
            _prop.SetValue(obj, val, null);
        }
        public override object GetValue(object obj)
        {
            return _prop.GetValue(obj, null);
        }
    }
    /**
    * 使用反射读写字段与其属性
    */
    public class ColumnField : Column
    {
        protected readonly FieldInfo _prop;
        public override string PropertyName { get { return _prop.Name; } }
        private string s;

        public ColumnField(FieldInfo prop)
        {
            this._prop = prop;
            this.ColumnType = Nullable.GetUnderlyingType(prop.FieldType) ?? prop.FieldType;
            //Name
            var attr = (ColumnAttribute)prop.GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault();
            this.Name = attr?.Name ?? prop.Name;
            //State
            this.IsPK = Orm.IsPK(prop);
            this.IsAutoInc = this.IsPK && Orm.IsAutoInc(prop);
            this.IsUnique = Orm.IsUnique(prop);
            this.IsNotNull = Orm.IsNotNull(prop);
            this.DefaultValue = Orm.DefaultValue(prop);
            this.MaxLength = Orm.MaxLength(prop);
        }

        public override void SetValue(object obj, object val)
        {
            _prop.SetValue(obj, val);
        }
        public override object GetValue(object obj)
        {
            return _prop.GetValue(obj);
        }
    }
}