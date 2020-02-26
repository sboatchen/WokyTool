using Newtonsoft.Json;
using WokyTool.單品;
using WokyTool.通用;

namespace WokyTool.商品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳商品組成資料 : 基本資料
    {
        [JsonProperty]
        public int 物品編號 { get; set; }

        [JsonProperty]
        public int 數量 { get; set; }
    }
}
