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
    public class 平台訂單回單轉換_摩天 : 可格式化_Excel
    {
        protected 平台訂單新增資料 _Data;

        public 平台訂單回單轉換_摩天(平台訂單新增資料 Data_)
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
            foreach (var Pair_ in _Data.額外資訊)
            {
                App_.Cells[Row_, Pair_.Key] = Pair_.Value;
            }

            App_.Cells[Row_, 3] = "已配送";
           
             switch (_Data.配送公司)
            { 
                case 列舉.配送公司.全速配:
                    App_.Cells[Row_, 5] = 字串.新竹貨運;
                    break;
                case 列舉.配送公司.宅配通:
                    App_.Cells[Row_, 5] = 字串.宅配通;
                    break;
                default:
                    訊息管理器.獨體.Error("平台訂單回單轉換_摩天 can't find 配送公司 " + _Data.配送公司.ToString());
                    break;
            }

            App_.Cells[Row_, 6] = _Data.配送單號;

            return Row_ + 1;
        }
    }
}
