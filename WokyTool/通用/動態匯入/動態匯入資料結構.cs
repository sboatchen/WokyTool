using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 動態匯入資料結構 : MyData
    {
        public 動態匯入檔案結構 檔案結構 { get; set; }

        [JsonProperty]
        public List<object> 資料 { get; set; }

        public 動態匯入資料結構(動態匯入檔案結構 檔案結構_)
        {
            檔案結構 = 檔案結構_;
            資料 = new List<object>();

            // 設定資料皆從1開始，所以讀入的時候需塞入空白資料
            資料.Add(null);
        }
    }
}
