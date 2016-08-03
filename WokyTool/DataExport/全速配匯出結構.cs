using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.DataImport;

namespace WokyTool.DataExport
{
    class 全速配匯出結構
    {
        [CsvColumn(Name = "序號", FieldIndex = 1)]
        public int 序號 { get; set; }
        [CsvColumn(Name = "來源表單編號", FieldIndex = 2)]
        public string 無用1 { get; set; }
        [CsvColumn(Name = "收件人姓名", FieldIndex = 3)]
        public string 姓名 { get; set; }
        [CsvColumn(Name = "收件人郵遞區號", FieldIndex = 4)]
        public string 無用2 { get; set; }
        [CsvColumn(Name = "收件人地址", FieldIndex = 5)]
        public string 地址 { get; set; }
        [CsvColumn(Name = "收件人電話(日)", FieldIndex = 6)]
        public string 電話 { get; set; }
        [CsvColumn(Name = "收件人電話(夜)", FieldIndex = 7)]
        public string 無用3 { get; set; }
        [CsvColumn(Name = "收件人行動電話", FieldIndex = 8)]
        public string 手機 { get; set; }
        [CsvColumn(Name = "購物車備註", FieldIndex = 9)]
        public string 備註 { get; set; }
        [CsvColumn(Name = "(商品編號)商品名稱", FieldIndex = 10)]
        public string 商品 { get; set; }
        [CsvColumn(Name = "商品料號", FieldIndex = 11)]
        public string 無用4 { get; set; }
        [CsvColumn(Name = "商品屬性", FieldIndex = 12)]
        public string 無用5 { get; set; }
        [CsvColumn(Name = "商品數量", FieldIndex = 13)]
        public int 數量_無用 { get; set; }
        [CsvColumn(Name = "審件等級", FieldIndex = 14)]
        public int 審件等級_無用 { get; set; }
        [CsvColumn(Name = "代收貨款", FieldIndex = 15)]
        public string 無用6 { get; set; }
        [CsvColumn(Name = "貨號", FieldIndex = 16)]
        public string 無用7 { get; set; }
        [CsvColumn(Name = "指配日期(yyyyMMdd)", FieldIndex = 17)]
        public string 指配日期 { get; set; }

        protected 可配送 _資料來源;

        public 全速配匯出結構(int 序號_, 可配送 From_)
        {
            _資料來源 = From_;
            序號 = 序號_;
            姓名 = From_.配送姓名;
            地址 = From_.配送地址;
            電話 = From_.配送電話;
            手機 = From_.配送手機;
            備註 = From_.配送備註;
            商品 = From_.配送商品;
            數量_無用 = 1;
            審件等級_無用 = 3;

            if (From_.指配日期.Ticks == 0)
                指配日期 = "";
            else
                指配日期 = From_.指配日期.ToString("yyyyMMdd");
        }

        // 更新配送單號
        public bool SetDeliveryNO(全速配匯入結構 Import_)
        {
            if (Import_.姓名.CompareTo(this.姓名) != 0)
                return false;

            _資料來源.SetDiliver(Import_.配送單號);
            return true;
        }

        // 清除配送單號 - 匯入失敗用
        public void CleanDeliveryNO()
        {
            _資料來源.SetDiliver(null);
        }
    }
}
