﻿using Newtonsoft.Json;
using WokyTool.單品;
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

        [可匯入(名稱 = "供應商", 說明 = "必要")]
        [JsonProperty]
        public string 供應商識別
        {
            get { return _供應商識別; }
            set { 
                _供應商識別 = value;
                供應商 = 供應商資料管理器.獨體.取得(_供應商識別);
            }
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
        private string _供應商識別;
        private string _單品識別;

        public 列舉.進貨類型 類型
        {
            get { return 轉換.類型; }
            set { 轉換.類型 = value; }
        }

        public 供應商資料 供應商
        {
            get { return 轉換.供應商; }
            set { 轉換.供應商 = value; }
        }

        public 單品資料 單品
        {
            get { return 轉換.單品; }
            set { 轉換.單品 = value; }
        }

        public string 供應商名稱 { get { return 轉換.供應商.名稱; } }
        public string 單品名稱 { get { return 轉換.單品.名稱; } }

        /********************************/

        public static readonly 進貨新增匯入資料 空白 = new 進貨新增匯入資料
        {
            轉換 = 進貨新增資料.空白
        };
    }
}

