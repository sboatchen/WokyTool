using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public interface 可格式化_Excel
    {
        void TitleToExcelCell(Microsoft.Office.Interop.Excel.Application App_);
        void ToExcelCell(Microsoft.Office.Interop.Excel.Application App_, int Row_);
    }
}
