using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Linq;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 配送撿貨轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private 物品合併資料 _物品合併資料 = new 物品合併資料();

        public 配送撿貨轉換(IEnumerable<配送轉換資料> 資料列舉_)
        {
            foreach (配送轉換資料 資料_ in 資料列舉_)
            {
                資料_.撿貨合併(_物品合併資料);
            }
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "物品名稱";
            App_.Cells[1, 2] = "物品縮稱";
            App_.Cells[1, 3] = "數量";

            int 目前行數_ = 2;
            foreach (var 資料組_ in _物品合併資料.Map.OrderBy(Pair => Pair.Key.名稱))
            {
                App_.Cells[目前行數_, 1] = 資料組_.Key.名稱;
                App_.Cells[目前行數_, 2] = 資料組_.Key.縮寫;
                App_.Cells[目前行數_, 3] = 資料組_.Value;

                目前行數_++;
            }
        }
    }
}
