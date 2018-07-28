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

    class 出貨匯入結構_PC專櫃 : 商品訂單資料
    {
        /***** 資訊格式
        訂單編號
        群組          無
        
        商品序號    無
        數量        
          
        姓名          
        地址          
        電話  
        手機         無        
          
        指配日期     無
        指配時段     無
          
        代收方式     無
        代收金額     無
          
        配送公司     無
        配送單號     無
          
        備註          無    
        *********/
        /* 平台特殊欄位 */
        public string 特殊商品名稱 { get; set; }

        /* 平台回單複製用欄位 */
        //public string 無用_XXXX { get; set; }

        // 共用廠商快取
        protected static readonly 廠商資料 _共用廠商快取 = 廠商管理器.Instance.Get("PC專櫃");

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

            // 特殊商品名稱   【HANABI 賀娜】不鏽鋼316悶燒罐500ML(綠色) (M24773807)
            int Start_ = 特殊商品名稱.LastIndexOf("(");
            int End_ = 特殊商品名稱.LastIndexOf(")");
            if(Start_ == -1 || End_ == -1 || Start_ > End_)
            {
                商品序號 = 特殊商品名稱;
                商品 = 商品資料.ERROR;
            }
            else
            {
                商品序號 = 特殊商品名稱.Substring(Start_ + 1, End_ - Start_ - 1);
                商品 = 商品管理器.Instance.Get(廠商.編號, 商品序號);
            }

            // 地址    臺中市西區民生路168號6樓(國稅局政風室) (4001701234855)
            End_ = 地址.LastIndexOf("(");
            if (End_ != -1)
            {
                地址 = 地址.Substring(0, End_);
            }
        }

        // 準備配送
        //override public void 準備配送();

        // 完成配送
        //override public void 完成配送(string 配送單號_);

        // 是否已經配送
        //override public bool 是否已配送();
    }
}


