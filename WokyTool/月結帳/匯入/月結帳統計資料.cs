using Newtonsoft.Json;

namespace WokyTool.月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳統計資料
    {
        [JsonProperty]
        public int 商品編號 { get; set; }

        [JsonProperty]
        public int 數量 { get; set; }
    }
}

