using System;
using System.Collections.Generic;

namespace WokyTool.通用
{
    public class 列印檢查器<T> : 可檢查介面
    {
        public Dictionary<T, string> 資料書 { get; set; }

        public bool 是否合法
        {
            get { return 資料書.Count == 0; }
        }

        public 列印檢查器()
        {
            資料書 = new Dictionary<T, string>();
        }

        public void 錯誤(基本資料 資料_, string 訊息_)
        {
            T 新資料_ = (T)Convert.ChangeType(資料_, typeof(T));

            if (資料書.ContainsKey(新資料_))
                資料書[新資料_] += ", " + 訊息_;
            else
                資料書[新資料_] = 訊息_;
        }
    }
}
