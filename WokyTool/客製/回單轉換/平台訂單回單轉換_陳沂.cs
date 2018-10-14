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
    public class 平台訂單回單轉換_陳沂 : 可格式化_Excel
    {
        protected 平台訂單新增資料 _Data;

        protected static int _排序 = 1;

        public 平台訂單回單轉換_陳沂(平台訂單新增資料 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "排序";
            App_.Cells[1, 2] = "訂單號碼";
            App_.Cells[1, 3] = "物流單號";
            App_.Cells[1, 4] = "發票號碼";
            App_.Cells[1, 5] = "物流公司";

            _排序 = 1;

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _排序++;
            App_.Cells[Row_, 2] = _Data.訂單編號;
            App_.Cells[Row_, 3] = _Data.配送單號;
            App_.Cells[Row_, 4] = "";

            switch (_Data.配送公司)
            {
                case 列舉.配送公司.全速配:
                    App_.Cells[Row_, 5] = 字串.新竹貨運;
                    break;
                case 列舉.配送公司.宅配通:
                    App_.Cells[Row_, 5] = 字串.宅配通;
                    break;
                default:
                    if (_Data.處理狀態 != 列舉.訂單處理狀態.忽略)
                        訊息管理器.獨體.Error("平台訂單回單轉換_陳沂_不支援配送公司 " + _Data.配送公司.ToString());
                    break;
            }

            return Row_ + 1;
        }
    }
}
