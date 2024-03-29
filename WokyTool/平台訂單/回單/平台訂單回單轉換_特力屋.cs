﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單回單轉換_特力屋 : 可寫入介面_EXCEL
    {
        private static int 全速配 = 1;
        private static int 宅配通 = 5;

        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單回單轉換_特力屋(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[2, 1] = "*訂單號碼";
            App_.Cells[2, 2] = "*出貨日期";
            App_.Cells[2, 3] = "*配送單號";
            App_.Cells[2, 4] = "*貨運公司";
            App_.Cells[2, 5] = "貨運公司名稱";
            App_.Cells[2, 6] = "商品編號";
            App_.Cells[2, 7] = "商品名稱";
            App_.Cells[2, 8] = "廠商料號";
            App_.Cells[2, 9] = "數量";
            App_.Cells[2, 10] = "成本(未稅)";
            App_.Cells[2, 11] = "訂單日期";
            App_.Cells[2, 12] = "通路別(下單店別)";
            App_.Cells[2, 13] = "出貨備註";

            int 目前行數_ = 3;
            foreach (平台訂單新增資料 資料_ in _資料列舉)
            {
                App_.Cells[目前行數_, 1] = 資料_.訂單編號;
                App_.Cells[目前行數_, 2] = DateTime.Now.ToString("yyyyMMdd");
                App_.Cells[目前行數_, 3] = 資料_.配送單號;

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        App_.Cells[目前行數_, 4] = 全速配;
                        break;
                    case 列舉.配送公司.宅配通:
                        App_.Cells[目前行數_, 4] = 宅配通;
                        break;
                    default:
                        throw new Exception("平台訂單回單轉換_特力屋 不支援配送公司 " + 資料_.配送公司.ToString());
                }

                目前行數_++;
            }
        }
    }
}
