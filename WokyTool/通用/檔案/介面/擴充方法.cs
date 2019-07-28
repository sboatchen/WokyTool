using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WokyTool.測試;


namespace WokyTool.通用
{
    public static class 擴充方法
    {
        private static string[] CSV資料切割_ = new string[] { "\r\n", "\r", "\n" };
        private static string CSV欄位切割_ = "{0}(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))";

        public static IEnumerable<T> 讀出<T>(this 可讀出介面_CSV<T> 轉換_, string 內容_)
        {
            if (String.IsNullOrEmpty(內容_))
                yield break;

            string 欄位切割_ = string.Format(CSV欄位切割_, 轉換_.分格號);
            Regex 欄位解析_ = new Regex(欄位切割_);

            bool 是否檢查標頭_ = 轉換_.是否有標頭;
            foreach (string 資料_ in 內容_.Split(CSV資料切割_, StringSplitOptions.RemoveEmptyEntries))
            {
                string[] 資料列_ = 欄位解析_.Split(資料_);

                if (是否檢查標頭_)
                {
                    轉換_.讀出標頭(資料列_);
                    是否檢查標頭_ = false;
                    continue;
                }

                yield return 轉換_.讀出資料(資料列_);
            }
        }

        public static IEnumerable<string[]> 處理<T>(this 可讀出介面_EXCEL<T> 轉換_, Range 資料範圍_)
        {
            int 資料總數_ = 資料範圍_.Rows.Count - 轉換_.資料結尾忽略行數;
            int 欄位總數_ = 資料範圍_.Columns.Count;
            if (資料總數_ == 0 || 欄位總數_ == 0)
                return null;

            // 回傳標頭
            if (轉換_.標頭索引 >= 1)
            {
                string[] 資料_ = new string[欄位總數_];

                for (int 欄位索引_ = 1; 欄位索引_ <= 欄位總數_; 欄位索引_++)
                {
                    var 資料欄_ = 資料範圍_.Cells[轉換_.標頭索引, 欄位索引_];
                    string 內容_ = (資料欄_.Value2 != null) ? 資料欄_.Value2.ToString() : null;

                    if (內容_ == null && 資料欄_.MergeArea != null)
                    {
                        資料欄_ = 資料欄_.MergeArea.Cells[1, 1];
                        內容_ = (資料欄_.Value2 != null) ? 資料欄_.Value2.ToString() : null;
                    }

                    資料_[欄位索引_ - 1] = 內容_;
                }

                轉換_.讀出標頭(資料_);
            }

            List<string[]> 資料暫存_ = new List<string[]>();
            for (int 資料索引_ = 轉換_.資料開始索引; 資料索引_ <= 資料總數_; 資料索引_++)
            {
                string[] 資料列_ = new string[欄位總數_];

                for (int 欄位索引_ = 1; 欄位索引_ <= 欄位總數_; 欄位索引_++)
                {
                    var 資料欄_ = 資料範圍_.Cells[資料索引_, 欄位索引_];
                    string 內容_ = (資料欄_.Value2 != null) ? 資料欄_.Value2.ToString() : null;

                    if (內容_ == null && 資料欄_.MergeArea != null)
                    {
                        資料欄_ = 資料欄_.MergeArea.Cells[1, 1];
                        內容_ = (資料欄_.Value2 != null) ? 資料欄_.Value2.ToString() : null;
                    }

                    資料列_[欄位索引_ - 1] = 內容_;
                }

                資料暫存_.Add(資料列_);
            }

            return 資料暫存_;
        }

        public static IEnumerable<T> 讀出<T>(this 可讀出介面_EXCEL<T> 轉換_, IEnumerable<string[]> 資料暫存_)
        {
            if (資料暫存_ == null)
                yield break;

            foreach (string[] 資料列_ in 資料暫存_)
            {
                yield return 轉換_.讀出資料(資料列_);
            }
        }

        public static string 轉成字串(this string 內容_)
        {
            if (String.IsNullOrEmpty(內容_))
                return 內容_;

            if (內容_.StartsWith("\""))
                return 內容_.Substring(1, 內容_.Length - 2);    //@@ 需測試 字串裡面有""的狀況
            else
                return 內容_;
        }

        public static int 轉成整數(this string 內容_)
        {
            return Int32.Parse(內容_);
        }

        public static float 轉成浮點數(this string 內容_)
        {
            return float.Parse(內容_);
        }

        public static double 轉成倍精準浮點數(this string 內容_)
        {
            return Double.Parse(內容_);
        }

        public static DateTime 轉成時間(this string 內容_)
        {
            double d;
            if (double.TryParse(內容_, out d))
                return DateTime.FromOADate(d);
            else
                return DateTime.Parse(內容_);
        }

        public static T 轉成列舉<T>(this string 內容_)
        {
            return (T)(Enum.Parse(typeof(T), 內容_));
        }
    }
}
