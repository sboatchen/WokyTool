using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    interface 選取元件介面
    {
        object SelectedValue{get; set;}

        void 視窗激活();
    }
}
