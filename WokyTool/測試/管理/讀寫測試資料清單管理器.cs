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

namespace WokyTool.測試
{
    public class 讀寫測試資料清單管理器 : 可篩選列舉資料管理介面
    {
        public 可列舉資料管理介面 上層資料介面{ get; protected set; }
        public IEnumerable<讀寫測試資料> 唯讀特殊選項 { get; set; }

        public int 資料版本 
        {
            get
            {
                return 上層資料介面.資料版本 + _篩選介面.排序版本 + _篩選介面.篩選版本;
            }
        }

        private List<讀寫測試資料> _目前資料列 = null;
        private int _目前資料列版本 = -1;
        public object 資料列舉
        {
            get
            {
                if (_目前資料列版本 != 資料版本)
                {
                    IEnumerable<讀寫測試資料> 資料列舉_ = (IEnumerable<讀寫測試資料>)上層資料介面.資料列舉;

                    if (_篩選介面.是否排序)
                        資料列舉_ = _篩選介面.排序(資料列舉_);

                    if (_篩選介面.是否篩選)
                        資料列舉_ = _篩選介面.篩選(資料列舉_);

                    _目前資料列 = 唯讀特殊選項.Union(資料列舉_).ToList();
                    _目前資料列版本 = 資料版本;
                }

                return _目前資料列;
            }
        }

        protected 新版可篩選介面<讀寫測試資料>  _篩選介面 = null;
        public object 篩選介面
        {
            get
            {
                return _篩選介面;
            }
        }

        // 建構子
        public 讀寫測試資料清單管理器(可列舉資料管理介面 上層資料介面_, 新版可篩選介面<讀寫測試資料> 篩選介面_, IEnumerable<讀寫測試資料> 唯讀特殊選項_)
        {
            this.上層資料介面 = 上層資料介面_;
            this._篩選介面 = 篩選介面_;
            this.唯讀特殊選項 = 唯讀特殊選項_;
        }
    }
}
