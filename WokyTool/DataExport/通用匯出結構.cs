using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.DataExport
{
    public class 通用匯出結構 : 可格式化_Excel
    {
        public String Name { get; private set; }
        protected Dictionary<String, String> Data { get; private set; }

        public 通用匯出結構(String Name_)
        {
            Name = Name_;
            Data = new Dictionary<String, String>();
        }

        // 新增資料
        public void Add(String Key_, String Value_)
        {
            Data[Key_] = Value_;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "屬性";
            App_.Cells[1, 2] = "數值";

            int Row_ = 2;
            foreach (var Pair_ in Data)
            {
                App_.Cells[Row_, 1] = Pair_.Key;
                App_.Cells[Row_, 2] = Pair_.Value;
                Row_++;
            }

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            return Row_;
        }
    }
}
