using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.平台訂單;
using WokyTool.單品;
using WokyTool.客戶;
using WokyTool.寄庫;
using WokyTool.通用;

namespace WokyTool.商品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 商品資料 : 可編號記錄資料
    {
        [JsonProperty]
        public int 公司編號
        {
            get
            {
                return 公司.編號;
            }
            set
            {
                公司 = 公司資料管理器.獨體.取得(value);
            }
        }

        [JsonProperty]
        public int 客戶編號
        {
            get
            {
                return 客戶.編號;
            }
            set
            {
                客戶 = 客戶資料管理器.獨體.取得(value);
            }
        }

        [可匯出]
        [JsonProperty]
        public string 品號 { get; set; }   // 對方使用的產品編號

        [可匯出]
        [JsonProperty]
        public string 名稱 { get; set; }    // 對方使用的產品名稱

        [JsonProperty]
        public List<商品組成資料> 組成 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 進價 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 售價 { get; set; }     //TODO 合併至 自訂售價列

        [可匯出]
        [JsonProperty]
        public List<自訂售價資料> 自訂售價列 { get; set; }

        [可匯出]
        [JsonProperty]
        public int 寄庫數量 { get; set; }

        /********************************/

        public 品類資料 品類 { get; private set; }

        public 供應商資料 供應商 { get; private set; }

        public 品牌資料 品牌 { get; private set; }

        public 公司資料 公司 { get; set; }

        public 客戶資料 客戶 { get; set; }

        [可匯出(名稱 = "品類")]
        public string 品類名稱 { get { return 品類.名稱; } }

        [可匯出(名稱 = "供應商")]
        public string 供應商名稱 { get { return 供應商.名稱; } }

        [可匯出(名稱 = "品牌")]
        public string 品牌名稱 { get { return 品牌.名稱; } }

        [可匯出(名稱 = "公司")]
        public string 公司名稱 { get { return 公司.名稱; } }

        [可匯出(名稱 = "客戶")]
        public string 客戶名稱 { get { return 客戶.名稱; } }

        [可匯出]
        public decimal 成本 { get; private set; }

        [可匯出(名稱 = "組成")]
        public string 組成字串 { get; private set; }

        [可匯出]
        public decimal 利潤
        {
            get
            {
                return 進價 - 成本;
            }
        }

        public decimal 取得售價(string 索引_)
        {
            if (自訂售價列 == null || string.IsNullOrEmpty(索引_))
                return 售價;

            return 自訂售價列.Where(Value => Value.索引.Equals(索引_)).Select(Value => Value.售價).DefaultIfEmpty(售價).First();
        }

        /********************************/

        public 商品資料 Self { get { return this; } }

        public 商品資料()
        {
            公司 = 公司資料.空白;
            客戶 = 客戶資料.空白;

            品類 = 品類資料.空白;
            供應商 = 供應商資料.空白;
            品牌 = 品牌資料.空白;
        }

        public static readonly 商品資料 不篩選 = new 商品資料
        {
            編號 = 常數.不篩選資料編碼,

            公司 = 公司資料.不篩選,
            客戶 = 客戶資料.不篩選,

            品類 = 品類資料.不篩選,
            供應商 = 供應商資料.不篩選,
            品牌 = 品牌資料.不篩選,

            品號 = 字串.不篩選,
            名稱 = 字串.不篩選,
        };

        public static readonly 商品資料 空白 = new 商品資料
        {
            編號 = 常數.空白資料編碼,

            公司 = 公司資料.空白,
            客戶 = 客戶資料.空白,

            品類 = 品類資料.空白,
            供應商 = 供應商資料.空白,
            品牌 = 品牌資料.空白,

            品號 = 字串.無,
            名稱 = 字串.無,
        };

        public static 商品資料 錯誤 = new 商品資料
        {
            編號 = 常數.錯誤資料編碼,

            公司 = 公司資料.錯誤,
            客戶 = 客戶資料.錯誤,

            品類 = 品類資料.錯誤,
            供應商 = 供應商資料.錯誤,
            品牌 = 品牌資料.錯誤,

            品號 = 字串.錯誤,
            名稱 = 字串.錯誤,
        };

        public static 商品資料 折扣 = new 商品資料    //@@ check use
        {
            編號 = 常數.商品折扣資料編碼,

            公司 = 公司資料.空白,
            客戶 = 客戶資料.空白,

            品類 = 品類資料.空白,
            供應商 = 供應商資料.空白,
            品牌 = 品牌資料.空白,

            品號 = 字串.折扣,
            名稱 = 字串.折扣,
        };

        /********************************/

        public void 更新組成()
        {
            成本 = 0;
            品牌 = 品牌資料.空白;
            組成字串 = 字串.空;

            if (組成 == null || 組成.Count == 0)
                return;

            StringBuilder SB_ = new StringBuilder();
            foreach (var Group_ in 組成.GroupBy(Value => Value.群組))
            {
                if (Group_.Key == 0)
                {
                    foreach (商品組成資料 資料_ in Group_)
                    {
                        成本 += 資料_.成本 * 資料_.數量;

                        if (SB_.Length != 0)
                            SB_.Append("&");

                        if (String.IsNullOrEmpty(資料_.單品.縮寫))
                            SB_.Append(資料_.單品.名稱);
                        else
                            SB_.Append(資料_.單品.縮寫);

                        if (資料_.數量 > 1)
                            SB_.Append("*").Append(資料_.數量);
                    }
                }
                else
                {
                    if (SB_.Length != 0)
                        SB_.Append("&");

                    decimal 最大成本_ = 0;
                    bool 非第一筆_ = false;
                    foreach (商品組成資料 資料_ in Group_)
                    {
                        if (非第一筆_)
                            SB_.Append(",");
                        非第一筆_ = true;

                        decimal 目前成本_ = 資料_.成本 * 資料_.數量;
                        if (目前成本_ > 最大成本_) 最大成本_ = 目前成本_;

                        if (String.IsNullOrEmpty(資料_.單品.縮寫))
                            SB_.Append(資料_.單品.名稱);
                        else
                            SB_.Append(資料_.單品.縮寫);

                        if (資料_.數量 > 1)
                            SB_.Append("*").Append(資料_.數量);
                    }

                    成本 += 最大成本_;
                }
            }

            組成字串 = SB_.ToString();

            HashSet<品類資料> 品類群_ = 組成.Select(Value => Value.單品.品類).Where(Value => Value.編號是否有值()).ToSet();
            switch (品類群_.Count)
            {
                case 0:
                    品類 = 品類資料.空白;
                    break;
                case 1:
                    品類 = 品類群_.First();
                    break;
                default:
                    品類 = 品類資料.混和;
                    break;
            }

            HashSet<供應商資料> 供應商群_ = 組成.Select(Value => Value.單品.供應商).Where(Value => Value.編號是否有值()).ToSet();
            switch (供應商群_.Count)
            {
                case 0:
                    供應商 = 供應商資料.空白;
                    break;
                case 1:
                    供應商 = 供應商群_.First();
                    break;
                default:
                    供應商 = 供應商資料.混和;
                    break;
            }

            HashSet<品牌資料> 品牌群_ = 組成.Select(Value => Value.單品.品牌).Where(Value => Value.編號是否有值()).ToSet();
            switch (品牌群_.Count)
            {
                case 0:
                    品牌 = 品牌資料.空白;
                    break;
                case 1:
                    品牌 = 品牌群_.First();
                    break;
                default:
                    品牌 = 品牌資料.混和;
                    break;
            }
        }

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (false == 公司.編號是否合法())
                檢查器_.錯誤(資料_, "公司不合法");

            if (false == 客戶.編號是否合法())
                檢查器_.錯誤(資料_, "客戶不合法");

            if (String.IsNullOrEmpty(名稱))
                檢查器_.錯誤(資料_, "名稱不合法");
            //else if (商品資料管理器.獨體.資料列舉2.Where(Value => Value.公司 == 公司 && Value.客戶 == 客戶 && Value != 參考_ && 名稱.Equals(Value.名稱)).Any())
            //    檢查器_.錯誤(資料_, "名稱重複"); //@@ 名稱是否該唯一 顏色??

            if (false == String.IsNullOrEmpty(品號) && 
                    商品資料管理器.獨體.資料列舉2.Where(Value => Value.公司 == 公司 && Value.客戶 == 客戶 && Value != 參考_ && 品號.Equals(Value.品號)).Any())
                檢查器_.錯誤(資料_, "品號重複");

            if (組成 != null)
            {
                foreach (商品組成資料 商品組成資料_ in 組成)
                    商品組成資料_.檢查合法(檢查器_, 資料_, 參考_);
            }  
            //@@ 是否允許組合為空
        }

        public override void 刪除檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;

            foreach (寄庫新增資料 寄庫新增資料_ in 寄庫新增資料管理器.獨體.資料列.Where(Value => Value.商品 == this))
            {
                檢查器_.錯誤(資料_, "資料綁定中:" + 寄庫新增資料_.ToString(false));
            }

            foreach (平台訂單新增資料 平台訂單新增資料_ in 平台訂單新增資料管理器.獨體.資料列舉2.Where(Value => Value.商品 == this))
            {
                檢查器_.錯誤(資料_, "資料綁定中:" + 平台訂單新增資料_.ToString(false));
            }

            //@@ 一般訂單
        }
    }
}
