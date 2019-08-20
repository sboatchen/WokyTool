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
    public class 可清單資料管理器<T> : 可清單列舉資料管理介面 where T : 可編輯資料<T>
    {
        public 可列舉資料來源管理介面 來源管理介面{ get; protected set; }
        public IEnumerable<T> 特殊選項 { get; protected set; }

        public int 資料版本 
        {
            get
            {
                return 來源管理介面.資料版本 + _篩選介面.排序版本 + _篩選介面.篩選版本;
            }
        }

        private List<T> _目前資料列 = null;
        private int _目前資料列版本 = -1;
        public object 資料列舉
        {
            get
            {
                if (_目前資料列版本 != 資料版本)
                {
                    IEnumerable<T> 資料列舉_ = (IEnumerable<T>)來源管理介面.資料列舉;

                    if (_篩選介面.是否排序)
                        資料列舉_ = _篩選介面.排序(資料列舉_);

                    if (_篩選介面.是否篩選)
                        資料列舉_ = _篩選介面.篩選(資料列舉_);

                    _目前資料列 = 特殊選項.Union(資料列舉_).ToList();
                    _目前資料列版本 = 資料版本;
                }

                return _目前資料列;
            }
        }

        protected 新版可篩選介面<T> _篩選介面 = null;
        public 可篩選介面_視窗 篩選介面
        {
            get
            {
                return _篩選介面;
            }
        }

        // 建構子
        public 可清單資料管理器(可列舉資料來源管理介面 來源管理介面_, 新版可篩選介面<T> 篩選介面_, IEnumerable<T> 特殊選項_)
        {
            this.來源管理介面 = 來源管理介面_;
            this._篩選介面 = 篩選介面_;
            this.特殊選項 = 特殊選項_;
        }

        public void 合法檢查(可處理檢查介面 管理器_)
        {
            foreach (T 資料_ in _目前資料列)
            {
                資料_.合法檢查(管理器_);
            }
        }
    }
}
