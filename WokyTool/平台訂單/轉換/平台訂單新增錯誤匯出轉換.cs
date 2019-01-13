using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.平台訂單
{
    public class 平台訂單新增錯誤匯出轉換 : 可序列化_Excel
    {
        protected IEnumerable<平台訂單匯入資料> _資料列;

        public String 標頭 { get; set; }

        public String 樣板 { get { return null; } }

        public 平台訂單新增錯誤匯出轉換(IEnumerable<平台訂單匯入資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "訂單編號";
            App_.Cells[1, 2] = "姓名";
            App_.Cells[1, 3] = "商品";
            App_.Cells[1, 4] = "錯誤訊息";

            int 目前行數_ = 2;
            foreach (平台訂單匯入資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.訂單編號;
                App_.Cells[目前行數_, 2] = 資料_.姓名;
                App_.Cells[目前行數_, 3] = 資料_.商品識別;
                App_.Cells[目前行數_, 4] = 資料_.錯誤訊息;

                目前行數_++;
            }
        }
    }
}
