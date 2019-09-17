using Newtonsoft.Json;
using WokyTool.物品;
using WokyTool.通用;
using WokyTool.盤點;

namespace WokyTool.庫存
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 物品庫存封存資料 : 可封存資料
    {
        [JsonProperty]
        public int 物品編號
        {
            get { return 物品.編號; }
        }

        [JsonProperty]
        public string 物品名稱
        {
            get { return 物品.名稱; }
        }

        [JsonProperty]
        public string 物品縮寫
        {
            get { return 物品.縮寫; }
        }

        [JsonProperty]
        public int 庫存
        {
            get { return 物品.庫存; }
        }

        [JsonProperty]
        public decimal 最後進貨成本
        {
            get { return 物品.最後進貨成本; }
        }

        [JsonProperty]
        public decimal 庫存總成本
        {
            get { return 物品.庫存總成本; }
        }

        [JsonProperty]
        public string 備註 { get; set; }

        [JsonProperty]
        public decimal 成本
        {
            get
            {
                if (庫存 == 0)
                    return 最後進貨成本;
                else
                    return 庫存總成本 / 庫存;
            }
        }

        /********************************/

        public 物品資料 物品 { get; set; }

        /********************************/

        public static 物品庫存封存資料 建立(盤點資料 資料_)
        {
            if (資料_.目前庫存 == 資料_.物品.庫存)
                return null;

            return new 物品庫存封存資料
            {
                物品 = 資料_.物品,
                備註 = "盤點調整",
            };
        }

        public static 物品庫存封存資料 建立_寄庫(物品資料 資料_)
        {
            return new 物品庫存封存資料
            {
                物品 = 資料_,
                備註 = "寄庫",
            };
        }
    }
}

