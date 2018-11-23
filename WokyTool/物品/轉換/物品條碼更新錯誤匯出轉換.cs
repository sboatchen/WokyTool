using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.物品
{
    public class 物品條碼更新錯誤匯出轉換 : 可序列化_Excel
    {
        protected IEnumerable<物品條碼更新匯入資料> _資料列;

        public String 標頭 { get; set; }

        public 物品條碼更新錯誤匯出轉換(IEnumerable<物品條碼更新匯入資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "縮寫";
            App_.Cells[1, 2] = "條碼";
            App_.Cells[1, 3] = "錯誤訊息";

            int 目前行數_ = 2;
            foreach (物品條碼更新匯入資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.物品縮寫識別;
                App_.Cells[目前行數_, 2] = 資料_.條碼;
                App_.Cells[目前行數_, 3] = 資料_.錯誤訊息;

                目前行數_++;
            }
        }
    }
}
