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
using WokyTool.客製;
using WokyTool.配送;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單匯入處理_ibonMart : 平台訂單匯入處理介面, 可讀出介面_CSV<平台訂單新增匯入資料>
    {
        private static string 運費 = "運費(廠配品)'";

        public string 分格號 { get { return ","; } }

        public bool 是否有標頭 { get { return true; } }

        public string 密碼 { get { return null; } }

        public Encoding 編碼 { get { return Encoding.Default; } }

        public 平台訂單匯入處理_ibonMart()
        {
            客戶 = 客戶資料管理器.獨體.取得("ibon mart");
        }

        public IEnumerable<平台訂單新增匯入資料> 讀出資料(string[] 資料列_)
        {
            // 表單裡如呈現以上>>>'運費(廠配品)'<<<的字樣，請自動省略不讀取
            string 運費確認 = 資料列_[17].轉成字串();
            if (運費.Equals(運費確認))
                yield break;

            string 訂單編號_ = 資料列_[4].轉成字串();

            string 姓名_ = 資料列_[7].轉成字串();
            string 手機_ = 資料列_[8].轉成字串();
            string 地址_ = 資料列_[9].轉成字串();

            string 商品識別_ = 資料列_[15].轉成字串();
            商品資料 商品_ = 商品資料管理器.獨體.取得(客戶.編號, 商品識別_);

            int 數量_ = 資料列_[19].轉成整數();

            string 備註_ = 資料列_[27].轉成字串();

            yield return new 平台訂單新增匯入資料
            {
                處理時間 = DateTime.Now,
                處理狀態 = 列舉.訂單處理狀態.新增,

                訂單編號 = 訂單編號_,

                客戶 = this.客戶,

                姓名 = 姓名_,
                手機 = 手機_,
                地址 = 地址_,

                商品識別 = 商品識別_,
                商品 = 商品_,
                數量 = 數量_,

                備註 = 備註_,

                處理器 = this,
                標頭 = _標頭列,
                內容 = 資料列_,
            };
        }

        public override void 後續處理(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            var 轉換_ = new 平台訂單回單轉換_ibonMart(資料列舉_);

            String 標題_ = String.Format("回單_{0}_{1}_{2}", 公司.名稱, 客戶.名稱, 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);
        }
    }
}
