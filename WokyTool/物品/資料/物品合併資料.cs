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

namespace WokyTool.單品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 單品合併資料 : 基本資料
    {
        public static 單品合併資料 共用 = new 單品合併資料();

        public Dictionary<單品資料, int> 組成書 { get; private set; }
        public List<List<商品組成資料>> 群組列 { get; private set; }

        public int 體積 { get; private set; }

        public decimal 成本 { get; private set; }

        public 單品合併資料()
        {
            組成書 = new Dictionary<單品資料, int>();
            群組列 = new List<List<商品組成資料>>();
            體積 = 0;
            成本 = 0;
        }

        public void 新增(單品資料 單品資料_, int 數量_)
        {
            if (單品資料_.編號是否有值() == false || 數量_ == 0)
                return;

            if (數量_ < 0)
                throw new Exception("單品合併資料::數量小於0" + 數量_);

            成本 += 單品資料_.成本 * 數量_;

            int 目前數量_ = 0;
            if (組成書.TryGetValue(單品資料_, out 目前數量_))
            {
                組成書[單品資料_] = 目前數量_ + 數量_;
            }
            else
            {
                組成書.Add(單品資料_, 數量_);
            }
        }

        public void 新增(商品資料 商品資料_)
        {
            if (商品資料_.組成 == null)
                return;

            foreach (var Group_ in 商品資料_.組成.GroupBy(Value => Value.群組))
            {
                if (Group_.Key == 0)
                {
                    foreach (商品組成資料 商品組成資料_ in Group_)
                    {
                        新增(商品組成資料_.單品, 商品組成資料_.數量);
                    }
                }
                else
                {
                    List<商品組成資料> 新群組_ = Group_.ToList();
                    群組列.Add(新群組_);

                    成本 += 新群組_.Max(Value => Value.單品.成本 * Value.數量);
                }
            }
        }

        //@@
        public void 新增(商品資料 商品資料_, int 數量_)
        {
            if (商品資料_.組成 == null)
                return;

            foreach (var Item_ in 商品資料_.組成)
            {
                新增(Item_.單品, Item_.數量 * 數量_);
            }
        }

        //@@
        public void 新增_忽視錯誤(商品資料 商品資料_, int 數量_)
        {
            if (商品資料_.組成 == null)
                return;

            foreach (var Item_ in 商品資料_.組成)
            {
                單品資料 單品資料_ = Item_.單品;
                int 總數量_ = Item_.數量 * 數量_;

                if (單品資料_.編號是否有值() == false || 總數量_ <= 0)
                    return;

                int 目前數量_ = 0;
                if (組成書.TryGetValue(單品資料_, out 目前數量_))
                {
                    組成書[單品資料_] = 目前數量_ + 總數量_;
                }
                else
                {
                    組成書.Add(單品資料_, 總數量_);
                }
            }
        }

        //@@
        public void 新增(平台訂單新增資料 資料_)
        {
            新增(資料_.商品, 資料_.數量);
        }

        //@@
        public void 新增(一般訂單新增資料 資料_)
        {
            foreach (一般訂單新增組成資料 組成資料_ in 資料_.組成)
                新增(組成資料_.單品, 組成資料_.數量);
        }

        public void 清除()
        {
            組成書.Clear();
            體積 = 0;
            成本 = 0;
        }

        public override string ToString()
        {
            if (組成書.Count == 0)
                return 字串.空;

            var GroupQuery_ = 組成書.GroupBy(Pair => (string.IsNullOrEmpty(Pair.Key.類別)) ? 字串.無 : Pair.Key.類別);

            StringBuilder SB_ = new StringBuilder();
            foreach (var Group_ in GroupQuery_)
            {
                if (Group_.Key == 字串.無)
                {
                    foreach (var 單品組成_ in Group_)
                    {
                        if (SB_.Length > 0)
                            SB_.Append(" & ");

                        if (String.IsNullOrEmpty(單品組成_.Key.縮寫))
                            SB_.Append(單品組成_.Key.名稱);
                        else
                            SB_.Append(單品組成_.Key.縮寫);

                        SB_.Append("*").Append(單品組成_.Value);
                    }
                }
                else
                {
                    if (SB_.Length > 0)
                        SB_.Append(" & ");

                    SB_.Append(Group_.Key).Append("-");

                    bool isNotFirst_ = false;
                    foreach (var 單品組成_ in Group_)
                    {
                        if (isNotFirst_)
                            SB_.Append(",");
                        isNotFirst_ = true;

                        SB_.Append(單品組成_.Key.顏色);

                        SB_.Append("*").Append(單品組成_.Value);
                    }
                }
            }

            foreach (List<商品組成資料> 群組_ in 群組列)
            {
                if (SB_.Length > 0)
                    SB_.Append(" & ");

                bool isNotFirst_ = false;
                foreach (商品組成資料 資料_ in 群組_)
                {
                    if (isNotFirst_)
                        SB_.Append("|");
                    isNotFirst_ = true;

                    if (String.IsNullOrEmpty(資料_.單品.縮寫))
                        SB_.Append(資料_.單品.名稱);
                    else
                        SB_.Append(資料_.單品.縮寫);

                    SB_.Append("*").Append(資料_.數量);
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
                            單品 = 單品資料管理器.獨體.取得(組成_[0])
                        };

                        組成列_.Add(商品組成資料_);
                        continue;
                    }

                    if (同類別資料_.Contains(",") == false)
                    {
                        var 組成_ = 同類別資料_.Split('*');
                        單品資料 單品資料_ = 單品資料管理器.獨體.取得(組成_[0]);
                        if (單品資料_.編號是否有值())
                        {
                            商品組成資料 商品組成資料_ = new 商品組成資料
                            {
                                數量 = Int16.Parse(組成_[1]),
                                單品 = 單品資料_
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
                            單品 = 單品資料管理器.獨體.取得_類別(類別_, 組成_[0])
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
