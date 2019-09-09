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
        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<配送轉換資料> _資料列舉;

        public 配送明細轉換(IEnumerable<配送轉換資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "平台";
            App_.Cells[1, 2] = "姓名";
            App_.Cells[1, 3] = "明細";

            int 目前行數_ = 2;
            foreach (配送轉換資料 資料_ in _資料列舉)
            {
                App_.Cells[目前行數_, 1] = 取得客戶名稱(資料_);
                App_.Cells[目前行數_, 2] = 資料_.姓名;
                App_.Cells[目前行數_, 3] = 資料_.內容;

                目前行數_++;
            }
        }

        private string 取得客戶名稱(配送轉換資料 資料_)
        {
            平台訂單配送轉換資料 平台訂單配送轉換資料_ = 資料_ as 平台訂單配送轉換資料;
            if (平台訂單配送轉換資料_ != null)
                return 平台訂單配送轉換資料_.來源資料.客戶.名稱;

            平台訂單合併配送轉換資料 平台訂單合併配送轉換資料_ = 資料_ as 平台訂單合併配送轉換資料;
            if (平台訂單合併配送轉換資料_ != null)
                return 平台訂單合併配送轉換資料_.來源資料列.First().客戶.名稱;

            return "非平台";
        }
    }
}
