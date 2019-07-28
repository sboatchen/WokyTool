using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 可寫入介面_CSV
    {
        String 分類 { get; }

        String 分格號 { get; }

        String 密碼 { get; }

        void 寫入(CSVBuilder Builder_);
    }
}
