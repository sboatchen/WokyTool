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
    class 回單號結構_myfone : 可格式化_Csv
    {
        private static string 全速配編號 = "hct_s";
        private static string 宅配通編號 = "e_can_s";

        protected 出貨匯入結構_myfone _Data;

        public 回單號結構_myfone(出貨匯入結構_myfone Data_)
        {
            _Data = Data_;
        }

        [CsvColumn(Name = "訂單日期", FieldIndex = 1)]
        public string 訂單日期 { get { return _Data.無用_訂單日期; } }
        [CsvColumn(Name = "出貨單編號", FieldIndex = 2)]
        public string 出貨單編號 { get { return _Data.無用_出貨單編號; } }
        [CsvColumn(Name = "訂單編號", FieldIndex = 3)]
        public string 訂單編號 { get { return _Data.訂單編號; } }

        [CsvColumn(Name = "運送方式", FieldIndex = 4)]
        public string 運送方式 { get { return _Data.無用_運送方式; } }
        [CsvColumn(Name = "物流代碼", FieldIndex = 5)]
        public string 物流代碼
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
                        MessageBox.Show("回單號結構_myfone can't find 配送公司 " + _Data.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 字串.空;
                }
            }
        }
        [CsvColumn(Name = "配送單號", FieldIndex = 6)]
        public string 配送單號 { get { return _Data.配送單號; } }

        [CsvColumn(Name = "商品貨號", FieldIndex = 7)]
        public string 商品貨號 { get { return _Data.商品序號; } }
        [CsvColumn(Name = "供應商料號", FieldIndex = 8)]
        public string 供應商料號 { get { return _Data.無用_供應商料號; } }
        [CsvColumn(Name = "商品名稱", FieldIndex = 9)]
        public string 商品名稱 { get { return _Data.無用_商品名稱; } }
        [CsvColumn(Name = "樣式", FieldIndex = 10)]
        public string 樣式 { get { return _Data.無用_樣式; } }
        [CsvColumn(Name = "贈品資訊", FieldIndex = 11)]
        public string 贈品資訊 { get { return _Data.無用_贈品資訊; } }

        [CsvColumn(Name = "數量", FieldIndex = 12)]
        public int 數量 { get { return _Data.數量; } }
        [CsvColumn(Name = "無用_單位成本", FieldIndex = 13)]
        public int 無用_單位成本 { get { return _Data.無用_單位成本; } }
        [CsvColumn(Name = "成本小計", FieldIndex = 14)]
        public int 成本小計 { get { return _Data.無用_成本小計; } }

        [CsvColumn(Name = "收件人", FieldIndex = 15)]
        public string 收件人 { get { return _Data.姓名; } }
        [CsvColumn(Name = "聯絡電話", FieldIndex = 16)]
        public string 聯絡電話 { get { return _Data.電話; } }
        [CsvColumn(Name = "行動電話", FieldIndex = 17)]
        public string 行動電話 { get { return _Data.手機; } }
        [CsvColumn(Name = "送貨地址", FieldIndex = 18)]
        public string 送貨地址 { get { return _Data.地址; } }

        [CsvColumn(Name = "發票號碼", FieldIndex = 19)]
        public string 發票號碼 { get { return _Data.無用_發票號碼; } }
        [CsvColumn(Name = "出貨單備註", FieldIndex = 20)]
        public string 出貨單備註 { get { return _Data.備註; } }
    }
}
