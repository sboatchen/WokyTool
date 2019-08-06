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
    public class 月結帳商品品牌營業額匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return "總覽"; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private Dictionary<物品品牌資料, decimal> _資料書;


        public 月結帳商品品牌營業額匯出轉換(Dictionary<物品品牌資料, decimal> 資料書_)
        {
            this._資料書 = 資料書_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "名稱";
            App_.Cells[1, 2] = "營業額";


            int 目前行數_ = 2;
            foreach (var 資料_ in _資料書)
            {
                App_.Cells[目前行數_, 1] = 資料_.Key.名稱;
                App_.Cells[目前行數_, 2] = 資料_.Value;

                目前行數_++;
            }
        }
    }
}
