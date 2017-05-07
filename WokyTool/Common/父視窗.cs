using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public interface 父視窗<T>
    {
        void onChildClosing(子視窗<T> Child_);

        void onClickFilter(子視窗<T> Child_);
    }
}
