using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.商品
{
    public class 商品總覽匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get; set; }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<商品資料> _資料列舉;

        public 商品總覽匯出轉換(string 分類_, IEnumerable<商品資料> 資料列舉_)
        {
            分類 = 分類_;
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(Application App_)
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
            物品合併資料 物品合併資料_ = new 物品合併資料();
            foreach (商品資料 資料_ in _資料列舉)
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

                物品合併資料_.清除();
                物品合併資料_.新增(資料_);
                App_.Cells[目前行數_, 13] = 物品合併資料_.ToString();

                目前行數_++;
            }
        }
    }
}
