using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WokyTool.通用
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 動態匯入資料結構 : 基本資料
    {
        public 動態匯入檔案結構 檔案結構 { get; set; }

        [JsonProperty]
        public Dictionary<String, object> 資料 { get; set; }

        [JsonProperty]
        public Dictionary<int, object> 詳細 { get; set; }

        public 動態匯入資料結構(動態匯入檔案結構 檔案結構_)
        {
            檔案結構 = 檔案結構_;
            資料 = new Dictionary<String, object>();
            詳細 = new Dictionary<int, object>();
        }

        public T Get<T>(String Key_)
        {
            object Data_;
            資料.TryGetValue(Key_, out Data_);
            if(Data_ == null)
                return default(T);
            return (T)Data_;
        }

        public String GetFromDetail(int Index_)
        {
            object Data_;
            詳細.TryGetValue(Index_, out Data_);
            if (Data_ == null)
                return null;

            return Data_.ToString();
        }

        public Decimal GetDecimalFromDetail(int Index_)
        {
            object Data_;
            詳細.TryGetValue(Index_, out Data_);
            if (Data_ == null)
                return 0;

            return Convert.ToDecimal(Data_.ToString());
        }
    }
}
