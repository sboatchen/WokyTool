using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;

namespace WokyTool.DataExport
{
    class 撿貨統計結構: 可格式化_Excel
    {
        public string 物品名稱 { get; set; }
        public int 數量 { get; set; }

        public 撿貨統計結構(string 物品名稱_, int 數量_)
        {
            物品名稱 = 物品名稱_;
            數量 = 數量_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "物品名稱";
            App_.Cells[1, 2] = "數量";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = 物品名稱;
            App_.Cells[Row_, 2] = 數量;

            return Row_ + 1;
        }
    }
}
