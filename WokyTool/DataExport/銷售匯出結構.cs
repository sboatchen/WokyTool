using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;

namespace WokyTool.DataExport
{
    class 銷售匯出結構 : 可格式化_Excel
    {
        protected 銷售資料_編輯 _Data;

        public 銷售匯出結構(銷售資料_編輯 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "建立日期";
            App_.Cells[1, 2] = "訂單編號";
            App_.Cells[1, 3] = "商品名稱";
            App_.Cells[1, 4] = "商品編號";
            App_.Cells[1, 5] = "數量";
            App_.Cells[1, 6] = "成本";
            App_.Cells[1, 7] = "售價";
            App_.Cells[1, 8] = "利潤";
            App_.Cells[1, 9] = "總利潤";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.建立日期;
            App_.Cells[Row_, 2] = _Data.訂單編號;
            App_.Cells[Row_, 3] = _Data.商品;
            App_.Cells[Row_, 4] = _Data.商品編號;
            App_.Cells[Row_, 5] = _Data.數量;
            App_.Cells[Row_, 6] = _Data.成本;
            App_.Cells[Row_, 7] = _Data.售價;
            App_.Cells[Row_, 8] = _Data.利潤;
            App_.Cells[Row_, 9] = _Data.總利潤;

            return Row_ + 1;
        }
    }
}
