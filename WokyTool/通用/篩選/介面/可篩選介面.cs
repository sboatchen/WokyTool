﻿using System.Collections.Generic;

namespace WokyTool.通用
{
    public interface 新版可篩選介面<T> : 視窗可篩選介面
    {
        int 排序版本 { get; }
        int 篩選版本 { get; }

        IEnumerable<T> 篩選(IEnumerable<T> 資料列舉_);
        IEnumerable<T> 排序(IEnumerable<T> 資料列舉_);
    }
}
