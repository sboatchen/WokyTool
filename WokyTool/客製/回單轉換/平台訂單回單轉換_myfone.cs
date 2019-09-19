
namespace WokyTool.客製
{
    class 平台訂單回單轉換_myfone //: 可格式化_Csv
    {
        /*private static string 全速配編號 = "hct_s";
        private static string 宅配通編號 = "e_can_s";

        protected 平台訂單新增資料 _Data;

        public 平台訂單回單轉換_myfone(平台訂單新增資料 Data_)
        {
            _Data = Data_;
        }

        [CsvColumn(Name = "訂單日期", FieldIndex = 1)]
        public string 訂單日期 { get { return 函式.取得字串(_Data.額外資訊, 1); } }
        [CsvColumn(Name = "出貨單編號", FieldIndex = 2)]
        public string 出貨單編號 { get { return 函式.取得字串(_Data.額外資訊, 2); } }
        [CsvColumn(Name = "訂單編號", FieldIndex = 3)]
        public string 訂單編號 { get { return _Data.訂單編號; } }

        [CsvColumn(Name = "運送方式", FieldIndex = 4)]
        public string 運送方式 { get { return 函式.取得字串(_Data.額外資訊, 4); } }
        [CsvColumn(Name = "物流代碼", FieldIndex = 5)]
        public string 物流代碼
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
                        訊息管理器.獨體.錯誤("平台訂單回單轉換_myfone 不支援配送公司 " + _Data.配送公司.ToString());
                        return 字串.空;
                }
            }
        }
        [CsvColumn(Name = "配送單號", FieldIndex = 6)]
        public string 配送單號 { get { return _Data.配送單號; } }

        [CsvColumn(Name = "商品貨號", FieldIndex = 7)]
        public string 商品貨號 { get { return 函式.取得字串(_Data.額外資訊, 7); } }
        [CsvColumn(Name = "供應商料號", FieldIndex = 8)]
        public string 供應商料號 { get { return 函式.取得字串(_Data.額外資訊, 8); } }
        [CsvColumn(Name = "商品名稱", FieldIndex = 9)]
        public string 商品名稱 { get { return 函式.取得字串(_Data.額外資訊, 9); } }
        [CsvColumn(Name = "樣式", FieldIndex = 10)]
        public string 樣式 { get { return 函式.取得字串(_Data.額外資訊, 10); } }
        [CsvColumn(Name = "贈品資訊", FieldIndex = 11)]
        public string 贈品資訊 { get { return 函式.取得字串(_Data.額外資訊, 11); } }

        [CsvColumn(Name = "數量", FieldIndex = 12)]
        public int 數量 { get { return _Data.數量; } }
        [CsvColumn(Name = "單位成本", FieldIndex = 13)]
        public string 無用_單位成本 { get { return 函式.取得字串(_Data.額外資訊, 13); } }
        [CsvColumn(Name = "成本小計", FieldIndex = 14)]
        public string 成本小計 { get { return 函式.取得字串(_Data.額外資訊, 14); } }

        [CsvColumn(Name = "購買人email", FieldIndex = 15)]
        public string 購買人email { get { return 函式.取得字串(_Data.額外資訊, 15); } }
        [CsvColumn(Name = "收件人", FieldIndex = 16)]
        public string 收件人 { get { return _Data.姓名; } }
        [CsvColumn(Name = "聯絡電話", FieldIndex = 17)]
        public string 聯絡電話 { get { return _Data.電話; } }
        [CsvColumn(Name = "行動電話", FieldIndex = 18)]
        public string 行動電話 { get { return _Data.手機; } }
        [CsvColumn(Name = "送貨地址", FieldIndex = 19)]
        public string 送貨地址 { get { return _Data.地址; } }

        [CsvColumn(Name = "發票號碼", FieldIndex = 20)]
        public string 發票號碼 { get { return 函式.取得字串(_Data.額外資訊, 20); } }
        [CsvColumn(Name = "出貨單備註", FieldIndex = 21)]
        public string 出貨單備註 { get { return _Data.備註; } }*/
    }
}
