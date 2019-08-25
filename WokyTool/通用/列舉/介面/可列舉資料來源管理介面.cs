﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 可列舉資料來源管理介面 : 可列舉資料管理介面
    {
        void 更新資料(object 資料列obj_);
        void 更新資料();    // 用於重製資料

        void 合法檢查(可檢查介面 檢查器_);
    }
}
