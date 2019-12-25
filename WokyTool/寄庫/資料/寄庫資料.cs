using Newtonsoft.Json;
using System;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.寄庫
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 寄庫資料 : 新版可記錄資料, 可處理介面
    {
        [可匯出]
        [JsonProperty]
        public DateTime 處理時間 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 處理者 { get; set; }

        [可匯出]
        [JsonProperty]
        public DateTime 入庫時間 { get; set; }

        [JsonProperty]
        public string 公司 { get; set; }

        [JsonProperty]
        public string 客戶 { get; set; }

        [JsonProperty]
        public int 商品編號 { get; set; }

        [JsonProperty]
        public string 商品 { get; set; }

        [可匯出]
        [JsonProperty]
        public int 數量 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 成本 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 入庫單號 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 備註 { get; set; }

        /********************************/

        public 寄庫資料 Self { get { return this; } }

        public static readonly 寄庫資料 空白 = new 寄庫資料
        {
            處理時間 = default(DateTime),
            處理者 = 字串.空,

            入庫時間 = default(DateTime),

            公司 = 字串.空,
            客戶 = 字串.空,

            商品編號 = 常數.空白資料編碼,
            商品 = 字串.空,

            數量 = 0,
            成本 = 0,

            入庫單號 = 字串.空,
            備註 = 字串.空,
        };

        public static 寄庫資料 錯誤 = new 寄庫資料
        {
            處理時間 = default(DateTime),
            處理者 = 字串.錯誤,

            入庫時間 = default(DateTime),

            公司 = 字串.錯誤,
            客戶 = 字串.錯誤,

            商品編號 = 常數.錯誤資料編碼,
            商品 = 字串.錯誤,

            數量 = 0,
            成本 = 0,

            入庫單號 = 字串.錯誤,
            備註 = 字串.錯誤,
        };

        public static 寄庫資料 建立(寄庫新增資料 資料_)
        {
            return new 寄庫資料
            {
                處理時間 = DateTime.Now,
                處理者 = 系統參數.使用者名稱,

                入庫時間 = 資料_.入庫時間,

                公司 = 資料_.公司名稱,
                客戶 = 資料_.客戶名稱,

                商品編號 = 資料_.商品編號,
                商品 = 資料_.商品名稱,

                數量 = 資料_.數量,

                入庫單號 = 資料_.入庫單號,
                備註 = 資料_.備註,
            };
        }

        /********************************/

        /*public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            //基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (處理時間.Ticks == 0)
                檢查器_.錯誤(資料_, "處理時間不合法");

            if (公司.編號是否合法() == false)
                檢查器_.錯誤(資料_, "公司不合法");

            if (客戶.編號是否合法() == false)
                檢查器_.錯誤(資料_, "客戶不合法");

            if (商品.編號是否合法() == false)
                檢查器_.錯誤(資料_, "商品不合法");

            if (數量 <= 0)
                檢查器_.錯誤(資料_, "數量不合法");
        }*/
    }
}

