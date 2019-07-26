using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 可讀出_CSV<T>
    {
        String 分格號 { get; }

        String 密碼 { get; }

        List<T> 讀出(String 內容_);
    }
}
