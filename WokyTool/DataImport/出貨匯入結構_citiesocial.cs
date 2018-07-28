﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.DataImport
{
    class 出貨匯入結構_citiesocial : 商品訂單資料
    {
        /***** 資訊格式
        訂單編號
        群組          無
        
        商品序號    
        數量        
          
        姓名          
        地址          無   
        電話          
        手機         無     
          
        指配日期     無
        指配時段     無
          
        代收方式     無
        代收金額     無
          
        配送公司     無
        配送單號     無
          
        備註         
        *********/
        /* 平台特殊欄位 */
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string post_code { get; set; }
        public DateTime promise_date { get; set; }

        /* 平台回單複製用欄位 */
        //public string 無用_商品名稱 { get; set; }

        // 共用廠商快取
        protected static readonly 廠商資料 _共用廠商快取 = 廠商管理器.Instance.Get("citiesocial");

        // 是否為不處理的資料
        private bool _IsIgnore = false;

        // 是否為需處理物件
        //override public bool IsRead();
       
        // 是否合法
        //override public bool IsLegal();

        // 是否需要配送
        override public bool IsIgnore()
        {
            return _IsIgnore;
        }

        // 初始化
        override public void Init()
        {
            群組 = 0;

            // 五日以上的單子不處理
            if (promise_date.CompareTo(時間.五天後) > 0)
                _IsIgnore = true;

            廠商 = _共用廠商快取;
            地址 = address_1 + address_2 + city + post_code;

            指配時段 = 列舉.指配時段類型.無;

            代收方式 = 列舉.代收類型.無;
            代收金額 = 0;

            配送公司 = 列舉.配送公司類型.無;
            配送單號 = null;

            商品 = 商品管理器.Instance.Get(廠商.編號, 商品序號);
        }

        // 準備配送
        //override public void 準備配送();

        // 完成配送
        //override public void 完成配送(string 配送單號_);

        // 是否已經配送
        //override public bool 是否已配送();
    }
}
