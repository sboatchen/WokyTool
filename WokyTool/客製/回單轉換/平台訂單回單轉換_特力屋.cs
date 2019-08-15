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
    public class 平台訂單回單轉換_特力屋 : 可寫入介面_EXCEL
    {
        private static int 全速配 = 1;
        private static int 宅配通 = 5;


        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列;

        public 平台訂單回單轉換_特力屋(IEnumerable<平台訂單新增資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "*訂單號碼";
            App_.Cells[1, 2] = "*出貨日期";
            App_.Cells[1, 3] = "*配送單號";
            App_.Cells[1, 4] = "*貨運公司";
            App_.Cells[1, 5] = "貨運公司名稱";
            App_.Cells[1, 6] = "商品編號";
            App_.Cells[1, 7] = "商品名稱";
            App_.Cells[1, 8] = "廠商料號";
            App_.Cells[1, 9] = "數量";
            App_.Cells[1, 10] = "成本(未稅)";
            App_.Cells[1, 11] = "訂單日期";
            App_.Cells[1, 12] = "通路別(下單店別)";
            App_.Cells[1, 13] = "出貨備註";

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.訂單編號;
                App_.Cells[目前行數_, 2] = 資料_.處理時間.ToString("yyyyMMdd");
                App_.Cells[目前行數_, 3] = 資料_.配送單號;

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        App_.Cells[目前行數_, 4] = 全速配;
                        break;
                    case 列舉.配送公司.宅配通:
                        App_.Cells[目前行數_, 4] = 宅配通;
                        break;
                    default:
                        throw new Exception("平台訂單回單轉換_特力屋 不支援配送公司 " + 資料_.配送公司.ToString());
                }

                目前行數_++;
            }
        }
    }
}
