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
    public class 可編輯資料管理器<T> : 可編輯列舉資料管理介面 where T : 可編輯資料
    {
        public 可列舉資料來源管理介面 來源管理介面 { get; protected set; }

        protected BindingSource _公用BS = new BindingSource();
        public BindingSource 公用BS { get { return _公用BS; } }

        public int 資料版本 
        {
            get
            {
                return 來源管理介面.資料版本 + 篩選器.排序版本 + 篩選器.篩選版本;
            }
        }

        private int _目前資料版本 = -1;
        private int _目前排序版本 = -1;
        private int _目前篩選版本 = -1;
        private int _目前資料數量 = -1;

        private List<T> _目前資料列 = null;
        private IEnumerable<T> _目前資料列舉 = null;

        public object 資料列舉
        {
            get
            {
                if (_目前資料版本 != 來源管理介面.資料版本)
                {
                    _目前資料版本 = 來源管理介面.資料版本;
                    _目前資料列 = null;  // 清除目前資料，等待排序時重建

                    _目前排序版本 = -1;   // 通知重建排序
                }

                if (_目前排序版本 != 篩選器.排序版本)
                {
                    _目前排序版本 = 篩選器.排序版本;
                    if (_目前資料列 == null)
                    {
                        if(篩選器.是否排序)
                            _目前資料列 = 篩選器.排序((IEnumerable<T>)來源管理介面.資料列舉).ToList();
                        else
                            _目前資料列 = ((IEnumerable<T>)來源管理介面.資料列舉).ToList();

                        _目前資料數量 = _目前資料列.Count;
                    }
                    else
                    {
                        if(篩選器.是否排序)
                            _目前資料列 = 篩選器.排序(_目前資料列).ToList();
                    }

                    _目前篩選版本 = -1;   // 通知重新篩選
                }

                if (_目前篩選版本 != 篩選器.篩選版本)
                {
                    _目前篩選版本 = 篩選器.篩選版本;

                    _目前資料列舉 = 篩選器.篩選(_目前資料列);
                    if (_目前資料列舉.Any() == false)
                        _目前資料列舉 = new List<T>();

                    _公用BS.DataSource = _目前資料列舉;     //@@ 當原本沒有資料 並允許家資料 GridView 會預設一筆空資料 這時加入資料 會導致錯誤
                                                        // ex 開啟 平台訂單新增總攬視窗 -> 開啟 平台訂單新增匯入視窗 並匯入 -> 平台訂單新增總攬視窗 出錯 
                    _公用BS.ResetBindings(false);
                }

                return _目前資料列舉;
            }
        }

        public 新版可篩選介面<T> 篩選器 { get; protected set; }
        public 視窗可篩選介面 視窗篩選器 { get { return 篩選器; } }

        public bool 是否可編輯 { get; protected set; }

        public bool 是否編輯中
        {
            get
            {
                if (是否可編輯 == false)
                    return false;

                bool 是否編輯中_ = false;
                foreach (T 資料_ in _目前資料列)
                    是否編輯中_ |= 資料_.更新編輯狀態();

                return 是否編輯中_ || (_目前資料數量 != _目前資料列.Count);
            }
        }

        public void 完成編輯(bool 是否紀錄_)
        {
            if (是否紀錄_)
            {
                例外檢查器 例外檢查器_ = new 例外檢查器();

                foreach (T 資料_ in _目前資料列.Where(Value => Value.是否編輯中))
                {
                    資料_.合法檢查(例外檢查器_);
                }

                foreach (T 資料_ in _目前資料列)
                {
                    資料_.紀錄編輯(true);
                }

                來源管理介面.更新資料(_目前資料列);
            }
            else
            {
                foreach (T 資料_ in _目前資料列)
                {
                    資料_.取消編輯();
                }

                _目前資料版本 = -1;   //強制更新
            }
        }

        // 建構子
        public 可編輯資料管理器(可列舉資料來源管理介面 來源管理介面_, 新版可篩選介面<T> 篩選器_, bool 是否可編輯_)
        {
            this.來源管理介面 = 來源管理介面_;
            this.篩選器 = 篩選器_;
            this.是否可編輯 = 是否可編輯_;
        }

        public void 合法檢查(可檢查介面 檢查器_)
        {
            foreach (T 資料_ in _目前資料列)
            {
                資料_.合法檢查(檢查器_);
            }
        }
    }
}
