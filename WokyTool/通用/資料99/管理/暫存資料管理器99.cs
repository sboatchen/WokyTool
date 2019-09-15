using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WokyTool.通用
{
    public abstract class 暫存資料管理器<T> : 可編輯資料列管理介面 where T : 基本資料
    {
        // 資料BindingList
        public BindingList<T> 可編輯BList { get; set; }
        public object 可編輯資料列 { get{ return 可編輯BList; } }

        public virtual bool 是否可編輯 { get { return false; } }

        public int 可編輯資料列版本 { get; protected set; }

        // 建構子
        protected 暫存資料管理器()
        {
            if (是否可編輯 == false)
                throw new Exception("該資料缺少權限進行編輯" + this.GetType().ToString()); 

            可編輯BList = new BindingList<T>();
            可編輯BList.AllowEdit = true;
            可編輯BList.AllowNew = true;
            可編輯BList.AllowRemove = true;

            可編輯資料列版本 = 1;
        }

        public void 檢查合法()
        {
            // 檢查到第一個錯誤 即回傳
            foreach (T Item in 可編輯BList)
            {
                Item.檢查合法();
            }
        }

        public void 新增(IEnumerable<T> Enumerator_)
        {
            if (Enumerator_ == null)
                return;

            可編輯BList.RaiseListChangedEvents = false;

            foreach (T Item_ in Enumerator_)
            {
                if (Item_ == null)
                    continue;

                可編輯BList.Add(Item_);
            }

            可編輯資料列版本++;
            可編輯BList.RaiseListChangedEvents = true;

            try
            {
                檢查合法();
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.通知(ex.Message);
            }
        }

        public void 資料異動()
        {
            可編輯資料列版本++;
        }

        public virtual bool 是否正在編輯()
        {
            return 可編輯BList.Count > 0;
        }

        public virtual void 完成編輯(bool 是否存檔_)
        {
            //if (!IsSave_)
            //    return;

            檢查合法();

            可編輯資料列版本++;
        }
    }
}
