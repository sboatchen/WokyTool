using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public interface 可選擇子視窗<T> : 子視窗<T>
    {
         void SetDefaultSelect(T Item_);
    }
}
