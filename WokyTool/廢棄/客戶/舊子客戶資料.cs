﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.廢棄
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 舊子客戶資料
    {
        [JsonProperty]
        public int 編號 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        [JsonProperty]
        public List<int> 聯絡人編號列 { get; set; }

        public 子客戶資料 新資料 { get; set; }

        public 子客戶資料 轉換()
        {
            新資料 = new 子客戶資料
            {
                編號 = 編號,
                名稱 = 名稱,
                客戶 = 客戶資料.錯誤,
            };

            return 新資料;
        }
    }
}
