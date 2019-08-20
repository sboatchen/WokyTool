using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 通用匯出欄位設定資料 : 基本資料
    {
        [JsonProperty]
        public string 名稱 { get; set; }

        [JsonProperty]
        public string 屬性 { get; set; }

        public static readonly 通用匯出欄位設定資料 空白 = new 通用匯出欄位設定資料
        {
            名稱 = 字串.無,
            屬性 = 字串.無,
        };
    }
}
