﻿using Newtonsoft.Json;
using System;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.進貨
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 進貨資料 : 新版可記錄資料, 可處理介面
    {
        [可匯出]
        [JsonProperty]
        public DateTime 處理時間 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 處理者 { get; set; }

        [可匯出]
        [JsonProperty]
        public 列舉.進貨類型 類型 { get; set; }

        [JsonProperty]
        public int 供應商編號 { get; set; }

        [JsonProperty]
        public string 供應商名稱 { get; set; }

        [JsonProperty]
        public int 單品編號 { get; set; }

        [JsonProperty]
        public string 單品名稱 { get; set; }

        [可匯出]
        [JsonProperty]
        public int 數量 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 單價 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 備註 { get; set; }

        /********************************/

        public decimal 總金額
        {
            get
            {
                return 數量 * 單價;
            }
        }

        /********************************/

        public 進貨資料 Self { get { return this; } }

        public static readonly 進貨資料 空白 = new 進貨資料
        {
            處理時間 = default(DateTime),
            處理者 = 字串.無,

            類型 = 列舉.進貨類型.一般,

            供應商編號 = 常數.空白資料編碼,
            供應商名稱 = 字串.無,
            單品編號 = 常數.空白資料編碼,
            單品名稱 = 字串.無,

            數量 = 0,
            單價 = 0,

            備註 = 字串.無,
        };

        public static 進貨資料 錯誤 = new 進貨資料
        {
            處理時間 = default(DateTime),
            處理者 = 字串.錯誤,

            類型 = 列舉.進貨類型.錯誤,

            供應商編號 = 常數.錯誤資料編碼,
            供應商名稱 = 字串.錯誤,
            單品編號 = 常數.錯誤資料編碼,
            單品名稱 = 字串.錯誤,

            數量 = 0,
            單價 = 0,

            備註 = 字串.錯誤,
        };

        public static 進貨資料 建立(進貨新增資料 資料_)
        {
            return new 進貨資料
            {
                處理時間 = DateTime.Now,
                處理者 = 系統參數.使用者名稱,

                類型 = 資料_.類型,

                供應商編號 = 資料_.供應商編號,
                供應商名稱 = 資料_.供應商名稱,
                單品編號 = 資料_.單品編號,
                單品名稱 = 資料_.單品名稱,

                數量 = 資料_.數量,
                單價 = 資料_.單價,

                備註 = 資料_.備註,
            };
        }
    }
}

