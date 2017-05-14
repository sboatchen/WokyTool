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
using WokyTool.FormOther;

namespace WokyTool.DataMgr
{
    class 銷售管理器
    {
        // 檔案位置
        private static string FILE_PATH = "Work/Sell.csv";

        // 資料Map
        public Dictionary<int, 銷售資料> Map { get; private set; }
        // 資料是否異動
        public bool IsDirty { get; private set; }
        // 資料綁定廣播
        public 監測綁定廣播<銷售資料_編輯> Binding { get; private set; }

        // 獨體
        private static readonly 銷售管理器 _Instance = new 銷售管理器();
        public static 銷售管理器 Instance
        {
            get
            {
                return _Instance;
            }
        }

        // 建構子
        private 銷售管理器()
        {
            InitData();

            Binding = new 監測綁定廣播<銷售資料_編輯>(Map.Select(x => new 銷售資料_編輯(x.Value)));

            IsDirty = false;
        }

        // 初始化資料
        private void InitData()
        {
            if (File.Exists(FILE_PATH))
            {
                CsvContext SetReader_ = new CsvContext();
                Map = SetReader_.Read<銷售資料>(FILE_PATH, 共用.ReaderDefine)
                                  .ToDictionary(Data => Data.編號);

                Map[常數.錯誤資料編碼] = 銷售資料.ERROR;
                Map[常數.空白資料編碼] = 銷售資料.NULL;
            }
            else
            {
                //@@ temp
                Map = new Dictionary<int, 銷售資料>();
                Map[常數.錯誤資料編碼] = 銷售資料.ERROR;
                Map[常數.空白資料編碼] = 銷售資料.NULL;

                MessageBox.Show("銷售管理器::InitData fail, can't find file" + Directory.GetCurrentDirectory(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public 銷售資料 Get(int ID)
        {
            銷售資料 Item_;
            if (Map.TryGetValue(ID, out Item_))
            {
                return Item_;
            }

            MessageBox.Show("銷售管理器 Get fail " + ID.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 銷售資料.ERROR;
        }

        // 新增資料
        public void Add(銷售資料 Item_)
        {
            if (Map.ContainsKey(Item_.編號))
            {
                MessageBox.Show("銷售管理器 Add fial, already have " + Item_.編號.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Map[Item_.編號] = Item_;

            SetDirty();
        }

        // 刪除資料
        public void Delete(銷售資料 Item_)
        {
            // 確認物件
            if (Map.ContainsKey(Item_.編號) == false)
            {
                MessageBox.Show("銷售管理器 Delete fail, 編號 = " + Item_.編號.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 檢查是否有其他資料綁定
            // ...

            // 確認刪除
            Map.Remove(Item_.編號);
            SetDirty();
        }

        // 刪除資料
        public void Delete(int ID_)
        {
            銷售資料 Item_;
            if (Map.TryGetValue(ID_, out Item_))
            {
                Delete(Item_);
            }
            else
            {
                MessageBox.Show("銷售管理器 Delete fail, 編號 = " + ID_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
