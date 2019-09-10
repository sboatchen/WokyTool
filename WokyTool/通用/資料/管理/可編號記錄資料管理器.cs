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
    public abstract class 可編號記錄資料管理器<T> : 可列舉資料來源管理介面, 可儲存介面, 可新增介面<T> where T : 可編號記錄資料
    {
        public abstract 列舉.編號 編號類型 { get; }

        public virtual bool 是否加密 { get { return false; } }
        public virtual bool 是否備份 { get { return true; } }
        public virtual bool 是否可編輯 { get { return true; } }

        public abstract string 檔案路徑 { get; }

        public abstract T 不篩選資料 { get; }
        public abstract T 空白資料 { get; }
        public abstract T 錯誤資料 { get; }

        protected virtual IEnumerable<T> 取得清單特殊選項()
        {
            yield return 空白資料;
            yield return 錯誤資料;
        }

        protected virtual IEnumerable<T> 取得篩選特殊選項()
        {
            if (不篩選資料 != null)
                yield return 不篩選資料;
            yield return 空白資料;
            yield return 錯誤資料;
        }

        protected Dictionary<int, T> _資料書 = null;
        protected int _目前資料書版本 = 0;
        protected int _下個編號 = 1;

        public int 資料版本 { get; protected set; }

        public object 資料列舉 { get { return 資料列舉2; } }
        public virtual IEnumerable<T> 資料列舉2
        {
            get
            {
                return _資料書.Select(Pair => Pair.Value);
            }
        }

        protected abstract 新版可篩選介面<T> 取得篩選器實體();

        public 可清單列舉資料管理介面 清單管理器
        {
            get
            {
                return new 可清單資料管理器<T>(this, 取得篩選器實體(), 取得清單特殊選項());
            }
        }

        public 可清單列舉資料管理介面 篩選管理器
        {
            get
            {
                return new 可清單資料管理器<T>(this, 取得篩選器實體(), 取得篩選特殊選項());
            }
        }

        private 可編輯列舉資料管理介面 _編輯管理器獨體 = null;
        public 可編輯列舉資料管理介面 編輯管理器
        {
            get
            {
                if (_編輯管理器獨體 == null)
                    _編輯管理器獨體 = new 可編輯資料管理器<T>(this, 取得篩選器實體(), 是否可編輯);
                return _編輯管理器獨體;
            }
        }

        protected 可檢查介面 新增物件檢查器 = new 例外檢查器();

        // 建構子
        protected 可編號記錄資料管理器()
        {
            初始化資料();

            資料儲存管理器.獨體.註冊(編號類型, this);
        }

        protected virtual void 初始化資料()
        {
            if (File.Exists(檔案路徑))
            {
                string json = 檔案.讀出(檔案路徑, 是否加密);
                if (String.IsNullOrEmpty(json))
                    _資料書 = new Dictionary<int, T>();
                else
                    _資料書 = JsonConvert.DeserializeObject<Dictionary<int, T>>(json);
            }
            else
            {
                _資料書 = new Dictionary<int, T>();
            }

            if (_資料書.Count == 0)
                _下個編號 = 1;
            else
                _下個編號 = _資料書.Max(Value => Value.Key) + 1;
        }

        public void 合法檢查(可檢查介面 檢查器_)
        {
            foreach (T 資料_ in 資料列舉2)
            {
                資料_.合法檢查(檢查器_);
            }
        }

        public void 儲存()
        {
            if (_目前資料書版本 != 資料版本)
            {
                _目前資料書版本 = 資料版本;

                // 備份舊資料
                if (是否備份)
                    檔案.備份(檔案路徑, true);

                // 更新資料
                檔案.寫入(檔案路徑, JsonConvert.SerializeObject(_資料書, Formatting.Indented), 是否加密);
            }
        }

        public virtual T 取得(int ID_)
        {
            if (ID_ == 常數.空白資料編碼)
                return 空白資料;

            if (ID_ == 常數.錯誤資料編碼)
                return 錯誤資料;

            T Item_;
            if (_資料書.TryGetValue(ID_, out Item_))
            {
                return Item_;
            }

            return 錯誤資料;
        }

        public virtual bool 包含(int ID_)
        {
            return _資料書.ContainsKey(ID_);
        }

        public virtual bool 包含(T 資料_)
        {
            return _資料書.ContainsKey(資料_.編號);
        }

        public void 新增(T 資料_)
        {
            資料_.合法檢查(新增物件檢查器);
            資料_.編號 = _下個編號++;

            _資料書[資料_.編號] = 資料_;

            資料版本++;
        }

        public void 新增(IEnumerable<T> 資料列舉_)
        {
            if (資料列舉_ == null || 資料列舉_.Any() == false)
                return;

            foreach (T 資料_ in 資料列舉_)
            {
                資料_.合法檢查(新增物件檢查器);
                資料_.編號 = _下個編號++;

                _資料書[資料_.編號] = 資料_;
            }

            資料版本++;
        }

        public bool 刪除(T 資料_)
        {
            if (_資料書.ContainsKey(資料_.編號) == false)
            {
                訊息管理器.獨體.警告("無法刪除指定物件,找不到 " + 資料_.ToString());
                return false;
            }

            _資料書.Remove(資料_.編號);

            資料版本++;

            return true;
        }

        public bool 刪除(IEnumerable<T> 資料列舉_)
        {
            if (資料列舉_ == null || 資料列舉_.Any() == false)
                return true;

            資料版本++;

            foreach (T 資料_ in 資料列舉_)
            {
                if (_資料書.ContainsKey(資料_.編號) == false)
                {
                    訊息管理器.獨體.警告("無法刪除指定物件,找不到 " + 資料_.ToString());
                    return false;
                }

                _資料書.Remove(資料_.編號);
            }

            return true;
        }

        public bool 更新(T 資料_)
        {
            if (_資料書.ContainsKey(資料_.編號) == false)
            {
                訊息管理器.獨體.警告("無法更新指定物件,找不到 " + 資料_.ToString());
                return false;
            }

            _資料書[資料_.編號] = 資料_;

            資料版本++;

            return true;
        }

        public bool 更新(IEnumerable<T> 資料列舉_)
        {
            if (資料列舉_ == null || 資料列舉_.Any() == false)
                return true;

            資料版本++;

            foreach (T 資料_ in 資料列舉_)
            {
                if (_資料書.ContainsKey(資料_.編號) == false)
                {
                    訊息管理器.獨體.警告("無法更新指定物件,找不到 " + 資料_.ToString());
                    return false;
                }

                _資料書[資料_.編號] = 資料_;
            }

            return true;
        }

        public virtual void 更新資料(object 資料列obj_)
        {
            IEnumerable<T> 資料列_ = 資料列obj_ as IEnumerable<T>;
            if (資料列_ == null)
            {
                訊息管理器.獨體.錯誤("更新資料型別錯誤: " + 資料列obj_.GetType().Name);
                return;
            }

            _資料書.Clear();

            foreach (T 資料_ in 資料列_)
            {
                if (資料_.編號 == 常數.新建資料編碼)
                    資料_.編號 = _下個編號++;

                _資料書[資料_.編號] = 資料_;
            }

            資料版本++;
        }
    }
}
