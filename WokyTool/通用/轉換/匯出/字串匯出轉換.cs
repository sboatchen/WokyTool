﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;

namespace WokyTool.通用
{
    public class 字串匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get; set; }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<String> _資料列舉;

        public 字串匯出轉換(string 分類_, IEnumerable<String> 資料列舉_)
        {
            分類 = 分類_;
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(Application App_)
        {
            int 目前行數_ = 1;
            foreach (String 資料_ in _資料列舉)
            {
                App_.Cells[目前行數_, 1] = 資料_;

                目前行數_++;
            }
        }
    }
}
