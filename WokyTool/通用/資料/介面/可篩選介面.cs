﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 可篩選介面<T>
    {
        bool 是否需篩選();

        bool 篩選(T Item_);
    }
}
