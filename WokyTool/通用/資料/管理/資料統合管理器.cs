using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataMgr;

namespace WokyTool.通用
{
    public abstract class 資料統合管理器<T, T2> : 資料管理器<T> where T : MyKeepableData<T>
    {
        public abstract string 讀取路徑 { get; }

        protected override void 初始化資料()
        {
            if (File.Exists(檔案路徑))
            {
                string json = 檔案.讀出(檔案路徑, 資料是否加密);
                if (String.IsNullOrEmpty(json))
                    Map = new Dictionary<int, T>();
                else
                    Map = JsonConvert.DeserializeObject<Dictionary<int, T>>(json);
            }
            else
            {
                Map = new Dictionary<int, T>();
            }

            if (Map.Count == 0)
                下個編號 = 1;
            else
                下個編號 = Map.Max(Value => Value.Key) + 1;
        }

        public void 讀取()
        {
            // 取得資料夾內所有檔案
            foreach (string FileName_ in Directory.GetFiles(讀取路徑))
            {
                訊息管理器.獨體.Debug("處理檔案:" + FileName_);

                string json = 檔案.讀出(FileName_);

                Dictionary<int, T2> Map_ = JsonConvert.DeserializeObject<Dictionary<int, T2>>(json);

                新增(Map_.Values.Select(Value => 轉化讀取資料(Value)));

                檔案.備份(FileName_, true);

                檔案.刪除(FileName_);   

                //@@@ 改用 搬移
            }
        }

        protected abstract T 轉化讀取資料(T2 新增資料_);
    }
}
