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
     /*
     * 預計出貨日須為2日內(今天+明天) 才進行出貨處理 並將配送狀態改為 可出貨
     *              2日外的 將配送狀態改為 已確認指定配送日 並將配送訊息 寫上預計出貨日
     * 商品序號 = 品號 + 單名編號
     */
    class 出貨匯入結構_Momo第三方 : 商品訂單資料
    {
        private static string 可出貨 = "可出貨";
        private static string 已確認指定配送日 = "已確認指定配送日";

        /* 可讀入資訊 */

        //public string 訂單編號 { get; set; }
        //public string 姓名 { get; set; }
        //public string 地址 { get; set; }
        //public int 數量 { get; set; }
        //public string 備註 { get; set; }

        /* 未讀入資訊 */

        //public int 群組 { get; set; }

        //public string 商品序號 { get; set; }
        //public string 電話 { get; set; }
        //public string 手機 { get; set; }

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

        public string 配送狀態 { get; set; }
        public string 配送訊息 { get; set; }
        public string 約定配送日 { get; set; }
        public string 訂單類別 { get; set; }
        public DateTime 預計出貨日 { get; set; }
        public string 品號 { get; set; }
        public string 單名編號 { get; set; }
        public string 發票號碼 { get; set; }

        /* 無用資訊 */

        public string 無用_項次 { get; set; }
        public string 無用_宅單備註 { get; set; }
        public string 無用_出貨地址 { get; set; }
        public string 無用_回收地址 { get; set; }
        public string 無用_轉單日 { get; set; }
        public string 無用_商品原廠編號 { get; set; }
        public string 無用_品名 { get; set; }
        public string 無用_單品詳細 { get; set; }
        public string 無用_進價 { get; set; }
        public string 無用_贈品 { get; set; }
        public string 無用_訂購人姓名 { get; set; }
        public string 無用_發票日期 { get; set; }
        public string 無用_個人識別碼 { get; set; }
        public string 無用_群組變價商品 { get; set; }
        public string 無用_付款方式 { get; set; }

        // 是否為不處理的資料
        private bool _IsIgnore;

        public string 併單比較用訂單編號 { get; set; }

        // 共用廠商快取
        protected static 廠商資料 _共用廠商快取 = null;
        protected static 廠商資料 共用廠商快取
        {
            get
            {
                if (_共用廠商快取 == null)
                    _共用廠商快取 = 廠商管理器.Instance.Get("Momo");
                return _共用廠商快取;
            }
        }

        // 是否為需處理物件
        //override public bool IsRead()

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

            // 兩日以上的單子不處理
            if (預計出貨日.CompareTo(時間.明天) > 0)
            {
                配送狀態 = 已確認指定配送日;
                配送訊息 = 預計出貨日.ToString("yyyy/MM/dd");
                約定配送日 = 配送訊息;
                _IsIgnore = true;
                return;
            }

            _IsIgnore = false;
            配送狀態 = 可出貨;
            
            廠商 = 共用廠商快取;

            指配日期 = 時間.NULL;
            指配時段 = 列舉.指配時段類型.無;

            代收方式 = 列舉.代收類型.無;
            代收金額 = 0;

            配送公司 = 列舉.配送公司類型.宅配通;
            配送單號 = null;

            // 商品序號 = 品號 + 單名編號
            if (單名編號 != null && 單名編號.Length > 0)
            {
                商品序號 = string.Format("{0}@{1}", 品號, 單名編號);
            }
            else
            {
                商品序號 = 品號;
            }

            商品 = 商品管理器.Instance.Get(廠商.編號, 商品序號);

            併單比較用訂單編號 = 訂單編號.Substring(0, 14);
        }

        // 準備配送
        //override public void 準備配送();

        // 完成配送
        //override public void 完成配送(string 配送單號_);

        // 是否已經配送
        //override public bool 是否已配送();

        // 發票是否符合
        override public bool IsReceiptMatch(string 發票號碼_)
        {
            return 發票號碼 == 發票號碼_;
        }

        // IComparable
        override public int CompareTo(訂單資料 Other)
        {
            // A null value means that this object is greater.
            if (Other == null)
                return 1;

            出貨匯入結構_Momo第三方 Other_ = (出貨匯入結構_Momo第三方)Other;

            int Value_ = String.Compare(this.併單比較用訂單編號, Other_.併單比較用訂單編號);
            if (Value_ != 0)
                return Value_;

            Value_ = String.Compare(this.姓名, Other_.姓名);
            if (Value_ != 0)
                return Value_;

            Value_ = String.Compare(this.地址, Other_.地址);
            if (Value_ != 0)
                return Value_;

            Value_ = String.Compare(this.無用_出貨地址, Other_.無用_出貨地址);
            if (Value_ != 0)
                return Value_;

            return String.Compare(this.無用_回收地址, Other_.無用_回收地址);
        }
    }
}
