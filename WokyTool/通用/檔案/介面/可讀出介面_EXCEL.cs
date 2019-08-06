using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 可讀出介面_EXCEL<T>
    {
        int 分頁索引 { get; }

        int 標頭索引 { get; }

        int 資料開始索引 { get; }

        int 資料結尾忽略行數 { get; }

        String 密碼 { get; }

        void 讀出標頭(string[] 標頭列_);

        IEnumerable<T> 讀出資料(string[] 資料列_);
    }
}
