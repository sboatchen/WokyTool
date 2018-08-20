using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.商品
{
    class 商品新增匯出轉換 : 可格式化_Excel
    {
        protected 商品新增匯入資料 _Data;

        public 商品新增匯出轉換(商品新增匯入資料 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "大類";
            App_.Cells[1, 2] = "小類";

            App_.Cells[1, 3] = "公司";
            App_.Cells[1, 4] = "客戶";

            App_.Cells[1, 5] = "名稱";
            App_.Cells[1, 6] = "品號";

            App_.Cells[1, 7] = "需求1";
            App_.Cells[1, 8] = "需求2";
            App_.Cells[1, 9] = "需求3";
            App_.Cells[1, 10] = "需求4";
            App_.Cells[1, 11] = "需求5";

            App_.Cells[1, 12] = "錯誤訊息";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.大類識別;
            App_.Cells[Row_, 2] = _Data.小類識別;

            App_.Cells[Row_, 3] = _Data.公司識別;
            App_.Cells[Row_, 4] = _Data.客戶識別;

            App_.Cells[Row_, 5] = _Data.名稱;
            App_.Cells[Row_, 6] = _Data.品號;

            App_.Cells[Row_, 7] = _Data.需求識別1;
            App_.Cells[Row_, 8] = _Data.需求識別2;
            App_.Cells[Row_, 9] = _Data.需求識別3;
            App_.Cells[Row_, 10] = _Data.需求識別4;
            App_.Cells[Row_, 11] = _Data.需求識別5;

            App_.Cells[Row_, 12] = _Data.錯誤訊息;

            return Row_ + 1;
        }
    }
}
