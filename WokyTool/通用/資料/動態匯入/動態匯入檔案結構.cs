using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using Excel = Microsoft.Office.Interop.Excel;

namespace WokyTool.通用
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 動態匯入檔案結構 : 基本資料
    {
        [JsonProperty]
        public 檔案匯入設定資料介面 設定 { get; set; }
        [JsonProperty]
        public List<動態匯入資料結構> 內容 { get; set; }

        public 動態匯入檔案結構(檔案匯入設定資料介面 設定_)
        {
            設定 = 設定_;
            內容 = new List<動態匯入資料結構>();
        }

        public void ReadExcel(String FileName_, bool 是否讀入雜值_)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            int rw = 0;
            int cl = 0;

            int cCnt = 0;
            int rCnt = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(FileName_, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            if(rw >= 5000)
            {
                訊息管理器.獨體.錯誤("偵測到檔案行數超過5000行，請確認");
                return;
            }

            if (cl >= 200)
            {
                訊息管理器.獨體.錯誤("偵測到檔案列數超過200列，請確認");
                return;
            }

            // 計算內容範圍
            int StartRow_ = 設定.開始位置;
            int EndRow_ = rw - 設定.結束位置;

            // 初始化資料物件
            for (rCnt = StartRow_; rCnt <= EndRow_; rCnt++)
            {
                內容.Add(new 動態匯入資料結構(this));
            }

            // 讀取內容
            dynamic dValue_ = null;
            try
            {
                if (是否讀入雜值_ == true)
                {
                    for (cCnt = 1; cCnt <= cl; cCnt++)
                    {
                        欄位匯入設定資料 欄位設定_ = 設定.取得欄位匯入設定資料(cCnt);
                        if (欄位匯入設定資料.ERROR == 欄位設定_)
                        {
                            object 上層資料_ = null;
                            int 資料列_ = 0;
                            for (rCnt = StartRow_; rCnt <= EndRow_; rCnt++, 資料列_++)
                            {
                                var cell = range.Cells[rCnt, cCnt] as Excel.Range;
                                dValue_ = cell.Value2;

                                object value = null;
                                if (dValue_ != null)
                                    value = dValue_.ToString();

                                if (value != null)
                                {
                                    內容[資料列_].詳細.Add(cCnt, value);
                                    上層資料_ = value;
                                }
                                else if (欄位設定_.可合併儲存格 == true && cell.MergeArea != null && 上層資料_ != null)
                                {
                                    內容[資料列_].詳細.Add(cCnt, 上層資料_);
                                }
                                else
                                {
                                    上層資料_ = null;
                                    內容[資料列_].詳細.Add(cCnt, null);
                                }
                            }
                        }
                        else
                        {
                            object 上層資料_ = null;
                            int 資料列_ = 0;
                            for (rCnt = StartRow_; rCnt <= EndRow_; rCnt++, 資料列_++)
                            {
                                var cell = range.Cells[rCnt, cCnt] as Excel.Range;
                                dValue_ = cell.Value2;
                                object value = 函式.轉型資料(dValue_, 欄位設定_.格式);

                                if (value != null)
                                {
                                    內容[資料列_].資料.Add(欄位設定_.名稱, value);
                                    內容[資料列_].詳細.Add(cCnt, value);
                                    上層資料_ = value;
                                }
                                else if (欄位設定_.可合併儲存格 == true && cell.MergeArea != null && 上層資料_ != null)
                                {
                                    內容[資料列_].資料.Add(欄位設定_.名稱, 上層資料_);
                                    內容[資料列_].詳細.Add(cCnt, 上層資料_);
                                }
                                else
                                {
                                    上層資料_ = null;
                                    內容[資料列_].資料.Add(欄位設定_.名稱, null);
                                    內容[資料列_].詳細.Add(cCnt, null);
                                }
                            }
                        }
                    }
                }
                else 
                {
                    for (cCnt = 1; cCnt <= cl; cCnt++)
                    {
                        欄位匯入設定資料 欄位設定_ = 設定.取得欄位匯入設定資料(cCnt);
                        if (欄位匯入設定資料.ERROR == 欄位設定_)
                            continue;

                        object 上層資料_ = null;
                        int 資料列_ = 0;
                        for (rCnt = StartRow_; rCnt <= EndRow_; rCnt++, 資料列_++)
                        {
                            var cell = range.Cells[rCnt, cCnt] as Excel.Range;
                            dValue_ = cell.Value2;
                            object value = 函式.轉型資料(dValue_, 欄位設定_.格式);

                            if (value != null)
                            {
                                內容[資料列_].資料.Add(欄位設定_.名稱, value);
                                上層資料_ = value;
                            }
                            else if (欄位設定_.可合併儲存格 == true && cell.MergeArea != null && 上層資料_ != null)
                            {
                                內容[資料列_].資料.Add(欄位設定_.名稱, 上層資料_);
                            }
                            else
                            {
                                上層資料_ = null;
                                內容[資料列_].資料.Add(欄位設定_.名稱, null);
                            }
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.錯誤("失敗位置:" + rCnt + "," + cCnt + " " + dValue_);
                throw ex;
            }
            finally
            {
                if (xlWorkBook != null)
                    xlWorkBook.Close(false, null, null);

                if (xlApp != null)
                    xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
        }
    }
}
