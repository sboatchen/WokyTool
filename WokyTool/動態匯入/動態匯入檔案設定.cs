using System.Collections.Generic;
using WokyTool.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;

namespace WokyTool.動態匯入
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class 動態匯入檔案設定 : MyData
    {
        [JsonProperty]
        public 列舉.檔案格式類型 格式 { get; set; }
      
        // >= 0
        [JsonProperty]
        public int 開始位置{ get; set; }
        
        // >= 0
        [JsonProperty]
        public int 結束位置{ get; set; }

        // -1 代表無標頭
        [JsonProperty]
        public int 標頭位置{ get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        [JsonProperty]
        public List<動態匯入資料設定> 資料List { get; set; }

        /********************************/

        public 動態匯入檔案設定()
        {
            資料List = new List<動態匯入資料設定>();
        }

        // 如果不合法 回傳例外
        public override string 檢查合法()
        {
            if (格式 <= 列舉.檔案格式類型.無)
                return "動態匯入檔案設定:格式不合法" + 格式;

            if (開始位置 < 0)
                return "動態匯入檔案設定:開始位置不合法" + 開始位置;

            if (結束位置 < 0)
                return "動態匯入檔案設定:結束位置不合法" + 結束位置;

            if (標頭位置 < -1 || 標頭位置 >= 開始位置)
                return "動態匯入檔案設定:標頭位置不合法" + 標頭位置;

            if (String.IsNullOrEmpty(名稱))
                return "動態匯入檔案設定:名稱不合法";

            return null;
        }
    }
}
