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
    class 回單號結構_創業家兄弟 : 可格式化_Csv
    {
        protected 出貨匯入結構_創業家兄弟 _Data;

        public 回單號結構_創業家兄弟(出貨匯入結構_創業家兄弟 Data_)
        {
            _Data = Data_;
        }

        [CsvColumn(Name = "訂單號碼", FieldIndex = 1)]
        public string 訂單編號
        {
            get
            {
                return _Data.訂單編號;
            }
        }

        [CsvColumn(Name = "收件人", FieldIndex = 2)]
        public string 姓名
        {
            get
            {
                return _Data.姓名;
            }
        }

        [CsvColumn(Name = "收件地址", FieldIndex = 3)]
        public string 地址
        {
            get
            {
                return _Data.地址;
            }
        }

        [CsvColumn(Name = "電話", FieldIndex = 4)]
        public string 電話
        {
            get
            {
                return _Data.電話;
            }
        }

        [CsvColumn(Name = "配送時段", FieldIndex = 5)]
        public string 無用_配送時段
        {
            get
            {
                return _Data.無用_配送時段;
            }
        }

        [CsvColumn(Name = "購買內容", FieldIndex = 6)]
        public string 商品序號
        {
            get
            {
                return _Data.商品序號;
            }
        }

        [CsvColumn(Name = "宅配編號", FieldIndex = 7)]
        public string 配送單號
        {
            get
            {
                return _Data.配送單號;
            }
        }

        [CsvColumn(Name = "貨運公司", FieldIndex = 8)]
        public string 配送公司
        {
            get
            {
                switch (_Data.配送公司)
                {
                    case 列舉.配送公司類型.全速配:
                        return 字串.新竹貨運;
                    case 列舉.配送公司類型.宅配通:
                        return 字串.宅配通;
                    default:
                        MessageBox.Show("回單號結構_創業家兄弟 can't find 配送公司 " + _Data.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 字串.空;
                }
            }
        }
    }
}
