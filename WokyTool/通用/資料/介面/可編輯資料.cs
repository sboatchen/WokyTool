using System.ComponentModel;

namespace WokyTool.通用
{
    public abstract class 可編輯資料 : 基本資料, IEditableObject, 可刪除檢查介面
    {
        public virtual void BeginEdit()
        {
        }

        public virtual void CancelEdit()
        {
        }

        public virtual void EndEdit()
        {
        }

        public bool 是否編輯中 { get; protected set; }

        public abstract void 取消編輯();

        public abstract void 紀錄編輯(bool 是否列印_ = false);

        public abstract bool 更新編輯狀態();

        public virtual void 刪除檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null)
        { 
        }

        public virtual void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
        }
    }
}
