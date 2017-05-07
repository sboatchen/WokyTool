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
    class 物品大類管理器
    {
        // 檔案位置
        private static string FILE_PATH = "Set/ItemLType.csv";

        // 資料Map
        public Dictionary<int, 物品大類資料> Map { get; private set; }
        // 資料是否異動
        public bool IsDirty { get; private set; }
        // 資料綁定廣播
        public 監測綁定廣播<物品大類資料> Binding { get; private set; }

        // 獨體
        private static readonly 物品大類管理器 _Instance = new 物品大類管理器();
        public static 物品大類管理器 Instance
        {
            get
            {
                return _Instance;
            }
        }

        // 建構子
        private 物品大類管理器()
        {
            InitData();

            Binding = new 監測綁定廣播<物品大類資料>(Map.Select(x => x.Value));

            IsDirty = false;
        }

        // 初始化資料
        private void InitData()
        {
            if (File.Exists(FILE_PATH))
            {
                CsvContext SetReader_ = new CsvContext();
                Map = SetReader_.Read<物品大類資料>(FILE_PATH, 共用.ReaderDefine)
                                  .ToDictionary(Data => Data.編號);

                Map[-1] = 物品大類資料.ERROR;
                Map[0] = 物品大類資料.NULL;
            }
            else
            {
                MessageBox.Show("物品大類管理器::InitData fail, can't find file" + Directory.GetCurrentDirectory(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public 物品大類資料 Get(int ID)
        {
            物品大類資料 Item_;
            if (Map.TryGetValue(ID, out Item_))
            {
                return Item_;
            }

            MessageBox.Show("物品大類管理器 Get fail " + ID.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 物品大類資料.ERROR;
        }

        // 取得資料 - 匯入資料時用，找不到時不會報錯
        public 物品大類資料 Get(string Name)
        {
            if (Name == null || Name.Length == 0)
                return 物品大類資料.NULL;

            物品大類資料 Item_ = Map.Values
                                   .Where(Value => Value.名稱 == Name)
                                   .FirstOrDefault();

            if (Item_ == null)
                return 物品大類資料.ERROR;
            else
                return Item_;
        }

        // 取得資料 - 匯入資料時用，找不到時不會報錯
        public 物品大類資料 Get(string Name, WokyTool.Common.列舉.搜尋失敗處理類型 Type)
        {
            if (Name == null || Name.Length == 0)
                return 物品大類資料.NULL;

            物品大類資料 Item_ = Map.Values
                                   .Where(Value => Value.名稱 == Name)
                                   .FirstOrDefault();

            if (Item_ != null)
                return Item_;

            switch(Type)
            {
                case WokyTool.Common.列舉.搜尋失敗處理類型.無:
                    return 物品大類資料.ERROR;
                case WokyTool.Common.列舉.搜尋失敗處理類型.找不到時新增:
                {
                    物品大類資料 New_ = 物品大類資料.New(Name);
                    Add(New_);
                    return New_;
                }
                default:
                    MessageBox.Show("物品大類資料.Get.Swith不支援,請通知苦逼程式", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 物品大類資料.ERROR;
            }
        }

        // 新增資料
        public void Add(物品大類資料 Item_)
        {
            if (Map.ContainsKey(Item_.編號))
            {
                MessageBox.Show("物品大類管理器 Add fial, already have " + Item_.編號.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Map[Item_.編號] = Item_;

            SetDirty();
        }

        // 新增資料
        public void Add()
        {
            物品大類資料 Item_ = 物品大類資料.New();

            if (Map.ContainsKey(Item_.編號))
            {
                MessageBox.Show("物品大類管理器 Add Empty fail, 編號 = " + Item_.編號.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Map[Item_.編號] = Item_;

            SetDirty();
        }

        // 刪除資料
        public void Delete(物品大類資料 Item_)
        {
            if (Map.ContainsKey(Item_.編號))
            {
                Map.Remove(Item_.編號);

                SetDirty();
            }
            else
            {
                MessageBox.Show("物品大類管理器 Delete fail, 編號 = " + Item_.編號.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 刪除資料
        public void Delete(int ID_)
        {
            物品大類資料 Item_;
            if (Map.TryGetValue(ID_, out Item_))
            {
                Map.Remove(ID_);

                SetDirty();
            }
            else
            {
                MessageBox.Show("物品大類管理器 Delete fail, 編號 = " + ID_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
