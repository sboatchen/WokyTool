﻿using Newtonsoft.Json;
using System;

namespace WokyTool.通用
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class 可封存資料 : 可編輯資料, 可處理介面
    {
        [JsonProperty]
        public DateTime 處理時間 { get; set; }

        [JsonProperty]
        public string 處理者 { get; set; }

        public 可封存資料()
        {
            處理時間 = DateTime.Now;
            處理者 = 系統參數.使用者名稱;
        }

        public override void 取消編輯()
        {
        }

        public override void 紀錄編輯(bool 是否列印_ = false)
        {
        }

        public override bool 更新編輯狀態()
        {
            return false;
        }
    }
}
