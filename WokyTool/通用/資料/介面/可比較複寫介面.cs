using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    interface 可比較複寫介面<T>
    {
        T 拷貝();
        void 覆蓋(T Item_);
        Boolean 是否一致(T Item_);
    }
}
