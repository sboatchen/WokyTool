using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public bool 資料是否異動 { get; private set; }

        // 資料BindingList
        public BindingList<T> 可編輯BList { get; private set; }
        public object 物件_可編輯BList { get{ return 可編輯BList; } }

        // 資料BindingList
        public BindingList<T> 唯讀BList { get; private set; }
        public object 物件_唯讀BList { get { return 唯讀BList; } }

        public int 編輯資料版本 { get; private set; }
        public int 唯讀資料版本 { get; private set; }

        public abstract string 檔案路徑 { get; }
        public abstract T 空白資料 { get; }
        public abstract T 錯誤資料 { get; }
        public abstract 列舉.編碼類型 編碼類型 { get; }

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
            InitData();

            資料是否異動 = false;
            編輯資料版本 = 1;
            唯讀資料版本 = 1;

            資料儲存管理器.獨體.註冊(編碼類型, this);
        }

        // 初始化資料
        private void InitData()
        {
            if (File.Exists(檔案路徑))
            {
                string json = File.ReadAllText(檔案路徑);
                if (String.IsNullOrEmpty(json))
                    Map = new Dictionary<int, T>();
                else
                    Map = JsonConvert.DeserializeObject<Dictionary<int, T>>(json);
            }
            else
            {
                Map = new Dictionary<int, T>();
            }

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
                檔案.設定備份(檔案路徑, true);

                // 更新資料
                File.WriteAllText(檔案路徑, JsonConvert.SerializeObject(Map, Formatting.Indented));
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

        // 新增資料
        //public void Add(T Item_)
        //{
        //    if (Item_.編號 > 常數.空白資料編碼)
        //        throw new Exception(this.GetType() + ":資料已有編號 " + Item_.ToString());

        //    Item_.編號 = 編碼管理器.Instance.Get(編碼類型);
        //    Map[Item_.編號] = Item_;

        //    SetDataDirty();
        //    SetBindingDirty();
        //}

        // 刪除資料
        //public void Delete(T Item_)
        //{
        //    // 確認物件
        //    if (Map.ContainsKey(Item_.編號) == false)
        //    {
        //        MessageBox.Show(this.GetType() + ":刪除失敗 " + Item_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    //@@ 檢查是否有其他資料綁定
        //    /*List<訊息資料> RelatedItem_ = 商品管理器.Instance.Map.Select(X => X.Value)
        //                            .Where(X => (X.需求1 == Item_ || X.需求2 == Item_ || X.需求3 == Item_ || X.需求4 == Item_ || X.需求5 == Item_))
        //                            .Select(X => new 訊息資料("商品", String.Format("{0}:{1}", X.編號, X.名稱)))
        //                            .ToList();
        //    if (RelatedItem_.Count > 0)
        //    {
        //        var i = new 訊息列印視窗("物品刪除錯誤", RelatedItem_);
        //        i.Show();
        //        i.BringToFront();
        //        return;
        //    }*/

        //    // 確認刪除
        //    Map.Remove(Item_.編號);

        //    SetDataDirty();
        //    SetBindingDirty();
        //}

        // 刪除資料
        //public void Delete(int 編號_)
        //{
        //    T Item_;
        //    if (Map.TryGetValue(編號_, out Item_) == false)
        //    {
        //        MessageBox.Show(this.GetType() + ":刪除失敗, 編號 = " + 編號_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    Delete(Item_);
        //}

        public Boolean IsEditing()
        {
            //if (可編輯BList.Count != (Map.Count + 2))
            if (是否減少資料)
                return true;

            foreach (var Item_ in 可編輯BList)
            {
                if (Item_.isEditing())
                {
                    Item_.showEditDetail();
                    return true;
                }
            }

            return false;
        }

        public void UpdateEdit(bool IsSave_)
        {
            // ignore for speed up
            //if (IsEditing() == false)
            //    return;

            可編輯BList.RaiseListChangedEvents = false;
            唯讀BList.RaiseListChangedEvents = false;

            if (IsSave_)
            {
                if (篩選介面 == null)
                    SaveEdit();
                else
                    SaveEditWithFilter();
            }
            else
                CancelEdit();

            可編輯BList.RaiseListChangedEvents = true;
            唯讀BList.RaiseListChangedEvents = true;
            是否減少資料 = false;
        }

        protected void SaveEdit()
        {
            Map.Clear();
            
            唯讀BList.Clear();
            唯讀BList.Add(空白資料);
            唯讀BList.Add(錯誤資料);

            foreach (var Item_ in 可編輯BList)
            {
                Item_.FinishEdit();

                if (Item_.編號 == 常數.T新建資料編碼)
                {
                    Item_.檢查合法();
                    Item_.編號 = 編碼管理器.Instance.Get(編碼類型);
                }

                Map[Item_.編號] = Item_;
                唯讀BList.Add(Item_);
            }

            編輯資料版本++;
            唯讀資料版本++;
            資料是否異動 = true;
        }

        protected void SaveEditWithFilter()
        {
            //@@ 目前套用Filter 不支援新增刪除
            foreach (T Item_ in Map.Values)
            {
                Item_.FinishEdit();
            }

            編輯資料版本++;
            唯讀資料版本++;
            資料是否異動 = true;
        }

        protected void CancelEdit()
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
                    //Item_.CancelEdit();

                    if (篩選介面.篩選(Item_))
                        可編輯BList.Add(Item_);
                }
            }

            可編輯BList.RaiseListChangedEvents = true;
            編輯資料版本++;
            是否減少資料 = false;
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
