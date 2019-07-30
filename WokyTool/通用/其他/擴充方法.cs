using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WokyTool.測試;

namespace WokyTool.通用
{
    public static class 擴充方法
    {
        private static BinaryFormatter BF_ = new BinaryFormatter();

        public static T 深複製<T>(this T 物件_)
        {
            if (物件_ != null)
            {
                using (var MS_ = new MemoryStream())
                {
                    BF_.Serialize(MS_, 物件_);
                    MS_.Seek(0, SeekOrigin.Begin);
                    return (T)BF_.Deserialize(MS_);
                }
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

        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int memcmp(byte[] b1, byte[] b2, long count);

        public static bool 是否相等(this byte[] b1, byte[] b2)
        {
            // Validate buffers are the same length.
            // This also ensures that the count does not exceed the length of either buffer.  
            return b1.Length == b2.Length && memcmp(b1, b2, b1.Length) == 0;
        }
    }
}
