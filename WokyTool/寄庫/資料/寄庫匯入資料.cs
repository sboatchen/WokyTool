using Newtonsoft.Json;
using System;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.寄庫
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 寄庫匯入資料 : 可轉換資料<寄庫資料>
    {
        [可匯出]
        [JsonProperty]
        public DateTime 處理時間
        {
            get { return 轉換.處理時間; }
            set { 轉換.處理時間 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 商品識別
        {
            get { return _商品識別; }
            set { _商品識別 = value; }
        }

        [可匯出]
        [JsonProperty]
        public int 數量
        {
            get { return 轉換.數量; }
            set { 轉換.數量 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 入庫單號
        {
            get { return 轉換.入庫單號; }
            set { 轉換.入庫單號 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 備註
        {
            get { return 轉換.備註; }
            set { 轉換.備註 = value; }
        }

        /********************************/

        private string _商品識別;

        public 公司資料 公司
        {
            get { return 轉換.公司; }
            set { 轉換.公司 = value; }
        }

        public 客戶資料 客戶
        {
            get { return 轉換.客戶; }
            set { 轉換.客戶 = value; }
        }

        public 商品資料 商品
        {
            get { return 轉換.商品; }
            set { 轉換.商品 = value; }
        }

        public string 公司名稱 { get { return 轉換.公司.名稱; } }
        public string 客戶名稱 { get { return 轉換.客戶.名稱; } }
        public string 商品名稱 { get { return 轉換.商品.名稱; } }

    }
}

