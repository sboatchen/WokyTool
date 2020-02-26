using Newtonsoft.Json;
using WokyTool.通用;

namespace WokyTool.單品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 舊單品資料 : 可編號記錄資料
    {
        [JsonProperty]
        public int 大類編號
        {
            get
            {
                return 品類.編號;
            }
            set
            {
                品類 = 品類資料管理器.獨體.取得(value);
            }
        }

        [JsonProperty]
        public int 小類編號
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
        public int 品牌編號
        {
            get
            {
                return 品牌.編號;
            }
            set
            {
                品牌 = 品牌資料管理器.獨體.取得(value);
            }
        }

        [可匯出]
        [JsonProperty]
        public string 國際條碼 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 名稱 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 縮寫 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 類別 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 顏色 { get; set; }

        [可匯出]
        [JsonProperty]
        public int 庫存 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 庫存總成本 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 最後進貨成本 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 成本備註 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 儲位 { get; set; }

        [可匯出]
        public int 保留 { get; set; }

        /********************************/

        public 品類資料 品類 { get; set; }

        public 供應商資料 供應商 { get; set; }

        public 品牌資料 品牌 { get; set; }

        /********************************/

        public 舊單品資料()
        {
            品類 = 品類資料.空白;
            供應商 = 供應商資料.空白;
            品牌 = 品牌資料.空白;
        }

        public static 單品資料 轉換(舊單品資料 舊資料_)
        {
            return new 單品資料
            {
                編號 = 舊資料_.編號,

                品類 = 舊資料_.品類,
                供應商 = 舊資料_.供應商,
                品牌 = 舊資料_.品牌,

                國際條碼 = 舊資料_.國際條碼,

                名稱 = 舊資料_.名稱,
                縮寫 = 舊資料_.縮寫,

                類別 = 舊資料_.類別,
                顏色 = 舊資料_.顏色,

                庫存 = 舊資料_.庫存,
                庫存總成本 = 舊資料_.庫存總成本,
                最後進貨成本 = 舊資料_.最後進貨成本,
                成本備註 = 舊資料_.成本備註,

                儲位 = 舊資料_.儲位,
                保留 = 舊資料_.保留,
            };
        }
    }
}

