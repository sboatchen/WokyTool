using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public interface 可格式化_Excel
    {
        // 設定title，回傳下筆資料的輸入行位置
        int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_);

        // 設定資料
        int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_);
    }
}
