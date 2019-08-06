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
    public class 月結帳物品統計匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get; set; }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<KeyValuePair<物品.物品資料, int>> _資料列;

        public 月結帳物品統計匯出轉換(IGrouping<物品品牌資料, KeyValuePair<物品.物品資料, int>> Group_)
        {
            分類 = Group_.Key.名稱;
            _資料列 = Group_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "名稱";
            App_.Cells[1, 2] = "數量";


            int 目前行數_ = 2;
            foreach (var 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.Key.名稱;
                App_.Cells[目前行數_, 2] = 資料_.Value;

                目前行數_++;
            }
        }
    }
}
