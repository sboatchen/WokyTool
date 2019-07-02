using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.物品;

namespace WokyTool.月結帳
{
    public class 月結帳物品統計總覽匯出轉換 : 可序列化_Excel
    {
        private IEnumerable<IGrouping<物品品牌資料, KeyValuePair<物品資料, int>>> GroupQueue_;

        public String 標頭 
        {
            get
            {
                return "總覽";
            }
        }

        public String 樣板 { get { return null; } }


        public 月結帳物品統計總覽匯出轉換(IEnumerable<IGrouping<物品品牌資料, KeyValuePair<物品資料, int>>> GroupQueue_)
        {
            this.GroupQueue_ = GroupQueue_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "名稱";
            App_.Cells[1, 2] = "數量";


            int 目前行數_ = 2;
            foreach (var 資料_ in GroupQueue_)
            {
                App_.Cells[目前行數_, 1] = 資料_.Key.名稱;
                App_.Cells[目前行數_, 2] = 資料_.Select(Value => Value.Value).Sum();

                目前行數_++;
            }
        }
    }
}
