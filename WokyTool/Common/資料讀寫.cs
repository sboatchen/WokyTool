using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Data;
using WokyTool.DataExport;
using Excel = Microsoft.Office.Interop.Excel;

namespace WokyTool.Common
{
    public class 資料讀寫
    {
        public static IEnumerable<T> ImportCSV<T>(資料讀寫參數CSV Param_) where T : class, 可格式化_Csv, new()
        {
            if (Param_.InitRead() == false)
            {
                Log.Warn("資料讀寫參數異常:" + Param_.ToString());
                return null;
            }

            try
            {
                CsvContext Reader_ = new CsvContext();
                return Reader_.Read<T>(Param_.檔名, Param_.CSV描述);
            }
            catch (Exception Error_)
            {
                Log.Warn("開啟檔案失敗" + Error_.ToString());
            }

            return null;
        }

        public static void ExportCSV<T>(IEnumerable<T> Items_, 資料讀寫參數 Param_) where T : 可格式化_Csv
        {
            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = Param_.檔名;
            dlg.DefaultExt = ".csv";                // Default file extension
            dlg.Filter = "csv files (.csv)|*.csv";  // Filter files by extension
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                Log.Warn("未選擇匯出檔案");
                return;
            }

            Param_.檔名 = dlg.FileName;

            // 寫入資料
            StreamWriter sw = new StreamWriter(Param_.檔名, false, Encoding.Default);
            CsvContext cc = new CsvContext();
            cc.Write(Items_, sw, 共用.OutputDefine);
            sw.Close();
        }








        // 通用匯出格式   //@@ 檢查是否有其他可以共用
        public static void ExportCSV<T>(String FileName_, IEnumerable<T> Items_) where T : 可格式化_Csv
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
        public static void ExportExcel<T>(String FileName_, IEnumerable<T> Items_, 通用匯出結構 Info_ = null, Excel.XlFileFormat Format_ = Excel.XlFileFormat.xlWorkbookNormal) where T : 可格式化_Excel
        {
            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = FileName_;

            switch (Format_)
            {
                case Excel.XlFileFormat.xlOpenXMLWorkbook:
                    dlg.DefaultExt = ".xlsx";
                    dlg.Filter = "xlsx files (.xlsx)|*.xlsx";
                    break;
                default:
                    dlg.DefaultExt = ".xls";                // Default file extension
                    dlg.Filter = "xls files (.xls)|*.xls";  // Filter files by extension
                    break;
            }

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
                Excel.Worksheet NowSheet = Wbook.ActiveSheet;

                // 填入額外資訊
                if (Info_ != null)
                {
                    NowSheet.Name = Info_.Name;
                    Info_.SetExcelTitle(App);
                    NowSheet = xlSheets.Add();
                }

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
                Wbook.SaveAs(dlg.FileName, Format_);

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
        public static void ExportExcel<T>(String FileName_, IEnumerable<IGrouping<String, T>> ItemGroup_, 通用匯出結構 Info_ = null, Excel.XlFileFormat Format_ = Excel.XlFileFormat.xlWorkbookNormal) where T : 可格式化_Excel
        {
            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = FileName_;

            switch (Format_)
            {
                case Excel.XlFileFormat.xlOpenXMLWorkbook:
                    dlg.DefaultExt = ".xlsx";
                    dlg.Filter = "xlsx files (.xlsx)|*.xlsx";
                    break;
                default:
                    dlg.DefaultExt = ".xls";                // Default file extension
                    dlg.Filter = "xls files (.xls)|*.xls";  // Filter files by extension
                    break;
            }

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
                Excel.Worksheet NowSheet = Wbook.ActiveSheet;

                // 填入額外資訊
                if (Info_ != null)
                {
                    NowSheet.Name = Info_.Name;
                    Info_.SetExcelTitle(App);
                    NowSheet = xlSheets.Add();
                }

                bool IsNotStart_ = false;
                foreach (var Pair_ in ItemGroup_)
                {
                    // 建立新分頁
                    if (IsNotStart_)
                        NowSheet = xlSheets.Add();
                    IsNotStart_ = true;

                    NowSheet.Name = Pair_.Key;

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
                Wbook.SaveAs(dlg.FileName, Format_);

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





    }
}
