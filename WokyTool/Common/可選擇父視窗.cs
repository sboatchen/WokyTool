using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public interface 可選擇父視窗<T> : 父視窗<T>
    {
        void onSelect(T Item_);
    }
}
