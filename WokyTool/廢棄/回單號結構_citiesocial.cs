﻿using LINQtoCSV;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.DataImport;
using WokyTool.通用;

namespace WokyTool.DataExport
{
    class 回單號結構_citiesocial : 可格式化_Excel
    {
        protected 出貨匯入結構_citiesocial _Data;

        public 回單號結構_citiesocial(出貨匯入結構_citiesocial Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Application App_)
        {
            App_.Cells[1, 1] = "retailer_id";
            App_.Cells[1, 2] = "purchase_order";
            App_.Cells[1, 3] = "carrier";
            App_.Cells[1, 4] = "tracking_numbers";
            App_.Cells[1, 5] = "vendor_sku";
            App_.Cells[1, 6] = "quantity";
            App_.Cells[1, 7] = "vendor_invoice_number";
            App_.Cells[1, 8] = "vendor_shipping_cost";
            App_.Cells[1, 9] = "vendor_handling_cost";
            App_.Cells[1, 10] = "carrier_invoice_number";
            App_.Cells[1, 11] = "carrier_shipping_cost";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Application App_, int Row_)
        {
            //App_.Cells[Row_, 2] = _Data.訂單編號;
           
            //switch (_Data.配送公司)
            //{
            //    case 列舉.配送公司.全速配:
            //        App_.Cells[Row_, 3] = 字串.新竹物流;
            //        break;
            //    case 列舉.配送公司.宅配通:
            //        App_.Cells[Row_, 3] = 字串.宅配通;
            //        break;
            //    default:
            //        訊息管理器.獨體.通知("回單號結構_citiesocial can't find 配送公司 " + _Data.配送公司.ToString());
            //        break;
            //}

            //App_.Cells[Row_, 4] = _Data.配送單號;
            //App_.Cells[Row_, 6] = _Data.數量;

            return Row_ + 1;
        }
    }
}
