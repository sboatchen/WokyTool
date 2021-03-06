﻿using Newtonsoft.Json;
using System;
using System.Linq;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.單品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 品牌資料 : 可編號記錄資料
    {
        [可匯出]
        [JsonProperty]
        public string 名稱 { get; set; }

        /********************************/

        public 品牌資料 Self { get { return this; } }

        public static 品牌資料 不篩選 = new 品牌資料
        {
            編號 = 常數.不篩選資料編碼,
            名稱 = 字串.不篩選,
        };

        public static readonly 品牌資料 空白 = new 品牌資料
        {
            編號 = 常數.空白資料編碼,
            名稱 = 字串.無,
        };

        public static 品牌資料 錯誤 = new 品牌資料
        {
            編號 = 常數.錯誤資料編碼,
            名稱 = 字串.錯誤,
        };

        public static 品牌資料 混和 = new 品牌資料
        {
            編號 = 常數.混和資料編碼,
            名稱 = 字串.混和,
        };

        /********************************/

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (String.IsNullOrEmpty(名稱))
                檢查器_.錯誤(資料_, "名稱不合法");
            else if (品牌資料管理器.獨體.資料列舉2.Where(Value => Value != 參考_ && 名稱.Equals(Value.名稱)).Any())
                檢查器_.錯誤(資料_, "名稱重複");
        }

        public override void 刪除檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;

            foreach (單品資料 單品資料_ in 單品資料管理器.獨體.資料列舉2.Where(Value => Value.品牌 == this))
            {
                檢查器_.錯誤(資料_, "資料綁定中:" + 單品資料_.ToString(false));
            }
        }
    }
}
