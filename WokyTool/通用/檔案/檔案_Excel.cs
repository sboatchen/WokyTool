using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;
using LinqToExcel;
using LinqToExcel.Query;

namespace WokyTool.通用
{
    public partial class 檔案
    {
        public static bool 詢問並寫入(string 檔名_, 可寫入介面_EXCEL 轉換_)
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
                case XlFileFormat.xlCSV:
                    SFD_.DefaultExt = ".csv";
                    SFD_.Filter = "csv files (.csv)|*.csv";
                    break;
                default:
                    訊息管理器.獨體.錯誤("不支援輸出格式: " + 轉換_.格式);
                    return false;
            }

            if (SFD_.ShowDialog() != DialogResult.OK)
                return false;

            Microsoft.Office.Interop.Excel.Application 應用程式_ = null;
            Workbook 工作簿_ = null;
            Worksheet 分頁_ = null;

            var 時間監測_ = System.Diagnostics.Stopwatch.StartNew();
            時間監測_.Start();

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

                if (false == String.IsNullOrEmpty(轉換_.分類))
                    分頁_.Name = 轉換_.分類;

                ((_Worksheet)分頁_).Activate();

                轉換_.寫入(應用程式_);

                // 存檔
                if (轉換_.密碼 == null)
                    工作簿_.SaveAs(SFD_.FileName, 轉換_.格式);
                else
                    工作簿_.SaveAs(SFD_.FileName, 轉換_.格式, 轉換_.密碼);


                時間監測_.Stop();
                訊息管理器.獨體.訊息("寫入檔案完成: " + SFD_.FileName + ", 費時:" + 時間監測_.ElapsedMilliseconds);

                return true;
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.錯誤("寫入檔案失敗: " + SFD_.FileName, ex);

                return false;
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

                if(時間監測_.IsRunning)
                    時間監測_.Stop();
            }
        }

        public static bool 詢問並寫入(string 檔名_, IEnumerable<可寫入介面_EXCEL> 轉換列_)
        {
            可寫入介面_EXCEL 參考_ = 轉換列_.DefaultIfEmpty(null).First();
            if (參考_ == null)
            {
                訊息管理器.獨體.通知("群組為空");
                return false;
            }

            // 開啟存檔位置
            SaveFileDialog SFD_ = new SaveFileDialog();
            SFD_.FileName = 檔名_;

            switch (參考_.格式)
            {
                case XlFileFormat.xlOpenXMLWorkbook:
                    SFD_.DefaultExt = ".xlsx";
                    SFD_.Filter = "xlsx files (.xlsx)|*.xlsx";
                    break;
                case XlFileFormat.xlWorkbookNormal:
                    SFD_.DefaultExt = ".xls";
                    SFD_.Filter = "xls files (.xls)|*.xls";
                    break;
                case XlFileFormat.xlCSV:
                    SFD_.DefaultExt = ".csv";
                    SFD_.Filter = "csv files (.csv)|*.csv";
                    break;
                default:
                    訊息管理器.獨體.錯誤("不支援輸出格式: " + 參考_.格式);
                    return false;
            }

            if (SFD_.ShowDialog() != DialogResult.OK)
                return false;

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

                    if (false == String.IsNullOrEmpty(轉換_.分類))
                        分頁_.Name = 轉換_.分類;

                    ((_Worksheet)分頁_).Activate();

                    轉換_.寫入(應用程式_);

                    是否為第一頁_ = false;
                }

                // 存檔
                if (參考_.密碼 == null)
                    工作簿_.SaveAs(SFD_.FileName, 參考_.格式);
                else
                    工作簿_.SaveAs(SFD_.FileName, 參考_.格式, 參考_.密碼);

                return true;
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.錯誤("寫入檔案失敗: " + SFD_.FileName, ex);

                return false;
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

        public static List<T> 詢問並讀出<T>(可讀出介面_EXCEL<T> 轉換_)
        {
            // 開啟存檔位置
            OpenFileDialog OFD_ = new OpenFileDialog();
            OFD_.Filter = "Excel files|*.*";

            if (OFD_.ShowDialog() != DialogResult.OK)
                return null;

            // 備份
            if (false == 備份(OFD_.FileName, 轉換_.GetType().Name, "檔案讀出"))
                return null;

            轉換_.讀出檔名(OFD_.FileName);

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
                if (轉換_.分頁名稱 != null)
                {
                    foreach (var obj in 工作簿_.Worksheets)
                    {
                        Worksheet 暫時分頁_ = (Worksheet)obj;
                        if (暫時分頁_.Name.Equals(轉換_.分頁名稱))
                        {
                            分頁_ = 暫時分頁_;
                            break;
                        }
                    }

                    if (分頁_ == null)
                        throw new Exception("找不到指定頁名:" + 轉換_.分頁名稱);
                }
                else 
                {
                    int 分頁索引_ = (轉換_.分頁索引 >= 1) ? 轉換_.分頁索引 : 1;
                    分頁_ = 工作簿_.Worksheets[分頁索引_];
                }

                // 取得資料範圍
                Range 資料範圍_ = 分頁_.UsedRange;

                int 資料總數_ = 資料範圍_.Rows.Count;
                //if (資料總數_ >= 5000)
                //    throw new Exception("偵測到檔案行數超過5000行，請確認");

                int 欄位總數_ = 資料範圍_.Columns.Count;
                if (欄位總數_ >= 200)
                    throw new Exception("偵測到檔案欄數超過200列，請確認");

                訊息管理器.獨體.訊息("EXCEL檔案, 欄數:" + 欄位總數_ + ", 行數:" + 資料總數_);

                var 資料暫存_ = 轉換_.處理(資料範圍_);
                List<T> 資料列_ = 轉換_.讀出(資料暫存_).ToList();
                return 資料列_;
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.錯誤("讀出檔案失敗: " + OFD_.FileName, ex);
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
        private static List<T> 詢問並讀出_EXCEL<T>(string 路徑_) where T : 可初始化介面
        {
            ExcelQueryFactory 讀取工廠_ = null;
            ExcelQueryable<T> 資料列舉_ = null;

            try
            {
                讀取工廠_ = new ExcelQueryFactory(路徑_);
                資料列舉_ = 讀取工廠_.Worksheet<T>(0);   // 指定第一頁

                List<T> 資料列_ = 資料列舉_.執行(Value => Value.初始化()).ToList();
                return 資料列_;
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.錯誤("讀出檔案失敗: " + 路徑_, ex);
                return null;
            }
            finally
            {
                if (讀取工廠_ != null)
                    讀取工廠_.Dispose();
            }
        }
    }
}
