using Newtonsoft.Json;
using WokyTool.物品;
using WokyTool.通用;
using System;

namespace WokyTool.活動
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 活動匯入資料 : 可轉換資料<活動資料>
    {
        [可匯入(說明 = "必要")]
        [JsonProperty]
        public DateTime 開始日期
        {
            get { return 轉換.開始日期; }
            set { 轉換.開始日期 = value; }
        }

        [可匯入(說明 = "必要")]
        [JsonProperty]
        public DateTime 結束日期
        {
            get { return 轉換.結束日期; }
            set { 轉換.結束日期 = value; }
        }

        [可匯入(說明 = "必要")]
        [JsonProperty]
        public string 名稱
        {
            get { return 轉換.名稱; }
            set { 轉換.名稱 = value; }
        }

        [可匯入(說明 = "必要")]
        [JsonProperty]
        public string 姓名
        {
            get { return 轉換.姓名; }
            set { 轉換.姓名 = value; }
        }

        [可匯入(名稱 = "物品", 說明 = "必要", 優先級 = 1, 識別 = true)]
        [JsonProperty]
        public string 物品識別
        {
            get { return _物品識別; }
            set { 
                _物品識別 = value;
                物品 = 物品資料管理器.獨體.取得(_物品識別);
            }
        }

        [可匯入(說明 = "必要")]
        [JsonProperty]
        public int 數量
        {
            get { return 轉換.數量; }
            set { 轉換.數量 = value; }
        }

        [可匯入]
        [JsonProperty]
        public string 備註
        {
            get { return 轉換.備註; }
            set { 轉換.備註 = value; }
        }

        /********************************/

        private string _物品識別;

        public 物品資料 物品
        {
            get { return 轉換.物品; }
            set { 轉換.物品 = value; }
        }

        public string 物品名稱 { get { return 轉換.物品.名稱; } }
    }
}

