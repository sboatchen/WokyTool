using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.通用;

namespace WokyTool.DataExport
{
    public class 工廠出貨匯出結構 : 可樣板化_Excel
    {
        protected List<物品訂單資料> _Data;
        protected bool _是否列印單價;

        public 工廠出貨匯出結構(List<物品訂單資料> Data_, bool 是否列印單價_)
        {
            _Data = Data_;
            _是否列印單價 = 是否列印單價_;
        }

        // 取得樣板位置
        public string GetTemplate()
        {
            if (_是否列印單價)
                return Path.GetFullPath("Template/DataExport/工廠出貨匯出樣板.xlsx");
            else
                return Path.GetFullPath("Template/DataExport/工廠出貨匯出樣板_無售價.xlsx");
        }

        // 設定資料
        public void SetData(Application App_)
        {
            if(_Data.Count <= 0)
                return;

            App_.Cells[1, 2] = _Data[0].流水號;
            App_.Cells[2, 2] = 時間.目前日期;
            App_.Cells[3, 2] = _Data[0].姓名;
            App_.Cells[4, 2] = _Data[0].電話;
            App_.Cells[5, 2] = _Data[0].手機;
            App_.Cells[6, 2] = _Data[0].地址;

            int Row_ = 9;
            int Total_ = 0;
            foreach (物品訂單資料 Item_ in _Data)
            {
                if (Row_ > 9)
                {
                    Range line = (Range)App_.Rows[Row_];
                    line.Insert();
                }

                int Column_ = 0;

                App_.Cells[Row_, ++Column_] = Row_ - 8;
                App_.Cells[Row_, ++Column_] = Item_.物品.編號;
                App_.Cells[Row_, ++Column_] = Item_.物品.名稱;
                App_.Cells[Row_, ++Column_] = Item_.數量;

                if (_是否列印單價)
                {
                    App_.Cells[Row_, ++Column_] = Item_.單價;
                    App_.Cells[Row_, ++Column_] = Item_.總金額;
                }

                App_.Cells[Row_, ++Column_] = Item_.備註;
                Total_ += Item_.總金額;

                Row_++;
            }

            // set total
            if (_是否列印單價)
            {
                Row_ += 1;
                App_.Cells[Row_, 6] = Total_;
            }
        }
    }
}
