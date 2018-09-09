using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.平台訂單
{
    public class 平台訂單新增錯誤匯出轉換 : 可格式化_Excel
    {
        protected 平台訂單匯入資料 _Data;

        public 平台訂單新增錯誤匯出轉換(平台訂單匯入資料 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "訂單編號";
            App_.Cells[1, 2] = "姓名";
            App_.Cells[1, 3] = "商品";
            App_.Cells[1, 4] = "錯誤訊息";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.訂單編號;
            App_.Cells[Row_, 2] = _Data.姓名;
            App_.Cells[Row_, 3] = _Data.商品識別;
            App_.Cells[Row_, 4] = _Data.錯誤訊息;

            return Row_ + 1;
        }
    }
}
