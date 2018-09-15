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
    public class 平台訂單回單轉換_遠傳加購 : 可格式化_Excel
    {
        private static string 全速配編號 = "02";
        private static string 宅配通編號 = "03";

        protected 平台訂單新增資料 _Data;

        public 平台訂單回單轉換_遠傳加購(平台訂單新增資料 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "訂單編號";
            App_.Cells[1, 2] = "物流商代碼";
            App_.Cells[1, 3] = "貨運單號";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.訂單編號;

            switch (_Data.配送公司)
            {
                case 列舉.配送公司.全速配:
                    App_.Cells[Row_, 2] = 全速配編號;
                    break;
                case 列舉.配送公司.宅配通:
                    App_.Cells[Row_, 2] = 宅配通編號;
                    break;
                default:
                    MessageBox.Show("平台訂單回單轉換_遠傳加購 can't find 配送公司 " + _Data.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            
            App_.Cells[Row_, 3] = _Data.配送單號;

            return Row_ + 1;
        }
    }
}
