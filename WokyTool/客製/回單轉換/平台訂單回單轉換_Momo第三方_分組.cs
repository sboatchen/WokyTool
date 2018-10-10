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
    public class 平台訂單回單轉換_Momo第三方_分組 : 可格式化_Excel
    {
        protected 平台訂單新增資料 _Data;

        public 平台訂單回單轉換_Momo第三方_分組(平台訂單新增資料 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "項次+燈號";
            App_.Cells[1, 2] = "併箱編號";
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

            App_.Cells[Row_, 2] = _Data.分組識別;

            return Row_ + 1;
        }
    }
}
