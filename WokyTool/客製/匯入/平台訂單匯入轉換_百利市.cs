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
    public class 平台訂單匯入轉換_百利市 : 平台訂單自定義介面, 可讀出介面_EXCEL<平台訂單匯入資料>
    {
        public int 分頁索引 { get { return 1; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return null; } }

        protected string[] _標頭列;

        public 平台訂單匯入轉換_百利市()
        {
            客戶 = 客戶資料管理器.獨體.取得("百利市");
        }

        public void 讀出標頭(string[] 標頭列_)
        {
            this._標頭列 = 標頭列_;
        }

        public IEnumerable<平台訂單匯入資料> 讀出資料(string[] 資料列_)
        {
            string 訂單編號_ = 資料列_[1].轉成字串();

            string 姓名_ = 資料列_[21].轉成字串();
            string 手機_ = 資料列_[24].轉成字串();
            string 電話_ = 資料列_[23].轉成字串();
            string 地址_ = 資料列_[22].轉成字串();

            string 商品識別_ = 資料列_[5].轉成字串();
            商品資料 商品_ = 商品資料管理器.獨體.Get(客戶.編號, 商品識別_);

            int 數量_ = 資料列_[9].轉成整數();

            string 備註_ = 資料列_[25].轉成字串();

            yield return new 平台訂單匯入資料
            {
                處理狀態 = 列舉.訂單處理狀態.新增,
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
            var 轉換_ = new 平台訂單回單轉換_百利市(資料_);

            String 標題_ = String.Format("回單_{0}_{1}_{2}", 公司.名稱, 客戶.名稱, 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }
    }
}
