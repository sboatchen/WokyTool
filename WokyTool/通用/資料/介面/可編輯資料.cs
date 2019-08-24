using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    public abstract class 可編輯資料<T> : 基本資料, IEditableObject, 可刪除檢查介面 where T : 基本資料
    {
        public bool 是否編輯中 { get; protected set; }

        // IEditableObject
        public abstract void BeginEdit();

        public virtual void CancelEdit()
        {
        }

        public virtual void EndEdit()
        {
        }

        public abstract void 取消編輯();

        public abstract void 紀錄編輯(bool 是否列印_ = false);

        public abstract bool 更新編輯狀態();

        public virtual void 刪除檢查(可處理檢查介面 介面_)
        { 
        }

        public virtual void 合法檢查(可處理檢查介面 介面_, IEnumerable<T> 資料列舉_)
        {
        }
    }
}
