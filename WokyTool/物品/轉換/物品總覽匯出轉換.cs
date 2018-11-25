using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.物品
{
    public class 物品總覽匯出轉換 : 可序列化_Excel
    {
        protected IEnumerable<物品資料> _資料列;

        public String 標頭 { get; set; }

        public 物品總覽匯出轉換(String 標頭_, IEnumerable<物品資料> 資料列_)
        {
            標頭 = 標頭_;
            _資料列 = 資料列_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "名稱";
            App_.Cells[1, 2] = "大類";
            App_.Cells[1, 3] = "小類";
            App_.Cells[1, 4] = "縮寫";
            App_.Cells[1, 5] = "最後進貨成本";

            int 目前行數_ = 2;
            foreach (物品資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.名稱;
                App_.Cells[目前行數_, 2] = 資料_.大類.名稱;
                App_.Cells[目前行數_, 3] = 資料_.小類.名稱;
                App_.Cells[目前行數_, 4] = 資料_.縮寫;
                App_.Cells[目前行數_, 5] = 資料_.最後進貨成本;

                目前行數_++;
            }
        }
    }
}
