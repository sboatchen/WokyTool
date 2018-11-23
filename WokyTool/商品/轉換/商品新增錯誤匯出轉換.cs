using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.商品
{
    public class 商品新增錯誤匯出轉換 : 可序列化_Excel
    {
        protected IEnumerable<商品新增匯入資料> _資料列;

        public String 標頭 { get; set; }

        public 商品新增錯誤匯出轉換(IEnumerable<商品新增匯入資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "大類";
            App_.Cells[1, 2] = "小類";

            App_.Cells[1, 3] = "公司";
            App_.Cells[1, 4] = "客戶";

            App_.Cells[1, 5] = "名稱";
            App_.Cells[1, 6] = "品號";

            App_.Cells[1, 7] = "需求1";
            App_.Cells[1, 8] = "需求2";
            App_.Cells[1, 9] = "需求3";
            App_.Cells[1, 10] = "需求4";
            App_.Cells[1, 11] = "需求5";

            App_.Cells[1, 12] = "錯誤訊息";

            int 目前行數_ = 2;
            foreach (商品新增匯入資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.大類識別;
                App_.Cells[目前行數_, 2] = 資料_.小類識別;

                App_.Cells[目前行數_, 3] = 資料_.公司識別;
                App_.Cells[目前行數_, 4] = 資料_.客戶識別;

                App_.Cells[目前行數_, 5] = 資料_.名稱;
                App_.Cells[目前行數_, 6] = 資料_.品號;

                App_.Cells[目前行數_, 7] = 資料_.需求識別1;
                App_.Cells[目前行數_, 8] = 資料_.需求識別2;
                App_.Cells[目前行數_, 9] = 資料_.需求識別3;
                App_.Cells[目前行數_, 10] = 資料_.需求識別4;
                App_.Cells[目前行數_, 11] = 資料_.需求識別5;

                App_.Cells[目前行數_, 12] = 資料_.錯誤訊息;

                目前行數_++;
            }
        }
    }
}
