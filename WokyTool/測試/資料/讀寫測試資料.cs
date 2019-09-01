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
    public class 讀寫測試資料 : 新版可記錄資料<讀寫測試資料>, 可初始化介面
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
        private DateTime _時間;
        public DateTime 時間 
        {
            get
            {
                if (_時間 == null)
                    return DateTime.MinValue;
                return _時間.AddDays(123);
            }
            set
            {
                _時間 = value;
            }
        }

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

        public 讀寫測試資料 Self
        {
            get { return this; }
        }

        /************************************************/

        public static 讀寫測試資料 不篩 = new 讀寫測試資料
        {
            編號 = 常數.不篩資料編碼,
            字串 = Common.字串.不篩選,
        };

        public static 讀寫測試資料 空白 = new 讀寫測試資料
        {
            編號 = 常數.空白資料編碼,
            字串 = Common.字串.空白,
        };

        public static 讀寫測試資料 錯誤 = new 讀寫測試資料
        {
            編號 = 常數.錯誤資料編碼,
            字串 = Common.字串.錯誤,
        };

        /************************************************/

        public void 初始化() { ; }

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            //基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (整數 < 0)
                檢查器_.錯誤(資料_, "整數不合法");

            if (浮點數 < 0)
                檢查器_.錯誤(資料_, "浮點數不合法");
        }

        public override void 刪除檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;

            if(列舉 == 通用.列舉.編號.公司)
                檢查器_.錯誤(資料_, "刪除測試");
        }
    }
}
