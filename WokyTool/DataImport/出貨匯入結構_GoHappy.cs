using LinqToExcel.Attributes;
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
    /*
     * 訂單狀態為 "出貨處理中" 才處理
     * 商品序號 = 品號 + 單名編號
     */

    class 出貨匯入結構_GoHappy : 商品訂單資料
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
        //public 列舉.指配時段類型 指配時段 { get; set; }
        //public 列舉.代收方式類型 代收方式 { get; set; }
        //public int 代收金額 { get; set; }
        //public 列舉.配送公司類型 配送公司 { get; set; }
        //public string 配送單號 { get; protected set; }

        /* 自用資訊 */

        public string 品號 { get; set; }
        public string 單名編號 { get; set; }
        public string 出貨單號 { get; set; }
        public string 訂單狀態 { get; set; }
        public DateTime 應出貨日期 { get; set; }

        // 是否為不處理的資料
        private bool _IsIgnore = false;

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
            if (應出貨日期.CompareTo(時間.五天後) > 0)
            {
                _IsIgnore = true;
                return;
            }

            廠商 = 共用廠商快取;

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

            指配日期 = 時間.NULL;
            指配時段 = 列舉.指配時段.無;

            代收方式 = 列舉.代收方式.無;
            代收金額 = 0;

            配送公司 = 列舉.配送公司.無;
            配送單號 = null;

            if (電話.CompareTo(NULL_STRING) == 0)
                電話 = null;

            if (手機.CompareTo(NULL_STRING) == 0)
                手機 = null;
        }

        // 準備配送
        //override public void 準備配送();

        // 完成配送
        //override public void 完成配送(string 配送單號_);

        // 是否已經配送
        //override public bool 是否已配送();
    }
}
