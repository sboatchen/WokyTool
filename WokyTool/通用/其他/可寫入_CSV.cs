using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public interface 可寫入_CSV
    {
        String 分類 { get; }

        String 密碼 { get; }

        void 寫入(StringBuilder SB_);
    }
}
