﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.月結帳
{
    public class 月結帳支出新增錯誤匯出轉換 : 可序列化_Excel
    {
        protected IEnumerable<月結帳支出新增匯入資料> _資料列;

        public String 標頭 { get; set; }

        public String 樣板 { get { return null; } }

        public 月結帳支出新增錯誤匯出轉換(IEnumerable<月結帳支出新增匯入資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "傳票號碼";
            App_.Cells[1, 2] = "廠商";
            App_.Cells[1, 3] = "費用";

            int 目前行數_ = 2;
            foreach (月結帳支出新增匯入資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.傳票號碼;
                App_.Cells[目前行數_, 2] = 資料_.廠商識別;
                App_.Cells[目前行數_, 3] = 資料_.費用;

                目前行數_++;
            }
        }
    }
}
