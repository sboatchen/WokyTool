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
     * 該平台不支援匯入 請手動回單號
     * 預購日/指定配達日 不確定是否使用
     */

    class 出貨匯入結構_PCHome : 商品訂單資料
    {
        private static string 尚未 = "尚未";

        /* 可讀入資訊 */

        //public string 訂單編號 { get; set; }
        //public string 姓名 { get; set; }
        //public string 地址 { get; set; }
        //public string 電話 { get; set; }
        //public string 商品序號 { get; set; }
        //public int 數量 { get; set; }
        //public string 備註 { get; set; }

        /* 未讀入資訊 */

        //public int 群組 { get; set; }

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

        public string 確認 { get; set; }
        public string 客戶留言 { get; set; }

        /* 無用資訊 */

        public string 無用_指定配達日 { get; set; }

        // 共用廠商快取
        protected static 廠商資料 _共用廠商快取 = null;
        protected static 廠商資料 共用廠商快取
        {
            get
            {
                if (_共用廠商快取 == null)
                    _共用廠商快取 = 廠商管理器.Instance.Get("PCHome");
                return _共用廠商快取;
            }
        }

        // 是否為需處理物件
        override public bool IsRead()
        {
            return 確認.CompareTo(尚未) == 0;
        }

        // 是否合法
        //override public bool IsLegal();

        // 初始化
        override public void Init()
        {
            群組 = 0;

            廠商 = 共用廠商快取;

            指配日期 = new DateTime(0);
            指配時段 = 列舉.指配時段類型.無;

            代收方式 = 列舉.代收類型.無;
            代收金額 = 0;

            配送公司 = 列舉.配送公司類型.無;
            配送單號 = null;

            // 取得需求的商品序號，輸入原為 FORLIFE折疊式濾茶網(附攜行盒)兩入組/(QFAECU-A900782OP-000)
            int Start_ = 商品序號.LastIndexOf("(");
            if (Start_ == -1)
            {
                MessageBox.Show("出貨匯入結構_PCHome::Init 商品序號異常 " + 商品序號, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            商品序號 = 商品序號.Substring(Start_ + 1, 商品序號.Length - Start_ - 2);

            商品 = 商品管理器.Instance.Get(廠商.編號, 商品序號);

            // 備註 = 無用_指定配達日(不確認是否使用，寫入備註) + 備註 + 客戶留言
            StringBuilder sb = new StringBuilder();
            bool IsNotNull = false;
            if (無用_指定配達日 != null && 無用_指定配達日.Length > 0)
            {
                sb.Append(string.Format("(未使用欄位指定配達日:{0})", 無用_指定配達日));
            }
            if (備註 != null && 備註.Length > 0)
            {
                sb.Append(備註);
                IsNotNull = true;
            }
            if (客戶留言 != null && 客戶留言.Length > 0)
            {
                if(IsNotNull)
                    sb.Append(",");
                sb.Append(客戶留言);
                IsNotNull = true;
            }
            備註 = sb.ToString();
           
        }

        // 準備配送
        //override public void PrepareDiliver();

        // 完成配送
        //override public void SetDiliver(string 配送單號_);

        // 是否已經配送
        //override public bool IsDilivered();
    }
}

