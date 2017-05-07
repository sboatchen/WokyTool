using LINQtoCSV;
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
    class 入庫管理器
    {
        // 檔案位置
        private static string FILE_PATH = "Work/Store.csv";

        // 資料Map
        public Dictionary<int, 入庫資料> Map { get; private set; }
        // 資料是否異動
        public bool IsDirty { get; private set; }
        // 資料綁定廣播
        public 監測綁定廣播<入庫資料> Binding { get; private set; }

        // 獨體
        private static readonly 入庫管理器 _Instance = new 入庫管理器();
        public static 入庫管理器 Instance
        {
            get
            {
                return _Instance;
            }
        }

        // 建構子
        private 入庫管理器()
        {
            InitData();

            Binding = new 監測綁定廣播<入庫資料>(Map.Select(x => x.Value));

            IsDirty = false;
        }

        // 初始化資料
        private void InitData()
        {
            if (File.Exists(FILE_PATH))
            {
                CsvContext SetReader_ = new CsvContext();
                Map = SetReader_.Read<入庫資料>(FILE_PATH, 共用.ReaderDefine)
                                  .ToDictionary(Data => Data.編號);

                Map[-1] = 入庫資料.ERROR;
                Map[0] = 入庫資料.NULL;
            }
            else
            {
                //@@ 暫時處理
                Map = new Dictionary<int, 入庫資料>();
                Map[-1] = 入庫資料.ERROR;
                Map[0] = 入庫資料.NULL;

                //@@ 暫時註解調，避免新版本找不到
                //MessageBox.Show("入庫管理器::InitData fail, can't find file " + Directory.GetCurrentDirectory(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //System.Environment.Exit(0);
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(Map.Values, Formatting.Indented);
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
                CsvContext cc = new CsvContext();
                cc.Write(Map.Values, FILE_PATH, 共用.OutputDefine);
                IsDirty = false;
            }
        }

        // 取得資料
        public 入庫資料 Get(int ID)
        {
            入庫資料 Item_;
            if (Map.TryGetValue(ID, out Item_))
            {
                return Item_;
            }

            MessageBox.Show("入庫管理器 Get fail " + ID.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 入庫資料.ERROR;
        }

        // 新增資料
        public void Add(入庫資料 Item_)
        {
            if (Map.ContainsKey(Item_.編號))
            {
                MessageBox.Show("入庫管理器 Add fial, already have " + Item_.編號.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Map[Item_.編號] = Item_;

            SetDirty(); ;
        }

        // 新增資料
        public void Add()
        {
            入庫資料 Item_ = 入庫資料.New();

            if (Map.ContainsKey(Item_.編號))
            {
                MessageBox.Show("入庫管理器 Add Empty fail, 編號 = " + Item_.編號.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Map[Item_.編號] = Item_;

            SetDirty();
        }

        // 刪除資料
        public bool Delete(入庫資料 Item_)
        {
            //@@ 如何避免帶入的參數資料與Map中的不一樣(有可能同編號)
            return Delete(Item_.編號);
        }

        // 刪除資料
        public bool Delete(int ID_) //@@ 全面改成有回傳
        {
            if (ID_ <= 常數.空白資料編碼)    //@@ 全面新增檢查
            {
                MessageBox.Show("入庫管理器::該資料無法刪除", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            入庫資料 Item_;
            if (Map.TryGetValue(ID_, out Item_) == false)
            {
                MessageBox.Show("入庫管理器::找不到資料 " + ID_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Item_.運作 == true)
            {
                MessageBox.Show("入庫管理器::該資料已運作，無法刪除", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);   //@@ 新增log系統
                return false;
            }

            Map.Remove(ID_);

            SetDirty();

            return true;
        }
    }
}

