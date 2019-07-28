﻿using LINQtoCSV;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.DataImport;
using WokyTool.平台訂單;
using WokyTool.通用;

namespace WokyTool.客製
{
    public class 平台訂單回單轉換_一休 : 可寫入介面_EXCEL
    {
        public String 分類 { get { return null; } }

        public String 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public String 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列;

        public 平台訂單回單轉換_一休(IEnumerable<平台訂單新增資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "排序";
            App_.Cells[1, 2] = "訂單號碼";
            App_.Cells[1, 3] = "物流單號";
            App_.Cells[1, 4] = "發票號碼";
            App_.Cells[1, 5] = "物流公司";

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 目前行數_ - 1;
                App_.Cells[目前行數_, 2] = 資料_.訂單編號;
                App_.Cells[目前行數_, 3] = 資料_.配送單號;
                App_.Cells[目前行數_, 4] = "";

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        App_.Cells[目前行數_, 5] = 字串.新竹貨運;
                        break;
                    case 列舉.配送公司.宅配通:
                        App_.Cells[目前行數_, 5] = 字串.宅配通;
                        break;
                    default:
                        if (資料_.處理狀態 != 列舉.訂單處理狀態.忽略)
                            訊息管理器.獨體.Error("平台訂單回單轉換_一休_不支援配送公司 " + 資料_.配送公司.ToString());
                        break;
                }

                目前行數_++;
            }
        }
    }
}
