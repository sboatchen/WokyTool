using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataImport;

namespace WokyTool.DataExport
{
    class 回單號結構_通用 : 可格式化_Excel
    {
        protected 物品訂單資料 _Data;

        public 回單號結構_通用(物品訂單資料 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "訂單編號";
            App_.Cells[1, 2] = "姓名";
            App_.Cells[1, 3] = "電話";
            App_.Cells[1, 4] = "手機";
            App_.Cells[1, 5] = "地址";

            App_.Cells[1, 6] = "廠商";
            App_.Cells[1, 7] = "物品";
            App_.Cells[1, 8] = "數量";

            App_.Cells[1, 9] = "重要備註";
            App_.Cells[1, 10] = "備註";

            App_.Cells[1, 11] = "指配日期";
            App_.Cells[1, 12] = "指配時段";
            App_.Cells[1, 13] = "代收方式";
            App_.Cells[1, 14] = "代收金額";
            App_.Cells[1, 15] = "配送公司";
            App_.Cells[1, 16] = "配送單號";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.訂單編號;
            App_.Cells[Row_, 2] = _Data.姓名;
            App_.Cells[Row_, 3] = _Data.電話;
            App_.Cells[Row_, 4] = _Data.手機;
            App_.Cells[Row_, 5] = _Data.地址;

            App_.Cells[Row_, 6] = _Data.廠商.名稱;
            App_.Cells[Row_, 7] = _Data.物品.名稱;
            App_.Cells[Row_, 8] = _Data.數量;

            App_.Cells[Row_, 9] = _Data.重要備註;
            App_.Cells[Row_, 10] = _Data.備註;

            App_.Cells[Row_, 11] = _Data.指配日期;
            App_.Cells[Row_, 12] = _Data.指配時段;
            App_.Cells[Row_, 13] = _Data.代收方式;
            App_.Cells[Row_, 14] = _Data.代收金額;
            App_.Cells[Row_, 15] = _Data.配送公司;
            App_.Cells[Row_, 16] = _Data.配送單號;

            return Row_ + 1;
        }
    }
}
