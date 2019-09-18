using Newtonsoft.Json;

namespace WokyTool.通用
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class 可匯入資料 : 基本資料
    {
        [JsonProperty]
        public string 錯誤訊息 { get; set; }
    }
}
