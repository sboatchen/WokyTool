﻿using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WokyTool.Common
{
    public static class 函式
    {
        // 組合需求物品字串
        public static String GetCombineItemString(Dictionary<String, int> 物品列表_)
        {
            StringBuilder sb = new StringBuilder();
            bool IsNotFrist_ = false;
            foreach (var Pair in 物品列表_)
            {
                if (IsNotFrist_)
                {
                    sb.Append('+');
                }

                sb.Append(Pair.Key);

                int Number_ = Pair.Value;
                if (Number_ > 1)
                {
                    sb.Append('*');
                    sb.Append(Number_);
                }

                IsNotFrist_ = true;
            }
            return sb.ToString();
        }

        // 通用匯出格式   //@@ 檢查是否有其他可以共用
        public static void ExportCSV<T>(String FileName_, IEnumerable<T> Items_)
        {
            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = FileName_;
            dlg.DefaultExt = ".csv";                // Default file extension
            dlg.Filter = "csv files (.csv)|*.csv";  // Filter files by extension
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;

            // 寫入資料
            StreamWriter sw = new StreamWriter(dlg.FileName, false, Encoding.Default);
            CsvContext cc = new CsvContext();
            cc.Write(Items_, sw, 共用.OutputDefine);
            sw.Close();
        }

        // 通用匯出格式   //@@ 檢查是否有其他可以共用
        public static void ExportExcel<T>(String FileName_, IEnumerable<T> Items_) where T : 可格式化_Excel
        {
            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = FileName_;
            dlg.DefaultExt = ".xls";                // Default file extension
            dlg.Filter = "xls files (.xls)|*.xls";  // Filter files by extension
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            // 寫入資料
            try
            {
                // 開啟程序
                Excel.Application App = new Excel.Application();
                // App.Visible = true;
                // App.UserControl = true;

                // 開啟工作簿
                Excel.Workbook Wbook = App.Workbooks.Add();

                int x = 1;
                bool IsFirst_ = true;
                foreach (var Item in Items_)
                {
                    if (IsFirst_)
                    {
                        x = Item.SetExcelTitle(App);
                        IsFirst_ = false;
                    }

                    x = Item.SetExcelData(App, x);
                }

                // This works.
                Wbook.SaveAs(dlg.FileName, Excel.XlFileFormat.xlWorkbookNormal);

                //關閉工作簿
                Wbook.Close();

                //離開程序
                App.Quit();
            }
            catch (Exception theException)
            {
                MessageBox.Show("匯出失敗，請通知苦逼程式," + theException.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 通用匯出格式
        public static void ExportExcel<T>(String FileName_, IEnumerable<IGrouping<String, T>> ItemGroup_) where T : 可格式化_Excel
        {
            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = FileName_;
            dlg.DefaultExt = ".xls";                // Default file extension
            dlg.Filter = "xls files (.xls)|*.xls";  // Filter files by extension
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            // 寫入資料
            try
            {
                // 開啟程序
                Excel.Application App = new Excel.Application();
                // App.Visible = true;
                // App.UserControl = true;

                // 開啟工作簿
                Excel.Workbook Wbook = App.Workbooks.Add();

                // 取得分頁
                var xlSheets = Wbook.Sheets as Excel.Sheets;

                foreach (var Pair_ in ItemGroup_)
                {
                    // 建立新分頁
                    var xlNewSheet = (Excel.Worksheet)xlSheets.Add();
                    xlNewSheet.Name = Pair_.Key;

                    int x = 1;
                    bool IsFirst_ = true;
                    foreach (var Item in Pair_)
                    {
                        if (IsFirst_)
                        {
                            x = Item.SetExcelTitle(App);
                            IsFirst_ = false;
                        }

                        x = Item.SetExcelData(App, x);
                    }
                }

                // This works.
                Wbook.SaveAs(dlg.FileName, Excel.XlFileFormat.xlWorkbookNormal);

                //關閉工作簿
                Wbook.Close();

                //離開程序
                App.Quit();
            }
            catch (Exception theException)
            {
                MessageBox.Show("匯出失敗，請通知苦逼程式," + theException.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 拷貝檔案
        public static void GetFile(String FileName_, String Resource_)
        {
            // 取得副檔名
            int Index_ = Resource_.LastIndexOf(".");
            string Type_ = Resource_.Substring(Index_, Resource_.Length - Index_);

            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = FileName_;
            dlg.DefaultExt = Type_;                // Default file extension
            //dlg.Filter = "csv files (.csv)|*.csv";  // Filter files by extension
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;

            // 寫入資料
            System.IO.File.Copy(Resource_, dlg.FileName);
        }
    }
}
