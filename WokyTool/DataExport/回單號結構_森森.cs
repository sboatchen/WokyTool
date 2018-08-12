using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataImport;
using WokyTool.通用;

namespace WokyTool.DataExport
{
    class 回單號結構_森森 : 可格式化_Csv
    {
        protected 出貨匯入結構_森森 _Data;

        public 回單號結構_森森(出貨匯入結構_森森 Data_)
        {
            _Data = Data_;
        }

        [CsvColumn(Name = "", FieldIndex = 1)]
        public string 無用 { get { return _Data.無用; } }
        [CsvColumn(Name = "訂單號碼", FieldIndex = 2)]
        public string 訂單編號 { get { return _Data.訂單編號; } }
        [CsvColumn(Name = "訂單序號", FieldIndex = 3)]
        public string 無用_訂單序號 { get { return _Data.無用_訂單序號; } }
        [CsvColumn(Name = "送貨單號", FieldIndex = 4)]
        public string 無用_送貨單號 { get { return _Data.無用_送貨單號; } }
        [CsvColumn(Name = "通路別", FieldIndex = 5)]
        public string 無用_通路別 { get { return _Data.無用_通路別; } }
        [CsvColumn(Name = "銷售編號", FieldIndex = 6)]
        public string 無用_銷售編號 { get { return _Data.無用_銷售編號; } }
        [CsvColumn(Name = "商品編號", FieldIndex = 7)]
        public string 平台商品編號 { get { return _Data.平台商品編號; } }
        [CsvColumn(Name = "商品名稱", FieldIndex = 8)]
        public string 無用_商品名稱 { get { return _Data.無用_商品名稱; } }
        [CsvColumn(Name = "顏色", FieldIndex = 9)]
        public string 無用_顏色 { get { return _Data.無用_顏色; } }
        [CsvColumn(Name = "款式", FieldIndex = 10)]
        public string 款式 { get { return _Data.款式; } }
        [CsvColumn(Name = "廠商料號", FieldIndex = 11)]
        public string 無用_廠商料號 { get { return _Data.無用_廠商料號; } }
        [CsvColumn(Name = "訂單類別", FieldIndex = 12)]
        public string 訂單類別 { get { return _Data.訂單類別; } }
        [CsvColumn(Name = "數量", FieldIndex = 13)]
        public int 數量 { get { return _Data.數量; } }
        [CsvColumn(Name = "售價", FieldIndex = 14)]
        public string 無用_售價 { get { return _Data.無用_售價; } }
        [CsvColumn(Name = "成本", FieldIndex = 15)]
        public string 無用_成本 { get { return _Data.無用_成本; } }
        [CsvColumn(Name = "客戶名稱", FieldIndex = 16)]
        public string 姓名 { get { return _Data.姓名; } }
        [CsvColumn(Name = "客戶電話", FieldIndex = 17)]
        public string 手機 { get { return _Data.手機; } }
        [CsvColumn(Name = "室內電話", FieldIndex = 18)]
        public string 電話 { get { return _Data.電話; } }
        [CsvColumn(Name = "配送地址", FieldIndex = 19)]
        public string 地址 { get { return _Data.地址; } }
        [CsvColumn(Name = "貨運公司", FieldIndex = 20)]
        public string 配送公司
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
                        MessageBox.Show("回單號結構_森森 can't find 配送公司 " + _Data.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 字串.空;
                }
            }
        }
        [CsvColumn(Name = "配送單號", FieldIndex = 21)]
        public string 配送單號 { get { return _Data.配送單號; } }
        [CsvColumn(Name = "出貨指示日", FieldIndex = 22)]
        public string 無用_出貨指示日 { get { return _Data.無用_出貨指示日.ToShortDateString(); } }
        [CsvColumn(Name = "要求配送日", FieldIndex = 23)]
        public string 無用_要求配送日 { get { return _Data.無用_要求配送日; } }
        [CsvColumn(Name = "要求配送時間", FieldIndex = 24)]
        public string 無用_要求配送時間 { get { return _Data.無用_要求配送時間; } }
        [CsvColumn(Name = "備註", FieldIndex = 25)]
        public string 備註 { get { return _Data.備註; } }
        [CsvColumn(Name = "電子發票號碼", FieldIndex = 26)]
        public string 無用_電子發票號碼 { get { return _Data.無用_電子發票號碼; } }
        [CsvColumn(Name = "識別碼", FieldIndex = 27)]
        public string 無用_識別碼 { get { return _Data.無用_識別碼; } }
        [CsvColumn(Name = "電子發票日期", FieldIndex = 28)]
        public string 無用_電子發票日期 { get { return _Data.無用_電子發票日期.ToShortDateString(); } }
        [CsvColumn(Name = "贈品", FieldIndex = 29)]
        public string 無用_贈品 { get { return _Data.無用_贈品; } }
        [CsvColumn(Name = "廠商配送訊息", FieldIndex = 30)]
        public string 無用_廠商配送訊息 { get { return _Data.無用_廠商配送訊息; } }
        [CsvColumn(Name = "預計入庫日期", FieldIndex = 31)]
        public string 無用_預計入庫日期 { get { return _Data.無用_預計入庫日期.ToShortDateString(); } }
        [CsvColumn(Name = "商品編號 ", FieldIndex = 32)]
        public string 無用_商品編號 { get { return _Data.無用_商品編號; } }
    }
}
