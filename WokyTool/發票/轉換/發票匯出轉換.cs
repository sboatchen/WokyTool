using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using WokyTool.通用;

namespace WokyTool.發票
{
    public class 發票匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        public List<發票匯入資料> 資料列;

        public int 資料數量
        {
            get
            {
                return 資料列.Count;
            }
        }

        public 發票匯出轉換()
        {
            資料列 = new List<發票匯入資料>();
        }

        public void 新增(發票匯入資料 資料_)
        {
            資料列.Add(資料_);
        }

        public void 清除()
        {
            資料列.Clear();
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "發票號碼";
            App_.Cells[1, 2] = "註記欄(不轉入進銷項媒體申報檔)";
            App_.Cells[1, 3] = "格式代號";
            App_.Cells[1, 4] = "發票狀態";
            App_.Cells[1, 5] = "發票日期";
            App_.Cells[1, 6] = "買方統一編號";
            App_.Cells[1, 7] = "買方名稱";
            App_.Cells[1, 8] = "賣方統一編號";
            App_.Cells[1, 9] = "賣方名稱";
            App_.Cells[1, 10] = "寄送日期";
            App_.Cells[1, 11] = "銷售額合計";
            App_.Cells[1, 12] = "營業稅";
            App_.Cells[1, 13] = "總計";
            App_.Cells[1, 14] = "課稅別";

            int 目前行數_ = 2;
            decimal 總計_ = 0;

            decimal 含營業稅總未稅金額_ = 0;
            decimal 含營業稅總營業稅_ = 0;
            decimal 含營業稅總總金額_ = 0;

            foreach (發票匯入資料 資料_ in 資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.發票號碼;
                App_.Cells[目前行數_, 2] = 資料_.註記;
                App_.Cells[目前行數_, 3] = 資料_.格式代號;
                App_.Cells[目前行數_, 4] = 資料_.發票狀態;
                App_.Cells[目前行數_, 5] = 資料_.發票日期;
                App_.Cells[目前行數_, 6] = 資料_.買方統一編號;
                App_.Cells[目前行數_, 7] = 資料_.買方名稱;
                App_.Cells[目前行數_, 8] = 資料_.賣方統一編號;
                App_.Cells[目前行數_, 9] = 資料_.賣方名稱;
                App_.Cells[目前行數_, 10] = 資料_.寄送日期;
                App_.Cells[目前行數_, 11] = 資料_.銷售額合計;
                App_.Cells[目前行數_, 12] = 資料_.營業稅;
                App_.Cells[目前行數_, 13] = 資料_.總計;
                App_.Cells[目前行數_, 14] = 資料_.課稅別;

                目前行數_++;

                if (資料_.營業稅 > 0)
                {
                    含營業稅總未稅金額_ += 資料_.銷售額合計;
                    含營業稅總營業稅_ += 資料_.營業稅;
                    含營業稅總總金額_ += 資料_.總計;
                }
                else
                    總計_ += 資料_.總計;
            }

            App_.Cells[目前行數_, 11] = 含營業稅總未稅金額_;
            App_.Cells[目前行數_, 12] = 含營業稅總營業稅_;
            App_.Cells[目前行數_, 13] = 含營業稅總總金額_;

            int 總金額_ = (int)Math.Round(總計_);
            int 未稅金額_ = (int)(Math.Round(Decimal.Divide(總計_, (decimal)1.05)));
            int 營業稅_ = 總金額_ - 未稅金額_;

            目前行數_++;
            App_.Cells[目前行數_, 11] = 未稅金額_;
            App_.Cells[目前行數_, 12] = 營業稅_;
            App_.Cells[目前行數_, 13] = 總金額_;

            目前行數_++;
            App_.Cells[目前行數_, 11] = 未稅金額_ + 含營業稅總未稅金額_;
            App_.Cells[目前行數_, 12] = 營業稅_ + 含營業稅總營業稅_;
            App_.Cells[目前行數_, 13] = 總金額_ + 含營業稅總總金額_;

        }
    }
}
