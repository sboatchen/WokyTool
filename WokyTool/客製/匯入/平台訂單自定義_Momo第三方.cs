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
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.客製
{
    public class 平台訂單自定義_Momo第三方 : 平台訂單自定義介面
    {
        private static string 尚未取得 = "尚未取得";

        private static int 併單比較索引 = -1;

        public override IEnumerable<平台訂單匯入資料> 轉換(動態匯入檔案結構 檔案_)
        {
            平台訂單匯入設定資料 設定_ = (平台訂單匯入設定資料)(檔案_.設定);

            公司資料 公司_ = 設定_.公司;
            客戶資料 客戶_ = 設定_.客戶;

            foreach (var 動態資料_ in 檔案_.內容)
            {
                // 預計出貨日須為2日內(今天+明天) 才進行出貨處理 並將配送狀態改為 可出貨
                // 2日外的 將配送狀態改為 已確認指定配送日 並將配送訊息 寫上預計出貨日
                列舉.訂單處理狀態 處理狀態_ = 列舉.訂單處理狀態.新增;
                DateTime 處理時間_ = new DateTime();
                DateTime 出貨日期_ = 動態資料_.Get<DateTime>(平台訂單列舉.匯入需求欄位.檢查_出貨日期.ToString());
                if (出貨日期_.CompareTo(時間.明天) > 0)
                {
                    處理狀態_ = 列舉.訂單處理狀態.忽略;
                    處理時間_ = 出貨日期_;
                }

                // 併單檢查用
                String 訂單編號_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶訂單編號.ToString());
                String 出貨地址_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.檢查_出貨地址.ToString());
                String 回收地址_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.檢查_回收地址.ToString());
                String 併單比較字串_ = String.Format("@{0}_{1}_{2}", 訂單編號_.Substring(0, 14), 出貨地址_, 回收地址_);
                Dictionary<int, object> 額外資訊_ = 動態資料_.詳細;
                額外資訊_.Add(併單比較索引, 併單比較字串_);

                String 商品識別_ = null;
                String 客戶商品編號_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶商品編號.ToString());
                String 客戶商品子編號_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶商品子編號.ToString());
                if (String.IsNullOrEmpty(客戶商品子編號_))
                {
                    商品識別_ = 客戶商品編號_;
                }
                else
                {
                    商品識別_ = string.Format("{0}@{1}", 客戶商品編號_, 客戶商品子編號_);
                }

                var 平台訂單匯入資料_ = new 平台訂單匯入資料
                {
                    處理狀態 = 處理狀態_,
                    處理時間 = 處理時間_,
                    公司 = 公司_,
                    客戶 = 客戶_,
                    訂單編號 = 訂單編號_,
                    商品識別 = 商品識別_,
                    數量 = 動態資料_.Get<Int32>(平台訂單列舉.匯入需求欄位.數量.ToString()),
                    姓名 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.姓名.ToString()),
                    地址 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.地址.ToString()),
                    電話 = 尚未取得,
                    手機 = 尚未取得,
                    備註 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.備註.ToString()),
                    發票號碼 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.發票號碼.ToString()),
                    配送公司 = 列舉.配送公司.宅配通,
                    額外資訊 = 額外資訊_,
                };

                平台訂單匯入資料_.商品 = 商品資料管理器.獨體.Get(客戶_.編號, 商品識別_);
                平台訂單匯入資料_.自定義介面 = this;

                yield return 平台訂單匯入資料_;
            }
        }

        public override String 取得分組識別(平台訂單新增資料 資料_)
        {
            Object 併單比較字串_;
            if (資料_.額外資訊.TryGetValue(併單比較索引, out 併單比較字串_) == false)
                return this.ToString();

            return base.取得分組識別(資料_) + 併單比較字串_.ToString();
        }

        public override void 回單(IEnumerable<平台訂單新增資料> 資料_)
        {
            /*var Items_ = 資料_.Select(Value => new 平台訂單回單轉換_Momo第三方(Value));

            String Title_ = String.Format("Momo第三方回單_{0}", 時間.目前日期);
            函式.ExportExcel<平台訂單回單轉換_Momo第三方>(Title_, Items_);*/
        }

    }
}
