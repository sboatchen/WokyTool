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
    public class 平台訂單回單轉換_Momo第三方_分組 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return "0"; } }

        private IEnumerable<平台訂單新增資料> _資料列;


        public 平台訂單回單轉換_Momo第三方_分組(IEnumerable<平台訂單新增資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "項次+燈號";
            App_.Cells[1, 2] = "併箱編號";

            // 以下同匯入訂單
            App_.Cells[1, 3] = "訂單編號";
            App_.Cells[1, 4] = "付款方式";
            App_.Cells[1, 5] = "收件人姓名";
            App_.Cells[1, 6] = "收件人地址";
            App_.Cells[1, 7] = "貨運公司\n出貨地址";
            App_.Cells[1, 8] = "貨運公司\n回收地址";
            App_.Cells[1, 9] = "訂單類別";
            App_.Cells[1, 10] = "客戶配送需求";
            App_.Cells[1, 11] = "轉單日";
            App_.Cells[1, 12] = "預計出貨日";
            App_.Cells[1, 13] = "商品原廠編號";
            App_.Cells[1, 14] = "品號";
            App_.Cells[1, 15] = "品名";
            App_.Cells[1, 16] = "單名編號";
            App_.Cells[1, 17] = "單品詳細";
            App_.Cells[1, 18] = "數量";
            App_.Cells[1, 19] = "進價(含稅)";
            App_.Cells[1, 20] = "贈品";
            App_.Cells[1, 21] = "訂購人姓名";
            App_.Cells[1, 22] = "發票號碼";
            App_.Cells[1, 23] = "發票日期";
            App_.Cells[1, 24] = "個人識別碼";
            App_.Cells[1, 25] = "群組變價商品";

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列)
            {
                foreach (var Pair_ in 資料_.額外資訊)
                {
                    if (Pair_.Key <= 0)
                        continue;
                    else if (Pair_.Key == 1)
                        App_.Cells[目前行數_, Pair_.Key] = Pair_.Value;
                    else if (Pair_.Key >= 6)
                        App_.Cells[目前行數_, Pair_.Key - 3] = Pair_.Value;
                }

                App_.Cells[目前行數_, 2] = 資料_.配送分組;

                目前行數_++;
            }
        }
    }
}
