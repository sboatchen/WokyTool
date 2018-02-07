using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.DataMgr;

namespace WokyTool.Data
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 盤點歷史資料 : 可格式化_Csv
    {
        [JsonProperty]
        [CsvColumn(Name = "編號")]
        public int 編號 { get; set; }

        [JsonProperty]
        [CsvColumn(Name = "時間")]
        public DateTime 時間 { get; set; }

        [JsonProperty]
        [CsvColumn(Name = "物品編號")]
        public int 物品編號 { get; set; }

        [JsonProperty]
        [CsvColumn(Name = "數量")]
        public int 數量 { get; set; }

        [JsonProperty]
        [CsvColumn(Name = "類型")]
        public 列舉.盤點類型 類型 { get; set; }

        public static 盤點歷史資料 New(盤點資料 From_)
        {
            return new 盤點歷史資料
            {
                編號 = 編碼管理器.Instance.Get(列舉.編碼類型.盤點),
                時間 = From_.時間,
                物品編號 = From_.物品.編號,
                數量 = From_.數量,
                類型 = From_.類型,
            };
        }

    }
}
