using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.平台訂單;
using WokyTool.客戶;
using WokyTool.配送;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.客製
{
    public class 平台訂單匯入轉換_中華電信 : 平台訂單自定義介面, 可讀出介面_EXCEL<平台訂單匯入資料>
    {
        private static string[] _資料切割 = new string[] { "\n" };
        private static string[] _欄位切割 = new string[] { ",數量:", ",單價:" };
        private static string 貨到付款 = "貨到付款";
        private static string 附發票 = "附發票";

        public int 分頁索引 { get { return 1; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return null; } }

        protected string[] _標頭列;

        public 平台訂單匯入轉換_中華電信()
        {
            客戶 = 客戶資料管理器.獨體.取得("中華電信");
        }

        public void 讀出標頭(string[] 標頭列_)
        {
            this._標頭列 = 標頭列_;
        }

        public IEnumerable<平台訂單匯入資料> 讀出資料(string[] 資料列_)
        {
            string 訂單編號_ = 資料列_[0].轉成字串();
            string 姓名_ = 資料列_[3].轉成字串();
            string 手機_ = 資料列_[4].轉成字串();
            string 電話_ = 資料列_[5].轉成字串();
            string 地址_ = 資料列_[15].轉成字串();

            列舉.代收方式 代收方式_ = 列舉.代收方式.無;
            decimal 代收金額_ = 0;
            string 備註_ = 資料列_[17].轉成字串();

            string 付款方式_ = 資料列_[16].轉成字串();
            if (貨到付款.Equals(付款方式_))
            {
                代收方式_ = 列舉.代收方式.現金;
                代收金額_ = 資料列_[13].轉成整數();

                if (string.IsNullOrEmpty(備註_))
                    備註_ = 附發票;
                else
                    備註_ += 附發票;
            }

            string 訂購明細列_ = 資料列_[18].轉成字串();
            if (string.IsNullOrEmpty(訂購明細列_))
                yield break;

            bool 是否為第一筆_ = true;
            foreach (string 訂購明細_ in 訂購明細列_.Split(_資料切割, StringSplitOptions.RemoveEmptyEntries))
            {
                string[] Temp_ = 訂購明細_.Split(_欄位切割, StringSplitOptions.None);
                string 詳細品名_ = Temp_[0];
                int 數量_ = Temp_[1].轉成整數();

                int 品名結束位置_ = 詳細品名_.IndexOf("]");
                string 商品編號_ = 詳細品名_.Substring(1, 品名結束位置_ - 1);

                int 子序號開始位置_ = 詳細品名_.LastIndexOf("(");
                int 子序號結束位置_ = 詳細品名_.LastIndexOf(")");
                string 子序號_ = null;
                if(詳細品名_[子序號結束位置_ -1] == ';')
                    子序號_ = 詳細品名_.Substring(子序號開始位置_ + 1, 子序號結束位置_ - 子序號開始位置_ - 2);
                else
                    子序號_ = 詳細品名_.Substring(子序號開始位置_ + 1, 子序號結束位置_ - 子序號開始位置_ - 1);

                string 商品識別_ = 函式.取得商品識別(商品編號_, 子序號_);

                商品資料 商品_ = 商品資料管理器.獨體.Get(客戶.編號, 商品識別_);

                平台訂單匯入資料 新資料_ = new 平台訂單匯入資料
                {
                    處理狀態 = 列舉.訂單處理狀態.新增,
                    訂單編號 = 訂單編號_,

                    客戶 = this.客戶,

                    姓名 = 姓名_,
                    手機 = 手機_,
                    電話 = 電話_,
                    地址 = 地址_,

                    商品識別 = 商品識別_,
                    商品 = 商品_,
                    數量 = 數量_,

                    代收方式 = 代收方式_,

                    自定義介面 = this,
                    標頭 = _標頭列,
                    內容 = 資料列_,
                };


                if (是否為第一筆_)
                {
                    新資料_.代收金額 = 代收金額_;
                    新資料_.備註 = 備註_;
                }
                是否為第一筆_ = false;

                yield return 新資料_;
            }
        }

        public override IEnumerable<平台訂單匯入資料> 轉換(動態匯入檔案結構 動態匯入檔案結構_)
        {
            throw new NotImplementedException();
        }

        public override void 回單(IEnumerable<平台訂單新增資料> 資料_)
        {
            var 轉換_ = new 平台訂單回單轉換_中華電信(資料_);

            String 標題_ = String.Format("回單_{0}_{1}_{2}", 公司.名稱, 客戶.名稱, 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }
    }
}
