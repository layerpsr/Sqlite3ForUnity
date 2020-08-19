namespace Sqlite3
{
    using System;
    using System.Collections.Generic;

    public static class MappingMgr
    {
        static Dictionary<Type, TableMapping> _mapping;
        static MappingMgr()
        {
            _mapping = new Dictionary<Type, TableMapping>()
            {
            };
        }
        public static TableMapping GetMapping<T>()
        {
            return GetMapping(typeof(T));
        }
        public static TableMapping GetMapping(Type type)
        {
            if (_mapping.ContainsKey(type))
            {
                return _mapping[type];
            }
            UnityEngine.Debug.LogWarning(string.Format("Type '{0}' not gen mapping code", type.FullName));
            return null;
        }
    }
}
