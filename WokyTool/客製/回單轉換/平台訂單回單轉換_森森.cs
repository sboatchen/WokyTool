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
    class 平台訂單回單轉換_森森 : 可格式化_Csv
    {
        protected 平台訂單新增資料 _Data;

        public 平台訂單回單轉換_森森(平台訂單新增資料 Data_)
        {
            _Data = Data_;
        }

        [CsvColumn(Name = "", FieldIndex = 1)]
        public string 無用 { get { return 通用函式.取得字串(_Data.額外資訊, 1); } }
        [CsvColumn(Name = "訂單號碼", FieldIndex = 2)]
        public string 訂單編號 { get { return _Data.訂單編號; } }
        [CsvColumn(Name = "併單序號", FieldIndex = 3)]
        public string 併單序號 { get { return 通用函式.取得字串(_Data.額外資訊, 3); } }
        [CsvColumn(Name = "送貨單號", FieldIndex = 4)]
        public string 送貨單號 { get { return 通用函式.取得字串(_Data.額外資訊, 4); } }
        [CsvColumn(Name = "銷售編號", FieldIndex = 5)]
        public string 銷售編號 { get { return 通用函式.取得字串(_Data.額外資訊, 5); } }
        [CsvColumn(Name = "商品編號", FieldIndex = 6)]
        public string 商品編號 { get { return 通用函式.取得字串(_Data.額外資訊, 6); } }
        [CsvColumn(Name = "商品名稱", FieldIndex = 7)]
        public string 商品名稱 { get { return 通用函式.取得字串(_Data.額外資訊, 7); } }
        [CsvColumn(Name = "顏色", FieldIndex = 8)]
        public string 顏色 { get { return 通用函式.取得字串(_Data.額外資訊, 8); } }
        [CsvColumn(Name = "款式", FieldIndex = 9)]
        public string 款式 { get { return 通用函式.取得字串(_Data.額外資訊, 9); } }
        [CsvColumn(Name = "廠商商品號碼", FieldIndex = 10)]
        public string 廠商商品號碼 { get { return 通用函式.取得字串(_Data.額外資訊, 10); } }
        [CsvColumn(Name = "訂單類別", FieldIndex = 11)]
        public string 訂單類別 { get { return 通用函式.取得字串(_Data.額外資訊, 11); } }
        [CsvColumn(Name = "數量", FieldIndex = 12)]
        public int 數量 { get { return _Data.數量; } }
        [CsvColumn(Name = "售價", FieldIndex = 13)]
        public string 售價 { get { return 通用函式.取得字串(_Data.額外資訊, 13); } }
        [CsvColumn(Name = "成本", FieldIndex = 14)]
        public string 成本 { get { return 通用函式.取得字串(_Data.額外資訊, 14); } }
        [CsvColumn(Name = "客戶名稱", FieldIndex = 15)]
        public string 客戶名稱 { get { return _Data.姓名; } }
        [CsvColumn(Name = "客戶電話", FieldIndex = 16)]
        public string 客戶電話 { get { return _Data.手機; } }
        [CsvColumn(Name = "室內電話", FieldIndex = 17)]
        public string 室內電話 { get { return _Data.電話; } }
        [CsvColumn(Name = "配送地址", FieldIndex = 18)]
        public string 配送地址 { get { return _Data.地址; } }
        [CsvColumn(Name = "貨運公司", FieldIndex = 19)]
        public string 貨運公司
        {
            get
            {
                switch (_Data.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        return 字串.新竹物流;
                    case 列舉.配送公司.宅配通:
                        return 字串.宅配通;
                    default:
                        訊息管理器.獨體.Error("平台訂單回單轉換_森森 不支援配送公司 " + _Data.配送公司.ToString());
                        return 字串.空;
                }
            }
        }

        [CsvColumn(Name = "配送單號", FieldIndex = 20)]
        public string 配送單號{ get { return _Data.配送單號; } }
        [CsvColumn(Name = "出貨指示日", FieldIndex = 21)]
        public string 出貨指示日 { get { return 通用函式.取得字串(_Data.額外資訊, 21); } }
        [CsvColumn(Name = "要求配送日", FieldIndex = 22)]
        public string 要求配送日 { get { return 通用函式.取得字串(_Data.額外資訊, 22); } }
        [CsvColumn(Name = "要求配送時間", FieldIndex = 23)]
        public string 要求配送時間 { get { return 通用函式.取得字串(_Data.額外資訊, 23); } }
        [CsvColumn(Name = "備註", FieldIndex = 24)]
        public string 備註 { get { return _Data.備註; } }
        [CsvColumn(Name = "贈品", FieldIndex = 25)]
        public string 贈品 { get { return 通用函式.取得字串(_Data.額外資訊, 25); } }
        [CsvColumn(Name = "廠商配送訊息", FieldIndex = 26)]
        public string 廠商配送訊息 { get { return 通用函式.取得字串(_Data.額外資訊, 26); } }
        [CsvColumn(Name = "預計入庫日", FieldIndex = 27)]
        public string 預計入庫日 { get { return 通用函式.取得字串(_Data.額外資訊, 27); } }
        [CsvColumn(Name = "通路別", FieldIndex = 28)]
        public string 通路別 { get { return 通用函式.取得字串(_Data.額外資訊, 28); } }
        [CsvColumn(Name = "併單訂單項次", FieldIndex = 29)]
        public string 併單訂單項次 { get { return 通用函式.取得字串(_Data.額外資訊, 29); } }
        [CsvColumn(Name = "訂單類別代號", FieldIndex = 30)]
        public string 訂單類別代號 { get { return 通用函式.取得字串(_Data.額外資訊, 30); } }
    }
}
