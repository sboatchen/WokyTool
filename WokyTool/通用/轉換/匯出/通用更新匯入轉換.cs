using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WokyTool.通用
{
    public class 通用更新匯入轉換<T> : 可讀出介面_EXCEL<T> //where T : ??
    {
        public int 分頁索引 { get { return 1; } }

        public string 分頁名稱 { get { return null; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return null; } }

        public Type 資料類型 { get; protected set; }

        private List<通用更新匯入欄位方法資料> _方法資料列 = new List<通用更新匯入欄位方法資料>();

        public 通用更新匯入轉換()
        {
            資料類型 = typeof(T);
        }

        public void 讀出標頭(string[] 標頭列_)
        {
            bool 是否有識別欄位_ = false;
            foreach (PropertyInfo 欄位_ in 資料類型.GetProperties())
            {
                可匯入Attribute 屬性_ = 欄位_.GetCustomAttributes(typeof(可匯入Attribute), true).Cast<可匯入Attribute>().DefaultIfEmpty(null).First();
                if (屬性_ == null)
                    continue;

                string 名稱_ = (string.IsNullOrEmpty(屬性_.名稱)) ? 欄位_.Name : 屬性_.名稱;
                int 資料索引_ = Array.IndexOf(標頭列_, 名稱_);
                if(資料索引_ == -1)
                    continue;

                通用更新匯入欄位方法資料 方法_ = new 通用更新匯入欄位方法資料
                {
                    優先級 = 屬性_.優先級,
                };

                string 類型_ = 欄位_.PropertyType.Name;
                switch (類型_)
                {
                    case "String":
                        方法_.方法 = (TSource, TValue) =>
                        {
                            string 值_ = TValue[資料索引_];
                            if (string.IsNullOrEmpty(值_))
                                欄位_.SetValue(TSource, null);
                            else
                                欄位_.SetValue(TSource, 值_);

                        };
                        break;
                    case "Int32":
                        方法_.方法 = (TSource, TValue) =>
                        {
                            string 值_ = TValue[資料索引_];
                            if (string.IsNullOrEmpty(值_))
                                欄位_.SetValue(TSource, 0);
                            else
                                欄位_.SetValue(TSource, Int32.Parse(值_));

                        };
                        break;
                    case "Int64":
                        方法_.方法 = (TSource, TValue) =>
                        {
                            string 值_ = TValue[資料索引_];
                            if (string.IsNullOrEmpty(值_))
                                欄位_.SetValue(TSource, 0);
                            else
                                欄位_.SetValue(TSource, Int64.Parse(值_));

                        };
                        break;
                    case "Decimal":
                        方法_.方法 = (TSource, TValue) =>
                        {
                            string 值_ = TValue[資料索引_];
                            if (string.IsNullOrEmpty(值_))
                                欄位_.SetValue(TSource, 0);
                            else
                                欄位_.SetValue(TSource, Decimal.Parse(值_));

                        };
                        break;
                    case "DateTime":
                        方法_.方法 = (TSource, TValue) =>
                        {
                            string 值_ = TValue[資料索引_];
                            if (string.IsNullOrEmpty(值_))
                                欄位_.SetValue(TSource, default(DateTime));
                            else
                                欄位_.SetValue(TSource, DateTime.Parse(值_));

                        };
                        break;
                    default:
                        訊息管理器.獨體.錯誤("不支援欄位類型轉換:" + 類型_);
                        break;

                }


                是否有識別欄位_ |= 屬性_.識別;

               _方法資料列.Add(方法_);
            }

            if (false == 是否有識別欄位_)
                throw new Exception("缺少識別欄位");

            _方法資料列 = _方法資料列.OrderBy(Value => Value.優先級).ToList();
        }

        public IEnumerable<T> 讀出資料(string[] 資料列_)
        {
            T 物件_ = (T)Activator.CreateInstance(typeof(T));

            foreach (通用更新匯入欄位方法資料 方法資料_ in _方法資料列)
            {
                方法資料_.方法(物件_, 資料列_);
            }

            yield return 物件_;
        }
    }
}
