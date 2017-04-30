﻿using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.Data;

namespace WokyTool.DataMgr
{
    class 公司管理器
    {
        // 檔案位置
        private static string FILE_PATH = "Set/Home.csv";

        // 資料Map
        public Dictionary<int, 公司資料> Map { get; private set; }
        // Binding
        public BindingSource Binding { get; private set; }
        // 資料是否異動
        public bool IsDirty { get; set; }

        // 獨體
        private static readonly 公司管理器 _Instance = new 公司管理器();
        public static 公司管理器 Instance
        {
            get
            {
                return _Instance;
            }
        }

        // 建構子
        private 公司管理器()
        {
            InitData();

            Binding = new BindingSource();
            Binding.DataSource = Map.Values;

            IsDirty = false;
        }

        // 初始化資料
        private void InitData()
        {
            if (File.Exists(FILE_PATH))
            {
                CsvContext SetReader_ = new CsvContext();
                Map = SetReader_.Read<公司資料>(FILE_PATH, 共用.ReaderDefine)
                                  .ToDictionary(Data => Data.編號);

                Map[-1] = 公司資料.ERROR;
                Map[0] = 公司資料.NULL;
            }
            else
            {
                //@@ 暫時處理
                Map = new Dictionary<int, 公司資料>();
                Map[-1] = 公司資料.ERROR;
                Map[0] = 公司資料.NULL;

                //@@ 暫時註解調，避免新版本找不到
                //MessageBox.Show("公司管理器::InitData fail, can't find file " + Directory.GetCurrentDirectory(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //System.Environment.Exit(0);
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(Map.Values, Formatting.Indented);
        }

        // 儲存檔案
        public void SaveData()
        {
            if (IsDirty)
            {
                CsvContext cc = new CsvContext();
                cc.Write(Map.Values, FILE_PATH, 共用.OutputDefine);
                IsDirty = false;
            }
        }

        // 取得資料
        public 公司資料 Get(int ID)
        {
            公司資料 Item_;
            if (Map.TryGetValue(ID, out Item_))
            {
                return Item_;
            }

            MessageBox.Show("公司管理器 Get fail " + ID.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 公司資料.ERROR;
        }

        // 取得資料 - 匯入資料時用，找不到時不會報錯
        public 公司資料 Get(string Name)
        {
            if (Name == null || Name.Length == 0)
                return 公司資料.NULL;

            公司資料 Item_ = Map.Values
                                .Where(Value => Value.名稱 == Name)
                                .FirstOrDefault();

            if (Item_ == null)
                return 公司資料.ERROR;
            else
                return Item_;
        }

        // 新增資料
        public void Add(公司資料 Item_)
        {
            if (Map.ContainsKey(Item_.編號))
            {
                MessageBox.Show("公司管理器 Add fial, already have " + Item_.編號.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Map[Item_.編號] = Item_;

            Binding.Add(Item_);
            IsDirty = true;
        }

        // 新增資料
        public void Add()
        {
            公司資料 Item_ = 公司資料.New();

            if (Map.ContainsKey(Item_.編號))
            {
                MessageBox.Show("公司管理器 Add Empty fail, 編號 = " + Item_.編號.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Map[Item_.編號] = Item_;

            Binding.Add(Item_);
            IsDirty = true;
        }

        // 刪除資料
        public void Delete(公司資料 Item_)
        {
            if (Map.ContainsKey(Item_.編號))
            {
                Map.Remove(Item_.編號);

                Binding.Remove(Item_);
                IsDirty = true;
            }
            else
            {
                MessageBox.Show("公司管理器 Delete fail, 編號 = " + Item_.編號.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 刪除資料
        public void Delete(int ID_)
        {
            公司資料 Item_;
            if (Map.TryGetValue(ID_, out Item_))
            {
                Map.Remove(ID_);
                Binding.Remove(Item_);
                IsDirty = true;
            }
            else
            {
                MessageBox.Show("公司管理器 Delete fail, 編號 = " + ID_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
