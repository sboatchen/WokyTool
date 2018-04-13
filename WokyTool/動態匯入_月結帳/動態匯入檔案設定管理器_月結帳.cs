using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.動態匯入_月結帳
{
    public class 動態匯入檔案設定管理器_月結帳   //@@ singleton parent class
    {
        // 檔案位置
        private static string FILE_PATH = "Set/月結帳設定.json";

        // 資料Map
        public Dictionary<string, 動態匯入檔案設定_月結帳> Map { get; private set; }
        // 資料是否異動
        public bool IsDirty { get; private set; }
        // 資料綁定廣播
        public 監測綁定廣播<動態匯入檔案設定_月結帳> Binding { get; private set; }

        // 獨體
        private static readonly 動態匯入檔案設定管理器_月結帳 _Instance = new 動態匯入檔案設定管理器_月結帳();
        public static 動態匯入檔案設定管理器_月結帳 Instance
        {
            get
            {
                return _Instance;
            }
        }

        // 建構子
        private 動態匯入檔案設定管理器_月結帳()
        {
            InitData();

            Binding = new 監測綁定廣播<動態匯入檔案設定_月結帳>(Map.Select(x => x.Value));

            IsDirty = false;
        }

        // 初始化資料
        private void InitData()
        {
            if (File.Exists(FILE_PATH))
            {
                string json = File.ReadAllText(FILE_PATH);
                if (String.IsNullOrEmpty(json))
                    Map = new Dictionary<string, 動態匯入檔案設定_月結帳>();
                else
                    Map = JsonConvert.DeserializeObject<Dictionary<string, 動態匯入檔案設定_月結帳>>(json);
            }
            else
            {
                MessageBox.Show("動態匯入檔案設定管理器_月結帳::InitData fail, can't find file" + Directory.GetCurrentDirectory() + FILE_PATH, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetDirty()
        {
            IsDirty = true;
            Binding.SetDirty();
        }

        // 儲存檔案
        public void SaveData()
        {
            if (IsDirty)
            {
                File.WriteAllText(FILE_PATH, JsonConvert.SerializeObject(Map, Formatting.Indented));
            }
        }

        // 取得資料
        public 動態匯入檔案設定_月結帳 Get(string Name_)
        {
            動態匯入檔案設定_月結帳 Item_;
            if (Map.TryGetValue(Name_, out Item_))
            {
                return Item_;
            }

            MessageBox.Show("動態匯入檔案設定管理器_月結帳: Get fail " + Name_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 動態匯入檔案設定_月結帳.ERROR;
        }

        // 新增資料
        public void Add(動態匯入檔案設定_月結帳 Item_)
        {
            if (Map.ContainsKey(Item_.名稱))
            {
                MessageBox.Show("動態匯入檔案設定管理器_月結帳: Add fial, already have " + Item_.名稱, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Map[Item_.名稱] = Item_;

            SetDirty();
        }

        // 刪除資料
        public void Delete(動態匯入檔案設定_月結帳 Item_)
        {
            // 確認物件
            if (Map.ContainsKey(Item_.名稱) == false)
            {
                MessageBox.Show("動態匯入檔案設定管理器_月結帳: Delete fail, 名稱 = " + Item_.名稱, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 檢查是否有其他資料綁定
            /*List<訊息資料> RelatedItem_ = 商品管理器.Instance.Map.Select(X => X.Value)
                                    .Where(X => (X.需求1 == Item_ || X.需求2 == Item_ || X.需求3 == Item_ || X.需求4 == Item_ || X.需求5 == Item_))
                                    .Select(X => new 訊息資料("商品", String.Format("{0}:{1}", X.編號, X.名稱)))
                                    .ToList();
            if (RelatedItem_.Count > 0)
            {
                var i = new 訊息列印視窗("物品刪除錯誤", RelatedItem_);
                i.Show();
                i.BringToFront();
                return;
            }*/

            // 確認刪除
            Map.Remove(Item_.名稱);
            SetDirty();
        }

        // 刪除資料
        public void Delete(string Name_)
        {
            動態匯入檔案設定_月結帳 Item_;
            if (Map.TryGetValue(Name_, out Item_) == false)
            {
                MessageBox.Show("動態匯入檔案設定管理器_月結帳: Delete fail, 名稱 = " + Name_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
             Delete(Item_);
        }
    }
}
