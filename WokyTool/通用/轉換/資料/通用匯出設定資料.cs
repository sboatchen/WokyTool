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
    public class 通用匯出設定資料 : 基本資料
    {
        [JsonProperty]
        public string 預設檔名 { get; set; }

        [JsonProperty]
        public 列舉.檔案格式 檔案格式 { get; set; }

        [JsonProperty]
        public string 切檔方式 { get; set; }

        [JsonProperty]
        public string 分頁方式 { get; set; }

        [JsonProperty]
        public List<通用匯出欄位設定資料> 欄位列 { get; set; }

        public 通用匯出設定資料()
        {
            欄位列 = new List<通用匯出欄位設定資料>();
        }
    }
}
