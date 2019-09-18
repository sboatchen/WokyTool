using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace WokyTool.通用
{
    public static class 擴充方法
    {
        private static BinaryFormatter BF_ = new BinaryFormatter();

        public static T 深複製<T>(this T 物件_)
        {
            if (物件_ != null)
            {
                string 資料_ = JsonConvert.SerializeObject(物件_, Formatting.None);
                return JsonConvert.DeserializeObject<T>(資料_);

                /*using (var MS_ = new MemoryStream())
                {
                    BF_.Serialize(MS_, 物件_);
                    MS_.Seek(0, SeekOrigin.Begin);
                    return (T)BF_.Deserialize(MS_);
                }*/
            }

            return default(T);
        }

        public static byte[] 轉成位元組(this Object 物件_)
        {
            if (物件_ != null)
            {
                using (var MS_ = new MemoryStream())
                {
                    BF_.Serialize(MS_, 物件_);
                    return MS_.ToArray();
                }
            }

            return null;
        }

        public static T 轉成物件<T>(this byte[] 位元組_)
        {
            if (位元組_ != null & 位元組_.Length > 0)
            {
                using (var MS_ = new MemoryStream())
                {
                    MS_.Write(位元組_, 0, 位元組_.Length);
                    MS_.Seek(0, SeekOrigin.Begin);
                    return (T)BF_.Deserialize(MS_);
                }
            }

            return default(T);
        }

        public static T 轉成物件<T>(this string 資料_)
        {
            if (string.IsNullOrEmpty(資料_) == false)
                return JsonConvert.DeserializeObject<T>(資料_);

            return default(T);
        }

        public static object 轉成物件(this string 資料_, Type 類型_)
        {
            if (string.IsNullOrEmpty(資料_) == false)
                return JsonConvert.DeserializeObject(資料_, 類型_);

            return null;
        }

        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int memcmp(byte[] b1, byte[] b2, long count);

        public static bool 是否相等(this byte[] b1, byte[] b2)
        {
            // Validate buffers are the same length.
            // This also ensures that the count does not exceed the length of either buffer.  
            return b1.Length == b2.Length && memcmp(b1, b2, b1.Length) == 0;
        }

        public static bool 完全拷貝(this Object 目標_, Object 來源_)
        {
            if (目標_.GetType() != 來源_.GetType())
            {
                訊息管理器.獨體.錯誤("完全拷貝錯誤, 型態不一致: " + 目標_.GetType() + " to " + 來源_.GetType());
                return false;
            }

            var 屬性列舉_ = 目標_.GetType().GetProperties().Where(Value => Value.CanWrite);

            foreach (var 屬性_ in 屬性列舉_)
            {
                屬性_.SetValue(目標_, 屬性_.GetValue(來源_));
            }

            return true;
        }

        public static bool 模糊拷貝(this Object 目標_, Object 來源_)
        {
            var 來源屬性列舉_ = 來源_.GetType().GetProperties().Where(Value => Value.CanRead);
            var 目標屬性列舉_ = 目標_.GetType().GetProperties().Where(Value => Value.CanWrite);

            foreach (var 來源屬性_ in 來源屬性列舉_)
            {
                foreach (var 目標屬性_ in 目標屬性列舉_)
                {
                    if (來源屬性_.Name == 目標屬性_.Name && 來源屬性_.PropertyType == 目標屬性_.PropertyType)
                    {
                        目標屬性_.SetValue(目標_, 來源屬性_.GetValue(來源_));
                        break;
                    }
                }
            }

            return true;
        }

        public static IEnumerable<TSource> 執行<TSource>(this IEnumerable<TSource> 資料列舉_, Action<TSource> 方法_)
        {
            foreach (TSource 資料_ in 資料列舉_)
            {
                方法_(資料_);
                yield return 資料_;

            }
        }

        public static List<Type> 取得繼承結構列(this Object 物件_)
        {
            return 取得繼承結構列(物件_.GetType());
        }
    }
}
