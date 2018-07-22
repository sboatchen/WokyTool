using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    public abstract class MyKeepableData<T> : MyData, IEditableObject, 可比較複寫介面<T>, 可編號介面
    {
        private T _副本;

        public abstract int 編號 { get; set; }

        public abstract T 拷貝();
        public abstract void 覆蓋(T Item_);
        public abstract Boolean 是否一致(T Item_);

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
            _副本 = default(T);
        }

        public bool isEditing()
        {
            return _副本 != null && this.是否一致(_副本) == false;
        }

        public void showEditDetail()
        {
            Console.WriteLine(this.ToString());
            Console.WriteLine("---------");
            if(_副本 != null)
                Console.WriteLine(_副本.ToString());
        }

        public bool 編號是否合法()
        {
            return 編號 != 常數.T新建資料編碼 && 編號 != 常數.T錯誤資料編碼;
        }
    }
}
