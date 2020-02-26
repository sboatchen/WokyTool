using Newtonsoft.Json;
using WokyTool.通用;

namespace WokyTool.盤點
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 盤點封存轉換 : 可封存資料
    {
        [JsonProperty]
        public int 單品編號
        {
            get { return 資料.單品.編號; }
        }

        [JsonProperty]
        public string 單品名稱
        {
            get { return 資料.單品.名稱; }
        }

        [JsonProperty]
        public string 單品縮寫
        {
            get { return 資料.單品.縮寫; }
        }

        [JsonProperty]
        public int 盤點前庫存
        {
            get { return 資料.單品.庫存; }
        }

        [JsonProperty]
        public int 大料架庫存
        {
            get { return 資料.大料架庫存; }
        }

        [JsonProperty]
        public int 小料架庫存
        {
            get { return 資料.小料架庫存; }
        }

        [JsonProperty]
        public int 萬通庫存
        {
            get { return 資料.萬通庫存; }
        }

        [JsonProperty]
        public int 更新庫存
        {
            get { return 資料.目前庫存; }
        }

        [JsonProperty]
        public string 備註
        {
            get { return 資料.備註; }
        }

        /********************************/

        public 盤點資料 資料 { get; set; }

        /********************************/

        public 盤點封存轉換(盤點資料 資料_)
        {
            資料 = 資料_;
        }
    }
}

