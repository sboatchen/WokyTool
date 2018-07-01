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
    public abstract class 資料管理器<T> : 可儲存類型 where T : MyKeepableData
    {
        // 資料Map
        public Dictionary<int, T> Map { get; /*@@private*/ set; }
        // 資料是否異動
        public bool IsDataDirty { get; private set; }

        // 資料BindingList
        public BindingList<T> BList { get; /*@@private*/ set; }
        // 資料BindingList 版本
        public int BindingVersion { get; private set; }

        public abstract string 檔案路徑 { get; }
        public abstract T 錯誤資料 { get; }
        public abstract 列舉.編碼類型 編碼類型 { get; }

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

            BList = new BindingList<T>(Map.Values.ToList());
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
            if (BList.Count != Map.Count)
                return true;

            foreach (var Item_ in BList)
            {
                if(Item_.isEditing())
                    return true;
            }

            return false;
        }

        public void UpdateEdit(bool IsSave_)
        {
            // ignore for speed up
            //if (IsEditing() == false)
            //    return;

            if (IsSave_)
                SaveEdit();
            else
                CancelEdit();
        }

        protected void SaveEdit()
        {
            Map = new Dictionary<int, T>();
            foreach (var Item_ in BList)
            {
                Item_.FinishEdit();

                if(Item_.編號 <= 常數.空白資料編碼)
                {
                    Item_.檢查合法();
                    Item_.編號 = 編碼管理器.Instance.Get(編碼類型);
                }

                Map[Item_.編號] = Item_;
            }

            BindingVersion++;
            SetDataDirty();
        }

        protected void CancelEdit()
        {
            BList.Clear();

            foreach (var Item_ in Map.Values)
            {
                Item_.CancelEdit();
                BList.Add(Item_);
            }
        }
    }
}
