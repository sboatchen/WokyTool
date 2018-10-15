using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.物品;

namespace WokyTool.進貨
{
    public class 進貨總覽匯出轉換 : 可格式化_Excel
    {
        protected 進貨資料 _Data;

        public 進貨總覽匯出轉換(進貨資料 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "編號";

            App_.Cells[1, 2] = "時間";
            App_.Cells[1, 3] = "類型";

            App_.Cells[1, 4] = "廠商";

            App_.Cells[1, 5] = "物品";
            App_.Cells[1, 6] = "數量";
            App_.Cells[1, 7] = "單價";

            App_.Cells[1, 8] = "備註";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.編號;

            App_.Cells[Row_, 2] = _Data.時間;
            App_.Cells[Row_, 3] = _Data.類型;

            App_.Cells[Row_, 4] = _Data.廠商.名稱;

            App_.Cells[Row_, 5] = _Data.物品.名稱;
            App_.Cells[Row_, 6] = _Data.數量;
            App_.Cells[Row_, 7] = _Data.單價;

            App_.Cells[Row_, 8] = _Data.備註;

            return Row_ + 1;
        }
    }
}
