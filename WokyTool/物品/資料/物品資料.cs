﻿using Newtonsoft.Json;
using System;
using System.Linq;
using WokyTool.Common;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.物品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 物品資料 : 可編號記錄資料
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
                大類 = 物品大類資料管理器.獨體.取得(value);
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
                小類 = 物品小類資料管理器.獨體.取得(value);
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

        [可匯出]
        [JsonProperty]
        public string 國際條碼 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 名稱 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 縮寫 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 類別 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 顏色 { get; set; }

        [可匯出]
        [JsonProperty]
        public int 體積 { get; set; }

        [可匯出]
        [JsonProperty]
        public int 庫存 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 庫存總成本 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 最後進貨成本 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 成本備註 { get; set; }

        /********************************/

        public 物品大類資料 大類 { get; set; }

        public 物品小類資料 小類 { get; set; }

        public 物品品牌資料 品牌 { get; set; }

        [可匯出(名稱 = "大類")]
        public string 大類名稱 { get { return 大類.名稱; } }

        [可匯出(名稱 = "小類")]
        public string 小類名稱 { get { return 小類.名稱; } }

        [可匯出(名稱 = "品牌")]
        public string 品牌名稱 { get { return 品牌.名稱; } }

        [可匯出]
        public decimal 成本
        {
            get
            {
                if (庫存 <= 0)
                    return 最後進貨成本;
                else
                    return 庫存總成本 / 庫存;
            }
        }

        /********************************/

        public 物品資料 Self { get { return this; } }

        public 物品資料()
        {
            大類 = 物品大類資料.空白;
            小類 = 物品小類資料.空白;
            品牌 = 物品品牌資料.空白;
        }

        public static readonly 物品資料 不篩選 = new 物品資料
        {
            編號 = 常數.不篩選資料編碼,

            大類 = 物品大類資料.不篩選,
            小類 = 物品小類資料.不篩選,
            品牌 = 物品品牌資料.不篩選,

            國際條碼 = 字串.空,

            名稱 = 字串.不篩選,
            縮寫 = 字串.不篩選,
            類別 = 字串.空,
            顏色 = 字串.空,

            體積 = 0,
            庫存 = 0,

            庫存總成本 = 0,
            最後進貨成本 = 0,
            成本備註 = 字串.空,
        };

        public static readonly 物品資料 空白 = new 物品資料
        {
            編號 = 常數.空白資料編碼,

            大類 = 物品大類資料.空白,
            小類 = 物品小類資料.空白,
            品牌 = 物品品牌資料.空白,

            國際條碼 = 字串.無,

            名稱 = 字串.無,
            縮寫 = 字串.無,
            類別 = 字串.無,
            顏色 = 字串.無,

            體積 = 0,
            庫存 = 0,

            庫存總成本 = 0,
            最後進貨成本 = 0,
            成本備註 = 字串.無,
        };

        public static 物品資料 錯誤 = new 物品資料
        {
            編號 = 常數.錯誤資料編碼,

            大類 = 物品大類資料.錯誤,
            小類 = 物品小類資料.錯誤,
            品牌 = 物品品牌資料.錯誤,

            國際條碼 = 字串.錯誤,

            名稱 = 字串.錯誤,
            縮寫 = 字串.錯誤,
            類別 = 字串.錯誤,
            顏色 = 字串.錯誤,

            體積 = 0,
            庫存 = 0,

            庫存總成本 = 0,
            最後進貨成本 = 0,
            成本備註 = 字串.錯誤,
        };

        /********************************/

        private static char[] 縮寫保留字元列 = new char[] { '*', '&', ',' };
        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (false == 大類.編號是否合法())
                檢查器_.錯誤(資料_, "大類不合法");

            if (false == 小類.編號是否合法())
                檢查器_.錯誤(資料_, "小類不合法");

            if (false == 品牌.編號是否合法())
                檢查器_.錯誤(資料_, "品牌不合法");

            if (String.IsNullOrEmpty(名稱))
                檢查器_.錯誤(this, "名稱不合法");
            else if (物品資料管理器.獨體.資料列舉2.Where(Value => Value != 參考_ && (名稱.Equals(Value.名稱) || 名稱.Equals(Value.縮寫))).Any())
                檢查器_.錯誤(資料_, "名稱重複");

            if (String.IsNullOrEmpty(縮寫))
                檢查器_.錯誤(資料_, "縮寫不合法");
            else if (物品資料管理器.獨體.資料列舉2.Where(Value => Value != 參考_ && (縮寫.Equals(Value.名稱) || 縮寫.Equals(Value.縮寫))).Any())
                檢查器_.錯誤(資料_, "縮寫重複");
            else if (縮寫.IndexOfAny(縮寫保留字元列) != -1)
                檢查器_.錯誤(資料_, "縮寫包含保留字元");

            // 有設定類別 則必須設定顏色
            if(false == String.IsNullOrEmpty(類別) && String.IsNullOrEmpty(顏色))
                檢查器_.錯誤(資料_, "有類別沒顏色");
        }

        public override void 刪除檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;

            foreach (商品資料 商品資料_ in 商品資料管理器.獨體.資料列舉2.Where(Value => Value.組成 != null && Value.組成.Where(Value2 => Value2.物品 == this).Any()))
            {
                檢查器_.錯誤(資料_, "資料綁定中:" + 商品資料_.ToString(false));
            }
        }
    }
}

