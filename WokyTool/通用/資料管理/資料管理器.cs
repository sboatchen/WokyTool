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
        // 資料是否異動
        public bool IsDataDirty { get; private set; }

        // 資料BindingList
        public BindingList<T> 可編輯BList { get; private set; }
        public object 物件_可編輯BList { get{ return 可編輯BList; } }

        // 資料BindingList 版本
        public int BindingVersion { get; private set; }

        // 資料BindingList
        public BindingList<T> 唯讀BList { get; private set; }

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

        protected ListChangedEventHandler _可編輯BList資料增減事件;
        protected bool _是否增減資料 = false;

        // 建構子
        protected 資料管理器()
        {
            InitData();

            IsDataDirty = false;

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
            可編輯BList.Add(空白資料);
            可編輯BList.Add(錯誤資料);

            唯讀BList = new BindingList<T>();
            唯讀BList.AllowEdit = false;
            唯讀BList.AllowNew = false;
            唯讀BList.AllowRemove = false;
            唯讀BList.Add(空白資料);
            唯讀BList.Add(錯誤資料);

            foreach (T Item_ in Map.Values)
            {
                可編輯BList.Add(Item_);
                唯讀BList.Add(Item_);
            }

            _可編輯BList資料增減事件 = new ListChangedEventHandler(this.可編輯BList資料增減);
            可編輯BList.ListChanged += _可編輯BList資料增減事件;
        }

        public void 可編輯BList資料增減(object sender, ListChangedEventArgs e)
        {
            Console.WriteLine(e.ListChangedType.ToString());
            _是否增減資料 = true;
        }

        public void SetDataDirty()
        {
            IsDataDirty = true;
        }

        // 儲存檔案
        public void 儲存()
        {
            if (IsDataDirty)
            {
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
            if (_是否增減資料)
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

            可編輯BList.ListChanged -= _可編輯BList資料增減事件;

            if (IsSave_)
            {
                if (篩選介面 == null)
                    SaveEdit();
                else
                    SaveEditWithFilter();
            }
            else
                CancelEdit();

            可編輯BList.ListChanged += _可編輯BList資料增減事件;
            _是否增減資料 = false;
        }

        protected void SaveEdit()
        {
            唯讀BList.Clear();
            Map.Clear();
            foreach (var Item_ in 可編輯BList)
            {
                if (Item_.編號 < 常數.T新建資料編碼)
                {
                    Item_.CancelEdit();
                    唯讀BList.Add(Item_);
                    continue;
                }

                Item_.FinishEdit();

                if(Item_.編號 == 常數.T新建資料編碼)
                {
                    Item_.檢查合法();
                    Item_.編號 = 編碼管理器.Instance.Get(編碼類型);
                }

                Map[Item_.編號] = Item_;
                唯讀BList.Add(Item_);
            }

            BindingVersion++;
            SetDataDirty();
        }

        protected void SaveEditWithFilter()
        {
            foreach (T Item_ in Map.Values)
            {
                Item_.FinishEdit();
            }

            BindingVersion++;
            SetDataDirty();
        }

        protected void CancelEdit()
        {
            可編輯BList.Clear();
            可編輯BList.Add(空白資料);
            可編輯BList.Add(錯誤資料);

            if (篩選介面 == null)
            {
                foreach (T Item_ in Map.Values)
                {
                    可編輯BList.Add(Item_);
                }
            }
            else
            {
                foreach (T Item_ in Map.Values)
                {
                    Item_.CancelEdit();

                    if (篩選介面.篩選(Item_))
                        可編輯BList.Add(Item_);
                }
            }
        }

        protected void 更新篩選條件()
        {
            可編輯BList.ListChanged -= _可編輯BList資料增減事件;

            可編輯BList.Clear();
            可編輯BList.Add(空白資料);
            可編輯BList.Add(錯誤資料);

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
                //@@ 目前無法處理在過濾的list中 進行資料增減的問題
                //@@ 目前處理上 更新篩選時 會捨棄之前所有的增減 但修改維持
                可編輯BList.AllowNew = false;
                可編輯BList.AllowRemove = false;

                foreach (T Item_ in Map.Values)
                {
                    //Item_.CancelEdit();

                    if (篩選介面.篩選(Item_))
                        可編輯BList.Add(Item_);
                }
            }

            可編輯BList.ListChanged += _可編輯BList資料增減事件;
            _是否增減資料 = false;
        }
    }
}
