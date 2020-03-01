using Newtonsoft.Json;
using WokyTool.單品;
using WokyTool.通用;
using System;

namespace WokyTool.預留
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 預留匯入資料 : 可轉換資料<預留資料>
    {
        [可匯入(說明 = "必要,如:2019-10-9")]
        [JsonProperty]
        public DateTime 開始日期
        {
            get { return 轉換.開始日期; }
            set { 轉換.開始日期 = value; }
        }

        [可匯入(說明 = "必要,如:2019-10-9")]
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

        [可匯入(名稱 = "單品", 說明 = "必要", 優先級 = 1, 識別 = true)]
        [JsonProperty]
        public string 單品識別
        {
            get { return _單品識別; }
            set { 
                _單品識別 = value;
                單品 = 單品資料管理器.獨體.取得(_單品識別);
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

        private string _單品識別;

        public 單品資料 單品
        {
            get { return 轉換.單品; }
            set { 轉換.單品 = value; }
        }

        public string 單品名稱 { get { return 轉換.單品.名稱; } }

        /********************************/

        public static readonly 預留匯入資料 空白 = new 預留匯入資料
        {
            轉換 = 預留資料.空白
        };
    }
}

