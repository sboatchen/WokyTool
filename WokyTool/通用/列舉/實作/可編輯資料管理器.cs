﻿using Newtonsoft.Json;
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
    public class 可編輯資料管理器<T> : 可編輯列舉資料管理介面 where T : 可編輯資料<T>
    {
        public 可列舉資料來源管理介面 來源管理介面 { get; protected set; }

        private int 取消編輯更新版本 = 0;

        public int 資料版本 
        {
            get
            {
                return 來源管理介面.資料版本 + _篩選介面.排序版本 + _篩選介面.篩選版本 + 取消編輯更新版本;
            }
        }

        private List<T> _目前資料列 = null;
        private int _目前資料列版本 = -1;
        private int _目前資料列數量 = -1;
        public object 資料列舉
        {
            get
            {
                if (_目前資料列版本 != (來源管理介面.資料版本 + _篩選介面.排序版本 + 取消編輯更新版本))
                {
                    if (_篩選介面.是否排序)
                        _目前資料列 = _篩選介面.排序((IEnumerable<T>)來源管理介面.資料列舉).ToList();
                    else
                        _目前資料列 = ((IEnumerable<T>)來源管理介面.資料列舉).ToList();

                    _目前資料列版本 = (來源管理介面.資料版本 + _篩選介面.排序版本 + 取消編輯更新版本);
                    _目前資料列數量 = _目前資料列.Count();
                }

                if (_篩選介面.是否篩選)
                    return _篩選介面.篩選(_目前資料列);
                else
                    return _目前資料列;
            }
        }

        protected BindingSource _公用BS = new BindingSource();
        public BindingSource 公用BS { get { return _公用BS; } }

        protected 新版可篩選介面<T> _篩選介面 = null;
        public object 篩選介面
        {
            get
            {
                return _篩選介面;
            }
        }

        public bool 是否可編輯 { get; protected set; }

        public bool 是否編輯中
        {
            get
            {
                if (是否可編輯 == false)
                    return false;

                if (_目前資料列數量 != _目前資料列.Count())
                    return true;

                foreach (T 資料_ in _目前資料列)
                {
                    if (資料_.是否編輯中)
                        return true;
                }

                return false;
            }
        }

        public void 完成編輯(bool 是否紀錄_)
        {
            if (是否紀錄_)
            {
                例外處理檢查管理器 例外處理檢查管理器_ = new 例外處理檢查管理器();
                foreach (T 資料_ in _目前資料列)
                {
                    資料_.合法檢查(例外處理檢查管理器_);
                }

                foreach (T 資料_ in _目前資料列)
                {
                    資料_.紀錄編輯();
                }

                來源管理介面.更新資料(_目前資料列);
            }
            else
            {
                foreach (T 資料_ in _目前資料列)
                {
                    資料_.取消編輯();
                }

                // 修正資料增減
                取消編輯更新版本++;
            }
        }

        // 建構子
        public 可編輯資料管理器(可列舉資料來源管理介面 來源管理介面_, 新版可篩選介面<T> 篩選介面_, bool 是否可編輯_)
        {
            this.來源管理介面 = 來源管理介面_;
            this._篩選介面 = 篩選介面_;
            this.是否可編輯 = 是否可編輯_;
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
