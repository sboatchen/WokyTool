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
    public abstract class 匯入資料管理器<T> : 資料管理器介面 where T : MyData
    {
        // 資料BindingList
        public BindingList<T> 可編輯BList { get; set; }
        public object 物件_可編輯BList { get{ return 可編輯BList; } }

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
            可編輯BList = new BindingList<T>();
            編輯資料版本 = 1;
        }

        public void 新增(IEnumerable<T> Enumerator_)
        {
            if (Enumerator_ == null)
                return;

            可編輯BList.RaiseListChangedEvents = false;

            foreach (T Item_ in Enumerator_)
            {
                可編輯BList.Add(Item_);
            }

            編輯資料版本++;
            可編輯BList.RaiseListChangedEvents = true;
        }

        public void 資料編輯中()
        {
            編輯資料版本++;
        }

        public Boolean 是否正在編輯()
        {
            return 可編輯BList.Count > 0;
        }

        public void 完成編輯(bool IsSave_)
        {
            if (!IsSave_)
                return;

            可編輯BList.RaiseListChangedEvents = false;

            匯入();

            可編輯BList.Clear();

            編輯資料版本++;
            可編輯BList.RaiseListChangedEvents = true;
        }

        protected abstract void 匯入();

        public void 檢查合法()
        {
            foreach (T Item in 可編輯BList)
            {
                Item.檢查合法();
            }
        }
    }
}
