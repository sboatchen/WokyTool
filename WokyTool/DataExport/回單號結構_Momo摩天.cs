using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataImport;

namespace WokyTool.DataExport
{
    class 回單號結構_Momo摩天 : 可格式化_Excel
    {
        protected 出貨匯入結構_Momo摩天 _Data;

        public 回單號結構_Momo摩天(出貨匯入結構_Momo摩天 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "項次";
            App_.Cells[1, 2] = "訂單編號";
            App_.Cells[1, 3] = "配送狀態";
            App_.Cells[1, 4] = "配送訊息";
            App_.Cells[1, 5] = "物流公司";
            App_.Cells[1, 6] = "配送單號";
            App_.Cells[1, 7] = "客戶配送需求";
            App_.Cells[1, 8] = "付款日";
            App_.Cells[1, 9] = "最晚出貨日";
            App_.Cells[1, 10] = "收件人姓名";
            App_.Cells[1, 11] = "電話";
            App_.Cells[1, 12] = "行動電話";
            App_.Cells[1, 13] = "地址";
            App_.Cells[1, 14] = "商店品號";
            App_.Cells[1, 15] = "商品編號";
            App_.Cells[1, 16] = "商品名稱";
            App_.Cells[1, 17] = "單品規格";
            App_.Cells[1, 18] = "數量";
            App_.Cells[1, 19] = "成交價";
            App_.Cells[1, 20] = "付款方式";
            App_.Cells[1, 21] = "分期";
            App_.Cells[1, 22] = "商品屬性";
            App_.Cells[1, 23] = "訂購人姓名";
            App_.Cells[1, 24] = "電話";
            App_.Cells[1, 25] = "行動電話";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.項次;
            App_.Cells[Row_, 2] = _Data.訂單編號;
            App_.Cells[Row_, 3] = _Data.配送狀態;
            App_.Cells[Row_, 4] = _Data.配送訊息;
           
             switch (_Data.配送公司)
            { 
                case 列舉.配送公司類型.全速配:
                    App_.Cells[Row_, 5] = 字串.新竹貨運;
                    break;
                case 列舉.配送公司類型.宅配通:
                    App_.Cells[Row_, 5] = 字串.宅配通;
                    break;
                default:
                    MessageBox.Show("回單號結構_Momo摩天 can't find 配送公司 " + _Data.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            App_.Cells[Row_, 6] = _Data.配送單號;
            App_.Cells[Row_, 7] = _Data.備註;
            App_.Cells[Row_, 8] = _Data.付款日;
            App_.Cells[Row_, 9] = _Data.最晚出貨日;
            App_.Cells[Row_, 10] = _Data.姓名;
            App_.Cells[Row_, 11] = _Data.電話;
            App_.Cells[Row_, 12] = _Data.手機;
            App_.Cells[Row_, 13] = _Data.地址;
            App_.Cells[Row_, 14] = _Data.商店品號;
            App_.Cells[Row_, 15] = _Data.廠商商品編號;
            App_.Cells[Row_, 16] = _Data.商品名稱;
            App_.Cells[Row_, 17] = _Data.單品規格;
            App_.Cells[Row_, 18] = _Data.數量;
            App_.Cells[Row_, 19] = _Data.成交價;
            App_.Cells[Row_, 20] = _Data.付款方式;
            App_.Cells[Row_, 21] = _Data.分期;
            App_.Cells[Row_, 22] = _Data.商品屬性;
            App_.Cells[Row_, 23] = _Data.訂購人姓名;
            App_.Cells[Row_, 24] = _Data.電話2;
            App_.Cells[Row_, 25] = _Data.行動電話2;

            return Row_ + 1;
        }
    }
}
