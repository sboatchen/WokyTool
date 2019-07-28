using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.進貨
{
    public class 進貨總覽匯出轉換 : 可寫入介面_EXCEL
    {
        public String 分類 { get { return null; } }

        public String 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public String 密碼 { get { return null; } }

        private IEnumerable<進貨資料> _資料列;

        public 進貨總覽匯出轉換(IEnumerable<進貨資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "編號";
            App_.Cells[1, 2] = "時間";
            App_.Cells[1, 3] = "類型";
            App_.Cells[1, 4] = "廠商";
            App_.Cells[1, 5] = "物品";
            App_.Cells[1, 6] = "數量";
            App_.Cells[1, 7] = "單價";
            App_.Cells[1, 8] = "備註";

            int 目前行數_ = 2;
            foreach (進貨資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.編號;
                App_.Cells[目前行數_, 2] = 資料_.時間;
                App_.Cells[目前行數_, 3] = 資料_.類型;
                App_.Cells[目前行數_, 4] = 資料_.廠商.名稱;
                App_.Cells[目前行數_, 5] = 資料_.物品.名稱;
                App_.Cells[目前行數_, 6] = 資料_.數量;
                App_.Cells[目前行數_, 7] = 資料_.單價;
                App_.Cells[目前行數_, 8] = 資料_.備註;

                目前行數_++;
            }
        }
    }
}
