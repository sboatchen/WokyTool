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
using WokyTool.通用;

namespace WokyTool.通用
{
    public abstract class 新版資料管理器<T> : 可列舉資料管理介面
    {
        protected Dictionary<int, T> _資料書 = null;

        public int 資料版本 { get; protected set; }
        
        public object 資料列舉 
        {   
            get 
            { 
                return _資料書.Select(Pair => Pair.Value); 
            } 
        }

        public abstract IEnumerable<T> 取得清單特殊選項();

        public abstract 新版可篩選介面<T> 取得篩選介面();

        public 可篩選列舉資料管理介面 資料清單管理器
        {
            get
            {
                return new 資料清單管理器<T>(this, 取得篩選介面(), 取得清單特殊選項());
            }
        }

        private 資料編輯管理器<T> _資料編輯管理器獨體 = null;
        public 可篩選列舉資料管理介面 編輯介面
        {
            get
            {
                if (_資料編輯管理器獨體 == null)
                    _資料編輯管理器獨體 = new 資料編輯管理器<T>(this, 取得篩選介面());
                return _資料編輯管理器獨體;
            }
        }
    }
}
