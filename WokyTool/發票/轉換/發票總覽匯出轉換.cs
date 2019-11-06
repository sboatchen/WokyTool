using Microsoft.Office.Interop.Excel;
using System;
using System.Linq;
using System.Collections.Generic;
using WokyTool.通用;

namespace WokyTool.發票
{
    public class 發票總覽匯出轉換 : 可寫入介面_EXCEL
    {
        private class 總覽資料
        {
            public int 序號 { get; set; }
            public string 發票號碼 { get; set; }
            public decimal 未稅 { get; set; }
            public decimal 稅額 { get; set; }
            public decimal 總計 { get; set; }
        }

        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private List<總覽資料> _資料列;

        public 發票總覽匯出轉換()
        {
            _資料列 = new List<總覽資料>();
        }


        public void 新增(string 發票號碼_, 發票匯出轉換 明細轉換_)
        {
            decimal 總計_ = 明細轉換_.資料列.Sum(Value => Value.總計);
            int 總金額_ = (int)Math.Round(總計_);
            int 未稅金額_ = (int)(Math.Round(Decimal.Divide(總計_, (decimal)1.05)));
            int 營業稅_ = 總金額_ - 未稅金額_;

            總覽資料 新資料_ = new 總覽資料
            {
                序號 = _資料列.Count + 1,
                發票號碼 = 發票號碼_,
                未稅 = 未稅金額_,
                稅額 = 營業稅_,
                總計 = 總金額_
            };

            _資料列.Add(新資料_);
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "序號";
            App_.Cells[1, 2] = "發票號碼)";
            App_.Cells[1, 3] = "未稅";
            App_.Cells[1, 4] = "稅額";
            App_.Cells[1, 5] = "總計";

            int 目前行數_ = 2;
            foreach (總覽資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.序號;
                App_.Cells[目前行數_, 2] = 資料_.發票號碼;
                App_.Cells[目前行數_, 3] = 資料_.未稅;
                App_.Cells[目前行數_, 4] = 資料_.稅額;
                App_.Cells[目前行數_, 5] = 資料_.總計;

                目前行數_++;
            }
        }
    }
}
