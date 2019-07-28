using LINQtoCSV;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.平台訂單;
using WokyTool.通用;

namespace WokyTool.客製
{
    public class 平台訂單回單轉換_摩天 : 可寫入介面_EXCEL
    {
        public String 分類 { get { return null; } }

        public String 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public String 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列;

        public 平台訂單回單轉換_摩天(IEnumerable<平台訂單新增資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Application App_)
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

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列)
            {
                foreach (var Pair_ in 資料_.額外資訊)
                {
                    App_.Cells[目前行數_, Pair_.Key] = Pair_.Value;
                }

                App_.Cells[目前行數_, 3] = "已配送";
           
                 switch (資料_.配送公司)
                { 
                    case 列舉.配送公司.全速配:
                        App_.Cells[目前行數_, 5] = 字串.新竹貨運;
                        break;
                    case 列舉.配送公司.宅配通:
                        App_.Cells[目前行數_, 5] = 字串.宅配通;
                        break;
                    default:
                        訊息管理器.獨體.Error("平台訂單回單轉換_摩天 不支援配送公司 " + 資料_.配送公司.ToString());
                        break;
                }

                App_.Cells[目前行數_, 6] = 資料_.配送單號;


                目前行數_++;
            }
        }
    }
}
