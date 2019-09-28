using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.商品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 商品資料 : 可編號記錄資料
    {
        [JsonProperty]
        public int 大類編號
        {
            get
            {
                return 大類.編號;
            }
            set
            {
                大類 = 商品大類資料管理器.獨體.取得(value);
            }
        }

        [JsonProperty]
        public int 小類編號
        {
            get
            {
                return 小類.編號;
            }
            set
            {
                小類 = 商品小類資料管理器.獨體.取得(value);
            }
        }

        [JsonProperty]
        public int 品牌編號
        {
            get
            {
                return 品牌.編號;
            }
            set
            {
                品牌 = 物品品牌資料管理器.獨體.取得(value);
            }
        }

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

        [JsonProperty]
        [可匯出(名稱 = "組成")]
        public string 組成字串 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 進價 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 售價 { get; set; }

        [可匯出]
        [JsonProperty]
        public int 寄庫數量 { get; set; }

        [可匯出]
        [JsonProperty]
        public int 體積 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 成本 { get; set; }

        /********************************/

        public 商品大類資料 大類 { get; set; }

        public 商品小類資料 小類 { get; set; }

        public 物品品牌資料 品牌 { get; protected set; }

        public 公司資料 公司 { get; set; }

        public 客戶資料 客戶 { get; set; }

        [可匯出(名稱 = "大類")]
        public string 大類名稱 { get { return 大類.名稱; } }

        [可匯出(名稱 = "小類")]
        public string 小類名稱 { get { return 小類.名稱; } }

        [可匯出(名稱 = "品牌")]
        public string 品牌名稱 { get { return 品牌.名稱; } }

        [可匯出(名稱 = "公司")]
        public string 公司名稱 { get { return 公司.名稱; } }

        [可匯出(名稱 = "客戶")]
        public string 客戶名稱 { get { return 客戶.名稱; } }

        [可匯出]
        public decimal 利潤
        {
            get
            {
                return 進價 - 成本;
            }
        }

        /********************************/

        public 商品資料 Self { get { return this; } }

        public 商品資料()
        {
            大類 = 商品大類資料.空白;
            小類 = 商品小類資料.空白;
            品牌 = 物品品牌資料.空白;
            公司 = 公司資料.空白;
            客戶 = 客戶資料.空白;

        }

        public static readonly 商品資料 不篩選 = new 商品資料
        {
            編號 = 常數.不篩選資料編碼,

            大類 = 商品大類資料.不篩選,
            小類 = 商品小類資料.不篩選,
            品牌 = 物品品牌資料.不篩選,

            公司 = 公司資料.不篩選,
            客戶 = 客戶資料.不篩選,

            品號 = 字串.不篩選,
            名稱 = 字串.不篩選,
        };

        public static readonly 商品資料 空白 = new 商品資料
        {
            編號 = 常數.空白資料編碼,

            大類 = 商品大類資料.空白,
            小類 = 商品小類資料.空白,
            品牌 = 物品品牌資料.空白,

            公司 = 公司資料.空白,
            客戶 = 客戶資料.空白,

            品號 = 字串.無,
            名稱 = 字串.無,
        };

        public static 商品資料 錯誤 = new 商品資料
        {
            編號 = 常數.錯誤資料編碼,

            大類 = 商品大類資料.錯誤,
            小類 = 商品小類資料.錯誤,
            品牌 = 物品品牌資料.錯誤,

            公司 = 公司資料.錯誤,
            客戶 = 客戶資料.錯誤,

            品號 = 字串.錯誤,
            名稱 = 字串.錯誤,
        };

        public static 商品資料 折扣 = new 商品資料    //@@ check use
        {
            編號 = 常數.商品折扣資料編碼,

            大類 = 商品大類資料.空白,
            小類 = 商品小類資料.空白,
            品牌 = 物品品牌資料.空白,

            公司 = 公司資料.空白,
            客戶 = 客戶資料.空白,

            品號 = 字串.折扣,
            名稱 = 字串.折扣,
        };

        /********************************/

        public void 更新組成()
        {
            if (組成 == null || 組成.Count == 0)
            {
                組成 = null;
                組成字串 = 字串.空;
                成本 = 0;
                體積 = 0;
                品牌 = 物品品牌資料.空白;
            }
            else
            {
                物品合併資料.共用.清除();
                物品合併資料.共用.新增(this);

                組成字串 = 物品合併資料.共用.ToString();
                成本 = 物品合併資料.共用.成本;
                體積 = 物品合併資料.共用.體積;

                品牌 = 物品品牌資料.空白;
                foreach (商品組成資料 商品組成資料_ in 組成)
                {
                    物品品牌資料 Temp_ = 商品組成資料_.物品.品牌;
                    if (Temp_.編號 <= 0 || Temp_ == 品牌)
                        continue;

                    if (品牌 == 物品品牌資料.空白)
                        品牌 = Temp_;
                    else
                        品牌 = 物品品牌資料.混和;
                }
            }
        }

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (false == 大類.編號是否合法())
                檢查器_.錯誤(資料_, "大類不合法");

            if (false == 小類.編號是否合法())
                檢查器_.錯誤(資料_, "小類不合法");

            if (false == 公司.編號是否合法())
                檢查器_.錯誤(資料_, "公司不合法");

            if (false == 客戶.編號是否合法())
                檢查器_.錯誤(資料_, "客戶不合法");

            if (String.IsNullOrEmpty(名稱))
                檢查器_.錯誤(this, "名稱不合法");
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
            //@@ 平台訂單新增資料 需考慮所有新增資料
            //@@ 寄庫新增資料
        }
    }
}
