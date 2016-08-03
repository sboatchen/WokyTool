﻿using LinqToExcel.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;

namespace WokyTool.DataImport
{
    /*
     * 訂單狀態為 "出貨處理中" 才處理
     */

    class 出貨匯入結構_GoHappy : 出貨資料
    {
        private static string 出貨處理中 = "出貨處理中";
        private static string NULL_STRING = "'null";

        /* 可讀入資訊 */

        //public string 訂單編號 { get; set; }
        //public string 姓名 { get; set; }
        //public string 地址 { get; set; }
        //public string 電話 { get; set; }
        //public string 手機 { get; set; }
        //public string 商品序號 { get; set; }
        //public int 數量 { get; set; }
        //public string 備註 { get; set; }

        /* 未讀入資訊 */

        //public int 群組 { get; set; }
        
        //public 廠商資料 廠商;
        //public int 廠商編號 { get; set; }
        //public 商品資料 商品;
        //public int 商品編號 { get; set; }

        //public DateTime 指配日期 { get; set; }
        //public WokyTool.Common.列舉.指配時段類型 指配時段 { get; set; }
        //public WokyTool.Common.列舉.代收類型 代收方式 { get; set; }
        //public int 代收金額 { get; set; }
        //public WokyTool.Common.列舉.配送公司類型 配送公司 { get; set; }
        //public string 配送單號 { get; protected set; }

        /* 自用資訊 */

        public string 出貨單號 { get; set; }
        public string 訂單狀態 { get; set; }

        // 共用廠商快取
        protected static 廠商資料 _共用廠商快取 = null;
        protected static 廠商資料 共用廠商快取
        {
            get
            {
                if (_共用廠商快取 == null)
                    _共用廠商快取 = 廠商管理器.Instance.Get("GoHappy");
                return _共用廠商快取;
            }
        }

        // 是否為需處理物件
        override public bool IsRead()
        {
            return 訂單狀態.CompareTo(出貨處理中) == 0;
        }

        // 是否合法
        //override public bool IsLegal();

        // 初始化
        override public void Init()
        {
            群組 = 0;

            廠商 = 共用廠商快取;
            商品 = 商品管理器.Instance.Get(廠商.編號, 商品序號);

            指配日期 = new DateTime(0);
            指配時段 = 列舉.指配時段類型.無;

            代收方式 = 列舉.代收類型.無;
            代收金額 = 0;

            配送公司 = 列舉.配送公司類型.無;
            配送單號 = null;

            if (電話.CompareTo(NULL_STRING) == 0)
                電話 = null;

            if (手機.CompareTo(NULL_STRING) == 0)
                手機 = null;
        }

        // 準備配送
        //override public void PrepareDiliver();

        // 完成配送
        //override public void SetDiliver(string 配送單號_);

        // 是否已經配送
        //override public bool IsDilivered();
    }
}
