using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataImport;
using WokyTool.平台訂單;
using WokyTool.通用;

namespace WokyTool.客製
{
    class 平台訂單回單轉換_uDesign : 可格式化_Excel
    {
        private static readonly string 全速配編號 = "HCT-新竹貨運";
        private static readonly string 宅配通編號 = "CAN-台灣宅配通";

        protected 平台訂單新增資料 _Data;

        public 平台訂單回單轉換_uDesign(平台訂單新增資料 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
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

            App_.Cells[2, 1] = "訂單通知函發送日";
            App_.Cells[2, 2] = "最遲出貨日";
            App_.Cells[2, 3] = "訂單編號";
            App_.Cells[2, 4] = "購物車編號";
            App_.Cells[2, 5] = "訂購日期";
            App_.Cells[2, 6] = "訂購人姓名";
            App_.Cells[2, 7] = "收貨人姓名";
            App_.Cells[2, 8] = "收貨人市話";
            App_.Cells[2, 9] = "收貨人手機";
            App_.Cells[2, 10] = "收件人郵遞區號";
            App_.Cells[2, 11] = "收貨人地址";
            App_.Cells[2, 12] = "配送備註";
            App_.Cells[2, 13] = "購買備註";
            App_.Cells[2, 14] = "商品編號";
            App_.Cells[2, 15] = "廠商料號";
            App_.Cells[2, 16] = "商品型號";
            App_.Cells[2, 17] = "國際條碼";
            App_.Cells[2, 18] = "商品名稱+規格尺寸";
            App_.Cells[2, 19] = "特標語";
            App_.Cells[2, 20] = "訂購數量";
            App_.Cells[2, 21] = "原售價";
            App_.Cells[2, 22] = "原售價-小計";
            App_.Cells[2, 23] = "進貨價";
            App_.Cells[2, 24] = "進貨價-小計";
            App_.Cells[2, 25] = "指交日期";
            App_.Cells[2, 26] = "合作物流";
            App_.Cells[2, 27] = "貨運單號";
            App_.Cells[2, 28] = "貨運公司";
			
            return 3;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            foreach (var Pair_ in _Data.額外資訊)
            {
                App_.Cells[Row_, Pair_.Key] = Pair_.Value;
            }

            switch (_Data.配送公司)
            {
                case 列舉.配送公司.全速配:
                    App_.Cells[Row_, 26] = 全速配編號;
                    break;
                case 列舉.配送公司.宅配通:
                    App_.Cells[Row_, 26] = 宅配通編號;
                    break;
                default:
                    MessageBox.Show("平台訂單回單轉換_uDesign can't find 配送公司 " + _Data.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            App_.Cells[Row_, 27] = _Data.配送單號;

            return Row_ + 1;
        }
    }
}
