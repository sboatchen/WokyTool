using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;

namespace WokyTool.DataExport
{
    public class 工廠出貨匯出結構 : 可樣板化_Excel
    {
        protected List<物品訂單資料> _Data;

        public 工廠出貨匯出結構(List<物品訂單資料> Data_)
        {
            _Data = Data_;
        }

        // 取得樣板位置
        public string GetTemplate()
        {
            return Path.GetFullPath("Template/DataExport/工廠出貨匯出樣板.xlsx");
        }

        // 設定資料
        public void SetData(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 2] = 共用.NowYMD;
            //App_.Cells[2,2] = "1235"; // 單號

            int Row_ = 8;
            int Total_ = 0;
            foreach (物品訂單資料 Item_ in _Data)
            {
                if (Row_ > 8)
                {
                    Range line = (Range)App_.Rows[Row_];
                    line.Insert();
                }

                App_.Cells[Row_, 1] = Row_ - 7;
                App_.Cells[Row_, 2] = Item_.物品.編號;
                App_.Cells[Row_, 3] = Item_.物品.名稱;
                App_.Cells[Row_, 5] = Item_.數量;
                App_.Cells[Row_, 6] = Item_.單價;
                App_.Cells[Row_, 7] = Item_.總金額;
                Total_ += Item_.總金額;

                Row_++;
            }

            // set total
            Row_ += 1;
            App_.Cells[Row_, 7] = Total_;
        }
    }
}
