using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 全速配匯出轉換 : 可寫入介面_CSV
    {
        public string 分類 { get { return null; } }

        public string 分格號 { get { return ","; } }

        public string 密碼 { get { return null; } }

        public Encoding 編碼 { get { return Encoding.Default; } }

        private IEnumerable<配送轉換資料> _資料列舉;

        public 全速配匯出轉換(IEnumerable<配送轉換資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(CSVBuilder Builder_)
        {
            Builder_.加入標頭(
                "序號",
                "來源表單編號",
                "收件人姓名",
                "收件人郵遞區號",
                "收件人地址",
                "收件人電話(日)",
                "收件人電話(夜)",
                "收件人行動電話",
                "購物車備註",
                "(商品編號)商品名稱",
                "商品料號",
                "商品屬性",
                "商品數量",
                "審件等級",
                "代收貨款",
                "貨號",
                "指配日期(yyyyMMdd)");

            int 序號_ = 1;
            foreach (配送轉換資料 資料_ in _資料列舉)
            {
                Builder_.加入(序號_++);
                Builder_.加入((object)null, false);
                Builder_.加入(資料_.姓名);
                Builder_.加入((object)null, false);
                Builder_.加入(資料_.地址);
                Builder_.加入(資料_.電話);

                if(String.IsNullOrEmpty(資料_.手機))
                {
                    Builder_.加入((object)null, false);
                    Builder_.加入((object)null, false);
                }
                else if (資料_.手機.Length >= 15)    // 手機欄位無法放太長的字串 過長的改放到電話2
                {
                    Builder_.加入(資料_.電話);
                    Builder_.加入((object)null, false);
                }
                else
                {
                    Builder_.加入((object)null, false);
                    Builder_.加入(資料_.手機);
                }

                Builder_.加入(資料_.備註);
                Builder_.加入(資料_.內容);
                Builder_.加入((object)null, false);
                Builder_.加入((object)null, false);
                Builder_.加入(1);
                Builder_.加入(3);
                Builder_.加入((object)null, false);
                Builder_.加入((object)null, false);

                if (資料_.指配日期.Ticks > 0)
                    Builder_.加入(資料_.指配日期.ToString("yyyyMMdd"), true);
                else
                    Builder_.加入((object)null, true);
            }
        }
    }
}