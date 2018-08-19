using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 可匯入資料 : MyData
    {
        [JsonProperty]
        public string 錯誤訊息 { get; set; }
    }
}
