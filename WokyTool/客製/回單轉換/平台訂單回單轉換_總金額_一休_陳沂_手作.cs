using LINQtoCSV;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.平台訂單;
using WokyTool.通用;

namespace WokyTool.客製
{
    public class 平台訂單回單轉換_總金額_一休_陳沂_手作 //: 可寫入介面_EXCEL
    {
        /*public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private Dictionary<string, decimal> _資料書;

        public 平台訂單回單轉換_總金額_一休_陳沂_手作(IEnumerable<IGrouping<string, 平台訂單新增資料>> GroupQueue_)
        {
            _資料書 = new Dictionary<string, decimal>();

            String 姓名_ = null;
            decimal 總金額_ = 0;
            foreach(var Pair_ in GroupQueue_)
            {
                總金額_ = 0;

                foreach (平台訂單新增資料 資料_ in Pair_)
                {
                    姓名_ = 資料_.姓名;

                    Object Temp_;
                    if (資料_.額外資訊.TryGetValue(-1, out Temp_))
                    {
                        總金額_ += Decimal.Parse(Temp_.ToString());
                    }
                }

                _資料書.Add(姓名_, 總金額_);
            }
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "姓名";
            App_.Cells[1, 2] = "總金額";

            int 目前行數_ = 2;
            foreach (var Pair_ in _資料書)
            {
                App_.Cells[目前行數_, 1] = Pair_.Key;
                App_.Cells[目前行數_, 2] = Pair_.Value;

                目前行數_++;
            }
        }*/
    }
}
