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
    public class 資料編輯管理器<T> : 可篩選列舉資料管理介面
    {
        public 可列舉資料管理介面 上層資料介面{ get; protected set; }

        public int 資料版本 
        {
            get
            {
                return 上層資料介面.資料版本 + _篩選介面.排序版本 + _篩選介面.篩選版本;
            }
        }

        private List<T> _目前資料列 = null;
        private int _目前資料列版本 = -1;
        public object 資料列舉
        {
            get
            {
                if (_目前資料列版本 != (上層資料介面.資料版本 + _篩選介面.排序版本))
                {
                    if (_篩選介面.是否排序)
                        _目前資料列 = _篩選介面.排序((IEnumerable<T>)上層資料介面.資料列舉).ToList();
                    else
                        _目前資料列 = ((IEnumerable<T>)上層資料介面.資料列舉).ToList();

                    _目前資料列版本 = (上層資料介面.資料版本 + _篩選介面.排序版本);
                }

                if (_篩選介面.是否篩選)
                    return _篩選介面.篩選(_目前資料列);
                else
                    return _目前資料列;
            }
        }

        protected 新版可篩選介面<T> _篩選介面 = null;
        public object 篩選介面
        {
            get
            {
                return _篩選介面;
            }
        }

        // 建構子
        public 資料編輯管理器(可列舉資料管理介面 上層資料介面_, 新版可篩選介面<T> 篩選介面_)
        {
            this.上層資料介面 = 上層資料介面_;
            this._篩選介面 = 篩選介面_;
        }
    }
}
