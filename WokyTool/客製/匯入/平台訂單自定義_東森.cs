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
    public class 平台訂單自定義_東森 : 平台訂單自定義介面
    {
        private static string 一般訂單 = "一般訂單";
        private static string 員購訂單 = "員購訂單";

        public override IEnumerable<平台訂單匯入資料> 轉換(動態匯入檔案結構 檔案_)
        {
            平台訂單匯入設定資料 設定_ = (平台訂單匯入設定資料)(檔案_.設定);

            公司資料 公司_ = 設定_.公司;
            客戶資料 客戶_ = 設定_.客戶;

            foreach (var 動態資料_ in 檔案_.內容)
            {
                // 訂單狀態為 "一般訂單", "員購訂單" 才處理
                列舉.訂單處理狀態 處理狀態_ = 列舉.訂單處理狀態.新增;
                String 訂單類別_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.檢查_訂單類別.ToString());
                if (一般訂單.Equals(訂單類別_) == false && 員購訂單.Equals(訂單類別_) == false)
                {
                    處理狀態_ = 列舉.訂單處理狀態.忽略;
                }

                // 商品序號 = 平台商品編號 + 款式 + 顏色
                String 客戶商品編號_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶商品編號.ToString());
                String 客戶商品子編號_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶商品子編號.ToString());
                String 顏色_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.顏色.ToString());
                String 商品識別_ = 商品識別_ = string.Format("{0}@{1}@{2}", 客戶商品編號_, 客戶商品子編號_, 顏色_);

                var 平台訂單匯入資料_ = new 平台訂單匯入資料
                {
                    處理狀態 = 處理狀態_,
                    公司 = 公司_,
                    客戶 = 客戶_,
                    訂單編號 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶訂單編號.ToString()),
                    商品識別 = 商品識別_,
                    數量 = 動態資料_.Get<Int32>(平台訂單列舉.匯入需求欄位.數量.ToString()),
                    姓名 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.姓名.ToString()),
                    地址 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.地址.ToString()),
                    電話 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.電話.ToString()),
                    手機 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.手機.ToString()),
                    備註 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.備註.ToString()),
                    額外資訊 = 動態資料_.詳細,
                };

                平台訂單匯入資料_.商品 = 商品資料管理器.獨體.Get(客戶_.編號, 商品識別_);
                平台訂單匯入資料_.自定義介面 = this;

                yield return 平台訂單匯入資料_;
            }
        }

        public override void 回單(IEnumerable<平台訂單新增資料> 資料_)
        {
            var Items_ = 資料_.Select(Value => new 平台訂單回單轉換_東森(Value));

            String Title_ = String.Format("東森回單_{0}", 時間.目前日期);
            舊函式.ExportCSV<平台訂單回單轉換_東森>(Title_, Items_);
        }
    }
}
