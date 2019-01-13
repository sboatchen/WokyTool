using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳分頁匯出轉換 : 可序列化_Excel
    {
        protected 月結帳會計資料 _資料;

        public String 標頭 
        { 
            get
            {
                return _資料.設定.名稱;
            }
        }

        public String 樣板 { get { return null; } }

        public 月結帳分頁匯出轉換(月結帳會計資料 資料_)
        {
            _資料 = 資料_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "訂單編號";
            App_.Cells[1, 2] = "商品名稱";
            App_.Cells[1, 3] = "數量";
            App_.Cells[1, 4] = "單價";
            App_.Cells[1, 5] = "含稅單價";
            App_.Cells[1, 6] = "總金額";
            App_.Cells[1, 7] = "成本";
            App_.Cells[1, 8] = "總成本";
            App_.Cells[1, 9] = "利潤";
            App_.Cells[1, 10] = "總利潤";

            if (_資料.資料列 == null || _資料.資料列.Count() == 0)
            {
                訊息管理器.獨體.Warn(標頭 + " 資料為空");
                return;
            }

            int 目前行數_ = 2;
            foreach (月結帳資料 月結帳資料_ in _資料.資料列)
            {
                App_.Cells[目前行數_, 1] = 月結帳資料_.訂單編號;
                App_.Cells[目前行數_, 2] = 月結帳資料_.商品.名稱;
                App_.Cells[目前行數_, 3] = 月結帳資料_.數量;
                App_.Cells[目前行數_, 4] = 月結帳資料_.單價;
                App_.Cells[目前行數_, 5] = 月結帳資料_.含稅單價;
                App_.Cells[目前行數_, 6] = 月結帳資料_.總金額;
                App_.Cells[目前行數_, 7] = 月結帳資料_.成本;
                App_.Cells[目前行數_, 8] = 月結帳資料_.總成本;
                App_.Cells[目前行數_, 9] = 月結帳資料_.利潤;
                App_.Cells[目前行數_, 10] = 月結帳資料_.總利潤;

                目前行數_++;
            }
        }
    }
}
