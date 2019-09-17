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
    public class 平台訂單匯入處理_Momo第三方 : 平台訂單匯入處理介面, 可讀出介面_EXCEL<平台訂單新增匯入資料>
    {
        private static string 尚未取得 = "尚未取得";

        public int 分頁索引 { get { return 1; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return "27723845t"; } }

        public 平台訂單匯入處理_Momo第三方()
        {
            客戶 = 客戶資料管理器.獨體.取得("Momo");
        }

        public IEnumerable<平台訂單新增匯入資料> 讀出資料(string[] 資料列_)
        {
            // 預計出貨日須為2日內(今天+明天) 才進行出貨處理 並將配送狀態改為 可出貨
            // 2日外的 將配送狀態改為 已確認指定配送日 並將配送訊息 寫上預計出貨日
            DateTime 出貨日期_ = 資料列_[13].轉成時間();
            DateTime 處理時間_ = DateTime.Now;
            列舉.訂單處理狀態 處理狀態_ = 列舉.訂單處理狀態.新增;
            if (出貨日期_.CompareTo(時間.明天) > 0)
            {
                處理狀態_ = 列舉.訂單處理狀態.忽略;
                處理時間_ = 出貨日期_;
            }

            string 訂單編號_ = 資料列_[5].轉成字串();

            string 姓名_ = 資料列_[6].轉成字串();
            string 地址_ = 資料列_[7].轉成字串();

            // 商品識別 = 商品編號 + 子編號
            string 商品編號_ = 資料列_[15].轉成字串();
            string 規格_ = 資料列_[17].轉成字串();
            string 商品識別_ = 函式.取得商品識別(商品編號_, 規格_);
            商品資料 商品_ = 商品資料管理器.獨體.取得(客戶.編號, 商品識別_);

            int 數量_ = 資料列_[19].轉成整數();

            string 備註_ = 資料列_[11].轉成字串();

            string 發票號碼_ = 資料列_[23].轉成字串();

            yield return new 平台訂單新增匯入資料
            {
                處理時間 = 處理時間_,
                處理狀態 = 處理狀態_,

                訂單編號 = 訂單編號_,

                客戶 = this.客戶,

                姓名 = 姓名_,
                手機 = 尚未取得,
                電話 = 尚未取得,
                地址 = 地址_,

                商品識別 = 商品識別_,
                商品 = 商品_,
                數量 = 數量_,

                備註 = 備註_,

                發票號碼 = 發票號碼_,
                配送公司 = 列舉.配送公司.三方, //@@ 列舉.配送公司.宅配通

                處理器 = this,
                標頭 = _標頭列,
                內容 = 資料列_,
            };
        }

        public override String 取得分組識別(平台訂單新增資料 資料_)
        {
            // 公司 + 客戶 + 姓名 + 地址 + 訂單編號前14碼 + 出貨地址 + 回收地址
            return String.Format("{0}_{1}_{2}_{3}_{4}_{5}_{6}", 資料_.公司.名稱, 資料_.客戶.名稱, 資料_.姓名, 資料_.地址, 資料_.訂單編號.Substring(0, 14), 資料_.內容[8], 資料_.內容[9]);
        }

        public override void 後續處理(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            {
                var 轉換_ = new 平台訂單回單轉換_Momo第三方_分組(資料列舉_);
                String 標題_ = String.Format("分組_{0}_{1}_{2}", 公司.名稱, "Momo三方", 時間.目前日期);
                檔案.詢問並寫入(標題_, 轉換_);
            }

            {
                var 轉換_ = new 平台訂單回單轉換_Momo第三方_進度(資料列舉_);
                String 標題_ = String.Format("進度_{0}_{1}_{2}", 公司.名稱, "Momo三方", 時間.目前日期);
                檔案.詢問並寫入(標題_, 轉換_);
            }
        }
    }
}
