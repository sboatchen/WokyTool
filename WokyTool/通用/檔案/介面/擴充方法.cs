using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WokyTool.Common;


namespace WokyTool.通用
{
    public static class 擴充方法_檔案
    {
        private static string[] _CSV資料切割 = new string[] { "\r\n", "\r", "\n" };
        private static string _CSV欄位切割 = "{0}(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))";

        public static IEnumerable<T> 讀出<T>(this 可讀出介面_CSV<T> 轉換_, string 內容_)
        {
            if (String.IsNullOrEmpty(內容_))
                yield break;

            string 欄位切割_ = string.Format(_CSV欄位切割, 轉換_.分格號);
            Regex 欄位解析_ = new Regex(欄位切割_);

            string[] 行_ = 內容_.Split(_CSV資料切割, StringSplitOptions.RemoveEmptyEntries);
            int 資料總數_ = 行_.Length - 轉換_.資料結尾忽略行數;

            for (int 行數_ = 1 ; 行數_ <= 資料總數_ ; 行數_++)
            {
                string 資料_ = 行_[行數_-1];
                string[] 資料列_ = 欄位解析_.Split(資料_);

                if (行數_ == 轉換_.標頭索引)
                    轉換_.讀出標頭(資料列_);
                else if (行數_ >= 轉換_.資料開始索引)
                {
                    foreach (T 子資料_ in 轉換_.讀出資料(資料列_))
                        yield return 子資料_;
                }
            }
        }

        public static IEnumerable<string[]> 處理<T>(this 可讀出介面_EXCEL<T> 轉換_, Range 資料範圍_)
        {
            int 行總數_ = 資料範圍_.Rows.Count;
            int 欄總數_ = 資料範圍_.Columns.Count;
            if (行總數_ == 0 || 欄總數_ == 0)
                return null;

            int 資料結束索引_ = 行總數_ - 轉換_.資料結尾忽略行數;
            List<string[]> 資料暫存_ = new List<string[]>();

            int 索引_ = 1;
            int 欄位索引_ = 1;
            try
            {
                for (; 索引_ <= 行總數_; 索引_++)
                {
                    string[] 資料列_ = new string[欄總數_];

                    欄位索引_ = 1;
                    for (; 欄位索引_ <= 欄總數_; 欄位索引_++)
                    {
                        var 資料欄_ = 資料範圍_.Cells[索引_, 欄位索引_];
                        string 內容_ = (資料欄_.Value2 != null) ? 資料欄_.Value2.ToString() : null;

                        if (內容_ == null && 資料欄_.MergeArea != null)
                        {
                            資料欄_ = 資料欄_.MergeArea.Cells[1, 1];
                            內容_ = (資料欄_.Value2 != null) ? 資料欄_.Value2.ToString() : null;
                        }

                        資料列_[欄位索引_ - 1] = 內容_;
                    }

                    if (索引_ == 轉換_.標頭索引)
                        轉換_.讀出標頭(資料列_);
                    else if (索引_ >= 轉換_.資料開始索引 && 索引_ <= 資料結束索引_)
                        資料暫存_.Add(資料列_);
                    else
                        轉換_.讀出額外資訊(索引_, 資料列_);

                    if (索引_ % 1000 == 0)
                    {
                        bool 是否繼續_ = 訊息管理器.獨體.確認(字串.讀取確認, "目前已讀取 " + 索引_ + " 行, 請確認是否繼續??");
                        if (是否繼續_ == false)
                            break;
                    }
                }

                return 資料暫存_;
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.錯誤("錯誤位置 " + 索引_ + ", " + 欄位索引_);
                throw ex;
            }
        }

        public static IEnumerable<T> 讀出<T>(this 可讀出介面_EXCEL<T> 轉換_, IEnumerable<string[]> 資料暫存_)
        {
            if (資料暫存_ == null)
                yield break;

            foreach (string[] 資料列_ in 資料暫存_)
            {
                foreach(T 資料_ in 轉換_.讀出資料(資料列_))    //@@濾掉資料底端 全部空白的資料
                    yield return 資料_;
            }   
        }

        public static string 移除前後引號(this string 內容_)
        {
            if (string.IsNullOrEmpty(內容_))
                return 內容_;

            int 開始位置 = 0;
            int 移除數量 = 0;

            if (內容_.StartsWith("\"") || 內容_.StartsWith("'"))
            {
                開始位置 = 1;
                移除數量 += 1;
            }

            if (內容_.EndsWith("\"") || 內容_.EndsWith("'"))
            {
                移除數量 += 1;
            }

            if (移除數量 > 0)
            {
                return 內容_.Substring(開始位置, 內容_.Length - 移除數量);
            }

            return 內容_;
        }

        public static string 轉成字串(this string 內容_)
        {
            if (string.IsNullOrEmpty(內容_))
                return null;

            return 內容_.移除前後引號();
        }

        public static int 轉成整數(this string 內容_)
        {
            if (string.IsNullOrEmpty(內容_))
                return 0;

            內容_ = 內容_.移除前後引號();

            return Int32.Parse(內容_);
        }

        public static float 轉成浮點數(this string 內容_)
        {
            if (string.IsNullOrEmpty(內容_))
                return 0f;

            內容_ = 內容_.移除前後引號();

            return float.Parse(內容_);
        }

        public static double 轉成倍精準浮點數(this string 內容_)
        {
            if (string.IsNullOrEmpty(內容_))
                return 0d;

            內容_ = 內容_.移除前後引號();

            return Double.Parse(內容_);
        }

        public static DateTime 轉成時間(this string 內容_)
        {
            if (string.IsNullOrEmpty(內容_))
                return DateTime.MinValue;

            內容_ = 內容_.移除前後引號();

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
