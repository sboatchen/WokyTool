using Newtonsoft.Json;
using WokyTool.商品;
using WokyTool.通用;
using System.Collections.Generic;
using System.Linq;

namespace WokyTool.月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳商品資料 : 可編號記錄資料
    {
        [JsonProperty]
        public List<月結帳商品組成資料> 組成 { get; set; }

        [JsonProperty]
        public Dictionary<月結帳單品資料, int> 需求 { get; set; }

        public bool 初始化(Dictionary<int, 月結帳單品資料> 單品資料書_)
        {
            if (組成 == null || 組成.Count == 0)
            {
                return false;
            }

            需求 = new Dictionary<月結帳單品資料, int>();
            foreach (var 資料_ in 組成)
            {
                月結帳單品資料 單品_ = null;
                if (單品資料書_.TryGetValue(資料_.物品編號, out 單品_))
                {
                    需求.Add(單品_, 資料_.數量);
                }
            }

            return 需求.Count > 0;
        }
    }
}

