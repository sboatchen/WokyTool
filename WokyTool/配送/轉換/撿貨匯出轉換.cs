using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 撿貨匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<撿貨資料> _資料列舉;

        public 撿貨匯出轉換(IEnumerable<撿貨資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "物品名稱";
            App_.Cells[1, 2] = "數量";

            int 目前行數_ = 2;
            foreach (撿貨資料 資料_ in _資料列舉)
            {
                App_.Cells[目前行數_, 1] = 資料_.物品名稱;
                App_.Cells[目前行數_, 2] = 資料_.數量;

                目前行數_++;
            }
        }
    }
}
