namespace Sqlite3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 对复杂数据类型提供支持 (基于性能考虑时, 应避免使用复杂数据)
    /// </summary>
    public static class SupportExtend
    {

        /// <summary> 转换类型标准名称 </summary>
        public static string GetNormalFullName(Type type)
        {
            var fullname = type.FullName.Replace("+", ".");
            if (fullname.StartsWith("System.Collections.Generic.List`1"))
            {
                //例子: System.Collections.Generic.List`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]])
                var i1 = fullname.IndexOf("[[") + 2;
                var i2 = fullname.IndexOf(",");
                var t1 = fullname.Substring(i1, i2 - i1);
                return "System.Collections.Generic.List<" + t1 + ">";
            }
            if (fullname.StartsWith("System.Collections.Generic.Dictionary`2"))
            {
                //例子: System.Collections.Generic.Dictionary`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]
                var i1 = fullname.IndexOf("[[") + 2;
                var i2 = fullname.IndexOf(",");
                var t1 = fullname.Substring(i1, i2 - i1);
                fullname = fullname.Substring(fullname.IndexOf("],[") + 3);
                var t2 = fullname.Substring(0, fullname.IndexOf(","));
                return "System.Collections.Generic.Dictionary<" + t1 + "," + t2 + ">";
            }

            if (fullname.IndexOf("(") >= 0 || fullname.IndexOf(")") >= 0 || fullname.IndexOf("`") >= 0)
                throw new NotSupportedException("Don't know about " + type);
            return fullname;
        }

        /// <summary>
        /// 是否支持的复杂数据类型
        /// </summary>
        public static bool IsSupportType(Type type)
        {
            return IsSupportType(GetNormalFullName(type));
        }
        /// <summary>
        /// 是否支持的复杂数据类型
        /// </summary>
        public static bool IsSupportType(string normal_fullname)
        {
            switch (normal_fullname)
            {
                //Array Type
                case "System.Boolena[]":
                case "System.Int16[]":
                case "System.Int32[]":
                case "System.Int64[]":
                case "System.Single[]":
                case "System.Double[]":
                case "System.Decimal[]":
                //String Type
                case "System.String[]":
                //List Type
                case "System.Collections.Generic.List<System.Boolena>":
                case "System.Collections.Generic.List<System.Int16>":
                case "System.Collections.Generic.List<System.Int32>":
                case "System.Collections.Generic.List<System.Int64>":
                case "System.Collections.Generic.List<System.Single>":
                case "System.Collections.Generic.List<System.Double>":
                case "System.Collections.Generic.List<System.Decimal>":
                case "System.Collections.Generic.List<System.String>":
                //Dict Type
                case "System.Collections.Generic.Dictionary<System.Int32,System.Int32>":
                case "System.Collections.Generic.Dictionary<System.Int32,System.Single>":
                case "System.Collections.Generic.Dictionary<System.String,System.String>":
                    return true;
            }

            return false;
        }

        /// <summary>
        /// 实现了自定义接口 (IDataText)
        /// </summary>
        public static bool IsSupportIDataText(Type type) => typeof(IDataText).IsAssignableFrom(type);
        /// <summary> 
        /// 实现了自定义接口 (IDataBytes)
        /// </summary>
        public static bool IsSupportIDataBytes(Type type) => typeof(IDataBytes).IsAssignableFrom(type);

        /// <summary>
        /// 将object序列化为string(仅限受支持类型)
        /// </summary>
        public static string ToString(object obj, string normal_fullname)
        {
            if (obj == null)
                return null;
            switch (normal_fullname)
            {
                //Array Type
                case "System.Boolena[]":
                    return ToString<bool>((bool[])obj);
                case "System.Int16[]":
                    return ToString<short>((short[])obj);
                case "System.Int32[]":
                    return ToString<int>((int[])obj);
                case "System.Int64[]":
                    return ToString<long>((long[])obj);
                case "System.Single[]":
                    return ToString<float>((float[])obj);
                case "System.Double[]":
                    return ToString<double>((double[])obj);
                case "System.Decimal[]":
                    return ToString<decimal>((decimal[])obj);
                //String Type
                case "System.String[]":
                    return ToString<string>((string[])obj);
                //List Type
                case "System.Collections.Generic.List<System.Boolena>":
                    return ToString<bool>((List<bool>)obj);
                case "System.Collections.Generic.List<System.Int16>":
                    return ToString<short>((List<short>)obj);
                case "System.Collections.Generic.List<System.Int32>":
                    return ToString<int>((List<int>)obj);
                case "System.Collections.Generic.List<System.Int64>":
                    return ToString<long>((List<long>)obj);
                case "System.Collections.Generic.List<System.Single>":
                    return ToString<float>((List<float>)obj);
                case "System.Collections.Generic.List<System.Double>":
                    return ToString<double>((List<double>)obj);
                case "System.Collections.Generic.List<System.Decimal>":
                    return ToString<decimal>((List<decimal>)obj);
                case "System.Collections.Generic.List<System.String>":
                    return ToString<string>((List<string>)obj);
                //Dict Type
                case "System.Collections.Generic.Dictionary<System.Int32,System.Int32>":
                    return ToString<int, int>((Dictionary<int, int>)obj);
                case "System.Collections.Generic.Dictionary<System.Int32,System.Single>":
                    return ToString<int, float>((Dictionary<int, float>)obj);
                case "System.Collections.Generic.Dictionary<System.String,System.String>":
                    return ToString<string, string>((Dictionary<string, string>)obj);
            }
            return "";
        }
        /// <summary>
        /// 从string中反序列化为对象(仅限受支持类型)
        /// </summary>
        public static object ToObject(string obj, string normal_fullname)
        {
            switch (normal_fullname)
            {
                //Array Type
                case "System.Boolena[]":
                    return ToArray<bool>(obj);
                case "System.Int16[]":
                    return ToArray<short>(obj);
                case "System.Int32[]":
                    return ToArray<int>(obj);
                case "System.Int64[]":
                    return ToArray<long>(obj);
                case "System.Single[]":
                    return ToArray<float>(obj);
                case "System.Double[]":
                    return ToArray<double>(obj);
                case "System.Decimal[]":
                    return ToArray<decimal>(obj);
                //String Type
                case "System.String[]":
                    return ToArray<string>(obj);
                //List Type
                case "System.Collections.Generic.List<System.Boolena>":
                    return ToList<bool>(obj);
                case "System.Collections.Generic.List<System.Int16>":
                    return ToList<short>(obj);
                case "System.Collections.Generic.List<System.Int32>":
                    return ToList<int>(obj);
                case "System.Collections.Generic.List<System.Int64>":
                    return ToList<long>(obj);
                case "System.Collections.Generic.List<System.Single>":
                    return ToList<float>(obj);
                case "System.Collections.Generic.List<System.Double>":
                    return ToList<double>(obj);
                case "System.Collections.Generic.List<System.Decimal>":
                    return ToList<decimal>(obj);
                case "System.Collections.Generic.List<System.String>":
                    return ToList<string>(obj);
                //Dict Type
                case "System.Collections.Generic.Dictionary<System.Int32,System.Int32>":
                    return ToDict<int, int>(obj);
                case "System.Collections.Generic.Dictionary<System.Int32,System.Single>":
                    return ToDict<int, float>(obj);
                case "System.Collections.Generic.Dictionary<System.String,System.String>":
                    return ToDict<int, string>(obj);
            }
            return null;
        }

        static readonly char ss_arr = ',';
        static readonly char ss_dict = '|';
        static readonly string[] rep_arr = new[] { "," };
        static readonly string[] rep_dict = new[] { "|" };
        static string ToString<T1, T2>(Dictionary<T1, T2> dict)
        {
            var str = "";
            if (dict != null)
            {
                var t1_is_string = typeof(T1) == typeof(string);
                var t2_is_string = typeof(T2) == typeof(string);
                foreach (var obj in dict)
                {
                    if (str.Length > 0) str += ss_arr;
                    str += obj.Key.ToString() + ss_dict + obj.Value;
                }
            }
            return str;
        }
        static string ToString<T>(List<T> list)
        {
            return ToString(list?.ToArray());
        }
        static string ToString<T>(T[] arr)
        {
            var str = "";
            if (arr != null)
            {
                var is_string = typeof(T) == typeof(string);
                if (is_string)
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i > 0) str += ss_arr;
                        str += arr[i].ToString();
                    }
                else
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i > 0) str += ss_arr;
                        str += arr[i].ToString();
                    }
            }
            return str;
        }
        static T[] ToArray<T>(string obj)
        {
            return ToList<T>(obj)?.ToArray(); ;
        }
        static List<T> ToList<T>(string obj)
        {
            if (!string.IsNullOrEmpty(obj))
            {
                object ret = null;
                var arr = obj.Split(ss_arr);
                switch (typeof(T).FullName)
                {
                    //Array Type
                    case "System.Boolena":
                        ret = new List<bool>(from o in arr select bool.Parse(o));
                        break;
                    case "System.Int16":
                        ret = new List<short>(from o in arr select short.Parse(o));
                        break;
                    case "System.Int32":
                        ret = new List<int>(from o in arr select int.Parse(o));
                        break;
                    case "System.Int64":
                        ret = new List<long>(from o in arr select long.Parse(o));
                        break;
                    case "System.Single":
                        ret = new List<float>(from o in arr select float.Parse(o));
                        break;
                    case "System.Double":
                        ret = new List<double>(from o in arr select double.Parse(o));
                        break;
                    case "System.Decimal":
                        ret = new List<decimal>(from o in arr select decimal.Parse(o));
                        break;
                    //String Type
                    case "System.String":
                        ret = new List<string>(from o in arr select o);
                        break;
                }
                if (ret != null)
                    return (List<T>)ret;
            }
            return default;
        }
        static Dictionary<T1, T2> ToDict<T1, T2>(string obj)
        {
            if (!string.IsNullOrEmpty(obj))
            {
                object ret = null;
                var dict_arr = from o in obj.Split(ss_arr) select o.Split(ss_dict);
                switch (typeof(T1).FullName + "," + typeof(T2).FullName)
                {
                    case "System.Int32,System.Int32":
                        {
                            var dict = new Dictionary<int, int>();
                            ret = dict;
                            foreach (var arr in dict_arr)
                                dict.Add(int.Parse(arr[0]), int.Parse(arr[1]));
                            break;
                        }
                    case "System.Int32,System.Single":
                        {
                            var dict = new Dictionary<int, float>();
                            ret = dict;
                            foreach (var arr in dict_arr)
                                dict.Add(int.Parse(arr[0]), float.Parse(arr[1]));
                            break;
                        }
                    case "System.String,System.String":
                        {
                            var dict = new Dictionary<string, string>();
                            ret = dict;
                            foreach (var arr in dict_arr)
                            {
                                var key = arr[0];
                                var value = arr[1];
                                dict.Add(arr[0], arr[1]);
                            }
                            break;
                        }
                }
                if (ret != null)
                    return (Dictionary<T1, T2>)ret;
            }
            return default;
        }

        //对string中的分隔符进行转码
        static string StringConvert(string str, string old_char, string new_char)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            return str.Replace(old_char, new_char);
        }
    }


    /// <summary>
    /// 自定义数据类型,必须实现此接口 (将对象序列化为string,或从string中反序列对象本身)
    /// </summary>
    public interface IDataText
    {
        string Save();
        void Load(string data);
    }
    /// <summary>
    /// 自定义数据类型,必须实现此接口 (将对象序列化为byte[],或从byte[]中反序列对象本身)
    /// </summary>
    public interface IDataBytes
    {
        byte[] Save();
        void Load(byte[] data);
    }
}