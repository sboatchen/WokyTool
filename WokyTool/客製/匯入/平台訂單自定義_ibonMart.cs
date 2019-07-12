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
    public class 平台訂單自定義_ibonMart : 平台訂單自定義介面
    {
        public override IEnumerable<平台訂單匯入資料> 轉換(動態匯入檔案結構 檔案_)
        {
            平台訂單匯入設定資料 設定_ = (平台訂單匯入設定資料)(檔案_.設定);

            公司資料 公司_ = 設定_.公司;
            客戶資料 客戶_ = 設定_.客戶;

            foreach (var 動態資料_ in 檔案_.內容)
            {

                String 訂單編號_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶訂單編號.ToString());
                訂單編號_ = 訂單編號_.Substring(1, 訂單編號_.Length - 2);

                String 商品識別_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶商品編號.ToString());
                商品識別_ = 商品識別_.Substring(1, 商品識別_.Length - 2);

                String 數量字串_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.數量.ToString());
                數量字串_ = 數量字串_.Substring(1, 數量字串_.Length - 2);
                int 數量_ = Int32.Parse(數量字串_);

                String 姓名_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.姓名.ToString());
                姓名_ = 姓名_.Substring(1, 姓名_.Length - 2);

                String 地址_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.地址.ToString());
                地址_ = 地址_.Substring(1, 地址_.Length - 2);

                String 電話_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.電話.ToString());
                電話_ = 電話_.Substring(1, 電話_.Length - 2);

                String 備註_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.備註.ToString());
                備註_ = 備註_.Substring(1, 備註_.Length - 2);

                var 平台訂單匯入資料_ = new 平台訂單匯入資料
                {
                    處理狀態 = 列舉.訂單處理狀態.新增,
                    公司 = 公司_,
                    客戶 = 客戶_,
                    訂單編號 = 訂單編號_,
                    商品識別 = 商品識別_,
                    數量 = 數量_,
                    姓名 = 姓名_,
                    地址 = 地址_,
                    電話 = 電話_,
                    //手機 = 手機_,
                    備註 = 備註_,
                    額外資訊 = 動態資料_.詳細,
                };

                平台訂單匯入資料_.商品 = 商品資料管理器.獨體.Get(客戶_.編號, 商品識別_);
                平台訂單匯入資料_.自定義介面 = this;

                yield return 平台訂單匯入資料_;
            }
        }

        public override void 回單(IEnumerable<平台訂單新增資料> 資料_)
        {
            var Items_ = 資料_.Select(Value => new 平台訂單回單轉換_ibonMart(Value));

            String Title_ = String.Format("ibonMart回單_{0}", 時間.目前日期);
            舊函式.ExportCSV<平台訂單回單轉換_ibonMart>(Title_, Items_);
        }
    }
}
