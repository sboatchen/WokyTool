using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;

namespace WokyTool.配送
{
    public class 撿貨匯出轉換 : 可序列化_Excel
    {
        protected IEnumerable<撿貨資料> _資料列;

        public String 標頭 { get; set; }

        public 撿貨匯出轉換(IEnumerable<撿貨資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "物品名稱";
            App_.Cells[1, 2] = "數量";

            int 目前行數_ = 2;
            foreach (撿貨資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.物品名稱;
                App_.Cells[目前行數_, 2] = 資料_.數量;

                目前行數_++;
            }
        }
    }
}
