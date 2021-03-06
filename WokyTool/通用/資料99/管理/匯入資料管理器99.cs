﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WokyTool.通用
{
    public abstract class 匯入資料管理器<T> : 可編輯資料列管理介面 where T : 可匯入資料
    {
        // 資料BindingList
        public BindingList<T> 可編輯BList { get; set; }
        public object 可編輯資料列 { get{ return 可編輯BList; } }

        public virtual bool 是否可編輯 { get { return false; } }

        public int 可編輯資料列版本 { get; protected set; }

        // 建構子
        protected 匯入資料管理器()
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
            // 全部檢查過一遍 更新錯誤訊息
            Exception FirstException_ = null;
            foreach (T Item in 可編輯BList)
            {
                try
                {
                    Item.檢查合法();
                    Item.錯誤訊息 = null;
                }
                catch (Exception ex)
                {
                    Item.錯誤訊息 = ex.Message;
                    if (FirstException_ == null)
                        FirstException_ = ex;
                }
            }

            if (FirstException_ != null)
                throw FirstException_;
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

                //Console.WriteLine(JsonConvert.SerializeObject(Item_, Formatting.Indented));
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

        public bool 是否正在編輯()
        {
            return 可編輯BList.Count > 0;
        }

        public void 完成編輯(bool 是否存檔_)
        {
            if (!是否存檔_)
                return;

            檢查合法();

            可編輯BList.RaiseListChangedEvents = false;

            匯入();

            可編輯BList.Clear();
            可編輯資料列版本++;

            可編輯BList.RaiseListChangedEvents = true;
        }

        protected abstract void 匯入();
    }
}
