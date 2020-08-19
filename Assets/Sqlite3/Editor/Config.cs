namespace Sqlite3
{
    using Sqlite3.Attribute;
    using System.Collections.Generic;

    /// <summary>
    /// 配置Gen Code的数据类型
    /// </summary>
    public static class MappingConfig
    {
        [TableConfig]
        public static List<Config> custom2
        {
            get
            {
                var types = new[]
                {
                    typeof(Example.Data),
                };

                var model = new Config(null) { PK = "id", AllAutoCreateIns = true };
                var list = new List<Config>();
                foreach (var type in types)
                {
                    var c = model.Clone();
                    c.Type = type;
                    list.Add(c);
                }
                return list;
            }
        }
    }
}
