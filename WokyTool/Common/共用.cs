using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace WokyTool.Common
{
    public static class 共用
    {
        // CSV讀寫檔格式
        public static CsvFileDescription ReaderDefine;
        public static CsvFileDescription OutputDefine;
        public static CsvFileDescription OutputAppendDefine;

        // 現在的年月日
        public static DateTime NowYMD;
        public static String NowYMDDec;

        public static DateTime TomorrowYMD;
        public static DateTime A5YMD;

        public static void Init()
        {
            // 初始化讀檔設定
            ReaderDefine = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                TextEncoding = Encoding.Unicode,
                DetectEncodingFromByteOrderMarks = true,
            };

            // 初始化寫檔設定
            OutputDefine = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = true,
                EnforceCsvColumnAttribute = true
            };

            // 初始化寫檔設定
            OutputAppendDefine = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = false,
                EnforceCsvColumnAttribute = true
            };

            NowYMD = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, 0);
            NowYMDDec = String.Format("{0}{1:00}{2:00}", NowYMD.Year, NowYMD.Month, NowYMD.Day);

            TomorrowYMD = NowYMD.AddDays(1);
            A5YMD = NowYMD.AddDays(5);
        }


        // 取得匯出的資料路徑
        /*FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
        dlg.Description = "指定匯出位置";
        dlg.ShowNewFolderButton = true;
        if (dlg.ShowDialog() != DialogResult.OK)
            return;

        string RootPath_ = dlg.SelectedPath;*/
    }
}
