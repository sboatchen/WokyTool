﻿using Newtonsoft.Json;
using System;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.通用;
using WokyTool.盤點;

namespace WokyTool.庫存
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 物品庫存封存資料 : 可封存資料
    {
        [JsonProperty]
        public DateTime 處理時間 { get; set; }

        [JsonProperty]
        public int 物品編號
        {
            get { return 物品.編號; }
        }

        [JsonProperty]
        public string 物品名稱
        {
            get { return 物品.名稱; }
        }

        [JsonProperty]
        public string 物品縮寫
        {
            get { return 物品.縮寫; }
        }

        [JsonProperty]
        public int 數量 { get; set; }

        [JsonProperty]
        public decimal 價格 { get; set; }

        [JsonProperty]
        public decimal 庫存總成本 { get; set; }

        [JsonProperty]
        public string 備註 { get; set; }

        [JsonProperty]
        public string 更新者 { get; set; }

        /********************************/

        public 物品資料 物品 { get; set; }

        /********************************/

        public static 物品庫存封存資料 建立(盤點資料 資料_)
        {
            int 數量_ = 資料_.目前庫存 - 資料_.物品.庫存;
            if (數量_ == 0)
                return null;

            return new 物品庫存封存資料
            {
                處理時間 = DateTime.Now,
                物品 = 資料_.物品,
                數量 = 數量_,
                價格 = 0,
                庫存總成本 = 資料_.物品.庫存總成本,
                備註 = "盤點調整",
                更新者 = 系統參數.使用者名稱,
            };
        }
    }
}

