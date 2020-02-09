﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    class 平台訂單回單轉換_東森 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單回單轉換_東森(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(Application App_)
        {
            平台訂單新增資料 平台訂單新增資料_ = _資料列舉.DefaultIfEmpty(null).First();
            if (平台訂單新增資料_ == null)
                return;

            int 欄位索引_ = 1;
            foreach (string 標頭_ in _資料列舉.First().標頭)
            {
                App_.Cells[1, 欄位索引_++] = 標頭_;
            }

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列舉)
            {
                欄位索引_ = 1;
                foreach (string 欄位內容_ in 資料_.內容)
                {
                    App_.Cells[目前行數_, 欄位索引_++] = 欄位內容_;
                }

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        App_.Cells[目前行數_, 19] = 字串.新竹物流;
                        break;
                    case 列舉.配送公司.宅配通:
                        App_.Cells[目前行數_, 19] = 字串.宅配通;
                        break;
                    default:
                        throw new Exception("平台訂單回單轉換_東森 不支援配送公司 " + 資料_.配送公司.ToString());
                }

                App_.Cells[目前行數_, 20] = 資料_.配送單號;

                目前行數_++;
            }
        }
    }
}
