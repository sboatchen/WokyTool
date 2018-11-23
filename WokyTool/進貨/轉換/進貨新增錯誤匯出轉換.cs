using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.進貨
{
    public class 進貨新增錯誤匯出轉換 : 可序列化_Excel
    {
        protected IEnumerable<進貨新增匯入資料> _資料列;

        public String 標頭 { get; set; }

        public 進貨新增錯誤匯出轉換(IEnumerable<進貨新增匯入資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "類型";
            App_.Cells[1, 2] = "廠商";
            App_.Cells[1, 3] = "物品";
            App_.Cells[1, 4] = "數量";
            App_.Cells[1, 5] = "單價";
            App_.Cells[1, 6] = "備註";
            App_.Cells[1, 7] = "錯誤訊息";

            int 目前行數_ = 2;
            foreach (進貨新增匯入資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.類型;
                App_.Cells[目前行數_, 2] = 資料_.廠商識別;
                App_.Cells[目前行數_, 3] = 資料_.物品識別;
                App_.Cells[目前行數_, 4] = 資料_.數量;
                App_.Cells[目前行數_, 5] = 資料_.單價;
                App_.Cells[目前行數_, 6] = 資料_.備註;
                App_.Cells[目前行數_, 7] = 資料_.錯誤訊息;

                目前行數_++;
            }
        }
    }
}
