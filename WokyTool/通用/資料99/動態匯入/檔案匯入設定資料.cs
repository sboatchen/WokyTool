using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace WokyTool.通用
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class 檔案匯入設定資料<T> : 可記錄資料<T>, 檔案匯入設定資料介面
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        [JsonProperty]
        public 列舉.檔案格式 格式 { get; set; }
      
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
        public List<欄位匯入設定資料> 資料List { get; set; }

        private Dictionary<int, 欄位匯入設定資料> _欄位位置對應表 = null;
        public Dictionary<int, 欄位匯入設定資料> 欄位位置對應表
        {
            get
            {
                if (_欄位位置對應表 == null)
                {
                    _欄位位置對應表 = new Dictionary<int, 欄位匯入設定資料>();
                    foreach (欄位匯入設定資料 Item_ in 資料List)
                    {
                        if (_欄位位置對應表.ContainsKey(Item_.列索引))
                            throw new Exception("列索引重複");

                        _欄位位置對應表.Add(Item_.列索引, Item_);
                    }
                }

                return _欄位位置對應表;
            }
        }

        private Dictionary<string, 欄位匯入設定資料> _名稱映射對應表 = null;
        public Dictionary<string, 欄位匯入設定資料> 名稱映射對應表
        {
            get
            {
                if (_名稱映射對應表 == null)
                {
                    _名稱映射對應表 = new Dictionary<string, 欄位匯入設定資料>();
                    foreach (欄位匯入設定資料 Item_ in 資料List)
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

        public 檔案匯入設定資料()
        {
            標頭位置 = -1;
            資料List = new List<欄位匯入設定資料>();
        }

        // this is abstract class that not support NULL, ERROR

        /********************************/

        // 如果不合法 回傳例外
        public override void 檢查合法()
        {
            if (列舉.是否有值((int)格式) == false)
                throw new Exception("檔案匯入設定資料:格式不合法:" + 格式);

            if (開始位置 < 0)
                throw new Exception("檔案匯入設定資料:開始位置不合法:" + 開始位置);

            if (結束位置 < 0)
                throw new Exception("檔案匯入設定資料:結束位置不合法:" + 結束位置);

            if (標頭位置 < -1 || 標頭位置 >= 開始位置)
                throw new Exception("檔案匯入設定資料:標頭位置不合法:" + 標頭位置);

            if (String.IsNullOrEmpty(名稱))
                throw new Exception("檔案匯入設定資料:名稱不合法");

            foreach (欄位匯入設定資料 資料 in 資料List)
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

        public 欄位匯入設定資料 取得欄位匯入設定資料(int Index_)
        {
            欄位匯入設定資料 Item_;
            if (欄位位置對應表.TryGetValue(Index_, out Item_))
            {
                return Item_;
            }

            return 欄位匯入設定資料.ERROR;
        }

        public 欄位匯入設定資料 取得欄位匯入設定資料(int Index_, 欄位匯入設定資料 Defualt_)
        {
            欄位匯入設定資料 Item_;
            if (欄位位置對應表.TryGetValue(Index_, out Item_))
            {
                return Item_;
            }

            return Defualt_;
        }

        public 欄位匯入設定資料 取得欄位匯入設定資料(String Name_)
        {
            欄位匯入設定資料 Item_;
            if (名稱映射對應表.TryGetValue(Name_, out Item_))
            {
                return Item_;
            }

            return 欄位匯入設定資料.ERROR;
        }

        public 欄位匯入設定資料 取得欄位匯入設定資料(String Name_, 欄位匯入設定資料 Defualt_)
        {
            欄位匯入設定資料 Item_;
            if (名稱映射對應表.TryGetValue(Name_, out Item_))
            {
                return Item_;
            }

            return Defualt_;
        }

        public int 取得欄位位置(String Name_)
        {
            欄位匯入設定資料 Item_;
            if (名稱映射對應表.TryGetValue(Name_, out Item_))
            {
                return Item_.列索引;
            }

            return -1;
        }

        public IEnumerable<T2> 匯入Excel<T2>(檔案匯入轉換介面<T2> 轉換介面_, bool 是否讀入雜值_) where T2 : 基本資料
        {
            if (格式 != 列舉.檔案格式.EXCEL)
                throw new Exception("檔案匯入設定資料<T>:_匯入Excel 檔案格式不匹配");

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return null;

            // 備份
            檔案.備份(openFileDialog1.FileName, this.名稱, "匯入", typeof(T2).Name);

            動態匯入檔案結構 動態匯入檔案結構_ = new 動態匯入檔案結構(this);

            try
            {
                動態匯入檔案結構_.ReadExcel(openFileDialog1.FileName, 是否讀入雜值_);
                return 轉換介面_.轉換(動態匯入檔案結構_);
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.通知(ex);
                return null;
            }
        }
    }
}
