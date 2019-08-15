using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.平台訂單;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 配送明細轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get; protected set; }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<可配送資料> _資料列;

        public 配送明細轉換(string 分類_, IEnumerable<可配送資料> 資料列_)
        {
            分類 = 分類_;
            _資料列 = 資料列_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "平台";
            App_.Cells[1, 2] = "姓名";
            App_.Cells[1, 3] = "明細";

            int 目前行數_ = 2;
            foreach (可配送資料 資料_ in _資料列)
            {
                平台訂單新增資料 平台資料_ = 資料_.配送參考 as 平台訂單新增資料;
                if (平台資料_ != null)
                    App_.Cells[目前行數_, 1] = 平台資料_.客戶.名稱;
                else
                    App_.Cells[目前行數_, 1] = "非平台";

                App_.Cells[目前行數_, 2] = 資料_.姓名;

                App_.Cells[目前行數_, 3] = 資料_.合併.ToString();

                目前行數_++;
            }
        }
    }
}
