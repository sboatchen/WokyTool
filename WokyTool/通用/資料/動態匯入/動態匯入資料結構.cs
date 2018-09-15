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
        public Dictionary<String, object> 資料 { get; set; }

        [JsonProperty]
        public Dictionary<int, object> 詳細 { get; set; }

        public 動態匯入資料結構(動態匯入檔案結構 檔案結構_)
        {
            檔案結構 = 檔案結構_;
            資料 = new Dictionary<String, object>();
            詳細 = new Dictionary<int, object>();
        }

        public T Get<T>(String Key_)
        {
            object Data_;
            if(資料.TryGetValue(Key_, out Data_))
                return (T)Data_;
            return default(T);
        }
    }
}
