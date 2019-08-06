using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    [Serializable]
    public abstract class 新版可匯入資料<T> : 可編輯資料<T> where T : 基本資料
    {
        [JsonProperty]
        public string 錯誤訊息 { get; set; }
    }
}
