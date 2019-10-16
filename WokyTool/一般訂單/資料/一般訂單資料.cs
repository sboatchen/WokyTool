using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 一般訂單資料 : 新版可記錄資料, 可處理介面
    {
        [可匯出]
        [JsonProperty]
        public DateTime 處理時間 { get; set; }

        [可匯出]
        [JsonProperty]
        public 列舉.訂單處理狀態 處理狀態 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 處理者 { get; set; }

        [JsonProperty]
        public int 公司編號 { get; set; }

        [JsonProperty]
        public string 公司名稱 { get; set; }

        [JsonProperty]
        public int 客戶編號 { get; set; }

        [JsonProperty]
        public string 客戶名稱 { get; set; }

        [JsonProperty]
        public int 子客戶編號 { get; set; }

        [JsonProperty]
        public string 子客戶名稱 { get; set; }

        [JsonProperty]
        public int 商品編號 { get; set; }

        [JsonProperty]
        public string 商品名稱 { get; set; }

        [可匯出]
        [JsonProperty]
        public int 數量 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 成本 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 單價 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 姓名 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 地址 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 電話 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 手機 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 備註 { get; set; }

        [可匯出]
        [JsonProperty]
        public 列舉.配送公司 配送公司 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 配送單號 { get; set; }

        [可匯出]
        [JsonProperty]
        public DateTime 指配日期 { get; set; }     // 指配日期.Ticks == 0 代表不指定

        [可匯出]
        [JsonProperty]
        public 列舉.指配時段 指配時段 { get; set; }

        [可匯出]
        [JsonProperty]
        public 列舉.代收方式 代收方式 { get; set; }

        [可匯出]
        [JsonProperty]
        public decimal 代收金額 { get; set; }

        /********************************/

        public decimal 總成本
        {
            get { return 數量 * 成本; }
        }


        public decimal 利潤
        {
            get
            {
                return 單價 - 成本;
            }
        }

        public decimal 總利潤
        {
            get
            {
                return 利潤 * 數量;
            }
        }

        /********************************/

        public 一般訂單資料 Self { get { return this; } }

        public static readonly 一般訂單資料 空白 = new 一般訂單資料
        {
            處理狀態 = 列舉.訂單處理狀態.新增,
            處理時間 = default(DateTime),
            處理者 = 字串.無,

            公司編號 = 常數.空白資料編碼,
            公司名稱 = 字串.無,
            客戶編號 = 常數.空白資料編碼,
            客戶名稱 = 字串.無,
            子客戶編號 = 常數.空白資料編碼,
            子客戶名稱 = 字串.無,
            商品編號 = 常數.空白資料編碼,
            商品名稱 = 字串.無,

            數量 = 0,
            單價 = 0,
            成本 = 0,

            姓名 = 字串.無,
            地址 = 字串.無,
            電話 = 字串.無,
            手機 = 字串.無,

            備註 = 字串.無,

            配送公司 = 列舉.配送公司.無,
            配送單號 = 字串.無,

            指配日期 = default(DateTime),
            指配時段 = 列舉.指配時段.無,

            代收方式 = 列舉.代收方式.無,
            代收金額 = 0,
        };

        public static 一般訂單資料 錯誤 = new 一般訂單資料
        {
            處理狀態 = 列舉.訂單處理狀態.錯誤,
            處理時間 = default(DateTime),
            處理者 = 字串.錯誤,

            公司編號 = 常數.錯誤資料編碼,
            公司名稱 = 字串.錯誤,
            客戶編號 = 常數.錯誤資料編碼,
            客戶名稱 = 字串.錯誤,
            子客戶編號 = 常數.錯誤資料編碼,
            子客戶名稱 = 字串.錯誤,
            商品編號 = 常數.錯誤資料編碼,
            商品名稱 = 字串.錯誤,

            數量 = 0,
            單價 = 0,
            成本 = 0,

            姓名 = 字串.錯誤,
            地址 = 字串.錯誤,
            電話 = 字串.錯誤,
            手機 = 字串.錯誤,

            備註 = 字串.錯誤,

            配送公司 = 列舉.配送公司.錯誤,
            配送單號 = 字串.錯誤,

            指配日期 = default(DateTime),
            指配時段 = 列舉.指配時段.錯誤,

            代收方式 = 列舉.代收方式.錯誤,
            代收金額 = 0,
        };

        public static IEnumerable<一般訂單資料> 建立(一般訂單新增資料 資料_)
        {
            foreach (一般訂單新增組成資料 組成資料_ in 資料_.組成列)
            {
                yield return new 一般訂單資料
                {
                    處理時間 = DateTime.Now,
                    處理者 = 系統參數.使用者名稱,
                    處理狀態 = 資料_.處理狀態,

                    公司編號 = 資料_.公司編號,
                    公司名稱 = 資料_.公司名稱,
                    客戶編號 = 資料_.客戶編號,
                    客戶名稱 = 資料_.客戶名稱,
                    子客戶編號 = 資料_.子客戶編號,
                    子客戶名稱 = 資料_.子客戶名稱,
                    商品編號 = 組成資料_.商品編號,
                    商品名稱 = 組成資料_.商品名稱,

                    數量 = 組成資料_.數量,
                    單價 = 組成資料_.商品.進價,

                    姓名 = 資料_.姓名,
                    地址 = 資料_.地址,
                    電話 = 資料_.電話,
                    手機 = 資料_.手機,

                    備註 = 資料_.備註,

                    配送公司 = 資料_.配送公司,
                    配送單號 = 資料_.配送單號,

                    指配日期 = 資料_.指配日期,
                    指配時段 = 資料_.指配時段,

                    代收方式 = 資料_.代收方式,
                    代收金額 = 資料_.代收金額,
                };
            }
        }

        /********************************/
    }
}

