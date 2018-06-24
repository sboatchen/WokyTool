using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public abstract class MyKeepableData : MyData, IEditableObject
    {
        private object _副本;

        public abstract int 編號 { get; set; }

        public abstract object 拷貝();
        public abstract void 覆蓋(object Item_);
        public abstract Boolean 是否一致(object Item_);

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

        public void FinishEdit()
        {
            _副本 = null;
        }

        public bool isEditing()
        {
            return _副本 != null && this.是否一致(_副本) == false;
        }
    }
}
