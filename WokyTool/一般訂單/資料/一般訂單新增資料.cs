﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 一般訂單新增資料 : 新版可記錄資料
    {
        [可匯出]
        [JsonProperty]
        public 列舉.訂單處理狀態 處理狀態 { get; set; }

        [JsonProperty]
        public int 公司編號
        {
            get
            {
                return 公司.編號;
            }
            set
            {
                公司 = 公司資料管理器.獨體.取得(value);
            }
        }

        [JsonProperty]
        public int 客戶編號
        {
            get
            {
                return 客戶.編號;
            }
            set
            {
                客戶 = 客戶資料管理器.獨體.取得(value);
            }
        }

        [JsonProperty]
        public int 子客戶編號
        {
            get
            {
                return 子客戶.編號;
            }
            set
            {
                子客戶 = 子客戶資料管理器.獨體.取得(value);
            }
        }

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

        [可匯出]
        [JsonProperty]
        public List<一般訂單新增組成資料> 組成列 { get; set; }

        /********************************/

        public 公司資料 公司 { get; set; }

        public 客戶資料 客戶 { get; set; }

        public 子客戶資料 子客戶 { get; set; }

        [可匯出(名稱 = "公司")]
        public string 公司名稱 { get { return 公司.名稱; } }

        [可匯出(名稱 = "客戶")]
        public string 客戶名稱 { get { return 客戶.名稱; } }

        [可匯出(名稱 = "子客戶")]
        public string 子客戶名稱 { get { return 子客戶.名稱; } }

        /********************************/

        public bool 是否退貨
        {
            get
            {
                bool? Flag_ = null;

                if (null == 組成列 || 0 == 組成列.Count)
                    throw new Exception("組成列為0:");

                foreach (一般訂單新增組成資料 組成資料_ in 組成列)
                {
                    if (Flag_ == null)
                    {
                        Flag_ = 組成資料_.數量 < 0;
                    }
                    else
                    {
                        bool Temp_ = 組成資料_.數量 < 0;
                        if (Flag_ != Temp_)
                            throw new Exception("數量不皆為正或負");
                    }
                }

                return (bool)Flag_;
            }
        }

        /********************************/

        public 一般訂單新增資料 Self { get { return this; } }

        public 一般訂單新增資料()
        {
            公司 = 公司資料.空白;
            客戶 = 客戶資料.空白;
            子客戶 = 子客戶資料.空白;
        }

        public static readonly 一般訂單新增資料 空白 = new 一般訂單新增資料
        {
            處理狀態 = 列舉.訂單處理狀態.新增,

            公司 = 公司資料.空白,
            客戶 = 客戶資料.空白,
            子客戶 = 子客戶資料.空白,

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

        public static 一般訂單新增資料 錯誤 = new 一般訂單新增資料
        {
            處理狀態 = 列舉.訂單處理狀態.錯誤,

            公司 = 公司資料.錯誤,
            客戶 = 客戶資料.錯誤,
            子客戶 = 子客戶資料.錯誤,

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

        /********************************/

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (列舉.訂單處理狀態.錯誤 == 處理狀態)
                檢查器_.錯誤(資料_, "處理錯誤");

            if (公司.編號是否合法() == false)
                檢查器_.錯誤(資料_, "公司不合法");

            if (客戶.編號是否合法() == false)
                檢查器_.錯誤(資料_, "客戶不合法");

            if (子客戶.編號是否合法() == false)
                檢查器_.錯誤(資料_, "子客戶不合法");

            if (String.IsNullOrEmpty(姓名))
                檢查器_.錯誤(資料_, "姓名不合法");

            if (String.IsNullOrEmpty(地址))
                檢查器_.錯誤(資料_, "地址不合法");

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                檢查器_.錯誤(資料_, "電話/手機不合法");

            if (null == 組成列 || 0 == 組成列.Count)
                檢查器_.錯誤(資料_, "組成不合法");
            else 
            {
                foreach (一般訂單新增組成資料 組成資料_ in 組成列)
                    組成資料_.檢查合法(檢查器_, 資料_, 參考_);
            }
        }
    }
}

