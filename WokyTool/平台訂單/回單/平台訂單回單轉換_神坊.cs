﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單回單轉換_神坊 : 可寫入介面_EXCEL
    {
        private static int 全速配 = 5;
        private static int 宅配通 = 2;

        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單回單轉換_神坊(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "訂單編號";
            App_.Cells[1, 2] = "商品名稱";
            App_.Cells[1, 3] = "收件人";
            App_.Cells[1, 4] = "出貨物流";
            App_.Cells[1, 5] = "出貨單號";

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列舉)
            {
                App_.Cells[目前行數_, 1] = 資料_.訂單編號;
                App_.Cells[目前行數_, 2] = 資料_.商品名稱 ;
                App_.Cells[目前行數_, 3] = 資料_.姓名;

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        App_.Cells[目前行數_, 4] = 全速配;
                        break;
                    case 列舉.配送公司.宅配通:
                        App_.Cells[目前行數_, 4] = 宅配通;
                        break;
                    default:
                        throw new Exception("平台訂單回單轉換_神坊 不支援配送公司 " + 資料_.配送公司.ToString());
                }

                App_.Cells[目前行數_, 5] = 資料_.配送單號;

                目前行數_++;
            }
        }
    }
}
