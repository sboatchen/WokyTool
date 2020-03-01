using Newtonsoft.Json;
using System.Collections.Generic;

namespace WokyTool.客戶
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 舊客戶資料
    {
        [JsonProperty]
        public int 編號 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        [JsonProperty]
        public List<int> 聯絡人編號列 { get; set; }

        [JsonProperty]
        public List<int> 子客戶編號列 { get; set; }

        public 客戶資料 新資料 { get; set; }

        public 客戶資料 轉換()
        {
            新資料 = new 客戶資料
            {
                編號 = 編號,
                名稱 = 名稱,
            };

            return 新資料; 
        }
    }
}

