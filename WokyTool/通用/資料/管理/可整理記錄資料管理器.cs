using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WokyTool.通用
{
    public abstract class 可整理記錄資料管理器<T> : 可記錄資料管理器<T>, 可整理介面 where T : 新版可記錄資料
    {
        public abstract string 待整理資料夾路徑 { get; }
        public string 待整理檔案路徑 { get { return String.Format("{0}/{1}_{2}.json", 待整理資料夾路徑, 系統參數.使用者名稱, 時間.目前完整時間); } }

        public bool 是否需整理()
        {
            return Directory.Exists(待整理資料夾路徑);
        }

        public virtual void 整理()
        {
            if (Directory.Exists(待整理資料夾路徑) == false)
                return;

            訊息管理器.獨體.訊息(typeof(T).Name + " 開始整理資料夾");

            List<T> 新增資料列_ = new List<T>();

            string[] 檔案路徑列_ = Directory.GetFiles(待整理資料夾路徑);
            foreach (string 檔案路徑_ in 檔案路徑列_)
            {
                訊息管理器.獨體.訊息("整理檔案 " + 檔案路徑_);

                string json = 檔案.讀出(檔案路徑_, 是否加密);
                if (String.IsNullOrEmpty(json))
                    continue;

                新增資料列_.AddRange(JsonConvert.DeserializeObject<List<T>>(json));
            }

            if (新增資料列_.Count == 0)
            {
                Directory.Delete(待整理資料夾路徑);
                return;
            }

            新增(新增資料列_);

            foreach (string 檔案路徑_ in 檔案路徑列_)
            {
                檔案.搬移至備份(檔案路徑_);
            }
            Directory.Delete(待整理資料夾路徑);

            資料版本++;
        }

        public virtual void 待整理(List<T> 資料列_)
        {
            檔案.寫入(待整理檔案路徑, JsonConvert.SerializeObject(資料列_, Formatting.Indented), false);
        }
    }
}
