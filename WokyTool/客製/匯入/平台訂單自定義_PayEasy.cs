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
    public class 平台訂單自定義_PayEasy : 平台訂單自定義介面
    {
        public override IEnumerable<平台訂單匯入資料> 轉換(動態匯入檔案結構 檔案_)
        {
            平台訂單匯入設定資料 設定_ = (平台訂單匯入設定資料)(檔案_.設定);

            公司資料 公司_ = 設定_.公司;
            客戶資料 客戶_ = 設定_.客戶;

            foreach (var 動態資料_ in 檔案_.內容)
            {
                var 平台訂單匯入資料_ = new 平台訂單匯入資料
                {
                    公司 = 公司_,
                    客戶 = 客戶_,
                    商品識別 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶商品編號.ToString()),
                    數量 = 動態資料_.Get<Int32>(平台訂單列舉.匯入需求欄位.數量.ToString()),
                    姓名 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.姓名.ToString()),
                    地址 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.地址.ToString()),
                    電話 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.電話.ToString()),
                    手機 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.手機.ToString()),
                    備註 = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.備註.ToString()),
                };

                平台訂單匯入資料_.商品 = 商品資料管理器.獨體.Get(客戶_.編號, 平台訂單匯入資料_.商品識別);

                yield return 平台訂單匯入資料_;
            }
        }

        public override void 回單(IEnumerable<平台訂單新增資料> 資料_)
        {
        }
    }
}
