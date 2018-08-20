using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.物品
{
    public class 物品條碼更新錯誤匯出轉換 : 可格式化_Excel
    {
        protected 物品條碼更新匯入資料 _Data;

        public 物品條碼更新錯誤匯出轉換(物品條碼更新匯入資料 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "縮寫";
            App_.Cells[1, 2] = "條碼";
            App_.Cells[1, 3] = "錯誤訊息";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.物品縮寫識別;
            App_.Cells[Row_, 2] = _Data.條碼;
            App_.Cells[Row_, 3] = _Data.錯誤訊息;

            return Row_ + 1;
        }
    }
}
