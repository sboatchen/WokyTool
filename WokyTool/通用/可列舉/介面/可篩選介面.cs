using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 新版可篩選介面<T> : 可篩選介面_視窗
    {
        int 排序版本 { get; }
        int 篩選版本 { get; }

        IEnumerable<T> 篩選(IEnumerable<T> 資料列舉_);
        IEnumerable<T> 排序(IEnumerable<T> 資料列舉_);
    }
}
