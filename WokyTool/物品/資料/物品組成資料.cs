using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.物品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 物品組成資料 : MyData
    {
        public Dictionary<物品資料, int> 組合 { get; private set; }

        public 物品組成資料()
        {
            組合 = new Dictionary<物品資料, int>();
        }

        public 物品組成資料(商品資料 商品資料_)
        {
            append(商品資料_);
        }

        public void append(物品資料 物品資料_, int 數量_)
        {
            if (物品資料_.編號是否有值() == false || 數量_ == 0)
                return;

            if (數量_ < 0)
                throw new Exception("物品組成資料::數量小於0" + 數量_);

            int 目前數量_ = 0;
            if (組合.TryGetValue(物品資料_, out 目前數量_))
            {
                目前數量_ += 數量_;
            }
            else
            {
                組合.Add(物品資料_, 數量_);
            }
        }

        public void append(商品資料 商品資料_)
        {
            append(商品資料_.需求1, 商品資料_.數量1);
            append(商品資料_.需求2, 商品資料_.數量2);
            append(商品資料_.需求3, 商品資料_.數量3);
            append(商品資料_.需求4, 商品資料_.數量1);
            append(商品資料_.需求5, 商品資料_.數量5);
        }

        public string 取得組合字串()
        {
            if (組合.Count == 0)
                return 字串.空;

            StringBuilder sb = new StringBuilder();
            foreach (var Pair_ in 組合)
            {
                if (sb.Length > 0)
                    sb.Append("+");

                sb.Append(Pair_.Key.縮寫);
                if (Pair_.Value == 1)
                    continue;

                sb.Append("*").Append(Pair_.Value);
            }

            return sb.ToString();
        }
    }
}
