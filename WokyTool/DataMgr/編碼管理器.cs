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
    class 編碼管理器
    {
        // 檔案位置
        private static string FILE_PATH = "Set/UID.csv";

        // 資料Map
        public Dictionary<列舉.編碼類型, 編碼資料> Map { get; private set; }
        // Binding
        public BindingSource Binding { get; private set; }
        // 資料是否異動
        public bool IsDirty { get; set; }

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
        public int Get(列舉.編碼類型 eType)
        {
            編碼資料 Item_;
            if (Map.TryGetValue(eType, out Item_))
            {
                IsDirty = true;
                return Item_.下個值++;
            }

            MessageBox.Show("編碼管理器::Get fail " + eType.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }
    }
}
