using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.物品;

namespace WokyTool.通用
{
    public class 通用轉換 : 可序列化_Excel
    {
        protected IEnumerable<String> _資料列;

        public String 標頭{ get; set; }

        public String 樣板 { get { return null; } }

        public 通用轉換(String 標頭_, IEnumerable<String> 資料列_)
        {
            標頭 = 標頭_;
            _資料列 = 資料列_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            int 目前行數_ = 1;
            物品合併資料 物品合併資料_ = new 物品合併資料();
            foreach (String 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_;
                目前行數_++;
            }
        }
    }
}
