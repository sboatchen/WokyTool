using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataMgr;

namespace WokyTool.通用
{
    public abstract class 匯入資料管理器<T> : 資料管理器介面 where T : 可匯入資料
    {
        // 資料BindingList
        public BindingList<T> 可編輯BList { get; set; }
        public object 物件_可編輯BList { get{ return 可編輯BList; } }

        public virtual bool 是否可編輯 { get { return false; } }

        public object 物件_唯讀BList 
        {
            get 
            {
                throw new Exception("目前不支援 物件_唯讀BList"); 
            } 
        }

        public int 編輯資料版本 { get; protected set; }
        public int 唯讀資料版本 
        {
            get 
            { 
                throw new Exception("目前不支援 唯讀資料版本"); 
            }
        }

        // 建構子
        protected 匯入資料管理器()
        {
            if (是否可編輯 == false)
                throw new Exception("該資料缺少權限進行編輯" + this.GetType().ToString()); 

            可編輯BList = new BindingList<T>();
            可編輯BList.AllowEdit = true;
            可編輯BList.AllowNew = true;
            可編輯BList.AllowRemove = true;

            編輯資料版本 = 1;
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
            }

            編輯資料版本++;
            可編輯BList.RaiseListChangedEvents = true;

            檢查合法();
        }

        public void 資料異動()
        {
            編輯資料版本++;
        }

        public bool 是否正在編輯()
        {
            return 可編輯BList.Count > 0;
        }

        public void 完成編輯(bool IsSave_)
        {
            if (!IsSave_)
                return;

            檢查合法();

            可編輯BList.RaiseListChangedEvents = false;

            匯入();

            可編輯BList.Clear();
            編輯資料版本++;

            可編輯BList.RaiseListChangedEvents = true;
        }

        protected abstract void 匯入();
    }
}
