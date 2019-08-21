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
        protected string _副本;

        public bool 是否編輯中 { get; protected set; }

        // IEditableObject
        public virtual void BeginEdit()
        {
            if (_副本 == null)
                _副本 = this.ToString(false);
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
            if (是否編輯中)
            {
                T 資料_ = _副本.轉成物件<T>();
                this.完全拷貝(資料_);

                _副本 = null;
            }
        }

        public virtual void 紀錄編輯(bool 是否列印_ = false)
        {
            if (是否列印_ && 是否編輯中)
            {
                訊息管理器.獨體.訊息("資列修改");

                訊息管理器.獨體.訊息(_副本);

                訊息管理器.獨體.訊息(this.ToString(false));

                訊息管理器.獨體.訊息("---------");
            }

            _副本 = null;
        }

        public virtual bool 更新編輯狀態()
        {
            if (_副本 == null)
            {
                是否編輯中 = false;
                return false;
            }

            string 資料_ = this.ToString(false);
            if (_副本.Equals(資料_))
            {
                _副本 = null;
                是否編輯中 = false;
                return false;
            }

            是否編輯中 = true;
            return true;
        }

        public virtual void 刪除檢查(可處理檢查介面 介面_) { ; }
    }
}
