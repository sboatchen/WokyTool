using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.測試
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class 讀寫測試資料 : 新版可記錄資料<讀寫測試資料>, 可初始化介面, IEditableObject
    {
        [JsonProperty]
        public string 字串 { get; set; }

        [JsonProperty]
        public int 整數 { get; set; }

        [JsonProperty]
        public float 浮點數 { get; set; }

        [JsonProperty]
        public double 倍精準浮點數 { get; set; }

        [JsonProperty]
        public DateTime 時間 { get; set; }

        [JsonProperty]
        public 列舉.編號 列舉 { get; set; }

        [CsvColumn(Name = "測試用")]
        [JsonProperty]
        public int 列舉值 { get; set; }

        [JsonProperty]
        public List<int> 整數列 { get; set; }

        [JsonProperty]
        public Dictionary<int, string> 書 { get; set; }

        [JsonProperty]
        public Int32 整數2 { get; set; }

        [NonSerialized()]
        protected 讀寫測試資料 _副本;

        public 讀寫測試資料 Self
        {
            get { return this; }
        }

        /************************************************/

        public static 讀寫測試資料 空白資料 = new 讀寫測試資料
        {
            字串 = "空白",
            整數 = 常數.空白資料編碼,
        };

        public static 讀寫測試資料 錯誤資料 = new 讀寫測試資料
        {
            字串 = "錯誤",
            整數 = 常數.錯誤資料編碼,
        };

        /************************************************/

        public void 初始化() { ; }

        public void BeginEdit()
        {
            _副本 = null;
        }

        // IEditableObject
        public void CancelEdit()
        {
            _副本 = null;
        }

        // IEditableObject
        public void EndEdit()
        {
            _副本 = null;
        }
    }
}
