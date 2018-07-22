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
    class 出貨匯入結構_遠傳加購 : 商品訂單資料
    {
        /***** 資訊格式
        訂單編號
        群組          無
        
        商品序號       無
        數量        
          
        姓名          
        地址          
        電話          無     
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
        public string 序號與名稱 { get; set; }
        public string 規格 { get; set; }

        /* 平台回單複製用欄位 */
        //public string 無用_XXXX { get; set; }

        // 共用廠商快取
        protected static readonly 廠商資料 _共用廠商快取 = 廠商管理器.Instance.Get("遠傳加購");

        // 是否為需處理物件
        //override public bool IsRead();
       
        // 是否合法
        //override public bool IsLegal();

        // 初始化
        override public void Init()
        {
            群組 = 0;

            廠商 = _共用廠商快取;

            指配日期 = 時間.NULL;
            指配時段 = 列舉.指配時段類型.無;

            代收方式 = 列舉.代收類型.無;
            代收金額 = 0;

            配送公司 = 列舉.配送公司類型.無;
            配送單號 = null;

            // 取得商品序號
            // 範例
            //  序號與名稱    (P00046618_05)德國HOPE歐普微壓循環氣密系列平底鍋26CM
            //  規格          無
            //  商品序號      P00046618_05@無
            int Start_ = 序號與名稱.IndexOf('(');
            int End_ = 序號與名稱.IndexOf(')');
            if(Start_ == -1 || End_ == -1)
            {
                商品序號 = 字串.標頭_錯誤 + 序號與名稱 + "@" + 規格;
            }
            else
            {
                商品序號 = 序號與名稱.Substring(Start_ +1, End_ - Start_ - 1) + "@" + 規格;
            }

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
