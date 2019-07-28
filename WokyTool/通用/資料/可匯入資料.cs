using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    //@@@ 待整理
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class 可匯入資料 : 基本資料
    {
        [JsonProperty]
        public string 錯誤訊息 { get; set; }
    }
}
