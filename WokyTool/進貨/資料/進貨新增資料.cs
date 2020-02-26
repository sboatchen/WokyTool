using Newtonsoft.Json;
using WokyTool.Common;
using WokyTool.單品;
using WokyTool.通用;

namespace WokyTool.進貨
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 進貨新增資料 : 新版可記錄資料
    {
        [JsonProperty]
        public 列舉.進貨類型 類型 { get; set; }

        [JsonProperty]
        public int 供應商編號
        {
            get
            {
                return 供應商.編號;
            }
            set
            {
                供應商 = 供應商資料管理器.獨體.取得(value);
            }
        }

        [JsonProperty]
        public int 單品編號
        {
            get
            {
                return 單品.編號;
            }
            set
            {
                單品 = 單品資料管理器.獨體.取得(value);
            }
        }

        [可匯出]
        [JsonProperty]
        public int 數量 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 單價 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 備註 { get; set; }

        /********************************/

        public 供應商資料 供應商 { get; set; }

        public 單品資料 單品 { get; set; }

        [可匯出(名稱 = "供應商")]
        public string 供應商名稱 { get { return 供應商.名稱; } }

        [可匯出(名稱 = "單品")]
        public string 單品名稱 { get { return 單品.名稱; } }

        public decimal 總金額
        {
            get
            {
                return 數量 * 單價;
            }
        }

        /********************************/

        public 進貨新增資料 Self { get { return this; } }

        public 進貨新增資料()
        {
            供應商 = 供應商資料.空白;
            單品 = 單品資料.空白;
        }

        public static readonly 進貨新增資料 空白 = new 進貨新增資料
        {
            類型 = 列舉.進貨類型.一般,

            供應商 = 供應商資料.空白,
            單品 = 單品資料.空白,

            數量 = 0,
            單價 = 0,
           
            備註 = 字串.無,
        };

        public static 進貨新增資料 錯誤 = new 進貨新增資料
        {
            類型 = 列舉.進貨類型.錯誤,

            供應商 = 供應商資料.錯誤,
            單品 = 單品資料.錯誤,

            數量 = 0,
            單價 = 0,
           
            備註 = 字串.錯誤,
        };

        /********************************/

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            //基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (列舉.進貨類型.錯誤 == 類型)
                檢查器_.錯誤(資料_, "類型錯誤");

            if (供應商.編號是否合法() == false)
                檢查器_.錯誤(資料_, "供應商不合法");

            if (單品.編號是否合法() == false)
                檢查器_.錯誤(資料_, "單品不合法");

            if (數量 <= 0)
                檢查器_.錯誤(資料_, "數量不合法");

            if (單價 < 0)
                檢查器_.錯誤(資料_, "單價不合法");
        }
    }
}

