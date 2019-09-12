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

namespace WokyTool.平台訂單
{
    public class 平台訂單回單轉換_百利市 : 可寫入介面_EXCEL
    {
        private static string 全速配 = "新竹物流";
        private static string 宅配通 = "台灣宅配通";


        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單回單轉換_百利市(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "商品Line*";
            App_.Cells[1, 2] = "訂單編號*";
            App_.Cells[1, 3] = "商品品號";
            App_.get_Range("C1").EntireColumn.NumberFormat = "@";   // 強迫以字串的方式記錄
            App_.Cells[1, 4] = "物流公司";
            App_.Cells[1, 5] = "運單號";
            App_.Cells[1, 6] = "出貨時間";
            App_.Cells[1, 7] = "是否客約";
            App_.Cells[1, 8] = "客約送貨時間";

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列舉)
            {
                App_.Cells[目前行數_, 1] = 資料_.內容[6];
                App_.Cells[目前行數_, 2] = 資料_.訂單編號;
                App_.Cells[目前行數_, 3] = 資料_.內容[5];

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        App_.Cells[目前行數_, 4] = 全速配;
                        break;
                    case 列舉.配送公司.宅配通:
                        App_.Cells[目前行數_, 4] = 宅配通;
                        break;
                    default:
                        throw new Exception("平台訂單回單轉換_百利市 不支援配送公司 " + 資料_.配送公司.ToString());
                }

                App_.Cells[目前行數_, 5] = 資料_.配送單號;

                // 出貨時間格式應該為年月日時分秒。例如：2015.12.30 12：00：00，例如：2015.12.30，則默認是2015.12.30 0：00:00
                App_.Cells[目前行數_, 6] = 資料_.處理時間.ToString("yyyy.MM.dd") + " 0:00:00";

                目前行數_++;
            }
        }
    }
}
