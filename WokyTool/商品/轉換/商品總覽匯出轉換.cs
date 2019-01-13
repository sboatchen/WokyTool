using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.物品;

namespace WokyTool.商品
{
    public class 商品總覽匯出轉換 : 可序列化_Excel
    {
        protected IEnumerable<商品資料> _資料列;

        public String 標頭{ get; set; }

        public String 樣板 { get { return null; } }

        public 商品總覽匯出轉換(String 標頭_, IEnumerable<商品資料> 資料列_)
        {
            標頭 = 標頭_;
            _資料列 = 資料列_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "編號";

            App_.Cells[1, 2] = "大類";
            App_.Cells[1, 3] = "小類";

            App_.Cells[1, 4] = "公司";
            App_.Cells[1, 5] = "客戶";

            App_.Cells[1, 6] = "名稱";
            App_.Cells[1, 7] = "品號";

            App_.Cells[1, 8] = "售價";
            App_.Cells[1, 9] = "成本";
            App_.Cells[1, 10] = "利潤";
            App_.Cells[1, 11] = "體積";
            App_.Cells[1, 12] = "寄庫數量";

            App_.Cells[1, 13] = "組成";


            int 目前行數_ = 2;
            物品組成資料 物品組成資料_ = new 物品組成資料();
            foreach (商品資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.編號;

                App_.Cells[目前行數_, 2] = 資料_.大類.名稱;
                App_.Cells[目前行數_, 3] = 資料_.小類.名稱;

                App_.Cells[目前行數_, 4] = 資料_.公司.名稱;
                App_.Cells[目前行數_, 5] = 資料_.客戶.名稱;

                App_.Cells[目前行數_, 6] = 資料_.名稱;
                App_.Cells[目前行數_, 7] = 資料_.品號;

                App_.Cells[目前行數_, 8] = 資料_.售價;
                App_.Cells[目前行數_, 9] = 資料_.成本;
                App_.Cells[目前行數_, 10] = 資料_.利潤;
                App_.Cells[目前行數_, 11] = 資料_.體積;
                App_.Cells[目前行數_, 12] = 資料_.寄庫數量;

                物品組成資料_.清除();
                物品組成資料_.新增(資料_);
                App_.Cells[目前行數_, 13] = 物品組成資料_.取得組合字串();

                目前行數_++;
            }
        }
    }
}
