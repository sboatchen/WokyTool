using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public class 函式
    {
        public static String 取得字串(Dictionary<int, Object> Map_, int index_)
        {
            Object Value_ = null;
            Map_.TryGetValue(index_, out Value_);

            if (Value_ == null)
                return null;
            return Value_.ToString();
        }

        public static object 轉型資料(object dynamic, 列舉.資料格式 資料格式類型)
        {
            if (dynamic == null)
                return null;

            switch (資料格式類型)
            {
                case 列舉.資料格式.文字:
                    return dynamic.ToString();
                case 列舉.資料格式.金額:
                    return Convert.ToDecimal(dynamic.ToString());
                case 列舉.資料格式.整數:
                    return Convert.ToInt32(dynamic.ToString());
                case 列舉.資料格式.日期:
                    {
                        double d;
                        if (double.TryParse(dynamic.ToString(), out d))
                            return DateTime.FromOADate(d);
                        else
                            return DateTime.Parse(dynamic.ToString());
                    }
                default:
                    throw new Exception("轉型資料 不支援的格式 " + 資料格式類型);
            }
        }

        public static bool 是否一致<T>(List<T> X_, List<T> Y_)
        {
             if(X_ == null && Y_ == null)
                return true;

            if(X_ == null || Y_ == null || X_.Count != Y_.Count)
                return false;

            int HashX_ = X_.Sum(Value => Value.GetHashCode());
            int HashY_ = Y_.Sum(Value => Value.GetHashCode());

            return X_ == Y_;
        }

        public static bool 是否一致<T, P>(Dictionary<P, List<T>> X_, Dictionary<P, List<T>> Y_)
        {
            if (X_ == null && Y_ == null)
                return true;

            if (X_ == null || Y_ == null || X_.Count != Y_.Count)
                return false;

            int HashX_ = X_.Values.Sum(Value => Value.GetHashCode());
            int HashY_ = Y_.Values.Sum(Value => Value.GetHashCode());

            return X_ == Y_;
        }
    }
}
