using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.月結帳
{
    public class 月結帳新增錯誤匯出轉換 : 可格式化_Excel
    {
        protected 月結帳匯入資料 _Data;

        public 月結帳新增錯誤匯出轉換(月結帳匯入資料 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "公司";
            App_.Cells[1, 2] = "客戶";
            App_.Cells[1, 3] = "商品";
            App_.Cells[1, 4] = "數量";
            App_.Cells[1, 5] = "單價";
            App_.Cells[1, 6] = "錯誤訊息";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.公司.名稱;
            App_.Cells[Row_, 2] = _Data.客戶.名稱;
            App_.Cells[Row_, 3] = _Data.商品識別;
            App_.Cells[Row_, 4] = _Data.數量;
            App_.Cells[Row_, 5] = _Data.單價;
            App_.Cells[Row_, 6] = _Data.錯誤訊息;

            return Row_ + 1;
        }
    }
}
