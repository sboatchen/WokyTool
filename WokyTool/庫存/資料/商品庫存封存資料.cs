using Newtonsoft.Json;
using WokyTool.通用;

namespace WokyTool.庫存
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 商品庫存封存資料 : 可封存資料
    {
        [JsonProperty]
        public string 類型 { get; set; }

        [JsonProperty]
        public string 編號 { get; set; }

        [JsonProperty]
        public int 商品編號 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        [JsonProperty]
        public string 公司 { get; set; }

        [JsonProperty]
        public string 客戶 { get; set; }

        [JsonProperty]
        public int 異動 { get; set; }

        [JsonProperty]
        public int 庫存 { get; set; }

        [JsonProperty]
        public decimal 成本 { get; set; }

        [JsonProperty]
        public decimal 利潤 { get; set; }

        [JsonProperty]
        public decimal 進價 { get; set; }

        [JsonProperty]
        public decimal 售價 { get; set; }

        [JsonProperty]
        public string 備註 { get; set; }

        /********************************/

        public static readonly 商品庫存封存資料 空白 = new 商品庫存封存資料
        {
        };
    }
}

