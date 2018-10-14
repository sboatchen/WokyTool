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
    public class 平台訂單自定義_陳沂 : 平台訂單自定義介面
    {
        private static string 待核款 = "待核款";
        private static string 宅配代收 = "宅配代收";
        private static string 打折 = "promotionsN";
        private static string 預購 = "預購";

        private static int 總價前綴索引 = -1;

        public override IEnumerable<平台訂單匯入資料> 轉換(動態匯入檔案結構 檔案_)
        {
            平台訂單匯入設定資料 設定_ = (平台訂單匯入設定資料)(檔案_.設定);

            公司資料 公司_ = 設定_.公司;
            客戶資料 客戶_ = 設定_.客戶;

            foreach (var 動態資料_ in 檔案_.內容)
            {
                列舉.訂單處理狀態 處理狀態_ = 列舉.訂單處理狀態.新增;

                String 訂單狀態_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.檢查_出貨狀態.ToString());
                if (待核款.CompareTo(訂單狀態_) == 0)
                {
                    處理狀態_ = 列舉.訂單處理狀態.忽略;
                }

                String 特殊備註_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.檢查_特殊備註.ToString());
                if (預購.CompareTo(特殊備註_) == 0)
                {
                    處理狀態_ = 列舉.訂單處理狀態.忽略;
                }

                Decimal 總價_ = 動態資料_.Get<Decimal>(平台訂單列舉.匯入需求欄位.總價.ToString());
                int 數量_ = 動態資料_.Get<Int32>(平台訂單列舉.匯入需求欄位.數量.ToString());
                Dictionary<int, object> 額外資訊_ = 動態資料_.詳細;
                額外資訊_.Add(總價前綴索引, 總價_);

                String 付款方式_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.檢查_付款方式.ToString());
                列舉.代收方式 代收方式_ = 列舉.代收方式.無;
                decimal 代收金額_ = 0;
                if (宅配代收.CompareTo(付款方式_) == 0)
                {
                    代收方式_ = 列舉.代收方式.現金;
                    代收金額_ = 總價_;
                }

                String 商品識別_ = null;
                商品資料 商品資料_ = null;
                String 商品類型_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.檢查_商品類型.ToString());
                if (打折.CompareTo(商品類型_) == 0)
                {
                    商品識別_ = 字串.折扣 ;
                    商品資料_ = 商品資料.折扣;
                }
                else 
                {
                    商品識別_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶商品編號.ToString());
                    商品資料_ = 商品資料管理器.獨體.Get(客戶_.編號, 商品識別_);
                }

                var 平台訂單匯入資料_ = new 平台訂單匯入資料
                {
                    處理狀態 = 處理狀態_,
                    公司 = 公司_,
                    客戶 = 客戶_,
                    訂單編號 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶訂單編號.ToString()),
                    商品識別 = 商品識別_,
                    數量 = 數量_,
                    姓名 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.姓名.ToString()),
                    地址 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.地址.ToString()),
                    電話 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.電話.ToString()),
                    手機 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.手機.ToString()),
                    備註 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.備註.ToString()),
                    代收方式 = 代收方式_,
                    代收金額 = 代收金額_,
                    額外資訊 = 動態資料_.詳細,
                };

                平台訂單匯入資料_.商品 = 商品資料_;
                平台訂單匯入資料_.自定義介面 = this;

                yield return 平台訂單匯入資料_;
            }
        }

        public override void 回單(IEnumerable<平台訂單新增資料> 資料_)
        {
            var Items_ = 資料_.Select(Value => new 平台訂單回單轉換_陳沂(Value));

            String Title_ = String.Format("陳沂回單_{0}", 時間.目前日期);
            函式.ExportExcel<平台訂單回單轉換_陳沂>(Title_, Items_);

            // 會計要用的 需列出總金額資料
            var GroupQueue_ = 資料_.Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.配送).GroupBy(Value => Value.配送分組 == 0 ? Value.ToString() : Value.配送分組.ToString());

            List<平台訂單回單轉換_總金額_一休_陳沂_手作> 總金額列表_ = new List<平台訂單回單轉換_總金額_一休_陳沂_手作>();
            foreach (var Group_ in GroupQueue_)
            {
                總金額列表_.Add(new 平台訂單回單轉換_總金額_一休_陳沂_手作(Group_.ToList()));
            }

            Title_ = String.Format("陳沂總金額_{0}", 時間.目前日期);
            函式.ExportExcel<平台訂單回單轉換_總金額_一休_陳沂_手作>(Title_, 總金額列表_);
        }

    }
}
