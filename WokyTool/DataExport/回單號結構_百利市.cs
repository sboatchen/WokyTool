using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataImport;

namespace WokyTool.DataExport
{
    class 回單號結構_百利市 : 可格式化_Excel
    {
        private static string 全速配編號 = "新竹物流";
        private static string 宅配通編號 = "台灣宅配通";

        protected 出貨匯入結構_百利市 _Data;

        public 回單號結構_百利市(出貨匯入結構_百利市 Data_)
        {
            _Data = Data_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
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

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.商品Line;
            App_.Cells[Row_, 2] = _Data.訂單編號;
            App_.Cells[Row_, 3] = _Data.商品序號;

            switch (_Data.配送公司)
            {
                case 列舉.配送公司類型.全速配:
                    App_.Cells[Row_, 4] = 全速配編號;
                    break;
                case 列舉.配送公司類型.宅配通:
                    App_.Cells[Row_, 4] = 宅配通編號;
                    break;
                default:
                    MessageBox.Show("回單號結構_百利市 can't find 配送公司 " + _Data.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            
            App_.Cells[Row_, 5] = _Data.配送單號;

            // 出貨時間格式應該為年月日時分秒。例如：2015.12.30 12：00：00，例如：2015.12.30，則默認是2015.12.30 0：00:00
            App_.Cells[Row_, 6] = 共用.NowYMD.ToString("yyyy.MM.dd") + " 0:00:00";

            return Row_ + 1;
        }
    }
}
