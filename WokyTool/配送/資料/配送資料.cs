using Newtonsoft.Json;
using System;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.配送
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 配送資料 : 新版可記錄資料, 可處理介面
    {
        [可匯出]
        [JsonProperty]
        public DateTime 處理時間 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 處理者 { get; set; }

        [可匯出]
        [JsonProperty]
        public virtual 列舉.配送公司 配送公司 { get; set; }

        [可匯出]
        [JsonProperty]
        public virtual string 配送單號 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 訂單編號 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 姓名 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 電話 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 手機 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 地址 { get; set; }

        [可匯出]
        [JsonProperty]
        public DateTime 指配日期 { get; set; }

        [可匯出]
        [JsonProperty]
        public 列舉.指配時段 指配時段 { get; set; }

        [可匯出]
        [JsonProperty]
        public 列舉.代收方式 代收方式 { get; set; }

        [可匯出]
        [JsonProperty]
        public virtual decimal 代收金額 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 備註 { get; set; }

        [可匯出]
        [JsonProperty]
        public int 件數 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 內容 { get; set; }

        /********************************/

        public 配送資料 Self { get { return this; } }

        public static readonly 配送資料 空白 = new 配送資料
        {
            處理時間 = default(DateTime),
            處理者 = 字串.無,

            配送公司 = 列舉.配送公司.無,
            配送單號 = 字串.無,

            姓名 = 字串.無,
            地址 = 字串.無,
            電話 = 字串.無,
            手機 = 字串.無,

            指配日期 = default(DateTime),
            指配時段 = 列舉.指配時段.無,

            代收方式 = 列舉.代收方式.無,
            代收金額 = 0,

            備註 = 字串.無,

            件數 = 0,
            內容 = 字串.無,
        };

        public static 配送資料 錯誤 = new 配送資料
        {
            處理時間 = default(DateTime),
            處理者 = 字串.錯誤,

            配送公司 = 列舉.配送公司.錯誤,
            配送單號 = 字串.錯誤,

            姓名 = 字串.錯誤,
            地址 = 字串.錯誤,
            電話 = 字串.錯誤,
            手機 = 字串.錯誤,

            指配日期 = default(DateTime),
            指配時段 = 列舉.指配時段.錯誤,

            代收方式 = 列舉.代收方式.錯誤,
            代收金額 = 0,

            備註 = 字串.錯誤,

            件數 = 0,
            內容 = 字串.錯誤,
        };

        /********************************/

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            //基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (列舉.是否有值((int)配送公司) == false)
                檢查器_.錯誤(資料_, "配送公司不合法");

            if (String.IsNullOrEmpty(配送單號))
                檢查器_.錯誤(資料_, "配送單號不合法");

            if (String.IsNullOrEmpty(姓名))
                檢查器_.錯誤(資料_, "姓名不合法");

            if (String.IsNullOrEmpty(地址))
                檢查器_.錯誤(資料_, "地址不合法");

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                檢查器_.錯誤(資料_, "電話/手機不合法");

            if (列舉.是否合法((int)指配時段) == false)
                檢查器_.錯誤(資料_, "指配時段不合法");

            if (列舉.是否合法((int)代收方式) == false)
                檢查器_.錯誤(資料_, "代收方式不合法");

            if (代收金額 < 0)
                檢查器_.錯誤(資料_, "代收金額不合法");

            if (件數 <= 0)
                檢查器_.錯誤(資料_, "件數不合法");
        }
    }
}
