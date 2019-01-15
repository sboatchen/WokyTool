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

namespace WokyTool.發票
{
    public class 發票匯入轉換 : 檔案匯入轉換介面<發票匯入資料>
    {
        public static string 已作廢 = "已作廢";

        public IEnumerable<發票匯入資料> 轉換(動態匯入檔案結構 檔案_)
        {
            foreach (var 動態資料_ in 檔案_.內容)
            {
                String 商品識別_ = 動態資料_.Get<String>(平台訂單列舉.匯入需求欄位.客戶商品編號.ToString());

                var 發票匯入資料_ = new 發票匯入資料
                {
                    發票號碼 = 動態資料_.GetFromDetail(1),
                    註記 = 動態資料_.GetFromDetail(2),
                    格式代號 = 動態資料_.GetFromDetail(3),
                    發票狀態 = 動態資料_.GetFromDetail(4),
                    發票日期 = 動態資料_.GetFromDetail(5),
                    買方統一編號 = 動態資料_.GetFromDetail(6),
                    買方名稱 = 動態資料_.GetFromDetail(7),
                    賣方統一編號 = 動態資料_.GetFromDetail(8),
                    賣方名稱 = 動態資料_.GetFromDetail(9),
                    寄送日期 = 動態資料_.GetFromDetail(10),
                    銷售額合計 = 動態資料_.GetDecimalFromDetail(11),
                    營業稅 = 動態資料_.GetDecimalFromDetail(12),
                    總計 = 動態資料_.GetDecimalFromDetail(13),
                    課稅別 = 動態資料_.GetFromDetail(14),
                    匯率 = 動態資料_.GetDecimalFromDetail(15),
                    載具號碼1 = 動態資料_.GetFromDetail(16),
                    載具號碼2 = 動態資料_.GetFromDetail(17),
                    總備註 = 動態資料_.GetFromDetail(18),
                };

                if (String.IsNullOrEmpty(發票匯入資料_.發票號碼) == false)
                {
                    發票匯入資料_.發票字軌 = 發票匯入資料_.發票號碼.Substring(0, 6);
                    發票匯入資料_.發票數值 = Int32.Parse(發票匯入資料_.發票號碼.Substring(6));
                }

                // 發票狀態已作廢 則後面金額K.L.M欄歸0
                if (已作廢.CompareTo(發票匯入資料_.發票狀態) == 0)
                {
                    發票匯入資料_.銷售額合計 = 0;
                    發票匯入資料_.營業稅 = 0;
                    發票匯入資料_.總計 = 0;
                }

                yield return 發票匯入資料_;
            }
        }
    }
}
