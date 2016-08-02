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
    class 回單號結構_創業家兄弟
    {
        [CsvColumn(Name = "訂單號碼", FieldIndex = 1)]
        public string 訂單編號 { get; set; }
        [CsvColumn(Name = "收件人", FieldIndex = 2)]
        public string 姓名 { get; set; }
        [CsvColumn(Name = "收件地址", FieldIndex = 3)]
        public string 地址 { get; set; }
        [CsvColumn(Name = "電話", FieldIndex = 4)]
        public string 電話 { get; set; }
        [CsvColumn(Name = "配送時段", FieldIndex = 5)]
        public string 無用_配送時段 { get; set; }
        [CsvColumn(Name = "購買內容", FieldIndex = 6)]
        public string 商品序號 { get; set; }
        [CsvColumn(Name = "宅配編號", FieldIndex = 7)]
        public string 配送單號 { get; set; }
        [CsvColumn(Name = "貨運公司", FieldIndex = 8)]
        public string 配送公司 { get; set; }

        public 回單號結構_創業家兄弟(WokyTool.DataImport.出貨匯入結構_創業家兄弟 From_)
        {
            訂單編號 = From_.訂單編號;
            姓名 = From_.姓名;
            地址 = From_.地址;
            電話 = From_.電話;
            無用_配送時段 = From_.無用_配送時段;
            商品序號 = From_.商品序號;
            
            switch (From_.配送公司)
            { 
                case 列舉.配送公司類型.全速配:
                    配送公司 = 字串.新竹貨運;
                    break;
                case 列舉.配送公司類型.宅配通:
                    配送公司 = 字串.宅配通;
                    break;
                default:
                    MessageBox.Show("回單號結構_創業家兄弟 can't find 配送公司 " + From_.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            
            配送單號 = From_.配送單號;
        }
    }
}
