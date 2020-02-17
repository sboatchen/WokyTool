using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.商品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 舊商品資料 : 可編號記錄資料
    {
        [JsonProperty]
        public int 大類編號 { get; set; }

        [JsonProperty]
        public int 小類編號 { get; set; }

        [JsonProperty]
        public int 公司編號 { get; set; }

        [JsonProperty]
        public int 客戶編號 { get; set; }

        [JsonProperty]
        public string 品號 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        [JsonProperty]
        public List<舊商品組成資料> 組成 { get; set; }
        
        [JsonProperty]
        public decimal 進價 { get; set; }
        
        [JsonProperty]
        public decimal 售價 { get; set; }
        
        [JsonProperty]
        public int 寄庫數量 { get; set; }
        
        [JsonProperty]
        public int 體積 { get; set; }
        
        [JsonProperty]
        public decimal 成本 { get; set; }
        
        [JsonProperty]
        public Dictionary<string, decimal> 自訂售價書 { get; set; }

        public static 商品資料 轉換(舊商品資料 舊資料_)
        {
            return new 商品資料
            {
                編號 = 舊資料_.編號,

                大類編號 = 舊資料_.大類編號,
                小類編號 = 舊資料_.小類編號,
                公司編號 = 舊資料_.公司編號,
                客戶編號 = 舊資料_.客戶編號,

                品號 = 舊資料_.品號,
                名稱 = 舊資料_.名稱,

                進價 = 舊資料_.進價,
                售價 = 舊資料_.售價,
                //自訂售價列 = null, //沒資料

                寄庫數量 = 舊資料_.寄庫數量,

                組成 = (舊資料_.組成 == null)? null : 舊資料_.組成.Select(Value => 舊商品組成資料.轉換(Value)).ToList(),
            };
        }
    }
}
