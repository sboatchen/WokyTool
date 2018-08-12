using System;
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
    class 出貨匯入結構_Momo摩天 : 商品訂單資料
    {
        /***** 資訊格式
        訂單編號
        群組          無
        
        商品序號       無
        數量
          
        姓名          
        地址          
        電話
        手機       
          
        指配日期     無
        指配時段     無
          
        代收方式     無
        代收金額     無
          
        配送公司     無
        配送單號     無
          
        備註
        *********/
        /* 平台特殊欄位 */
        public int 項次 { get; set; }
        public string 配送狀態 { get; set; }
        public string 配送訊息 { get; set; }
        public string 付款日 { get; set; }
        public string 最晚出貨日 { get; set; }
        public string 商店品號 { get; set; }
        public string 廠商商品編號 { get; set; }
        public string 商品名稱 { get; set; }
        public string 單品規格 { get; set; }
        public int 成交價 { get; set; }

        public string 付款方式 { get; set; }
        public string 分期 { get; set; }
        public string 商品屬性 { get; set; }
        public string 訂購人姓名 { get; set; }
        public string 電話2 { get; set; }
        public string 行動電話2 { get; set; }
        
        // 共用廠商快取
        protected static readonly 廠商資料 _共用廠商快取 = 廠商管理器.Instance.Get("Momo摩天");
        protected static readonly string 已配送 = "已配送";

        // 是否為需處理物件
        //override public bool IsRead();
       
        // 是否合法
        //override public bool IsLegal();

        // 初始化
        override public void Init()
        {
            群組 = 0;

            廠商 = _共用廠商快取;
            配送狀態 = 已配送;

            指配日期 = 時間.NULL;
            指配時段 = 列舉.指配時段.無;

            代收方式 = 列舉.代收方式.無;
            代收金額 = 0;

            配送單號 = null;

            // 商品序號 = 廠商商品編號 + 單品規格
            if (單品規格 != null && 單品規格.Length > 0)
            {
                商品序號 = string.Format("{0}@{1}", 廠商商品編號, 單品規格);
            }
            else
            {
                商品序號 = 廠商商品編號;
            }

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


