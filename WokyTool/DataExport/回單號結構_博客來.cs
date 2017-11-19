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
    class 回單號結構_博客來 : 可格式化_Csv
    {
        private static string 全速配編號 = "EX00000005";
        private static string 宅配通編號 = "EX00000007";

        protected 出貨匯入結構_博客來 _Data;

        public 回單號結構_博客來(出貨匯入結構_博客來 Data_)
        {
            _Data = Data_;
        }
        
        [CsvColumn(Name = "序號", FieldIndex = 1)]
        public string 序號 { get { return _Data.序號; } }

        [CsvColumn(Name = "重新拋回(是/否)", FieldIndex = 2)]
        public string 重新拋回 { get { return _Data.重新拋回; } }

        [CsvColumn(Name = "出貨方式", FieldIndex = 3)]
        public string 出貨方式 { get { return _Data.出貨方式; } }

        [CsvColumn(Name = "轉單日期", FieldIndex = 4)]
        public string 轉單日期 { get { return _Data.轉單日期; } }

        [CsvColumn(Name = "訂單編號", FieldIndex = 5)]
        public string 訂單編號 { get { return _Data.訂單編號; } }

        [CsvColumn(Name = "商品名稱", FieldIndex = 6)]
        public string 商品名稱 { get { return _Data.商品名稱; } }

        [CsvColumn(Name = "貨號", FieldIndex = 7)]
        public string 貨號 { get { return _Data.貨號; } }

        [CsvColumn(Name = "訂購量", FieldIndex = 8)]
        public int 數量 { get { return _Data.數量; } }

        [CsvColumn(Name = "收件人", FieldIndex = 9)]
        public string 姓名 { get { return _Data.姓名; } }

        [CsvColumn(Name = "配送日期(yyyy/mm/dd)", FieldIndex = 10)]
        public string 配送日期 { get { return 共用.NowYMD.ToString("yyyy/MM/dd"); } }

        [CsvColumn(Name = "貨運廠商(請填代碼)", FieldIndex = 11)]
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
                        MessageBox.Show("回單號結構_博客來 can't find 配送公司 " + _Data.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 字串.空;
                }
            }
        }

        [CsvColumn(Name = "貨運名稱(當前一欄位選擇其他時，此欄請輸入貨運名稱)", FieldIndex = 12)]
        public string 貨運名稱 { get { return 字串.空; } }

        [CsvColumn(Name = "貨運單號(輸入半形英文或數字)", FieldIndex = 13)]
        public string 配送單號 { get { return _Data.配送單號; } }

        [CsvColumn(Name = "聯絡電話", FieldIndex = 14)]
        public string 電話 { get { return _Data.電話; } }

        [CsvColumn(Name = "配送地址", FieldIndex = 15)]
        public string 地址 { get { return _Data.地址; } }

        [CsvColumn(Name = "店內碼", FieldIndex = 16)]
        public string 商品序號 { get { return _Data.商品序號; } }

        [CsvColumn(Name = "進貨價", FieldIndex = 17)]
        public string 進貨價 { get { return _Data.進貨價; } }

        [CsvColumn(Name = "進貨折扣", FieldIndex = 18)]
        public string 進貨折扣 { get { return _Data.進貨折扣; } }

        [CsvColumn(Name = "應付金額", FieldIndex = 19)]
        public string 應付金額 { get { return _Data.應付金額; } }

        [CsvColumn(Name = "發票聯式", FieldIndex = 20)]
        public string 發票聯式 { get { return _Data.發票聯式; } }

        [CsvColumn(Name = "預計配送日", FieldIndex = 21)]
        public string 預計配送日 { get { return _Data.預計配送日; } }

        [CsvColumn(Name = "上市日期", FieldIndex = 22)]
        public string 上市日期 { get { return _Data.上市日期; } }
    }
}
