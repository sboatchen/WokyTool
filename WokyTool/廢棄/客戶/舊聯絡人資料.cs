using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;
using WokyTool.客戶;
using WokyTool.通用;
using WokyTool.聯絡人;

namespace WokyTool.捨棄
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 舊聯絡人資料
    {
        [JsonProperty]
        public int 編號 { get; set; }

        [JsonProperty]
        public string 姓名 { get; set; }

        [JsonProperty]
        public string 電話 { get; set; }

        [JsonProperty]
        public string 手機 { get; set; }

        [JsonProperty]
        public string 地址 { get; set; }

        public 聯絡人資料 新資料 { get; set; }

        public 聯絡人資料 轉換()
        {
            新資料 = new 聯絡人資料
            {
                編號 = 編號,
                姓名 = 姓名,
                電話 = 電話,
                手機 = 手機,
                地址 = 地址,
                客戶 = 客戶資料.錯誤,
                子客戶 = 子客戶資料.空白,
            };

            return 新資料;
        }
    }
}