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
    public class 非平台訂單資料管理器
    {
        // 檔案位置
        private static string FILE_PATH = "History/非平台訂單.json";

        // 資料Map
        public Dictionary<int, 非平台訂單資料> Map { get; private set; }
        // 資料是否異動
        public bool IsDirty { get; private set; }
        // 資料綁定廣播
        public 監測綁定廣播<非平台訂單資料> Binding { get; private set; }

        // 獨體
        private static readonly 非平台訂單資料管理器 _Instance = new 非平台訂單資料管理器();
        public static 非平台訂單資料管理器 Instance
        {
            get
            {
                return _Instance;
            }
        }

        // 建構子
        private 非平台訂單資料管理器()
        {
            InitData();

            Binding = new 監測綁定廣播<非平台訂單資料>(Map.Select(x => x.Value));

            IsDirty = false;
        }

        // 初始化資料
        private void InitData()
        {
            if (File.Exists(FILE_PATH))
            {
                string json = File.ReadAllText(FILE_PATH);
                if (String.IsNullOrEmpty(json))
                    Map = new Dictionary<int, 非平台訂單資料>();
                else
                {
                    Map = JsonConvert.DeserializeObject<Dictionary<int, 非平台訂單資料>>(json);

                    foreach(非平台訂單資料 訂單_ in Map.Values)
                    {
                        訂單_.Init();
                    }
                }
            }
            else
            {
                Map = new Dictionary<int, 非平台訂單資料>();
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
        public 非平台訂單資料 Get(int 流水號_)
        {
            非平台訂單資料 訂單_;
            if (Map.TryGetValue(流水號_, out 訂單_))
            {
                return 訂單_;
            }

            MessageBox.Show("非平台訂單資料管理器: Get fail " + 流水號_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 非平台訂單資料.ERROR;
        }

        // 新增資料
        public void Add(非平台訂單資料 訂單_)
        {
            訂單_.流水號 = 編碼管理器.Instance.Get(列舉.編碼類型.訂單);
            foreach (訂單資料 子定單_ in 訂單_.Child)
            {
                子定單_.流水號 = 訂單_.流水號;
            }

            Map[訂單_.流水號] = 訂單_;

            SetDirty();
        }

        // 刪除資料
        public void Delete(非平台訂單資料 訂單_)
        {
            // 確認物件
            if (Map.ContainsKey(訂單_.流水號) == false)
            {
                MessageBox.Show("非平台訂單資料管理器: Delete fail, 名稱 = " + 訂單_.流水號, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //@@ 資料不該直接刪除 改成 狀態修改

            // 確認刪除
            Map.Remove(訂單_.流水號);
            SetDirty();
        }

        // 刪除資料
        public void Delete(int 流水號_)
        {
            非平台訂單資料 訂單_;
            if (Map.TryGetValue(流水號_, out 訂單_) == false)
            {
                MessageBox.Show("非平台訂單資料管理器: Delete fail, 流水號 = " + 流水號_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Delete(訂單_);
        }
    }
}
