using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳統計轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        public Dictionary<月結帳單品資料, int> 資料書 { get; set; }

        public 月結帳統計轉換()
        {
            資料書 = new Dictionary<月結帳單品資料, int>();
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "名稱";
            App_.Cells[1, 2] = "數量";

            int 目前行數_ = 2;
            foreach (var Pair_ in 資料書)
            {
                App_.Cells[目前行數_, 1] = Pair_.Key.名稱;
                App_.Cells[目前行數_, 2] = Pair_.Value;

                目前行數_++;
            }
        }
    }
}
