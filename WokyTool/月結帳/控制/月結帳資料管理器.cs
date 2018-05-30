﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataMgr;

namespace WokyTool.月結帳
{
    public class 月結帳資料管理器
    {
        // 檔案位置
        private static string FILE_PATH = "History/月結帳.json";

        // 資料Map
        public Dictionary<int, 月結帳資料> Map { get; private set; }
        // 資料是否異動
        public bool IsDirty { get; private set; }
        // 資料綁定廣播
        public 監測綁定廣播<月結帳資料> Binding { get; private set; }

        // 獨體
        private static readonly 月結帳資料管理器 _Instance = new 月結帳資料管理器();
        public static 月結帳資料管理器 Instance
        {
            get
            {
                return _Instance;
            }
        }

        // 建構子
        private 月結帳資料管理器()
        {
            InitData();

            Binding = new 監測綁定廣播<月結帳資料>(Map.Select(x => x.Value));

            IsDirty = false;
        }

        // 初始化資料
        private void InitData()
        {
            if (File.Exists(FILE_PATH))
            {
                string json = File.ReadAllText(FILE_PATH);
                if (String.IsNullOrEmpty(json))
                    Map = new Dictionary<int, 月結帳資料>();
                else
                    Map = JsonConvert.DeserializeObject<Dictionary<int, 月結帳資料>>(json);
            }
            else
            {
                Map = new Dictionary<int, 月結帳資料>();
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
        public 月結帳資料 Get(int ID_)
        {
            月結帳資料 Item_;
            if (Map.TryGetValue(ID_, out Item_))
            {
                return Item_;
            }

            MessageBox.Show("月結帳資料管理器: Get fail " + ID_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 月結帳資料.ERROR;
        }

        // 新增資料
        public void Add(月結帳資料 Item_)
        {
            Item_.編號 = 編碼管理器.Instance.Get(列舉.編碼類型.月結帳);
            Map[Item_.編號] = Item_;

            SetDirty();
        }

        // 刪除資料
        public void Delete(月結帳資料 Item_)
        {
            // 確認物件
            if (Map.ContainsKey(Item_.編號) == false)
            {
                MessageBox.Show("月結帳資料管理器: Delete fail, 名稱 = " + Item_.編號, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Map.Remove(Item_.編號);
            SetDirty();
        }

        // 刪除資料
        public void Delete(int 編號_)
        {
            月結帳資料 Item_;
            if (Map.TryGetValue(編號_, out Item_) == false)
            {
                MessageBox.Show("月結帳資料管理器: Delete fail, 編號 = " + 編號_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Delete(Item_);
        }
    }
}
