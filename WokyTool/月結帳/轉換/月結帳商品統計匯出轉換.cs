using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳商品統計匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return "總覽"; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private Dictionary<商品.商品資料, 月結帳商品統計暫存資料> Map_;

        public 月結帳商品統計匯出轉換(Dictionary<商品.商品資料, 月結帳商品統計暫存資料> Map_)
        {
            this.Map_ = Map_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "名稱";
            App_.Cells[1, 2] = "品牌";
            App_.Cells[1, 3] = "數量";
            App_.Cells[1, 4] = "營業額";
            App_.Cells[1, 5] = "成本";
            App_.Cells[1, 6] = "總成本";

            int 目前行數_ = 2;
            foreach (var 資料_ in Map_)
            {
                App_.Cells[目前行數_, 1] = 資料_.Key.名稱;
                App_.Cells[目前行數_, 2] = 資料_.Key.品牌.名稱;
                App_.Cells[目前行數_, 3] = 資料_.Value.數量;
                App_.Cells[目前行數_, 4] = 資料_.Value.營業額;
                App_.Cells[目前行數_, 5] = 資料_.Key.成本;
                App_.Cells[目前行數_, 6] = 資料_.Key.成本 * 資料_.Value.數量;

                目前行數_++;
            }
        }
    }
}
