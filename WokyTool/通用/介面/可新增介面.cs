using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 可新增介面<T>
    {
        void 新增(T 資料_);
        void 新增(IEnumerable<T> 資料列舉_);
    }
}
