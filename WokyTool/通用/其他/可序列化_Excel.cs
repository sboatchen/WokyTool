using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public interface 可序列化_Excel
    {
        String 標頭 { get; }

        String 樣板 { get; }

        void 寫入(Microsoft.Office.Interop.Excel.Application App_);

        https://xyz.cinc.biz/2013/10/csharp-create-excel.html
    }
}
