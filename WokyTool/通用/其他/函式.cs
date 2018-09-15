using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public class 通用函式
    {
        public static String 取得字串(Dictionary<int, Object> Map_, int index_)
        {
            Object Value_ = null;
            Map_.TryGetValue(index_, out Value_);

            if (Value_ == null)
                return null;
            return Value_.ToString();
        }
    }
}
