using Newtonsoft.Json;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.庫存
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 商品庫存封存資料 : 可封存資料
    {
        [JsonProperty]
        public int 商品編號
        {
            get { return 商品.編號; }
        }

        [JsonProperty]
        public string 商品名稱
        {
            get { return 商品.名稱; }
        }

        [JsonProperty]
        public string 公司名稱
        {
            get { return 商品.公司名稱; }
        }

        [JsonProperty]
        public string 客戶名稱
        {
            get { return 商品.客戶名稱; }
        }

        [JsonProperty]
        public int 庫存
        {
            get { return 商品.寄庫數量; }
        }

        [JsonProperty]
        public string 備註 { get; set; }

        [JsonProperty]
        public decimal 成本
        {
            get { return 商品.成本; }
        }

        /********************************/

        public 商品資料 商品 { get; set; }

        /********************************/

        public static 商品庫存封存資料 建立_寄庫(商品資料 資料_)
        {
            return new 商品庫存封存資料
            {
                商品 = 資料_,
                備註 = "寄庫",
            };
        }
    }
}

