using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 可寫入介面_CSV
    {
        string 分類 { get; }

        string 分格號 { get; }

        string 密碼 { get; }

        Encoding 編碼 { get; }

        void 寫入(CSVBuilder Builder_);
    }
}
