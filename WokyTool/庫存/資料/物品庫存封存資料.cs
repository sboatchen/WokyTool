using Newtonsoft.Json;
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.通用;
using WokyTool.盤點;

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

        /********************************/

        public static 物品庫存封存資料 建立_盤點(物品資料 資料_)
        {
            return new 物品庫存封存資料
            {
                //物品 = 資料_,
                備註 = "盤點",
            };
        }

        public static 物品庫存封存資料 建立_寄庫(物品資料 資料_)
        {
            return new 物品庫存封存資料
            {
                //物品 = 資料_,
                備註 = "寄庫",
            };
        }
    }
}

