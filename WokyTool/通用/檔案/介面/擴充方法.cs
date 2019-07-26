using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public static class 擴充方法
    {
        private static string[] 換行切割_ = new string[] { "\r\n", "\r", "\n" };

        public static IEnumerable<string[]> 解析<T>(this 可讀出_CSV<T> 轉換_, String 內容_)
        {
            if (String.IsNullOrEmpty(內容_))
                yield return null;

            string[] 列切割_ = new string[] { 轉換_.分格號 };

            foreach (string 行資料_ in 內容_.Split(換行切割_, StringSplitOptions.RemoveEmptyEntries))
            {
                yield return 行資料_.Split(列切割_, StringSplitOptions.None);
            }
        }
    }
}
