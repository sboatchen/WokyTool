﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    [Serializable]
    public abstract class 新版可記錄資料<T> : 可編輯資料<T>, 可編號介面 where T : 基本資料
    {
        public abstract int 編號 { get; set; }

        public virtual bool 編號是否合法()
        {
            return 編號 != 常數.新建資料編碼 && 編號 != 常數.錯誤資料編碼;
        }

        public bool 編號是否有值()
        {
            return 編號 > 常數.新建資料編碼;
        }
    }
}
