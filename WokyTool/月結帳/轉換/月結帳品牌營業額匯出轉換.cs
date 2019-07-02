using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.物品;

namespace WokyTool.月結帳
{
    public class 月結帳品牌營業額匯出轉換 : 可序列化_Excel
    {
        private Dictionary<物品品牌資料, decimal> Map_;

        public String 標頭 
        {
            get
            {
                return "總覽";
            }
        }

        public String 樣板 { get { return null; } }

        public 月結帳品牌營業額匯出轉換(Dictionary<物品品牌資料, decimal> Map_)
        {
            this.Map_ = Map_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "名稱";
            App_.Cells[1, 2] = "營業額";


            int 目前行數_ = 2;
            foreach (var 資料_ in Map_)
            {
                App_.Cells[目前行數_, 1] = 資料_.Key.名稱;
                App_.Cells[目前行數_, 2] = 資料_.Value;

                目前行數_++;
            }
        }
    }
}
