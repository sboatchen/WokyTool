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
    public class 平台訂單回單轉換_中華電信 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單回單轉換_中華電信(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "訂單編號";
            App_.Cells[1, 2] = "收件人";
            App_.Cells[1, 3] = "物流公司";
            App_.Cells[1, 4] = "物流編號";
            App_.Cells[1, 5] = "出貨日期";
            App_.Cells[1, 6] = "到貨日期";
            App_.Cells[1, 7] = "電子發票號碼(非必填)";

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列舉.GroupBy(Value => Value.配送單號).Select(Value => Value.First()))
            {
                App_.Cells[目前行數_, 1] = 資料_.訂單編號;
                App_.Cells[目前行數_, 2] = 資料_.姓名;

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        App_.Cells[目前行數_, 3] = 字串.新竹貨運;
                        break;
                    case 列舉.配送公司.宅配通:
                        App_.Cells[目前行數_, 3] = 字串.宅配通;
                        break;
                    default:
                        throw new Exception("平台訂單回單轉換_中華電信 不支援配送公司 " + 資料_.配送公司.ToString());
                }

                App_.Cells[目前行數_, 4] = 資料_.配送單號;
                App_.Cells[目前行數_, 5] = 時間.目前日期;
                App_.Cells[目前行數_, 6] = 時間.明天日期;

                目前行數_++;
            }
        }
    }
}
