using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using Microsoft.Office.Interop.Excel;
using System.IO;
using LinqToExcel;
using LinqToExcel.Query;

namespace WokyTool.通用
{
    public partial class 檔案
    {
        public static void 詢問並寫入(string 檔名_, 可寫入介面_EXCEL 轉換_)
        {
            // 開啟存檔位置
            SaveFileDialog SFD_ = new SaveFileDialog();
            SFD_.FileName = 檔名_;

            switch (轉換_.格式)
            {
                case XlFileFormat.xlOpenXMLWorkbook:
                    SFD_.DefaultExt = ".xlsx";
                    SFD_.Filter = "xlsx files (.xlsx)|*.xlsx";
                    break;
                case XlFileFormat.xlWorkbookNormal:
                    SFD_.DefaultExt = ".xls";
                    SFD_.Filter = "xls files (.xls)|*.xls";
                    break;
                default:
                    訊息管理器.獨體.Error("不支援輸出格式: " + 轉換_.格式);
                    return;
            }

            if (SFD_.ShowDialog() != DialogResult.OK)
                return;

            Microsoft.Office.Interop.Excel.Application 應用程式_ = null;
            Workbook 工作簿_ = null;
            Worksheet 分頁_ = null;

            try
            {
                // 開啟應用程式
                應用程式_ = new Microsoft.Office.Interop.Excel.Application();
                // 應用程式_.Visible = true;
                // 應用程式_.UserControl = true;

                // 開啟工作簿
                if (轉換_.樣板 == null)
                    工作簿_ = 應用程式_.Workbooks.Add();
                else
                    工作簿_ = 應用程式_.Workbooks.Open(Path.GetFullPath(轉換_.樣板));

                // 取得分頁
                分頁_ = 工作簿_.Worksheets[1];
                分頁_.Name = 轉換_.分類;
                ((_Worksheet)分頁_).Activate();

                轉換_.寫入(應用程式_);

                // 存檔
                if (轉換_.密碼 == null)
                    工作簿_.SaveAs(SFD_.FileName, 轉換_.格式);
                else
                    工作簿_.SaveAs(SFD_.FileName, 轉換_.格式, 轉換_.密碼);
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.Error("寫入檔案失敗: " + SFD_.FileName, ex);
            }
            finally
            {
                if (工作簿_ != null)
                    工作簿_.Close();

                if (應用程式_ != null)
                    應用程式_.Quit();

                //釋放Excel資源
                System.Runtime.InteropServices.Marshal.ReleaseComObject(應用程式_);
                分頁_ = null;
                工作簿_ = null;
                應用程式_ = null;
                GC.Collect();
            }
        }

        public static void 詢問並寫入(string 檔名_, List<可寫入介面_EXCEL> 轉換列_)
        {
            // 開啟存檔位置
            SaveFileDialog SFD_ = new SaveFileDialog();
            SFD_.FileName = 檔名_;

            switch (轉換列_[0].格式)
            {
                case XlFileFormat.xlOpenXMLWorkbook:
                    SFD_.DefaultExt = ".xlsx";
                    SFD_.Filter = "xlsx files (.xlsx)|*.xlsx";
                    break;
                case XlFileFormat.xlWorkbookNormal:
                    SFD_.DefaultExt = ".xls";
                    SFD_.Filter = "xls files (.xls)|*.xls";
                    break;
                default:
                    訊息管理器.獨體.Error("不支援輸出格式: " + 轉換列_[0].格式);
                    return;
            }

            if (SFD_.ShowDialog() != DialogResult.OK)
                return;

            Microsoft.Office.Interop.Excel.Application 應用程式_ = null;
            Workbook 工作簿_ = null;
            Worksheet 分頁_ = null;

            try
            {
                // 開啟應用程式
                應用程式_ = new Microsoft.Office.Interop.Excel.Application();
                // 應用程式_.Visible = true;
                // 應用程式_.UserControl = true;

                // 開啟工作簿
                工作簿_ = 應用程式_.Workbooks.Add();

                bool 是否為第一頁_ = true;
                foreach (可寫入介面_EXCEL 轉換_ in 轉換列_)
                {
                    // 取得分頁
                    if (是否為第一頁_)
                        分頁_ = 工作簿_.Worksheets[1];
                    else
                        分頁_ = 工作簿_.Sheets.Add();

                    分頁_.Name = 轉換_.分類;
                    ((_Worksheet)分頁_).Activate();

                    轉換_.寫入(應用程式_);

                    是否為第一頁_ = false;
                }

                // 存檔
                if (轉換列_[0].密碼 == null)
                    工作簿_.SaveAs(SFD_.FileName, 轉換列_[0].格式);
                else
                    工作簿_.SaveAs(SFD_.FileName, 轉換列_[0].格式, 轉換列_[0].密碼);
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.Error("寫入檔案失敗: " + SFD_.FileName, ex);
            }
            finally
            {
                if (工作簿_ != null)
                    工作簿_.Close();

                if (應用程式_ != null)
                    應用程式_.Quit();

                //釋放Excel資源
                System.Runtime.InteropServices.Marshal.ReleaseComObject(應用程式_);
                分頁_ = null;
                工作簿_ = null;
                應用程式_ = null;
                GC.Collect();
            }
        }

