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
    public class 平台訂單資料管理器
    {
        // 檔案位置
        private static string FILE_PATH = "History/平台訂單.json";

        // 資料Map
        public Dictionary<int, 商品訂單資料> Map { get; private set; }
        // 資料是否異動
        public bool IsDirty { get; private set; }
        // 資料綁定廣播
        public 監測綁定廣播<商品訂單資料> Binding { get; private set; }

        // 獨體
        private static readonly 平台訂單資料管理器 _Instance = new 平台訂單資料管理器();
        public static 平台訂單資料管理器 Instance
        {
            get
            {
                return _Instance;
            }
        }

        // 建構子
        private 平台訂單資料管理器()
        {
            InitData();

            Binding = new 監測綁定廣播<商品訂單資料>(Map.Select(x => x.Value));

            IsDirty = false;
        }

        // 初始化資料
        private void InitData()
        {
            if (File.Exists(FILE_PATH))
            {
                string json = File.ReadAllText(FILE_PATH);
                if (String.IsNullOrEmpty(json))
                    Map = new Dictionary<int, 商品訂單資料>();
                else
                    Map = JsonConvert.DeserializeObject<Dictionary<int, 商品訂單資料>>(json);
            }
            else
            {
                Map = new Dictionary<int, 商品訂單資料>();
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
        public 商品訂單資料 Get(int 流水號_)
        {
            商品訂單資料 物品_;
            if (Map.TryGetValue(流水號_, out 物品_))
            {
                return 物品_;
            }

            MessageBox.Show("平台訂單資料管理器: Get fail " + 流水號_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 商品訂單資料.ERROR;
        }

        // 新增資料
        public void Add(商品訂單資料 物品_)
        {
            物品_.流水號 = 編碼管理器.Instance.Get(列舉.編碼類型.訂單);
            Map[物品_.流水號] = 物品_;

            SetDirty();
        }

        // 刪除資料
        public void Delete(商品訂單資料 物品_)
        {
            // 確認物件
            if (Map.ContainsKey(物品_.流水號) == false)
            {
                MessageBox.Show("平台訂單資料管理器: Delete fail, 名稱 = " + 物品_.流水號, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //@@ 資料不該直接刪除 改成 狀態修改

            // 確認刪除
            Map.Remove(物品_.流水號);
            SetDirty();
        }

        // 刪除資料
        public void Delete(int 流水號_)
        {
            商品訂單資料 物品_;
            if (Map.TryGetValue(流水號_, out 物品_) == false)
            {
                MessageBox.Show("平台訂單資料管理器: Delete fail, 流水號 = " + 流水號_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Delete(物品_);
        }
    }
}
