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
    public class 平台訂單匯入轉換_Friday : 平台訂單自定義介面, 可讀出介面_CSV<平台訂單匯入資料>
    {
        private static string 出貨處理中 = "出貨處理中";

        public string 分格號 { get { return ","; } }

        public bool 是否有標頭 { get { return true; } }

        public string 密碼 { get { return null; } }

        public 公司資料 公司 { get; set; }
        public 客戶資料 客戶 { get; set; }

        protected string[] _標頭列;

        public 平台訂單匯入轉換_Friday(公司資料 公司_)
        {
            公司 = 公司_;
            客戶 = 客戶資料管理器.獨體.Get("Friday");
        }

        public void 讀出標頭(string[] 標頭列_)
        {
            this._標頭列 = 標頭列_;
        }

        public IEnumerable<平台訂單匯入資料> 讀出資料(string[] 資料列_)
        {
            // 訂單狀態為 "出貨處理中" 才處理 且 五日以上的單子不處理
            string 訂單狀態_ = 資料列_[7].轉成字串();
            DateTime 出貨日期_ = 資料列_[27].轉成時間();
            列舉.訂單處理狀態 處理狀態_ = 列舉.訂單處理狀態.新增;
            if (出貨處理中.Equals(訂單狀態_) == false || 出貨日期_.CompareTo(時間.五天後) >= 0)
            {
                處理狀態_ = 列舉.訂單處理狀態.忽略;
            }

            string 訂單編號_ = 資料列_[6].轉成字串();

            string 姓名_ = 資料列_[18].轉成字串();
            string 手機_ = 資料列_[22].轉成字串();
            string 電話_ = 資料列_[21].轉成字串();
            string 地址_ = 資料列_[20].轉成字串();

            // 商品識別 = 商品序號 + 規格編號或條碼
            string 商品編號_ = 資料列_[11].轉成字串();
            string 規格_ = 資料列_[12].轉成字串().Replace("\'", "");
            string 商品識別_ = 函式.取得商品識別(商品編號_, 規格_);
            商品資料 商品_ = 商品資料管理器.獨體.Get(客戶.編號, 商品識別_);

            int 數量_ = 資料列_[15].轉成整數();

            string 備註_ = 資料列_[23].轉成字串();

            yield return new 平台訂單匯入資料
            {
                處理狀態 = 處理狀態_,
                訂單編號 = 訂單編號_,

                公司 = this.公司,
                客戶 = this.客戶,

                姓名 = 姓名_,
                手機 = 手機_,
                電話 = 電話_,
                地址 = 地址_,

                商品識別 = 商品識別_,
                商品 = 商品_,
                數量 = 數量_,

                備註 = 備註_,

                自定義介面 = this,
                標頭 = _標頭列,
                內容 = 資料列_,
            };
        }

        public override IEnumerable<平台訂單匯入資料> 轉換(動態匯入檔案結構 動態匯入檔案結構_)
        {
            throw new NotImplementedException();
        }

        public override void 回單(IEnumerable<平台訂單新增資料> 資料_)
        {
            var 轉換_ = new 平台訂單回單轉換_Friday(資料_);

            String 標題_ = String.Format("回單_{0}_{1}_{2}", 公司.名稱, 客戶.名稱, 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }
    }
}
