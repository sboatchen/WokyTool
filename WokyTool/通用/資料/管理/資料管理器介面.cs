﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 資料管理器介面
    {
         // 資料BindingList
        object 物件_可編輯BList { get; }
        object 物件_唯讀BList { get; }

        int 編輯資料版本 { get; }
        int 唯讀資料版本 { get; }

        Boolean 是否正在編輯();
        void 完成編輯(bool IsSave_);

        void 資料編輯中();

        void 檢查合法();
    }
}
