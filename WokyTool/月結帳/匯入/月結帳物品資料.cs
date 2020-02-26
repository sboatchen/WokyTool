using Newtonsoft.Json;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳單品資料 : 可編號記錄資料
    {
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
    }
}

