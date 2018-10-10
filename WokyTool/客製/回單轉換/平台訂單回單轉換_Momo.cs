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
    public class 平台訂單回單轉換_Momo : 可格式化_Excel
    {
        private static string 已配送 = "已配送";
        private static string 已確認指定配送日 = "已確認指定配送日";

        protected 平台訂單新增資料 _Data;

        public 平台訂單回單轉換_Momo(平台訂單新增資料 Data_)
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
            foreach (var Pair_ in _Data.額外資訊)
            {
                if (Pair_.Key > 0)
                    App_.Cells[Row_, Pair_.Key] = Pair_.Value;
            }

            switch (_Data.處理狀態)
            {
                case 列舉.訂單處理狀態.配送:
                    App_.Cells[Row_, 3] = 已配送;
                    break;
                case 列舉.訂單處理狀態.忽略:
                    App_.Cells[Row_, 3] = 已確認指定配送日;

                    String 配送訊息_ = _Data.處理時間.ToString("yyyy/MM/dd");
                    App_.Cells[Row_, 4] = 配送訊息_;    // 配送訊息
                    App_.Cells[Row_, 5] = 配送訊息_;    // 約定配送日;
                    break;
                default:
                    訊息管理器.獨體.Error("平台訂單回單轉換_Momo 不支援處理狀態 " + _Data.處理狀態.ToString());
                    break;
            }

            switch (_Data.配送公司)
            {
                case 列舉.配送公司.全速配:
                    App_.Cells[Row_, 6] = 字串.新竹貨運;
                    break;
                case 列舉.配送公司.宅配通:
                    App_.Cells[Row_, 6] = 字串.宅配通;
                    break;
                default:
                    訊息管理器.獨體.Error("平台訂單回單轉換_Momo 不支援配送公司 " + _Data.配送公司.ToString());
                    break;
            }

            App_.Cells[Row_, 7] = _Data.配送單號;

            return Row_ + 1;
        }
    }
}
