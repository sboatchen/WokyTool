using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 可讀出介面_CSV<T>
    {
        string 分格號 { get; }

        string 密碼 { get; }

        bool 是否有標頭 { get; }

        void 讀出標頭(string[] 標頭列_);

        IEnumerable<T> 讀出資料(string[] 資料列_);
    }
}
