using Newtonsoft.Json;
using System;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.盤點
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 盤點封存資料 : 基本資料
    {
        [JsonProperty]
        public int 物品編號
        {
            get { return 資料.物品.編號; }
        }

        [JsonProperty]
        public string 物品名稱
        {
            get { return 資料.物品.名稱; }
        }

        [JsonProperty]
        public string 物品縮寫
        {
            get { return 資料.物品.縮寫; }
        }

        [JsonProperty]
        public int 盤點前庫存
        {
            get { return 資料.物品.庫存; }
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

        public 盤點資料 資料 { get; set; }

        public 盤點封存資料(盤點資料 資料_)
        {
            資料 = 資料_;
        }
    }
}