        public static IEnumerable<T> 詢問並讀出<T>(可讀出介面_EXCEL<T> 轉換_)
        {
            // 開啟存檔位置
            OpenFileDialog OFD_ = new OpenFileDialog();
            OFD_.Filter = "Excel files|*.*";

            if (OFD_.ShowDialog() != DialogResult.OK)
                return null;

            // 備份
            if (false == 備份(OFD_.FileName, typeof(T).Name, "檔案讀出"))
                return null;

            Microsoft.Office.Interop.Excel.Application 應用程式_ = null;
            Workbook 工作簿_ = null;
            Worksheet 分頁_ = null;

            try
            {
                // 開啟應用程式
                應用程式_ = new Microsoft.Office.Interop.Excel.Application();
                // 應用程式_.Visible = true;
                // 應用程式_.UserControl = true;

                // 開啟工作簿
                if (轉換_.密碼 == null)
                    工作簿_ = 應用程式_.Workbooks.Open(OFD_.FileName, Type.Missing, true);
                else
                    工作簿_ = 應用程式_.Workbooks.Open(OFD_.FileName, Type.Missing, true, Type.Missing, 轉換_.密碼);

                // 取得分頁
                int 分頁索引_ = (轉換_.分頁索引 >= 1) ? 轉換_.分頁索引 : 1;
                分頁_ = 工作簿_.Worksheets[分頁索引_];

                // 取得資料範圍
                Range 資料範圍_ = 分頁_.UsedRange;

                int 資料總數_ = 資料範圍_.Rows.Count;
                if (資料總數_ >= 5000)
                    throw new Exception("偵測到檔案行數超過5000行，請確認");

                int 欄位總數_ = 資料範圍_.Columns.Count;
                if (欄位總數_ >= 200)
                    throw new Exception("偵測到檔案列數超過200列，請確認");

                var 資料暫存_ = 轉換_.處理(資料範圍_);
                return 轉換_.讀出(資料暫存_);
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.Error("讀出檔案失敗: " + OFD_.FileName, ex);
                return null;
            }
            finally
            {
                if (工作簿_ != null)
                    工作簿_.Close();

                if (應用程式_ != null)
                    應用程式_.Quit();

                //釋放Excel資源
                System.Runtime.InteropServices.Marshal.ReleaseComObject(應用程式_);
                分頁_ = null;
                工作簿_ = null;
                應用程式_ = null;
                GC.Collect();
            }
        }

        // 警告 無法轉換列舉(會以double形式讀入，造成轉型失敗)
        public static IEnumerable<T> 詢問並讀出<T>() where T : 可初始化介面
        {
            // 開啟存檔位置
            OpenFileDialog OFD_ = new OpenFileDialog();
            OFD_.Filter = "Excel files|*.*";

            if (OFD_.ShowDialog() != DialogResult.OK)
                yield break;

            // 備份
            if (false == 備份(OFD_.FileName, typeof(T).Name, "檔案讀出"))
                yield break;

            ExcelQueryFactory 讀取工廠_ = null;
            ExcelQueryable<T> 資料列_ = null;

            try
            {
                讀取工廠_ = new ExcelQueryFactory(OFD_.FileName);
                資料列_ = 讀取工廠_.Worksheet<T>(0);   // 指定第一頁
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.Error("讀出檔案失敗: " + OFD_.FileName, ex);
                yield break;
            }
            finally
            {
                if (讀取工廠_ != null)
                    讀取工廠_.Dispose();
            }

            foreach (var Item_ in 資料列_)
            {
                Item_.初始化();
                yield return Item_;
            }
        }
    }
}
