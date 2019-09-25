using Newtonsoft.Json;
using WokyTool.通用;

namespace WokyTool.庫存
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 物品庫存封存資料 : 可封存資料
    {
        [JsonProperty]
        public string 類型 { get; set; }

        [JsonProperty]
        public string 編號 { get; set; }

        [JsonProperty]
        public int 物品編號 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        [JsonProperty]
        public string 縮寫 { get; set; }

        [JsonProperty]
        public string 公司 { get; set; }

        [JsonProperty]
        public string 客戶 { get; set; }

        [JsonProperty]
        public int 異動 { get; set; }

        [JsonProperty]
        public int 庫存 { get; set; }

        [JsonProperty]
        public decimal 最後進貨成本 { get; set; }

        [JsonProperty]
        public decimal 庫存總成本 { get; set; }

        [JsonProperty]
        public string 備註 { get; set; }

        /********************************/

        public decimal 成本
        {
            get
            {
                if (庫存 <= 0)
                    return 最後進貨成本;
                else
                    return 庫存總成本 / 庫存;
            }
        }
    }
}

