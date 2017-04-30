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
    class 回單號結構_森森
    {
        [CsvColumn(Name = "", FieldIndex = 1)]
        public string 無用 { get; set; }
        [CsvColumn(Name = "訂單號碼", FieldIndex = 2)]
        public string 訂單編號 { get; set; }
        [CsvColumn(Name = "訂單序號", FieldIndex = 3)]
        public string 無用_訂單序號 { get; set; }
        [CsvColumn(Name = "送貨單號", FieldIndex = 4)]
        public string 無用_送貨單號 { get; set; }
        [CsvColumn(Name = "通路別", FieldIndex = 5)]
        public string 無用_通路別 { get; set; }
        [CsvColumn(Name = "銷售編號", FieldIndex = 6)]
        public string 無用_銷售編號 { get; set; }
        [CsvColumn(Name = "商品編號", FieldIndex = 7)]
        public string 平台商品編號 { get; set; }
        [CsvColumn(Name = "商品名稱", FieldIndex = 8)]
        public string 無用_商品名稱 { get; set; }
        [CsvColumn(Name = "顏色", FieldIndex = 9)]
        public string 無用_顏色 { get; set; }
        [CsvColumn(Name = "款式", FieldIndex = 10)]
        public string 款式 { get; set; }
        [CsvColumn(Name = "廠商料號", FieldIndex = 11)]
        public string 無用_廠商料號 { get; set; }
        [CsvColumn(Name = "訂單類別", FieldIndex = 12)]
        public string 訂單類別 { get; set; }
        [CsvColumn(Name = "數量", FieldIndex = 13)]
        public int 數量 { get; set; }
        [CsvColumn(Name = "售價", FieldIndex = 14)]
        public string 無用_售價 { get; set; }
        [CsvColumn(Name = "成本", FieldIndex = 15)]
        public string 無用_成本 { get; set; }
        [CsvColumn(Name = "客戶名稱", FieldIndex = 16)]
        public string 姓名 { get; set; }
        [CsvColumn(Name = "客戶電話", FieldIndex = 17)]
        public string 手機 { get; set; }
        [CsvColumn(Name = "室內電話", FieldIndex = 18)]
        public string 電話 { get; set; }
        [CsvColumn(Name = "配送地址", FieldIndex = 19)]
        public string 地址 { get; set; }
        [CsvColumn(Name = "貨運公司", FieldIndex = 20)]
        public string 配送公司 { get; set; }
        [CsvColumn(Name = "配送單號", FieldIndex = 21)]
        public string 配送單號 { get; set; }
        [CsvColumn(Name = "出貨指示日", FieldIndex = 22)]
        public string 無用_出貨指示日 { get; set; }
        [CsvColumn(Name = "要求配送日", FieldIndex = 23)]
        public string 無用_要求配送日 { get; set; }
        [CsvColumn(Name = "要求配送時間", FieldIndex = 24)]
        public string 無用_要求配送時間 { get; set; }
        [CsvColumn(Name = "備註", FieldIndex = 25)]
        public string 備註 { get; set; }
        [CsvColumn(Name = "電子發票號碼", FieldIndex = 26)]
        public string 無用_電子發票號碼 { get; set; }
        [CsvColumn(Name = "識別碼", FieldIndex = 27)]
        public string 無用_識別碼 { get; set; }
        [CsvColumn(Name = "電子發票日期", FieldIndex = 28)]
        public string 無用_電子發票日期 { get; set; }
        [CsvColumn(Name = "贈品", FieldIndex = 29)]
        public string 無用_贈品 { get; set; }
        [CsvColumn(Name = "廠商配送訊息", FieldIndex = 30)]
        public string 無用_廠商配送訊息 { get; set; }
        [CsvColumn(Name = "預計入庫日期", FieldIndex = 31)]
        public string 無用_預計入庫日期 { get; set; }
        [CsvColumn(Name = "商品編號 ", FieldIndex = 32)]
        public string 無用_商品編號 { get; set; }

        public 回單號結構_森森(WokyTool.DataImport.出貨匯入結構_森森 From_)
        {
            無用 = From_.無用;
            訂單編號 = From_.訂單編號;
            無用_訂單序號 = From_.無用_訂單序號;
            無用_送貨單號 = From_.無用_送貨單號;
            無用_通路別 = From_.無用_通路別;
            無用_銷售編號 = From_.無用_銷售編號;
            平台商品編號 = From_.平台商品編號;
            無用_商品名稱 = From_.無用_商品名稱;
            無用_顏色 = From_.無用_顏色;
            款式 = From_.款式;
            無用_廠商料號 = From_.無用_廠商料號;
            訂單類別 = From_.訂單類別;
            數量 = From_.數量;
            無用_售價 = From_.無用_售價;
            無用_成本 = From_.無用_成本;
            姓名 = From_.姓名;
            手機 = From_.手機;
            電話 = From_.電話;
            地址 = From_.地址;
            無用_出貨指示日 = From_.無用_出貨指示日.ToShortDateString();
            無用_要求配送日 = From_.無用_要求配送日;
            無用_要求配送時間 = From_.無用_要求配送時間;
            備註 = From_.備註;
            無用_電子發票號碼 = From_.無用_電子發票號碼;
            無用_識別碼 = From_.無用_識別碼;
            無用_電子發票日期 = From_.無用_電子發票日期.ToShortDateString();
            無用_贈品 = From_.無用_贈品;
            無用_廠商配送訊息 = From_.無用_廠商配送訊息;
            無用_預計入庫日期 = From_.無用_預計入庫日期.ToShortDateString();
            無用_商品編號 = From_.無用_商品編號;

            switch (From_.配送公司)
            { 
                case 列舉.配送公司類型.全速配:
                    配送公司 = 字串.新竹物流;
                    break;
                case 列舉.配送公司類型.宅配通:
                    配送公司 = 字串.宅配通;
                    break;
                default:
                    MessageBox.Show("回單號結構_森森 can't find 配送公司 " + From_.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            
            配送單號 = From_.配送單號;
        }
    }
}
