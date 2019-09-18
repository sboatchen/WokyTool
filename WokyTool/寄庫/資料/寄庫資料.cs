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
    public class 寄庫資料 : 新版可記錄資料
    {
        [可匯出]
        [JsonProperty]
        public DateTime 處理時間 { get; set; }

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
        public string 入庫單號 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 備註 { get; set; }

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

        public 寄庫資料 Self { get { return this; } }

        public 寄庫資料()
        {
            處理時間 = DateTime.Now;

            公司 = 公司資料.空白;   //@@ 可以嘗試讓 下拉選單支援 null 資料
            客戶 = 客戶資料.空白;
            商品 = 商品資料.空白;
        }

        public static readonly 寄庫資料 空白 = new 寄庫資料
        {
            處理時間 = default(DateTime),

            公司 = 公司資料.空白,
            客戶 = 客戶資料.空白,

            商品 = 商品資料.空白,
            數量 = 0,

            入庫單號 = null,
            備註 = 字串.無,
        };

        public static 寄庫資料 錯誤 = new 寄庫資料
        {
            處理時間 = default(DateTime),

            公司 = 公司資料.錯誤,
            客戶 = 客戶資料.錯誤,

            商品 = 商品資料.錯誤,
            數量 = 0,

            入庫單號 = 字串.錯誤,
            備註 = 字串.錯誤,
        };

        /********************************/

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
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
        }
    }
}

