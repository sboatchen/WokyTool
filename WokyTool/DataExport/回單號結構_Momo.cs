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
    class 回單號結構_Momo : 可格式化_Excel
    {
        protected 出貨匯入結構_Momo _Data;

        public 回單號結構_Momo(出貨匯入結構_Momo Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "項次+燈號";
            App_.Cells[1, 2] = "訂單編號";
            App_.Cells[1, 3] = "配送狀態\n(說明參考Desc)";
            App_.Cells[1, 4] = "配送訊息";

            App_.Cells[1, 5] = "約定配送日";
            App_.get_Range("E1").EntireColumn.NumberFormat = "YYYY/MM/DD";

            App_.Cells[1, 6] = "物流公司\n(說明參考Desc)";
            App_.Cells[1, 7] = "配送單號";
            App_.Cells[1, 8] = "訂單類別";
            App_.Cells[1, 9] = "客戶配送需求";
            App_.Cells[1, 10] = "轉單日";
            App_.Cells[1, 11] = "預計出貨日";
            App_.Cells[1, 12] = "收件人姓名";
            App_.Cells[1, 13] = "收件人電話";
            App_.Cells[1, 14] = "收件人行動電話";
            App_.Cells[1, 15] = "收件人地址";
            App_.Cells[1, 16] = "商品原廠編號";
            App_.Cells[1, 17] = "品號";
            App_.Cells[1, 18] = "品名";
            App_.Cells[1, 19] = "單名編號";
            App_.Cells[1, 20] = "單品詳細";
            App_.Cells[1, 21] = "數量";
            App_.Cells[1, 22] = "進價(含稅)";
            App_.Cells[1, 23] = "贈品";
            App_.Cells[1, 24] = "訂購人姓名";
            App_.Cells[1, 25] = "發票號碼";
            App_.Cells[1, 26] = "發票日期";
            App_.Cells[1, 27] = "個人識別碼";
            App_.Cells[1, 28] = "群組變價商品";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.無用_項次;
            App_.Cells[Row_, 2] = _Data.訂單編號;
            App_.Cells[Row_, 3] = _Data.配送狀態;
            App_.Cells[Row_, 4] = _Data.配送訊息;
            App_.Cells[Row_, 5] = _Data.約定配送日;

             switch (_Data.配送公司)
            { 
                case 列舉.配送公司類型.全速配:
                    App_.Cells[Row_, 6] = 字串.新竹貨運;
                    break;
                case 列舉.配送公司類型.宅配通:
                    App_.Cells[Row_, 6] = 字串.宅配通;
                    break;
                /*default:  // 有些單子不處理
                    MessageBox.Show("回單號結構_Momo can't find 配送公司 " + _Data.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;*/
            }

            App_.Cells[Row_, 7] = _Data.配送單號;
            App_.Cells[Row_, 8] = _Data.訂單類別;
            App_.Cells[Row_, 9] = _Data.備註;
            App_.Cells[Row_, 10] = _Data.無用_轉單日;
            App_.Cells[Row_, 11] = _Data.預計出貨日;
            App_.Cells[Row_, 12] = _Data.姓名;
            App_.Cells[Row_, 13] = _Data.電話;
            App_.Cells[Row_, 14] = _Data.手機;
            App_.Cells[Row_, 15] = _Data.地址;
            App_.Cells[Row_, 16] = _Data.無用_商品原廠編號;
            App_.Cells[Row_, 17] = _Data.品號;
            App_.Cells[Row_, 18] = _Data.無用_品名;
            App_.Cells[Row_, 19] = _Data.單名編號;
            App_.Cells[Row_, 20] = _Data.無用_單品詳細;
            App_.Cells[Row_, 21] = _Data.數量;
            App_.Cells[Row_, 22] = _Data.無用_進價;
            App_.Cells[Row_, 23] = _Data.無用_贈品;
            App_.Cells[Row_, 24] = _Data.無用_訂購人姓名;
            App_.Cells[Row_, 25] = _Data.無用_發票號碼;
            App_.Cells[Row_, 26] = _Data.無用_發票日期;
            App_.Cells[Row_, 27] = _Data.無用_個人識別碼;
            App_.Cells[Row_, 28] = _Data.無用_群組變價商品;

            return Row_ + 1;
        }
    }
}
