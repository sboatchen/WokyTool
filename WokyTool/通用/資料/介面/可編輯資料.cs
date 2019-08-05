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
    [Serializable]
    public abstract class 可編輯資料<T> : 基本資料, IEditableObject where T : 基本資料
    {
        [NonSerialized()]
        protected byte[] _副本;

        // IEditableObject
        public virtual void BeginEdit()
        {
            if (_副本 == null)
                _副本 = this.轉成位元組();
        }

        // IEditableObject
        public void CancelEdit()
        {
            // 無用
        }

        // IEditableObject
        public void EndEdit()
        {
            // 無用
        }

        public virtual void 取消編輯()
        {
            if (_副本 != null)
            {
                T 資料_ = _副本.轉成物件<T>();
                this.完全拷貝(資料_);

                _副本 = null;
            }
        }

        public virtual void 紀錄編輯(bool 是否列印_ = false)
        {
            if (是否列印_ && _副本 != null)
            {
                訊息管理器.獨體.訊息("資列修改");

                T 資料_ = _副本.轉成物件<T>();
                訊息管理器.獨體.訊息(資料_.ToString(false));

                訊息管理器.獨體.訊息(this.ToString(false));

                訊息管理器.獨體.訊息("---------");
            }

            _副本 = null;
        }

        public virtual bool 是否正在編輯()
        {
            if (_副本 == null)
                return false;

            byte[] 位元組_ = this.轉成位元組();

            return _副本.是否相等(位元組_) == false;
        }
    }
}
