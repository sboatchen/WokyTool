using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.進貨
{
    class 進貨新增錯誤匯出轉換 : 可格式化_Excel
    {
        protected 進貨新增匯入資料 _Data;

        public 進貨新增錯誤匯出轉換(進貨新增匯入資料 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "類型";

            App_.Cells[1, 2] = "廠商";

            App_.Cells[1, 3] = "物品";
            App_.Cells[1, 4] = "數量";
            App_.Cells[1, 5] = "單價";

            App_.Cells[1, 6] = "備註";

            App_.Cells[1, 7] = "錯誤訊息";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.類型;

            App_.Cells[Row_, 2] = _Data.廠商識別;

            App_.Cells[Row_, 3] = _Data.物品識別;
            App_.Cells[Row_, 4] = _Data.數量;
            App_.Cells[Row_, 5] = _Data.單價;

            App_.Cells[Row_, 6] = _Data.備註;

            App_.Cells[Row_, 7] = _Data.錯誤訊息;

            return Row_ + 1;
        }
    }
}
