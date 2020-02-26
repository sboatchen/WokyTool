using Newtonsoft.Json;
using WokyTool.通用;

namespace WokyTool.商品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 舊商品組成資料 : 基本資料
    {
        [JsonProperty]
        public int 物品編號 { get; set; }

        [JsonProperty]
        public int 數量 { get; set; }

        public static 商品組成資料 轉換(舊商品組成資料 舊資料_)
        {
            return new 商品組成資料 { 
                群組 = 0,
                規格 = null,
                單品編號 = 舊資料_.物品編號,
                數量 = 舊資料_.數量,
            };
        }
    }
}
