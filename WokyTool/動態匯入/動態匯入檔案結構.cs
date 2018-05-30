using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using Excel = Microsoft.Office.Interop.Excel;

namespace WokyTool.動態匯入
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 動態匯入檔案結構 : MyData
    {
        [JsonProperty]
        public 動態匯入檔案設定 設定{ get; set; }
        [JsonProperty]
        public List<動態匯入資料結構> 內容 { get; set; }

        // 自行建立的名稱映射對應表 合併 使用者設定的名稱與讀取到的欄位名稱
        //public Dictionary<string, 動態匯入資料設定> 名稱映射對應表 { get; set; }

        public 動態匯入檔案結構(動態匯入檔案設定 設定_)
        {
            設定 = 設定_;
            內容 = new List<動態匯入資料結構>();

            //名稱映射對應表 = new Dictionary<string, 動態匯入資料設定>(設定.名稱映射對應表);
        }

        protected 動態匯入資料設定 getDataSetting(int Index_)
        {
            動態匯入資料設定 Item_;
            if (設定.欄位位置對應表.TryGetValue(Index_, out Item_))
            {
                return Item_;
            }

            return 動態匯入資料設定.ERROR;
        }

        public void ReadExcel(String FileName_)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            int rw = 0;
            int cl = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(FileName_, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            // 計算內容範圍
            int StartRow_ = 設定.開始位置;
            int EndRow_ = rw - 設定.結束位置;

            // 初始化資料物件
            for (int rCnt = StartRow_; rCnt <= EndRow_; rCnt++)
            {
                內容.Add(new 動態匯入資料結構(this));
            }

            // 讀取內容
            for (int cCnt = 1; cCnt <= cl; cCnt++)
            {
                動態匯入資料設定 資料設定_ = getDataSetting(cCnt);

                // 檢查是否設定欄位名稱
                /*if(設定.標頭位置 != -1 && 名稱映射對應表.ContainsValue(資料設定_) == false){
                    var cell = range.Cells[設定.標頭位置 , cCnt] as Excel.Range;
                    String 名稱_ = cell.Value2;
                    if(String.IsNullOrEmpty(名稱_) == false){
                        名稱映射對應表.Add(名稱_, 資料設定_);
                    }
                }*/

                dynamic 上層資料_ = null;
                for (int rCnt = StartRow_, 資料列_ = 0; rCnt <= EndRow_; rCnt++, 資料列_++)
                {
                    var cell = range.Cells[rCnt, cCnt] as Excel.Range;
                    var value = cell.Value2;

                    if (value != null)
                    {
                        內容[資料列_].資料.Add(value);
                        上層資料_ = value;
                    }
                    else if (資料設定_.可合併儲存格 == true && cell.MergeArea != null && 上層資料_ != null)
                    {
                        內容[資料列_].資料.Add(value);
                    }
                    else
                    {
                        上層資料_ = null;
                        內容[資料列_].資料.Add(null);
                    }
                }
            }

            xlWorkBook.Close(false, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }        
    }
}
