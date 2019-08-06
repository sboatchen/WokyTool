using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    public class 一般訂單匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get; set; }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<一般訂單資料> _資料列;

        public 一般訂單匯出轉換(IGrouping<客戶.客戶資料,一般訂單資料> Group_)
        {
            分類 = Group_.Key.名稱;
            _資料列 = Group_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "編號";

            App_.Cells[1, 2] = "處理時間";
            App_.Cells[1, 3] = "處理狀態";

            App_.Cells[1, 4] = "公司";
            App_.Cells[1, 5] = "客戶";
            App_.Cells[1, 6] = "子客戶";

            App_.Cells[1, 7] = "商品";
            App_.Cells[1, 8] = "數量";
            App_.Cells[1, 9] = "單價";

            App_.Cells[1, 10] = "姓名";
            App_.Cells[1, 11] = "地址";
            App_.Cells[1, 12] = "電話";
            App_.Cells[1, 13] = "手機";

            App_.Cells[1, 14] = "備註";

            App_.Cells[1, 15] = "配送公司";
            App_.Cells[1, 16] = "配送單號";

            App_.Cells[1, 17] = "指配日期";
            App_.Cells[1, 18] = "指配時段";

            App_.Cells[1, 19] = "代收方式";
            App_.Cells[1, 20] = "代收金額";

            App_.Cells[1, 21] = "發票號碼";


            int 目前行數_ = 2;
            foreach (一般訂單資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.編號;

                App_.Cells[目前行數_, 2] = 資料_.處理時間;
                App_.Cells[目前行數_, 3] = 資料_.處理狀態;

                App_.Cells[目前行數_, 4] = 資料_.公司.名稱;
                App_.Cells[目前行數_, 5] = 資料_.客戶.名稱;
                App_.Cells[目前行數_, 6] = 資料_.子客戶.名稱;

                App_.Cells[目前行數_, 7] = 資料_.商品.名稱;
                App_.Cells[目前行數_, 8] = 資料_.數量;
                App_.Cells[目前行數_, 9] = 資料_.單價;

                App_.Cells[目前行數_, 10] = 資料_.姓名;
                App_.Cells[目前行數_, 11] = 資料_.地址;
                App_.Cells[目前行數_, 12] = 資料_.電話;
                App_.Cells[目前行數_, 13] = 資料_.手機;

                App_.Cells[目前行數_, 14] = 資料_.備註;

                App_.Cells[目前行數_, 15] = 資料_.配送公司;
                App_.Cells[目前行數_, 16] = 資料_.配送單號;

                App_.Cells[目前行數_, 17] = 資料_.指配日期;
                App_.Cells[目前行數_, 18] = 資料_.指配時段;

                App_.Cells[目前行數_, 19] = 資料_.代收方式;
                App_.Cells[目前行數_, 20] = 資料_.代收金額;

                App_.Cells[目前行數_, 21] = 資料_.發票號碼;

                目前行數_++;
            }
        }
    }
}
