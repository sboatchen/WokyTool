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
    public abstract class 可記錄資料<T> : 基本資料, IEditableObject, 可編號介面
    {
        protected T _副本;

        public abstract int 編號 { get; set; }

        public abstract T 拷貝();
        public abstract void 覆蓋(T Item_);
        public abstract bool 是否一致(T Item_);

        // IEditableObject
        public void BeginEdit()
        {
            if (_副本 == null)
                _副本 = 拷貝();
        }

        // IEditableObject
        public void CancelEdit()
        {
            if (_副本 != null)
                覆蓋(_副本);
        }

        // IEditableObject
        public void EndEdit()
        {
        }

        public virtual void 完成編輯()
        {
            _副本 = default(T);
        }

        public bool 是否正在編輯()
        {
            return _副本 != null && this.是否一致(_副本) == false;
        }

        public void 顯示編輯明細()
        {
            訊息管理器.獨體.訊息("---------");
            訊息管理器.獨體.訊息(this.ToString(false));
            訊息管理器.獨體.訊息("->");
            if(_副本 != null)
                訊息管理器.獨體.訊息(JsonConvert.SerializeObject(_副本, Formatting.None));
            訊息管理器.獨體.訊息("---------");
        }

        public bool 編號是否合法()
        {
            return 編號 != 常數.新建資料編碼 && 編號 != 常數.錯誤資料編碼;
        }

        public bool 編號是否有值()
        {
            return 編號 > 常數.新建資料編碼;
        }
    }
}
