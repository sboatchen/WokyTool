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
using WokyTool.通用;

namespace WokyTool.DataMgr
{
    class 編碼管理器
    {
        // 檔案位置
        private static string FILE_PATH = "Set/UID.csv";

        // 資料Map
        public Dictionary<列舉.編號, 編碼資料> Map { get; private set; }
        // 資料是否異動
        public bool IsDirty { get; private set; }
        // 資料綁定廣播
        public 監測綁定廣播<編碼資料> Binding { get; private set; }

        // 獨體
        private static readonly 編碼管理器 _Instance = new 編碼管理器();
        public static 編碼管理器 Instance
        {
            get
            {
                return _Instance;
            }
        }

        // 建構子
        private 編碼管理器()
        {
            InitData();

            Binding = new 監測綁定廣播<編碼資料>(Map.Select(x => x.Value));

            IsDirty = false;
        }

        // 初始化資料
        private void InitData()
        {
            if (File.Exists(FILE_PATH))
            {
                CsvContext SetReader_ = new CsvContext();
                Map = SetReader_.Read<編碼資料>(FILE_PATH, 共用.ReaderDefine)
                                  .ToDictionary(item => item.類型);
            }
            else
            {
                MessageBox.Show("編碼管理器::InitData fail, can't find file" + Directory.GetCurrentDirectory(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // 取得下個唯一識別碼,並進行更新
        public int Get(列舉.編號 eType)
        {
            編碼資料 Item_;
            if (Map.TryGetValue(eType, out Item_) == false)
            {
                Item_ = new 編碼資料(eType);
                Map.Add(eType, Item_);
            }

            IsDirty = true;

            int Value_ = Item_.下個值++;
            SetDirty();

            return Value_;
        }
    }
}
