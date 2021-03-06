﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.單品;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳單品銷售排行匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return "單品銷售數量排行"; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private 單品合併資料 單品合併資料_;

        public 月結帳單品銷售排行匯出轉換(單品合併資料 單品合併資料_)
        {
            this.單品合併資料_ = 單品合併資料_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "名稱";
            App_.Cells[1, 2] = "數量";


            int 目前行數_ = 2;
            foreach (var 資料_ in 單品合併資料_.組成書.OrderByDescending(Pair => Pair.Value).Take(10))
            {
                App_.Cells[目前行數_, 1] = 資料_.Key.名稱;
                App_.Cells[目前行數_, 2] = 資料_.Value;

                目前行數_++;
            }
        }
    }
}
