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
    public abstract class 可管理資料管理器<T> : 可列舉資料來源管理介面 where T : 可編輯資料<T>
    {
        public int 資料版本 { get; protected set; }

        public abstract object 資料列舉 { get; }

        protected abstract 新版可篩選介面<T> 取得篩選介面();

        protected abstract IEnumerable<T> 取得清單特殊選項();

        public abstract bool 是否可編輯 { get; }

        public abstract void 更新資料(object 資料列_);

        public 可清單列舉資料管理介面 清單管理器
        {
            get
            {
                return new 可清單資料管理器<T>(this, 取得篩選介面(), 取得清單特殊選項());
            }
        }

        private 可編輯列舉資料管理介面 _編輯管理器獨體 = null;
        public 可編輯列舉資料管理介面 編輯管理器
        {
            get
            {
                if (_編輯管理器獨體 == null)
                    _編輯管理器獨體 = new 可編輯資料管理器<T>(this, 取得篩選介面(), 是否可編輯);
                return _編輯管理器獨體;
            }
        }

        public void 檢查合法(可處理合法介面 管理器_)
        {
            IEnumerable<T> 資料列_ = 資料列舉 as IEnumerable<T>;
            if (資料列_ == null)
            {
                訊息管理器.獨體.錯誤("型別錯誤: " + 資料列舉.GetType().Name);
                return;
            }

            foreach (T 資料_ in 資料列_)
            {
                資料_.檢查合法(管理器_);
            }
        }
    }
}
