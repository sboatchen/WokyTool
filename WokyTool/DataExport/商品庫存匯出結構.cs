using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;

namespace WokyTool.DataExport
{
    class 商品庫存匯出結構 : 可格式化_Excel
    {
        protected 商品資料 _Data;

        public 商品庫存匯出結構(商品資料 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Application App_)
        {
            App_.Cells[1, 1] = "品號";
            App_.Cells[1, 2] = "名稱";
            App_.Cells[1, 3] = "寄庫";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.品號;
            App_.Cells[Row_, 2] = _Data.名稱;
            App_.Cells[Row_, 3] = _Data.寄庫;

            return Row_ + 1;
        }
    }
}
