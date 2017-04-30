using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.Data
{
    //@@ 改道DataRecord
    public class 支出資料
    {
        [CsvColumn(Name = "結算時間", FieldIndex = 1)]
        public DateTime 結算時間 { get; set; }

        [CsvColumn(Name = "建立時間", FieldIndex = 2)]
        public DateTime 建立時間 { get; set; }
        [CsvColumn(Name = "編號", FieldIndex = 3)]
        public int 編號 { get; set; }
        [CsvColumn(Name = "類型", FieldIndex = 4)]
        public string 類型 { get; set; }

        [CsvColumn(Name = "廠商", FieldIndex = 5)]
        public string 廠商 { get; set; }
        [CsvColumn(Name = "物品", FieldIndex = 6)]
        public string 物品 { get; set; }

        [CsvColumn(Name = "數量", FieldIndex = 7)]
        public int 數量 { get; set; }
        [CsvColumn(Name = "單價", FieldIndex = 8)]
        public double 單價 { get; set; }
        [CsvColumn(Name = "總價", FieldIndex = 9)]
        public double 總價 { get; set; }

        [CsvColumn(Name = "幣值", FieldIndex = 10)]
        public string 幣值 { get; set; }
        [CsvColumn(Name = "匯率", FieldIndex = 11)]
        public double 匯率 { get; set; }
        [CsvColumn(Name = "總金額", FieldIndex = 12)]
        public int 總金額 { get; set; }

        [CsvColumn(Name = "備註", FieldIndex = 13)]
        public string 備註 { get; set; }

        public static 支出資料 New()
        {
            return new 支出資料
            {
                結算時間 = DateTime.Now,

                建立時間 = DateTime.Now,
                編號 = 0,
                類型 = 字串.空,

                廠商 = 字串.空,
                物品 = 字串.空,

                數量 = 0,
                單價 = 0,
                總價 = 0,

                幣值 = 字串.空,
                匯率 = 0,
                總金額 = 0,

                備註 = 字串.空,
            };
        }

        private static readonly 支出資料 _NULL = new 支出資料
        {
            結算時間 = new DateTime(0),
            建立時間 = new DateTime(0),
            編號 = 0,
            類型 = 字串.無,
            廠商 = 字串.無,
            物品 = 字串.無,
            數量 = 0,
            單價 = 0,
            總價 = 0,
            幣值 = 字串.空,
            匯率 = 0,
            總金額 = 0,
            備註 = 字串.空,
        };
        public static 支出資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 支出資料 _ERROR = new 支出資料
        {
            結算時間 = new DateTime(0),
            建立時間 = new DateTime(0),
            編號 = 0,
            類型 = 字串.錯誤,
            廠商 = 字串.錯誤,
            物品 = 字串.錯誤,
            數量 = 0,
            單價 = 0,
            總價 = 0,
            幣值 = 字串.錯誤,
            匯率 = 0,
            總金額 = 0,
            備註 = 字串.空,
        };
        public static 支出資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
