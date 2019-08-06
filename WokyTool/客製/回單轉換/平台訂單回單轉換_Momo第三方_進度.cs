using LINQtoCSV;
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
    public class 平台訂單回單轉換_Momo第三方_進度 : 可寫入介面_EXCEL
    {
        private static string 可出貨 = "可出貨";
        private static string 已確認指定配送日 = "已確認指定配送日";

        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列;

        public 平台訂單回單轉換_Momo第三方_進度(IEnumerable<平台訂單新增資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "項次+燈號";
            App_.Cells[1, 2] = "配送狀態\n(說明參考Desc)";
            App_.Cells[1, 3] = "配送訊息";

            App_.Cells[1, 4] = "約定配送日";
            //App_.get_Range("D1").EntireColumn.NumberFormat = "YYYY/MM/DD";

            App_.Cells[1, 5] = "宅單備註";
            App_.Cells[1, 6] = "訂單編號";

            // 這裡少了付款方式

            App_.Cells[1, 7] = "收件人姓名";
            App_.Cells[1, 8] = "收件人地址";
            App_.Cells[1, 9] = "貨運公司\n出貨地址";
            App_.Cells[1, 10] = "貨運公司\n回收地址";
            App_.Cells[1, 11] = "訂單類別";
            App_.Cells[1, 12] = "客戶配送需求";
            App_.Cells[1, 13] = "轉單日";
            App_.Cells[1, 14] = "預計出貨日";
            App_.Cells[1, 15] = "商品原廠編號";
            App_.Cells[1, 16] = "品號";
            App_.Cells[1, 17] = "品名";
            App_.Cells[1, 18] = "單名編號";
            App_.Cells[1, 19] = "單品詳細";
            App_.Cells[1, 20] = "數量";
            App_.Cells[1, 21] = "進價(含稅)";
            App_.Cells[1, 22] = "贈品";
            App_.Cells[1, 23] = "訂購人姓名";
            App_.Cells[1, 24] = "發票號碼";
            App_.Cells[1, 25] = "發票日期";
            App_.Cells[1, 26] = "個人識別碼";
            App_.Cells[1, 27] = "群組變價商品";

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列)
            {
                foreach (var Pair_ in 資料_.額外資訊)
                {
                    if (Pair_.Key <= 0)
                        continue;
                    else if (Pair_.Key <= 6)
                        App_.Cells[目前行數_, Pair_.Key] = Pair_.Value;
                    else if (Pair_.Key >= 8)
                        App_.Cells[目前行數_, Pair_.Key - 1] = Pair_.Value;
                }

                // 預計出貨日須為2日內(今天+明天) 才進行出貨處理 並將配送狀態改為 可出貨
                // 2日外的 將配送狀態改為 已確認指定配送日 並將配送訊息 寫上預計出貨日
                switch (資料_.處理狀態)
                {
                    case 列舉.訂單處理狀態.新增:
                        App_.Cells[目前行數_, 2] = 可出貨;
                        break;
                    case 列舉.訂單處理狀態.忽略:
                        App_.Cells[目前行數_, 2] = 已確認指定配送日;

                        String 配送訊息_ = 資料_.處理時間.ToString("yyyy/MM/dd");
                        App_.Cells[目前行數_, 3] = 配送訊息_;    // 配送訊息
                        App_.Cells[目前行數_, 4] = 配送訊息_;    // 約定配送日;
                        break;
                    default:
                        訊息管理器.獨體.錯誤("平台訂單回單轉換_Momo第三方_進度 不支援處理狀態 " + 資料_.處理狀態.ToString());
                        break;
                }

                目前行數_++;
            }
        }
    }
}
