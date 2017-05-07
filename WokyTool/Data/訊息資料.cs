using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.Data
{
    public class 訊息資料 : 可格式化_Excel
    {
        public string 標題 { get; set; }
        public string 訊息 { get; set; }

        public 訊息資料(string 標題_, string 訊息_)
        {
            this.標題 = 標題_;
            this.訊息 = 訊息_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "標題";
            App_.Cells[1, 2] = "訊息";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = 標題;
            App_.Cells[Row_, 2] = 訊息;

            return Row_ + 1;
        }
    }
}
