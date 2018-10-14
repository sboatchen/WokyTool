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
    public class 平台訂單回單轉換_總金額_一休_陳沂_手作 : 可格式化_Excel
    {
        protected String _姓名;
        protected decimal _總金額;

        public 平台訂單回單轉換_總金額_一休_陳沂_手作(List<平台訂單新增資料> List_)
        {
            _總金額 = 0;

            foreach (平台訂單新增資料 資料_ in List_)
            {
                _姓名 = 資料_.姓名;

                Object 總金額_;
                if(資料_.額外資訊.TryGetValue(-1, out 總金額_))
                {
                    _總金額 += Decimal.Parse(總金額_.ToString());
                }
            }
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "姓名";
            App_.Cells[1, 2] = "總金額";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _姓名;
            App_.Cells[Row_, 2] = _總金額;

            return Row_ + 1;
        }
    }
}
