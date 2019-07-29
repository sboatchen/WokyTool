using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                using (var stream = new MemoryStream())
                {
                    BF_.Serialize(stream, 物件_);
                    stream.Seek(0, SeekOrigin.Begin);
                    var result = (T)BF_.Deserialize(stream);
                    return result;
                }
            }

            return default(T);
        }
    }
}
