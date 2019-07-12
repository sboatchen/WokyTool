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
    public class 平台訂單回單轉換_神坊 : 可序列化_Excel
    {
        private static string 全速配編號 = "5";
        private static string 宅配通編號 = "2";

        protected IEnumerable<平台訂單新增資料> _資料列;

        public String 標頭 { get; set; }

        public String 樣板 { get { return null; } }

        public 平台訂單回單轉換_神坊(IEnumerable<平台訂單新增資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "訂單編號";
            App_.Cells[1, 2] = "商品名稱";
            App_.Cells[1, 3] = "收件人";
            App_.Cells[1, 4] = "出貨物流";

            App_.Cells[1, 5] = "出貨單號";

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.訂單編號;
                App_.Cells[目前行數_, 2] = 函式.取得字串(資料_.額外資訊, 2);
                App_.Cells[目前行數_, 3] = 資料_.姓名;

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        App_.Cells[目前行數_, 4] = 全速配編號;
                        break;
                    case 列舉.配送公司.宅配通:
                        App_.Cells[目前行數_, 4] = 宅配通編號;
                        break;
                    default:
                        訊息管理器.獨體.Error("平台訂單回單轉換_神坊 不支援配送公司 " + 資料_.配送公司.ToString());
                        break;
                }

                App_.Cells[目前行數_, 5] = 資料_.配送單號;

                目前行數_++;
            }
        }
    }
}
