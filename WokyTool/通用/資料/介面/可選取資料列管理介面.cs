using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 可選取資料列管理介面
    {
         // 資料BindingList
        object 可選取資料列 { get; }

        int 可選取資料列版本 { get; }
    }
}
