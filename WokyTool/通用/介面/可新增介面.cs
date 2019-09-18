using System.Collections.Generic;

namespace WokyTool.通用
{
    public interface 可新增介面<T>
    {
        void 新增(T 資料_);
        void 新增(IEnumerable<T> 資料列舉_);
    }
}
