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
    class 平台訂單回單轉換_博客來 : 可格式化_Csv
    {
        private static string 全速配編號 = "EX00000005";
        private static string 宅配通編號 = "EX00000007";

        protected 平台訂單新增資料 _Data;

        public 平台訂單回單轉換_博客來(平台訂單新增資料 Data_)
        {
            _Data = Data_;
        }
        
        [CsvColumn(Name = "序號", FieldIndex = 1)]
        public string 序號 { get { return 通用函式.取得字串(_Data.額外資訊, 1); } }

        [CsvColumn(Name = "重新拋回(是/否)", FieldIndex = 2)]
        public string 重新拋回 { get { return 通用函式.取得字串(_Data.額外資訊, 2); } }

        [CsvColumn(Name = "出貨方式", FieldIndex = 3)]
        public string 出貨方式 { get { return 通用函式.取得字串(_Data.額外資訊, 3); } }

        [CsvColumn(Name = "轉單日期", FieldIndex = 4)]
        public string 轉單日期 { get { return 通用函式.取得字串(_Data.額外資訊, 4); } }

        [CsvColumn(Name = "訂單編號", FieldIndex = 5)]
        public string 訂單編號 { get { return _Data.訂單編號; } }

        [CsvColumn(Name = "商品名稱", FieldIndex = 6)]
        public string 商品名稱 { get { return 通用函式.取得字串(_Data.額外資訊, 6); } }

        [CsvColumn(Name = "貨號", FieldIndex = 7)]
        public string 貨號 { get { return 通用函式.取得字串(_Data.額外資訊, 7); } }

        [CsvColumn(Name = "訂購量", FieldIndex = 8)]
        public int 數量 { get { return _Data.數量; } }

        [CsvColumn(Name = "收件人", FieldIndex = 9)]
        public string 姓名 { get { return _Data.姓名; } }

        [CsvColumn(Name = "配送日期(yyyy/mm/dd)", FieldIndex = 10)]
        public string 配送日期 { get { return 時間.目前日期_斜線; } }

        [CsvColumn(Name = "貨運廠商(請填代碼)", FieldIndex = 11)]
        public string 配送公司
        {
            get
            {
                switch (_Data.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        return 全速配編號;
                    case 列舉.配送公司.宅配通:
                        return 宅配通編號;
                    default:
                        訊息管理器.獨體.Error("平台訂單回單轉換_博客來 不支援配送公司 " + _Data.配送公司.ToString());
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
        public string 商品序號 { get { return 通用函式.取得字串(_Data.額外資訊, 16); } }

        [CsvColumn(Name = "進貨價", FieldIndex = 17)]
        public string 進貨價 { get { return 通用函式.取得字串(_Data.額外資訊, 17); } }

        [CsvColumn(Name = "進貨折扣", FieldIndex = 18)]
        public string 進貨折扣 { get { return 通用函式.取得字串(_Data.額外資訊, 18); } }

        [CsvColumn(Name = "應付金額", FieldIndex = 19)]
        public string 應付金額 { get { return 通用函式.取得字串(_Data.額外資訊, 19); } }

        [CsvColumn(Name = "發票聯式", FieldIndex = 20)]
        public string 發票聯式 { get { return 通用函式.取得字串(_Data.額外資訊, 20); } }

        [CsvColumn(Name = "預計配送日", FieldIndex = 21)]
        public string 預計配送日 { get { return 通用函式.取得字串(_Data.額外資訊, 21); } }

        [CsvColumn(Name = "上市日期", FieldIndex = 22)]
        public string 上市日期 { get { return 通用函式.取得字串(_Data.額外資訊, 22); } }
    }
}
