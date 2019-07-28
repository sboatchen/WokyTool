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
    public class 平台訂單自定義_遠傳加購 : 平台訂單自定義介面
    {
        public override IEnumerable<平台訂單匯入資料> 轉換(動態匯入檔案結構 檔案_)
        {
            平台訂單匯入設定資料 設定_ = (平台訂單匯入設定資料)(檔案_.設定);

            公司資料 公司_ = 設定_.公司;
            客戶資料 客戶_ = 設定_.客戶;

            foreach (var 動態資料_ in 檔案_.內容)
            {
                //  序號與名稱    (P00046618_05)德國HOPE歐普微壓循環氣密系列平底鍋26CM
                //  規格          無
                //  商品序號      P00046618_05@無

                String 客戶商品編號_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶商品編號.ToString());
                int Start_ = 客戶商品編號_.IndexOf('(');
                int End_ = 客戶商品編號_.IndexOf(')');
                if (Start_ == -1 || End_ == -1)
                {
                    客戶商品編號_ = 字串.標頭_錯誤 + 客戶商品編號_ ;
                }
                else
                {
                    客戶商品編號_ = 客戶商品編號_.Substring(Start_ + 1, End_ - Start_ - 1);
                }

                String 客戶商品子編號_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶商品子編號.ToString());

                String 商品識別_ = null;
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
                    處理狀態 = 列舉.訂單處理狀態.新增,
                    公司 = 公司_,
                    客戶 = 客戶_,
                    訂單編號 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶訂單編號.ToString()),
                    商品識別 = 商品識別_,
                    數量 = 動態資料_.Get<Int32>(平台訂單列舉.匯入需求欄位.數量.ToString()),
                    姓名 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.姓名.ToString()),
                    地址 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.地址.ToString()),
                    //電話 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.電話.ToString()),
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
            var 轉換_ = new 平台訂單回單轉換_遠傳加購(資料_);

            String 標題_ = String.Format("遠傳加購回單_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.Notify("匯出完成");
        }
    }
}
