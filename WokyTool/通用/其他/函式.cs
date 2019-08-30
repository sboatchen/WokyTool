using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public class 函式
    {
        //@@@ 待整理
        public static String 取得字串(Dictionary<int, Object> Map_, int index_)
        {
            Object Value_ = null;
            Map_.TryGetValue(index_, out Value_);

            if (Value_ == null)
                return null;
            return Value_.ToString();
        }

        //@@@ 待整理
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

        //@@@ 待整理
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

        //@@@ 待整理
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

        private static StringBuilder _商品識別SB = new StringBuilder();
        public static String 取得商品識別(params string[] 資料列_)
        {
            _商品識別SB.Clear();

            foreach (string 資料_ in 資料列_)
            {
                if (string.IsNullOrEmpty(資料_))
                    continue;

                if (_商品識別SB.Length > 0)
                    _商品識別SB.Append('@');

                _商品識別SB.Append(資料_);
            }

            return _商品識別SB.ToString();
        }

        public static List<Type> 取得繼承結構列(Type 物件類別_)
        {
            List<Type> 繼承結構列_ = new List<Type>();
            Type 疊代類別_ = 物件類別_;
            do
            {
                繼承結構列_.Add(疊代類別_);
                疊代類別_ = 疊代類別_.BaseType;
            } while (疊代類別_ != null);

            return 繼承結構列_;
        }
    }
}
