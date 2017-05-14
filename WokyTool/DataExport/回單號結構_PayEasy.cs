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
    class 回單號結構_PayEasy : 可格式化_Csv
    {
        private static string 全速配編號 = "51";
        private static string 宅配通編號 = "53";

        protected 出貨匯入結構_PayEasy _Data;

        public 回單號結構_PayEasy(出貨匯入結構_PayEasy Data_)
        {
            _Data = Data_;
        }

        [CsvColumn(Name = "訂單編號", FieldIndex = 1)]
        public string 訂單編號
        { 
            get
            {
                return _Data.訂單編號;
            }
        }

        [CsvColumn(Name = "物流公司", FieldIndex = 2)]
        public string 配送公司
        {
            get
            {
                switch (_Data.配送公司)
                {
                    case 列舉.配送公司類型.全速配:
                        return 全速配編號;
                    case 列舉.配送公司類型.宅配通:
                        return 宅配通編號;
                    default:
                        MessageBox.Show("回單號結構_PayEasy can't find 配送公司 " + _Data.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 字串.空;
                }
            }
        }

        [CsvColumn(Name = "配送單號", FieldIndex = 3)]
        public string 配送單號
        { 
            get
            {
                return _Data.配送單號;
            }
        }
        
        [CsvColumn(Name = "其他物流公司", FieldIndex = 4)]
        public string 其他物流公司 
        { 
            get
            {
                return 字串.空;
            }
        }
    }
}
