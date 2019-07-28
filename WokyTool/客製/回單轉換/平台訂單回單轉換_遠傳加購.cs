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
    public class 平台訂單回單轉換_遠傳加購 : 可寫入介面_EXCEL
    {
        private static string 全速配編號 = "02";
        private static string 宅配通編號 = "03";

        public String 分類 { get { return null; } }

        public String 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public String 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列;


        public 平台訂單回單轉換_遠傳加購(IEnumerable<平台訂單新增資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "訂單編號";
            App_.Cells[1, 2] = "物流商代碼";
            App_.Cells[1, 3] = "貨運單號";

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.訂單編號;

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        App_.Cells[目前行數_, 2] = 全速配編號;
                        break;
                    case 列舉.配送公司.宅配通:
                        App_.Cells[目前行數_, 2] = 宅配通編號;
                        break;
                    default:
                        訊息管理器.獨體.錯誤("平台訂單回單轉換_遠傳加購 不支援配送公司 " + 資料_.配送公司.ToString());
                        break;
                }
            
                App_.Cells[目前行數_, 3] = 資料_.配送單號;

                目前行數_++;
            }
        }
    }
}
