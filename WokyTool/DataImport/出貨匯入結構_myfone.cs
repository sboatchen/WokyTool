using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;

namespace WokyTool.DataImport
{
    class 出貨匯入結構_myfone : 商品訂單資料
    {
        /***** 資訊格式
        訂單編號
        群組          無
        
        商品序號
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
        //public string ?? { get; set; }

        /* 平台回單複製用欄位 */
        public string 無用_訂單日期 { get; set; }
        public string 無用_出貨單編號 { get; set; }
        public string 無用_運送方式 { get; set; }
        public string 無用_供應商料號 { get; set; }
        public string 無用_商品名稱 { get; set; }
        public string 無用_樣式 { get; set; }
        public string 無用_贈品資訊 { get; set; }
        public int 無用_單位成本 { get; set; }
        public int 無用_成本小計 { get; set; }
        public string 無用_購買人email { get; set; }
        public string 無用_發票號碼 { get; set; }

        // 共用廠商快取
        protected static readonly 廠商資料 _共用廠商快取 = 廠商管理器.Instance.Get("myfone");

        // 是否為需處理物件
        //override public bool IsRead();
       
        // 是否合法
        //override public bool IsLegal();

        // 初始化
        override public void Init()
        {
            群組 = 0;

            廠商 = _共用廠商快取;

            指配日期 = new DateTime(0);
            指配時段 = 列舉.指配時段類型.無;

            代收方式 = 列舉.代收類型.無;
            代收金額 = 0;

            配送公司 = 列舉.配送公司類型.無;
            配送單號 = null;
            
            商品 = 商品管理器.Instance.Get(廠商.編號, 商品序號);
        }

        // 準備配送
        //override public void PrepareDiliver();

        // 完成配送
        //override public void SetDiliver(string 配送單號_);

        // 是否已經配送
        //override public bool IsDilivered();
    }
}
