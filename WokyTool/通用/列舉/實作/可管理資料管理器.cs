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
    public abstract class 可管理資料管理器<T> : 可列舉資料來源管理介面 where T : 可編輯資料
    {
        public int 資料版本 { get; protected set; }

        public object 資料列舉 { get { return 資料列舉2; } }
        public abstract IEnumerable<T> 資料列舉2 { get; }

        protected abstract 新版可篩選介面<T> 取得篩選器實體();

        protected abstract IEnumerable<T> 取得清單特殊選項();
        protected abstract IEnumerable<T> 取得篩選特殊選項();

        public abstract bool 是否可編輯 { get; }

        public abstract void 更新資料(object 資料列_);

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

        public void 合法檢查(可檢查介面 檢查器_)
        {
            foreach (T 資料_ in 資料列舉2)
            {
                資料_.合法檢查(檢查器_);
            }
        }

        public void 更新資料()
        {
            資料版本++;
        }
    }
}
