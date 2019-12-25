using Newtonsoft.Json;
using WokyTool.廠商;
using WokyTool.物品;
using WokyTool.通用;
using System;

namespace WokyTool.進貨
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 進貨新增匯入資料 : 可轉換資料<進貨新增資料>
    {
        [可匯入(名稱 = "類型", 說明 = "必要:一般/退貨重進/未開發平台")]
        [JsonProperty]
        public string 類型識別
        {
            get { return _類型識別; }
            set {
                _類型識別 = value;
                try 
                {
                    轉換.類型 = (列舉.進貨類型)Enum.Parse(typeof(列舉.進貨類型), value);
                }
                catch
                {
                   轉換.類型 = 列舉.進貨類型.錯誤;
                }
            }
        }

        [可匯入(名稱 = "廠商", 說明 = "必要")]
        [JsonProperty]
        public string 廠商識別
        {
            get { return _廠商識別; }
            set { 
                _廠商識別 = value;
                廠商 = 廠商資料管理器.獨體.取得(_廠商識別);
            }
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

        [可匯入(說明 = "必要")]
        [JsonProperty]
        public decimal 單價
        {
            get { return 轉換.單價; }
            set { 轉換.單價 = value; }
        }

        [可匯入]
        [JsonProperty]
        public string 備註
        {
            get { return 轉換.備註; }
            set { 轉換.備註 = value; }
        }

        /********************************/

        private string _類型識別;
        private string _廠商識別;
        private string _物品識別;

        public 列舉.進貨類型 類型
        {
            get { return 轉換.類型; }
            set { 轉換.類型 = value; }
        }

        public 廠商資料 廠商
        {
            get { return 轉換.廠商; }
            set { 轉換.廠商 = value; }
        }

        public 物品資料 物品
        {
            get { return 轉換.物品; }
            set { 轉換.物品 = value; }
        }

        public string 廠商名稱 { get { return 轉換.廠商.名稱; } }
        public string 物品名稱 { get { return 轉換.物品.名稱; } }
    }
}

