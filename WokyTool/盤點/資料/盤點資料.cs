using Newtonsoft.Json;
using System;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.盤點
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 盤點資料 : 可編號記錄資料
    {
        [可匯出]
        [JsonProperty]
        public override int 編號
        {
            get
            {
                return 物品.編號;
            }
            set
            {
                物品 = 物品資料管理器.獨體.取得(value);
            }
        }

        [可匯出]
        [JsonProperty]
        public int 大料架庫存 { get; set; }

        [可匯出]
        [JsonProperty]
        public int 小料架庫存 { get; set; }

        [可匯出]
        [JsonProperty]
        public int 萬通庫存 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 備註 { get; set; }

        /********************************/

        public 物品資料 物品 { get; set; }

        [可匯出(名稱 = "物品")]
        public string 物品名稱 { get { return 物品.名稱; } }

        [可匯出(名稱 = "目前庫存")]
        [JsonProperty]
        public int 目前庫存
        {
            get { return 物品.庫存; }
        }

        [可匯出(名稱 = "更新庫存")]
        [JsonProperty]
        public int 更新庫存
        {
            get { return 大料架庫存 + 小料架庫存 + 萬通庫存; }
        }

        /********************************/

        public 盤點資料 Self { get { return this; } }

        public 盤點資料()
        {
            物品 = 物品資料.空白;
        }

        public static readonly 盤點資料 空白 = new 盤點資料
        {
            物品 = 物品資料.空白,

            大料架庫存 = 0,
            小料架庫存 = 0,
            萬通庫存 = 0,

            備註 = 字串.無,
        };

        public static 盤點資料 錯誤 = new 盤點資料
        {
            物品 = 物品資料.錯誤,

            大料架庫存 = 0,
            小料架庫存 = 0,
            萬通庫存 = 0,

            備註 = 字串.空,
        };

        public static 盤點資料 建立(物品資料 資料_)
        {
            return new 盤點資料
            {
                物品 = 資料_,

                大料架庫存 = 0,
                小料架庫存 = 0,
                萬通庫存 = 0,

                備註 = 字串.空,
            };
        }

        /********************************/

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            //基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (編號是否有值() == false)
                檢查器_.錯誤(資料_, "物品不合法");

            if (大料架庫存 < 0)
                檢查器_.錯誤(資料_, "大料架庫存不合法");

            if (小料架庫存 < 0)
                檢查器_.錯誤(資料_, "小料架庫存不合法");

            if (萬通庫存 < 0)
                檢查器_.錯誤(資料_, "萬通庫存不合法");
        }
    }
}

