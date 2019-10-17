using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WokyTool.Common;
using WokyTool.一般訂單;
using WokyTool.平台訂單;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.物品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 物品合併資料 : 基本資料
    {
        public static 物品合併資料 共用 = new 物品合併資料();

        public Dictionary<物品資料, int> Map { get; private set; }

        public int 體積 { get; private set; }

        public decimal 成本 { get; private set; }

        public 物品合併資料()
        {
            Map = new Dictionary<物品資料, int>();
            體積 = 0;
            成本 = 0;
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
            成本 += 物品資料_.成本 * 數量_;

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

        public void 新增_忽視錯誤(商品資料 商品資料_, int 數量_)
        {
            if (商品資料_.組成 == null)
                return;

            foreach (var Item_ in 商品資料_.組成)
            {
                物品資料 物品資料_ = Item_.物品;
                int 總數量_ = Item_.數量 * 數量_;

                if (物品資料_.編號是否有值() == false || 總數量_ <= 0)
                    return;

                int 目前數量_ = 0;
                if (Map.TryGetValue(物品資料_, out 目前數量_))
                {
                    Map[物品資料_] = 目前數量_ + 總數量_;
                }
                else
                {
                    Map.Add(物品資料_, 總數量_);
                }
            }
        }

        public void 新增(平台訂單新增資料 資料_)
        {
            新增(資料_.商品, 資料_.數量);
        }

        public void 新增(一般訂單新增資料 資料_)
        {
            foreach (一般訂單新增組成資料 組成資料_ in 資料_.組成列)
                新增(組成資料_.商品, 組成資料_.數量);
        }

        public void 清除()
        {
            Map.Clear();
            體積 = 0;
            成本 = 0;
        }

        public override string ToString()
        {
            if (Map.Count == 0)
                return 字串.空;

            var GroupQuery_ = Map.GroupBy(Pair => (string.IsNullOrEmpty(Pair.Key.類別)) ? 字串.無 : Pair.Key.類別);

            StringBuilder SB_ = new StringBuilder();
            foreach (var Group_ in GroupQuery_)
            {
                if (Group_.Key == 字串.無)
                {
                    foreach (var 物品組成_ in Group_)
                    {
                        if (SB_.Length > 0)
                            SB_.Append(" & ");

                        if (String.IsNullOrEmpty(物品組成_.Key.縮寫))
                            SB_.Append(物品組成_.Key.名稱);
                        else
                            SB_.Append(物品組成_.Key.縮寫);

                        SB_.Append("*").Append(物品組成_.Value);
                    }
                }
                else
                {
                    if (SB_.Length > 0)
                        SB_.Append(" & ");

                    SB_.Append(Group_.Key).Append("-");

                    bool isNotFirst_ = false;
                    foreach (var 物品組成_ in Group_)
                    {
                        if (isNotFirst_)
                            SB_.Append(",");
                        isNotFirst_ = true;

                        SB_.Append(物品組成_.Key.顏色);

                        SB_.Append("*").Append(物品組成_.Value);
                    }
                }
            }

            return SB_.ToString();
        }

        public List<商品組成資料> 解構(string 組成字串_)
        {
            if (string.IsNullOrEmpty(組成字串_))
                return null;

            try
            {
                var 類別列_ = 組成字串_.Split(new string[] { " & ", "&" }, Int16.MaxValue, StringSplitOptions.None);

                List<商品組成資料> 組成列_ = new List<商品組成資料>();
                foreach (string 同類別資料_ in 類別列_)
                {
                    int 類別索引_ = 同類別資料_.IndexOf('-');
                    if (類別索引_ == -1)
                    {
                        var 組成_ = 同類別資料_.Split('*');
                        商品組成資料 商品組成資料_ = new 商品組成資料
                        {
                            數量 = Int16.Parse(組成_[1]),
                            物品 = 物品資料管理器.獨體.取得(組成_[0])
                        };

                        組成列_.Add(商品組成資料_);
                        continue;
                    }

                    if (同類別資料_.Contains(",") == false)
                    {
                        var 組成_ = 同類別資料_.Split('*');
                        物品資料 物品資料_ = 物品資料管理器.獨體.取得(組成_[0]);
                        if (物品資料_.編號是否有值())
                        {
                            商品組成資料 商品組成資料_ = new 商品組成資料
                            {
                                數量 = Int16.Parse(組成_[1]),
                                物品 = 物品資料_
                            };

                            組成列_.Add(商品組成資料_);
                            continue;
                        }
                    }

                    string 類別_ = 同類別資料_.Substring(0, 類別索引_);
                    string 顏色資料群_ = 同類別資料_.Substring(類別索引_ + 1);

                    var 顏色資料列_ = 顏色資料群_.Split(',');
                    foreach (string 顏色資料_ in 顏色資料列_)
                    {
                        var 組成_ = 顏色資料_.Split('*');
                        商品組成資料 商品組成資料_ = new 商品組成資料
                        {
                            數量 = Int16.Parse(組成_[1]),
                            物品 = 物品資料管理器.獨體.取得_類別(類別_, 組成_[0])
                        };

                        組成列_.Add(商品組成資料_);
                    }
                }

                return 組成列_;
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.通知("解析錯誤:" + 組成字串_);
                throw ex;
            }
        }

        public 列舉.配送公司 推薦配送公司 
        {
            get
            {
                return 列舉.配送公司.宅配通;
                /*if (體積 >= 常數.宅配通配送最小體積)
                    return 列舉.配送公司.宅配通;
                else
                    return 列舉.配送公司.全速配;*/
            }
        }
    }
}
