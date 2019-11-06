using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單回單轉換_uDesign : 可寫入介面_EXCEL
    {
        private static string 全速配 = "HCT-新竹貨運";
        private static string 宅配通 = "CAN-台灣宅配通";

        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單回單轉換_uDesign(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "ntitm";
            App_.Cells[1, 2] = "prndldat";
            App_.Cells[1, 3] = "dmtshxuid";
            App_.Cells[1, 4] = "relshno";
            App_.Cells[1, 5] = "orddat";
            App_.Cells[1, 6] = "ordpesnm";
            App_.Cells[1, 7] = "agpesnm";
            App_.Cells[1, 8] = "agpestel1";
            App_.Cells[1, 9] = "agpesacttel";
            App_.Cells[1, 10] = "agpesadrzip";
            App_.Cells[1, 11] = "agpesadr";
            App_.Cells[1, 12] = "shipxrem";
            App_.Cells[1, 13] = "xrem";
            App_.Cells[1, 14] = "chlitpdno";
            App_.Cells[1, 15] = "orgprodid";
            App_.Cells[1, 16] = "ty";
            App_.Cells[1, 17] = "pdbarco";
            App_.Cells[1, 18] = "dsr";
            App_.Cells[1, 19] = "spslgn";
            App_.Cells[1, 20] = "qty";
            App_.Cells[1, 21] = "orgup";
            App_.Cells[1, 22] = "sumorgup";
            App_.Cells[1, 23] = "instockpr";
            App_.Cells[1, 24] = "suminstockpr";
            App_.Cells[1, 25] = "sstockdat";
            App_.Cells[1, 26] = "logco";
            App_.Cells[1, 27] = "shipno";
            App_.Cells[1, 28] = "shipco";

            int 欄位索引_ = 1;
            foreach (string 標頭_ in _資料列舉.First().標頭)
            {
                App_.Cells[2, 欄位索引_++] = 標頭_;
            }

            int 目前行數_ = 3;
            foreach (平台訂單新增資料 資料_ in _資料列舉)
            {
                欄位索引_ = 1;
                foreach (string 欄位內容_ in 資料_.內容)
                {
                    App_.Cells[目前行數_, 欄位索引_++] = 欄位內容_;
                }

                App_.Cells[目前行數_, 27] = 資料_.配送單號;

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        App_.Cells[目前行數_, 26] = 全速配;
                        break;
                    case 列舉.配送公司.宅配通:
                        App_.Cells[目前行數_, 26] = 宅配通;
                        break;
                    default:
                        throw new Exception("平台訂單回單轉換_uDesign 不支援配送公司 " + 資料_.配送公司.ToString());
                }

                目前行數_++;
            }
        }
    }
}
