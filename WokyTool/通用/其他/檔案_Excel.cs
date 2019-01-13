using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using Excel = Microsoft.Office.Interop.Excel;

namespace WokyTool.通用
{
    public partial class 檔案
    {
        public static void 寫入Excel(string 檔名_, 可序列化_Excel 資料_, Excel.XlFileFormat Format_ = Excel.XlFileFormat.xlWorkbookNormal)
        {
            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = 檔名_;

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

            訊息管理器.獨體.Debug("寫入檔案 " + 檔名_);

            // 寫入資料
            try
            {
                // 開啟程序
                Excel.Application App = new Excel.Application();
                // App.Visible = true;
                // App.UserControl = true;

                // 開啟工作簿
                Excel.Workbook Wbook = null;
                if (資料_.樣板 == null)
                    Wbook = App.Workbooks.Add();
                else
                    Wbook = App.Workbooks.Open(資料_.樣板);

                // 取得分頁
                var xlSheets = Wbook.Sheets as Excel.Sheets;
                Excel.Worksheet NowSheet = Wbook.ActiveSheet;

                if (String.IsNullOrEmpty(資料_.標頭)  == false)
                    NowSheet.Name = 資料_.標頭;

                資料_.寫入(App);

                // This works.
                Wbook.SaveAs(dlg.FileName, Format_);

                //關閉工作簿
                Wbook.Close();

                //離開程序
                App.Quit();
            }
            catch (Exception theException)
            {
                訊息管理器.獨體.Error("匯出失敗，請通知苦逼程式," + theException.ToString());
            }
        }

        public static void 寫入Excel(string 檔名_, List<可序列化_Excel> 資料列_, Excel.XlFileFormat Format_ = Excel.XlFileFormat.xlWorkbookNormal)
        {
            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = 檔名_;

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
                Excel.Workbook Wbook = null;
                App.Workbooks.Add();

                // 取得分頁
                var xlSheets = Wbook.Sheets as Excel.Sheets;
                Excel.Worksheet NowSheet = Wbook.ActiveSheet;

                bool IsNotStart_ = false;
                foreach (可序列化_Excel 資料_ in 資料列_)
                {
                    // 建立新分頁
                    if (IsNotStart_)
                        NowSheet = xlSheets.Add();
                    IsNotStart_ = true;

                    if (String.IsNullOrEmpty(資料_.標頭) == false)
                        NowSheet.Name = 資料_.標頭;

                    資料_.寫入(App);
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
                訊息管理器.獨體.Error("匯出失敗，請通知苦逼程式," + theException.ToString());
            }
        }
    }
}
