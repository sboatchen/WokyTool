using Newtonsoft.Json;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.通用;
using System;

namespace WokyTool.預留
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 預留資料 : 新版可記錄資料
    {
        [可匯出]
        [JsonProperty]
        public DateTime 開始日期 { get; set; }

        [可匯出]
        [JsonProperty]
        public DateTime 結束日期 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 名稱 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 姓名 { get; set; }

        [JsonProperty]
        public int 物品編號
        {
            get
            {
                return 物品.編號;
            }
            set
            {
                物品 = 物品資料管理器.獨體.取得(value);
            }
        }

        [可匯出]
        [JsonProperty]
        public int 數量 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 備註 { get; set; }

        /********************************/

        public 物品資料 物品 { get; set; }

        [可匯出(名稱 = "物品")]
        public string 物品名稱 { get { return 物品.名稱; } }

        public bool 是否保留中 
        { 
            get
            {
                return 時間.今天 >= 開始日期 && 時間.今天 <= 結束日期;
            }
        }

        public string 合併識別
        {
            get
            {
                return String.Format("{0}_{1}_{2}_{3}", 開始日期, 結束日期, 名稱, 姓名);
            }
        }

        /********************************/

        public 預留資料 Self { get { return this; } }

        public 預留資料()
        {
            物品 = 物品資料.空白;
        }

        public static readonly 預留資料 空白 = new 預留資料
        {
            開始日期 = default(DateTime),
            結束日期 = default(DateTime),

            名稱 = 字串.無,
            姓名 = 字串.無,

            物品 = 物品資料.空白,
            數量 = 0,
           
            備註 = 字串.無,
        };

        public static 預留資料 錯誤 = new 預留資料
        {
            開始日期 = default(DateTime),
            結束日期 = default(DateTime),

            名稱 = 字串.錯誤,
            姓名 = 字串.錯誤,

            物品 = 物品資料.錯誤,
            數量 = 0,

            備註 = 字串.錯誤,
        };

        /********************************/

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            //基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (開始日期 > 結束日期)
                檢查器_.錯誤(this, "預留日期不合法");

            if (String.IsNullOrEmpty(名稱))
                檢查器_.錯誤(this, "名稱不合法");

            if (String.IsNullOrEmpty(姓名))
                檢查器_.錯誤(this, "姓名不合法");

            if (物品.編號是否合法() == false)
                檢查器_.錯誤(資料_, "物品不合法");

            if (數量 <= 0)
                檢查器_.錯誤(資料_, "數量不合法");
        }
    }
}

