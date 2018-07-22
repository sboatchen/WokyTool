using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.DataImport
{
    class 出貨匯入結構_ibonMart : 商品訂單資料
    {
      
        // 這個平台的資料都會用 ' 包起來，所以需要轉一層

        /***** 資訊格式
        訂單編號    無
        群組          無
        
        商品序號    無
        數量          無
          
        姓名          無
        地址          無
        電話          無
        手機          無  
          
        指配日期     無
        指配時段     無
          
        代收方式     無
        代收金額     無
          
        配送公司     無
        配送單號     無
          
        備註
        *********/
        /* 平台特殊欄位 */
        public string 特殊_訂單編號 { get; set; }
        public string 特殊_商品序號 { get; set; }
        public string 特殊_數量 { get; set; }
        public string 特殊_姓名 { get; set; }
        public string 特殊_地址 { get; set; }
        public string 特殊_電話 { get; set; }
        public string 特殊_備註 { get; set; }

        protected string _訂單編號 = null;

        override public string 訂單編號
        {
            get
            {
                if(_訂單編號 == null)
                    _訂單編號 = 特殊_訂單編號.Substring(1, 特殊_訂單編號.Length - 2);
                return _訂單編號;
            }
            set
            {
                MessageBox.Show("出貨匯入結構_ibonMart不支援設定訂單編號", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* 平台回單複製用欄位 */
        public string 無用_出貨單編號 { get; set; }

        // 共用廠商快取
        protected static readonly 廠商資料 _共用廠商快取 = 廠商管理器.Instance.Get("ibon mart");

        // 是否為需處理物件
        override public bool IsRead(){ return true;}
       
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

            商品序號 = 特殊_商品序號.Substring(1, 特殊_商品序號.Length - 2);
            數量 = Int32.Parse(特殊_數量.Substring(1, 特殊_數量.Length - 2));
            姓名 = 特殊_姓名.Substring(1, 特殊_姓名.Length - 2);
            地址 = 特殊_地址.Substring(1, 特殊_地址.Length - 2);
            電話 = 特殊_電話.Substring(1, 特殊_電話.Length - 2);
            備註 = 特殊_備註.Substring(1, 特殊_備註.Length - 2);
            
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
