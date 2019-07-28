using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.商品
{
    public class 商品新增錯誤匯出轉換 : 可寫入介面_EXCEL
    {
        public String 分類 { get { return null; } }

        public String 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public String 密碼 { get { return null; } }

        private IEnumerable<商品新增匯入資料> _資料列;

        public 商品新增錯誤匯出轉換(IEnumerable<商品新增匯入資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "大類";
            App_.Cells[1, 2] = "小類";

            App_.Cells[1, 3] = "公司";
            App_.Cells[1, 4] = "客戶";

            App_.Cells[1, 5] = "名稱";
            App_.Cells[1, 6] = "品號";

            App_.Cells[1, 7] = "組成識別";

            App_.Cells[1, 8] = "錯誤訊息";

            int 目前行數_ = 2;
            foreach (商品新增匯入資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.大類識別;
                App_.Cells[目前行數_, 2] = 資料_.小類識別;

                App_.Cells[目前行數_, 3] = 資料_.公司識別;
                App_.Cells[目前行數_, 4] = 資料_.客戶識別;

                App_.Cells[目前行數_, 5] = 資料_.名稱;
                App_.Cells[目前行數_, 6] = 資料_.品號;

                App_.Cells[目前行數_, 7] = 資料_.組成識別;

                App_.Cells[目前行數_, 8] = 資料_.錯誤訊息;

                目前行數_++;
            }
        }
    }
}
