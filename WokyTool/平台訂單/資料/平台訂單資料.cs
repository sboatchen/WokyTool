using Newtonsoft.Json;
using System;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 平台訂單資料 : 新版可記錄資料
    {
        [可匯出]
        [JsonProperty]
        public DateTime 處理時間 { get; set; }

        [可匯出]
        [JsonProperty]
        public 列舉.訂單處理狀態 處理狀態 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 處理者 { get; set; }

        [JsonProperty]
        public int 公司編號
        {
            get
            {
                return 公司.編號;
            }
            set
            {
                公司 = 公司資料管理器.獨體.取得(value);
            }
        }

        [JsonProperty]
        public int 客戶編號
        {
            get
            {
                return 客戶.編號;
            }
            set
            {
                客戶 = 客戶資料管理器.獨體.取得(value);
            }
        }

        [JsonProperty]
        public int 商品編號
        {
            get
            {
                return 商品.編號;
            }
            set
            {
                商品 = 商品資料管理器.獨體.取得(value);
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
        public decimal 含稅單價 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 姓名 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 地址 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 電話 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 手機 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 訂單編號 { get; set; }

        [可匯出]
        [JsonProperty]
        public String 發票號碼 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 備註 { get; set; }

        [可匯出]
        [JsonProperty]
        public 列舉.配送公司 配送公司 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 配送單號 { get; set; }

        [可匯出]
        [JsonProperty]
        public DateTime 指配日期 { get; set; }     // 指配日期.Ticks == 0 代表不指定

        [可匯出]
        [JsonProperty]
        public 列舉.指配時段 指配時段 { get; set; }

        [可匯出]
        [JsonProperty]
        public 列舉.代收方式 代收方式 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 代收金額 { get; set; }

        [JsonProperty]
        public string[] 標頭 { get; set; }

        [JsonProperty]
        public string[] 內容 { get; set; }

        /********************************/

        public 公司資料 公司 { get; set; }

        public 客戶資料 客戶 { get; set; }

        public 商品資料 商品 { get; set; }

        [可匯出(名稱 = "公司")]
        public string 公司名稱 { get { return 公司.名稱; } }

        [可匯出(名稱 = "客戶")]
        public string 客戶名稱 { get { return 客戶.名稱; } }

        [可匯出(名稱 = "商品")]
        public string 商品名稱 { get { return 商品.名稱; } }

        /********************************/

        public 平台訂單資料 Self { get { return this; } }

        public 平台訂單資料()
        {
            公司 = 公司資料.空白;   //@@ 可以嘗試讓 下拉選單支援 null 資料
            客戶 = 客戶資料.空白;
            商品 = 商品資料.空白;
        }

        public static readonly 平台訂單資料 空白 = new 平台訂單資料
        {
            處理狀態 = 列舉.訂單處理狀態.新增,
            處理時間 = default(DateTime),
            處理者 = 字串.無,

            公司 = 公司資料.空白,
            客戶 = 客戶資料.空白,

            商品 = 商品資料.空白,

            數量 = 0,
            單價 = 0,
            含稅單價 = 0,

            姓名 = 字串.無,
            地址 = 字串.無,
            電話 = 字串.無,
            手機 = 字串.無,

            訂單編號 = 字串.無,
            發票號碼 = null,
            備註 = 字串.無,

            配送公司 = 列舉.配送公司.無,
            配送單號 = 字串.無,

            指配日期 = default(DateTime),
            指配時段 = 列舉.指配時段.無,

            代收方式 = 列舉.代收方式.無,
            代收金額 = 0,

            標頭 = null,
            內容 = null,
        };

        public static 平台訂單資料 錯誤 = new 平台訂單資料
        {
            處理狀態 = 列舉.訂單處理狀態.錯誤,
            處理時間 = default(DateTime),
            處理者 = 字串.錯誤,

            公司 = 公司資料.錯誤,
            客戶 = 客戶資料.錯誤,

            商品 = 商品資料.錯誤,

            數量 = 0,
            單價 = 0,
            含稅單價 = 0,

            姓名 = 字串.錯誤,
            地址 = 字串.錯誤,
            電話 = 字串.錯誤,
            手機 = 字串.錯誤,

            訂單編號 = 字串.錯誤,
            發票號碼 = 字串.錯誤,
            備註 = 字串.錯誤,

            配送公司 = 列舉.配送公司.錯誤,
            配送單號 = 字串.錯誤,

            指配日期 = default(DateTime),
            指配時段 = 列舉.指配時段.錯誤,

            代收方式 = 列舉.代收方式.錯誤,
            代收金額 = 0,

            標頭 = null,
            內容 = null,
        };

        /********************************/

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            //基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            /*if (列舉.訂單處理狀態.錯誤 == 處理狀態)
                檢查器_.錯誤(資料_, "處理錯誤");

            if (公司.編號是否合法() == false)
                檢查器_.錯誤(資料_, "公司不合法");

            if (客戶.編號是否合法() == false)
                檢查器_.錯誤(資料_, "客戶不合法");

            if (商品.編號是否合法() == false)
                檢查器_.錯誤(資料_, "商品不合法");

            if (String.IsNullOrEmpty(姓名))
                檢查器_.錯誤(資料_, "姓名不合法");

            if (String.IsNullOrEmpty(地址))
                檢查器_.錯誤(資料_, "地址不合法");

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                檢查器_.錯誤(資料_, "電話/手機不合法");

            if (String.IsNullOrEmpty(訂單編號))
                檢查器_.錯誤(資料_, "訂單編號不合法");*/
        }
    }
}

