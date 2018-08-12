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
     * 訂單狀態為 "一般訂單" 才處理
     * 商品序號 = 平台商品編號 + 款式
     * 無用_要求配送日,無用_要求配送時間 不確定是否使用
     */

    class 出貨匯入結構_森森 : 商品訂單資料
    {
        private static string 一般訂單 = "一般訂單";

        /* 可讀入資訊 */

        //public string 訂單編號 { get; set; }
        //public string 姓名 { get; set; }
        //public string 地址 { get; set; }
        //public string 電話 { get; set; }
        //public string 手機 { get; set; }
        //public int 數量 { get; set; }
        //public string 備註 { get; set; }

        /* 未讀入資訊 */

        //public int 群組 { get; set; }

        //public string 商品序號 { get; set; }
        
        //public 廠商資料 廠商;
        //public int 廠商編號 { get; set; }
        //public 商品資料 商品;
        //public int 商品編號 { get; set; }

        //public DateTime 指配日期 { get; set; }
        //public 列舉.指配時段類型 指配時段 { get; set; }
        //public 列舉.代收方式類型 代收方式 { get; set; }
        //public int 代收金額 { get; set; }
        //public 列舉.配送公司類型 配送公司 { get; set; }
        //public string 配送單號 { get; protected set; }

        /* 自用資訊 */

        public string 訂單類別 { get; set; }
        public string 平台商品編號 { get; set; }
        public string 款式 { get; set; }

         /* 無用資訊 */

        public string 無用 { get; set; }
        public string 無用_訂單序號 { get; set; }
        public string 無用_送貨單號 { get; set; }
        public string 無用_通路別 { get; set; }
        public string 無用_銷售編號 { get; set; }
        public string 無用_商品名稱 { get; set; }
        public string 無用_顏色 { get; set; }
        public string 無用_廠商料號 { get; set; }
        public string 無用_售價 { get; set; }
        public string 無用_成本 { get; set; }
        public DateTime 無用_出貨指示日 { get; set; }
        public string 無用_要求配送日 { get; set; }
        public string 無用_要求配送時間 { get; set; }
        public string 無用_電子發票號碼 { get; set; }
        public string 無用_識別碼 { get; set; }
        public DateTime 無用_電子發票日期 { get; set; }
        public string 無用_贈品 { get; set; }
        public string 無用_廠商配送訊息 { get; set; }
        public DateTime 無用_預計入庫日期 { get; set; }
        public string 無用_商品編號 { get; set; }

        // 共用廠商快取
        protected static 廠商資料 _共用廠商快取 = null;
        protected static 廠商資料 共用廠商快取
        {
            get
            {
                if (_共用廠商快取 == null)
                    _共用廠商快取 = 廠商管理器.Instance.Get("森森");
                return _共用廠商快取;
            }
        }

        // 是否為需處理物件
        override public bool IsRead()
        {
            return 訂單類別.CompareTo(一般訂單) == 0;
        }

        // 是否合法
        //override public bool IsLegal();

        // 初始化
        override public void Init()
        {
            群組 = 0;

            廠商 = 共用廠商快取;

            指配日期 = 時間.NULL;
            指配時段 = 列舉.指配時段.無;

            代收方式 = 列舉.代收方式.無;
            代收金額 = 0;

            配送公司 = 列舉.配送公司.無;
            配送單號 = null;

            // 商品序號 = 商品序號 + 款式
            if (款式 != null && 款式 != "共同")
            {
                商品序號 = string.Format("{0}@{1}", 平台商品編號, 款式);
            }
            else
            {
                商品序號 = 平台商品編號;
            }

            商品 = 商品管理器.Instance.Get(廠商.編號, 商品序號);

            // 備註 = 無用_要求配送日(不確認是否使用，寫入備註) + 無用_要求配送時間(不確認是否使用，寫入備註) + 備註
            StringBuilder sb = new StringBuilder();
            if (無用_要求配送日 != null && 無用_要求配送日.Length > 0)
            {
                sb.Append(string.Format("(未使用欄位要求配送日:{0})", 無用_要求配送日));
            }
            if (無用_要求配送時間 != null && 無用_要求配送時間.Length > 0)
            {
                sb.Append(string.Format("(未使用欄位要求配送時間:{0})", 無用_要求配送時間));
            }
            if (備註 != null && 備註.Length > 0)
            {
                sb.Append(備註);
            }
            備註 = sb.ToString();
        }

        // 準備配送
        //override public void 準備配送();

        // 完成配送
        //override public void 完成配送(string 配送單號_);

        // 是否已經配送
        //override public bool 是否已配送();
    }
}
