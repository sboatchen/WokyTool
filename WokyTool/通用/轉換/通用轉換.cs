﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    public class 通用轉換 : 可寫入介面_EXCEL
    {
        public String 分類 { get; set; }

        public String 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public String 密碼 { get { return null; } }

        private IEnumerable<String> _資料列;

        public 通用轉換(String 分類_, IEnumerable<String> 資料列_)
        {
            分類 = 分類_;
            _資料列 = 資料列_;
        }

        public void 寫入(Application App_)
        {
            int 目前行數_ = 1;
            foreach (String 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_;

                目前行數_++;
            }
        }
    }
}
