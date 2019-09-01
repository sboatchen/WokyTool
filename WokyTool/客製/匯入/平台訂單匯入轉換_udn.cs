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
    public class 平台訂單匯入轉換_UDN : 平台訂單自定義介面, 可讀出介面_EXCEL<平台訂單匯入資料>
    {
        public int 分頁索引 { get { return 1; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 3; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return null; } }

        protected string[] _標頭列;

        public 平台訂單匯入轉換_UDN()
        {
            客戶 = 客戶資料管理器.獨體.取得("UDN");
        }

        public void 讀出標頭(string[] 標頭列_)
        {
            this._標頭列 = 標頭列_;
        }

        public IEnumerable<平台訂單匯入資料> 讀出資料(string[] 資料列_)
        {
            string 訂單編號_ = 資料列_[2].轉成字串();

            string 姓名_ = 資料列_[6].轉成字串();
            string 手機_ = 資料列_[8].轉成字串();
            string 電話_ = 資料列_[7].轉成字串();
            string 地址_ = 資料列_[10].轉成字串();

            string 商品識別_ = 資料列_[13].轉成字串();
            商品資料 商品_ = 商品資料管理器.獨體.取得(客戶.編號, 商品識別_);

            int 數量_ = 資料列_[19].轉成整數();

            string 備註_ = 資料列_[11].轉成字串() + 資料列_[12].轉成字串();

            yield return new 平台訂單匯入資料
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

        public override void 回單(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            var 轉換_ = new 平台訂單回單轉換_UDN(資料列舉_);

            String 標題_ = String.Format("回單_{0}_{1}_{2}", 公司.名稱, 客戶.名稱, 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);
        }
    }
}
