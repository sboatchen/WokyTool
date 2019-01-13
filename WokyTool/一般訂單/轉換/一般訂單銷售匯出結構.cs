using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.一般訂單;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    public class 一般訂單銷售匯出結構 : 可序列化_Excel
    {
        public 一般訂單新增資料 資料 { get; set; }

        public String 標頭 
        {
            get
            {
                return "明細";
            }
        }

        public String 樣板 
        {
            get
            {
                //if (_是否列印單價)
                return Path.GetFullPath("樣板/一般訂單/一般出貨銷售匯出樣板.xlsx");
                //else
                //    return Path.GetFullPath("Template/DataExport/工廠出貨匯出樣板_無售價.xlsx");
            }
        }

        public 一般訂單銷售匯出結構(一般訂單新增資料 資料_)
        {
            資料 = 資料_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 2] = 資料.編號;
            App_.Cells[2, 2] = 時間.目前日期_斜線;
            App_.Cells[3, 2] = 資料.姓名;
            App_.Cells[4, 2] = 資料.電話;
            App_.Cells[5, 2] = 資料.手機;
            App_.Cells[6, 2] = 資料.地址;

            int Row_ = 9;
            decimal Total_ = 0;
            foreach (一般訂單新增商品資料 Item_ in 資料.清單)
            {
                if (Row_ > 9)
                {
                    Range line = (Range)App_.Rows[Row_];
                    line.Insert();
                }

                int Column_ = 0;

                App_.Cells[Row_, ++Column_] = Row_ - 8;
                App_.Cells[Row_, ++Column_] = Item_.商品編號;
                App_.Cells[Row_, ++Column_] = Item_.商品名稱;
                App_.Cells[Row_, ++Column_] = Item_.數量;

                //if (_是否列印單價)
                {
                    App_.Cells[Row_, ++Column_] = Item_.單價;
                    App_.Cells[Row_, ++Column_] = Item_.總金額;
                }

                App_.Cells[Row_, ++Column_] = Item_.備註;
                Total_ += Item_.總金額;

                Row_++;
            }

            // set total
            //if (_是否列印單價)
            {
                Row_ += 1;
                App_.Cells[Row_, 6] = Total_;
            }
        }
    }
}
