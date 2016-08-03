using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.DataExport
{
    class 回單號結構_GoHappy
    {
        private static string 全速配編號 = "4";
        private static string 宅配通編號 = "3";

        [CsvColumn(Name = "訂單編號", FieldIndex = 1)]
        public string 訂單編號 { get; set; }
        [CsvColumn(Name = "出貨單號", FieldIndex = 2)]
        public string 出貨單號 { get; set; }
        [CsvColumn(Name = "宅配廠商代碼", FieldIndex = 3)]
        public string 配送公司 { get; set; }
        [CsvColumn(Name = "宅配單號", FieldIndex = 4)]
        public string 配送單號 { get; set; }

        public 回單號結構_GoHappy(WokyTool.DataImport.出貨匯入結構_GoHappy From_)
        {
            訂單編號 = From_.訂單編號;
            出貨單號 = From_.出貨單號;

            switch (From_.配送公司)
            { 
                case 列舉.配送公司類型.全速配:
                    配送公司 = 全速配編號;
                    break;
                case 列舉.配送公司類型.宅配通:
                    配送公司 = 宅配通編號;
                    break;
                default:
                    MessageBox.Show("回單號結構_GoHappy can't find 配送公司 " + From_.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            
            配送單號 = From_.配送單號;
        }
    }
}
