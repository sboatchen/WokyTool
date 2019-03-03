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
    public class 物品合併資料 : MyData
    {
        public Dictionary<物品資料, int> Map { get; private set; }

        public int 體積 { get; private set; }

        public 物品合併資料()
        {
            Map = new Dictionary<物品資料, int>();
            體積 = 0;
        }

        public 物品合併資料(商品資料 商品資料_)
        {
            新增(商品資料_);
        }

        public void 新增(物品資料 物品資料_, int 數量_)
        {
            if (物品資料_.編號是否有值() == false || 數量_ == 0)
                return;

            if (數量_ < 0)
                throw new Exception("物品合併資料::數量小於0" + 數量_);

            體積 += 物品資料_.體積 * 數量_;

            int 目前數量_ = 0;
            if (Map.TryGetValue(物品資料_, out 目前數量_))
            {
                Map[物品資料_] = 目前數量_ + 數量_;
            }
            else
            {
                Map.Add(物品資料_, 數量_);
            }
        }

        public void 新增(商品資料 商品資料_)
        {
            if (商品資料_.組成 == null)
                return;

            foreach (var Item_ in 商品資料_.組成)
            {
                新增(Item_.物品, Item_.數量);
            }
        }

        public void 新增(商品資料 商品資料_, int 數量_)
        {
            if (商品資料_.組成 == null)
                return;

            foreach (var Item_ in 商品資料_.組成)
            {
                新增(Item_.物品, Item_.數量 * 數量_);
            }
        }

        public void 清除()
        {
            Map.Clear();
        }

        public override string ToString()
        {
            if (Map.Count == 0)
                return 字串.空;

            StringBuilder sb = new StringBuilder();
            foreach (var Pair_ in Map)
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
