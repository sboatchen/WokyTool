using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.月結帳
{
    public class 月結帳分頁匯出轉換 : 可序列化_Excel
    {
        protected IEnumerable<月結帳資料> _資料列;

        public String 標頭 { get; private set; }

        public 月結帳分頁匯出轉換(String 標頭_, IEnumerable<月結帳資料> 資料列_)
        {
            標頭 = 標頭_;
            _資料列 = 資料列_;
        }

        public decimal 總營業額()
        {
            return _資料列.Sum(Value => Value.總金額);
        }

        public decimal 總成本()
        {
            return _資料列.Sum(Value => Value.總成本);
        }

        public decimal 總利潤()
        {
            return _資料列.Sum(Value => Value.總利潤);
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

            int 目前行數_ = 2;
            foreach (月結帳資料 月結帳資料_ in _資料列)
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
