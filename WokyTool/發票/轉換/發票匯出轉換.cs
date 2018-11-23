using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.發票
{
    public class 發票匯出轉換 : 可序列化_Excel
    {
        protected List<發票匯入資料> _資料列;

        public int 資料數量
        {
            get
            {
                return _資料列.Count;
            }
        }

        public String 標頭 
        {
            get { return "總覽"; }
        }

        public 發票匯出轉換()
        {
            _資料列 = new List<發票匯入資料>();
        }

        public void 新增(發票匯入資料 資料_)
        {
            _資料列.Add(資料_);
        }

        public void 清除()
        {
            _資料列.Clear();
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
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
            App_.Cells[1, 15] = "匯率";
            App_.Cells[1, 16] = "載具號碼1";
            App_.Cells[1, 17] = "載具號碼2";
            App_.Cells[1, 18] = "總備註";

            int 目前行數_ = 2;
            decimal 總計_ = 0;
            foreach (發票匯入資料 資料_ in _資料列)
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
                App_.Cells[目前行數_, 15] = 資料_.匯率;
                App_.Cells[目前行數_, 16] = 資料_.載具號碼1;
                App_.Cells[目前行數_, 17] = 資料_.載具號碼2;
                App_.Cells[目前行數_, 18] = 資料_.總備註;

                目前行數_++;
                總計_ += 資料_.總計;
            }

            int 總金額_ = (int)總計_;
            int 未稅金額_ = (int)(Decimal.Divide(總計_, (decimal)1.05));
            int 營業稅_ = 總金額_ - 未稅金額_;

            App_.Cells[目前行數_, 11] = 未稅金額_;
            App_.Cells[目前行數_, 12] = 營業稅_;
            App_.Cells[目前行數_, 13] = 總金額_;
        }
    }
}
