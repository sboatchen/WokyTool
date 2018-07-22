using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.物品;

namespace WokyTool.商品
{
    public class 商品總覽匯出轉換 : 可格式化_Excel
    {
        protected 商品資料 _Data;
        protected 物品組成資料 _物品組成資料;

        public 商品總覽匯出轉換(商品資料 Data_)
        {
            _Data = Data_;

            _物品組成資料 = new 物品組成資料(Data_);
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "編號";

            App_.Cells[1, 2] = "大類";
            App_.Cells[1, 3] = "小類";

            App_.Cells[1, 4] = "公司";
            App_.Cells[1, 5] = "客戶";

            App_.Cells[1, 6] = "名稱";
            App_.Cells[1, 7] = "品號";

            App_.Cells[1, 8] = "售價";
            App_.Cells[1, 9] = "成本";
            App_.Cells[1, 10] = "利潤";
            App_.Cells[1, 11] = "體積";
            App_.Cells[1, 12] = "寄庫數量";

            App_.Cells[1, 13] = "組成";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = _Data.編號;

            App_.Cells[Row_, 2] = _Data.大類.名稱;
            App_.Cells[Row_, 3] = _Data.小類.名稱;

            App_.Cells[Row_, 4] = _Data.公司.名稱;
            App_.Cells[Row_, 5] = _Data.客戶.名稱;

            App_.Cells[Row_, 6] = _Data.名稱;
            App_.Cells[Row_, 7] = _Data.品號;

            App_.Cells[Row_, 8] = _Data.售價;
            App_.Cells[Row_, 9] = _Data.成本;
            App_.Cells[Row_, 10] = _Data.利潤;
            App_.Cells[Row_, 11] = _Data.體積;
            App_.Cells[Row_, 12] = _Data.寄庫數量;


            App_.Cells[Row_, 13] = _物品組成資料.取得組合字串();


            return Row_ + 1;
        }
    }
}
