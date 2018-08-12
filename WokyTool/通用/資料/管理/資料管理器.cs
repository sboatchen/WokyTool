﻿using Newtonsoft.Json;
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
    public abstract class 資料管理器<T> : 可儲存介面, 資料管理器介面 where T : MyKeepableData<T>
    {
        // 資料Map
        public Dictionary<int, T> Map { get; /*@@private*/ set; }
        public bool 資料是否異動 { get; protected set; }

        // 資料BindingList
        public BindingList<T> 可編輯BList { get; protected set; }
        public object 物件_可編輯BList { get{ return 可編輯BList; } }

        // 資料BindingList
        public BindingList<T> 唯讀BList { get; protected set; }
        public object 物件_唯讀BList { get { return 唯讀BList; } }

        public int 編輯資料版本 { get; protected set; }
        public int 唯讀資料版本 { get; protected set; }

        public virtual bool 資料是否加密 { get { return false; } }
        public virtual bool 資料是否備份 { get { return true; } }

        public abstract string 檔案路徑 { get; }
        public abstract T 空白資料 { get; }
        public abstract T 錯誤資料 { get; }
        public abstract 列舉.編號 編號類型 { get; }

        protected 可篩選介面<T> _篩選介面 = null;
        public 可篩選介面<T> 篩選介面
        {
            get
            {
                return _篩選介面;
            }
            set
            {
                _篩選介面 = value;
                更新篩選條件();
            }
        }

        protected int _增減資料數量 = 0;
        protected bool 是否減少資料
        {
            get
            {
                return _增減資料數量 < 0; // 當BindingList == 0 時，系統預設加的資料不會進行刪除
            }
            set
            {
                if (value != false)
                    throw new Exception("是否減少資料不可自行設定為true");

                _增減資料數量 = 0;
            }
        }

        // 建構子
        protected 資料管理器()
        {
            初始化資料();

            可編輯BList = new BindingList<T>();
            可編輯BList.RaiseListChangedEvents = false;
            可編輯BList.ListChanged += new ListChangedEventHandler(this.可編輯BList資料增減);

            唯讀BList = new BindingList<T>();
            唯讀BList.AllowEdit = false;
            唯讀BList.AllowNew = false;
            唯讀BList.AllowRemove = false;
            唯讀BList.RaiseListChangedEvents = false;
            唯讀BList.Add(空白資料);
            唯讀BList.Add(錯誤資料);

            foreach (T Item_ in Map.Values)
            {
                可編輯BList.Add(Item_);
                唯讀BList.Add(Item_);
            }

            可編輯BList.RaiseListChangedEvents = true;
            唯讀BList.RaiseListChangedEvents = true;

            資料是否異動 = false;
            編輯資料版本 = 1;
            唯讀資料版本 = 1;

            資料儲存管理器.獨體.註冊(編號類型, this);
        }

        protected void 初始化資料()
        {
            if (File.Exists(檔案路徑))
            {
                string json = 檔案.讀出檔案(檔案路徑, 資料是否加密);
                if (String.IsNullOrEmpty(json))
                    Map = new Dictionary<int, T>();
                else
                    Map = JsonConvert.DeserializeObject<Dictionary<int, T>>(json);
            }
            else
            {
                Map = new Dictionary<int, T>();
            }
        }

        public void 可編輯BList資料增減(object sender, ListChangedEventArgs e)
        {
            Console.WriteLine(e.ListChangedType.ToString());
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                _增減資料數量--;
            }
            else if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                _增減資料數量++;
            }
        }

        // 儲存檔案
        public void 儲存()
        {
            if (資料是否異動)
            {
                // 備份舊資料
                if (資料是否備份)
                    檔案.備份資料檔案(檔案路徑, true);

                // 更新資料
                檔案.寫入檔案(檔案路徑, JsonConvert.SerializeObject(Map, Formatting.Indented), 資料是否加密);
            }
        }

        public void 檢查合法()
        {
            foreach (T Item in Map.Values)
            {
                Item.檢查合法();
            }
        }

        // 取得資料
        public T Get(int ID_)
        {
            if (ID_ == 常數.T空白資料編碼)
                return 空白資料;

            if (ID_ == 常數.T錯誤資料編碼)
                return 錯誤資料;

            T Item_;
            if (Map.TryGetValue(ID_, out Item_))
            {
                return Item_;
            }

            return 錯誤資料;
        }

        public void 資料編輯中()
        {
            編輯資料版本++;
        }

        public Boolean 是否正在編輯()
        {
            //if (可編輯BList.Count != (Map.Count + 2))
            if (是否減少資料)
                return true;

            foreach (var Item_ in 可編輯BList)
            {
                if (Item_.是否正在編輯())
                {
                    Item_.顯示編輯明細();
                    return true;
                }
            }

            return false;
        }

        public void 完成編輯(bool IsSave_)
        {
            // ignore for speed up
            //if (是否正在編輯() == false)
            //    return;

            可編輯BList.RaiseListChangedEvents = false;
            唯讀BList.RaiseListChangedEvents = false;

            if (IsSave_)
            {
                if (篩選介面 == null)
                    儲存編輯();
                else
                    儲存編輯_過濾();
            }
            else
                取消編輯();

            可編輯BList.RaiseListChangedEvents = true;
            唯讀BList.RaiseListChangedEvents = true;
            是否減少資料 = false;
        }

        protected void 儲存編輯()
        {
            Map.Clear();
            
            唯讀BList.Clear();
            唯讀BList.Add(空白資料);
            唯讀BList.Add(錯誤資料);

            foreach (var Item_ in 可編輯BList)
            {
                Item_.完成編輯();

                if (Item_.編號 == 常數.T新建資料編碼)
                {
                    Item_.檢查合法();
                    Item_.編號 = 編碼管理器.Instance.Get(編號類型);
                }

                Map[Item_.編號] = Item_;
                唯讀BList.Add(Item_);
            }

            編輯資料版本++;
            唯讀資料版本++;
            資料是否異動 = true;
        }

        protected void 儲存編輯_過濾()
        {
            //@@ 目前套用Filter 不支援新增刪除
            foreach (T Item_ in Map.Values)
            {
                Item_.完成編輯();
            }

            編輯資料版本++;
            唯讀資料版本++;
            資料是否異動 = true;
        }

        protected void 取消編輯()
        {
            if (篩選介面 == null)
            {
                可編輯BList.Clear();

                foreach (T Item_ in Map.Values)
                {
                    Item_.CancelEdit();
                    可編輯BList.Add(Item_);
                }
            }
            else
            {
                // 套用Filter 不支援新增刪除
                foreach (T Item_ in Map.Values)
                {
                    Item_.CancelEdit();
                }
            }
        }

        protected void 更新篩選條件()
        {
            可編輯BList.RaiseListChangedEvents = false;

            可編輯BList.Clear();

            if (篩選介面 == null)
            {
                可編輯BList.AllowNew = true;
                可編輯BList.AllowRemove = true;

                foreach (T Item_ in Map.Values)
                {
                    可編輯BList.Add(Item_);
                }
            }
            else
            {
                //@@ 目前套用Filter 不支援新增刪除
                可編輯BList.AllowNew = false;
                可編輯BList.AllowRemove = false;

                foreach (T Item_ in Map.Values)
                {
                    //Item_.取消編輯();

                    if (篩選介面.篩選(Item_))
                        可編輯BList.Add(Item_);
                }
            }

            可編輯BList.RaiseListChangedEvents = true;
            編輯資料版本++;
            是否減少資料 = false;
        }

        public void 新增(IEnumerable<T> Enumerator_)
        {
            可編輯BList.RaiseListChangedEvents = false;
            唯讀BList.RaiseListChangedEvents = false;

            foreach (T Item_ in Enumerator_)
            {
                Item_.完成編輯();

                if (Item_.編號 == 常數.T新建資料編碼)
                {
                    Item_.檢查合法();
                    Item_.編號 = 編碼管理器.Instance.Get(編號類型);
                }

                Map[Item_.編號] = Item_;

                if (篩選介面 == null || 篩選介面.篩選(Item_))
                    可編輯BList.Add(Item_);

                唯讀BList.Add(Item_);
            }

            編輯資料版本++;
            唯讀資料版本++;
            資料是否異動 = true;

            可編輯BList.RaiseListChangedEvents = true;
            唯讀BList.RaiseListChangedEvents = true;
        }

        public void 資料搬移()  //@@ temp
        {
            可編輯BList.RaiseListChangedEvents = false;
            唯讀BList.RaiseListChangedEvents = false;

            可編輯BList.Clear();

            唯讀BList.Clear();
            唯讀BList.Add(空白資料);
            唯讀BList.Add(錯誤資料);

            foreach (T Item_ in Map.Values)
            {
                可編輯BList.Add(Item_);
                唯讀BList.Add(Item_);
            }

            可編輯BList.RaiseListChangedEvents = true;
            唯讀BList.RaiseListChangedEvents = true;
            是否減少資料 = false;
            資料是否異動 = true;
        }
    }
}
