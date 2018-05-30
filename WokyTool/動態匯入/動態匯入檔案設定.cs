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

        private Dictionary<int, 動態匯入資料設定> _欄位位置對應表 = null;
        public Dictionary<int, 動態匯入資料設定> 欄位位置對應表
        {
            get
            {
                if (_欄位位置對應表 == null)
                {
                    _欄位位置對應表 = new Dictionary<int, 動態匯入資料設定>();
                    foreach (動態匯入資料設定 Item_ in 資料List)
                    {
                        if (_欄位位置對應表.ContainsKey(Item_.列索引))
                            throw new Exception("列索引重複");

                        _欄位位置對應表.Add(Item_.列索引, Item_);
                    }
                }

                return _欄位位置對應表;
            }
        
        }

        private Dictionary<string, 動態匯入資料設定> _名稱映射對應表 = null;
        public Dictionary<string, 動態匯入資料設定> 名稱映射對應表
        {
            get
            {
                if (_名稱映射對應表 == null)
                {
                    _名稱映射對應表 = new Dictionary<string, 動態匯入資料設定>();
                    foreach (動態匯入資料設定 Item_ in 資料List)
                    {
                        if (String.IsNullOrEmpty(Item_.名稱))
                            continue;

                        if (_名稱映射對應表.ContainsKey(Item_.名稱))
                            throw new Exception("名稱重複");

                        _名稱映射對應表.Add(Item_.名稱, Item_);
                    }
                }

                return _名稱映射對應表;
            }

        }

        /********************************/

        public 動態匯入檔案設定()
        {
            資料List = new List<動態匯入資料設定>();
        }

        // 如果不合法 回傳例外
        public override void 檢查合法()
        {
            if (格式 <= 列舉.檔案格式類型.無)
                throw new Exception("動態匯入檔案設定:格式不合法:" + 格式);

            if (開始位置 < 0)
                throw new Exception("動態匯入檔案設定:開始位置不合法:" + 開始位置);

            if (結束位置 < 0)
                throw new Exception("動態匯入檔案設定:結束位置不合法:" + 結束位置);

            if (標頭位置 < -1 || 標頭位置 >= 開始位置)
                throw new Exception("動態匯入檔案設定:標頭位置不合法:" + 標頭位置);

            if (String.IsNullOrEmpty(名稱))
                throw new Exception( "動態匯入檔案設定:名稱不合法");

            foreach (動態匯入資料設定 資料 in 資料List)
            {
                資料.檢查合法();
            }

            // 重建此表
            _欄位位置對應表 = null;
            var x = 欄位位置對應表;

            // 重建此表
            _名稱映射對應表 = null;
            var y = 名稱映射對應表;
        }
    }
}
