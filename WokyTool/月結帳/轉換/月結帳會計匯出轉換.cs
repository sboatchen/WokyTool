﻿using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;
using WokyTool.月結帳;
using Microsoft.Office.Interop.Excel;

namespace WokyTool.月結帳
{
    class 月結帳會計匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return "會計"; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<月結帳會計資料> _資料列;

        public 月結帳會計匯出轉換(IEnumerable<月結帳會計資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "客戶";
            App_.Cells[1, 2] = "營業額";
            App_.Cells[1, 3] = "佣金";
            App_.Cells[1, 4] = "作帳應收";
            App_.Cells[1, 5] = "實收";
            App_.Cells[1, 6] = "應收款日期";
            App_.Cells[1, 7] = "本期欠收";
            App_.Cells[1, 8] = "前期欠收";
            App_.Cells[1, 9] = "前期實收";
            App_.Cells[1, 10] = "利潤";
            App_.Cells[1, 11] = "進貨成本";
            App_.Cells[1, 12] = "毛利率";
            App_.Cells[1, 13] = "業務";

            int 目前行數_ = 2;
            foreach (月結帳會計資料 月結帳會計資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 月結帳會計資料_.設定.名稱;
                App_.Cells[目前行數_, 2] = Convert.ToInt32(月結帳會計資料_.營業額);
                App_.Cells[目前行數_, 3] = Convert.ToInt32(月結帳會計資料_.佣金);
                App_.Cells[目前行數_, 4] = Convert.ToInt32(月結帳會計資料_.作帳應收);
                App_.Cells[目前行數_, 5] = Convert.ToInt32(月結帳會計資料_.實收);
                App_.Cells[目前行數_, 6] = 月結帳會計資料_.應收款日期;
                App_.Cells[目前行數_, 7] = Convert.ToInt32(月結帳會計資料_.本期欠收);
                App_.Cells[目前行數_, 8] = Convert.ToInt32(月結帳會計資料_.前期欠收);
                App_.Cells[目前行數_, 9] = Convert.ToInt32(月結帳會計資料_.前期實收);
                App_.Cells[目前行數_, 10] = Convert.ToInt32(月結帳會計資料_.利潤);
                App_.Cells[目前行數_, 11] = Convert.ToInt32(月結帳會計資料_.進貨成本);
                App_.Cells[目前行數_, 12] = 月結帳會計資料_.毛利率;
                App_.Cells[目前行數_, 13] = 月結帳會計資料_.設定.業務.名稱;

                目前行數_++;
            }
        }
    }
}
