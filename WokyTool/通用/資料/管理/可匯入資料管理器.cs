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
    public abstract class 可匯入資料管理器<TSource, TValue> : 可編輯列舉資料管理介面, 可儲存介面
        where TSource : 新版可匯入資料<TValue>
        where TValue : 新版可記錄資料
    {
        public List<TSource> 資料列 { get; protected set; }
        protected int _資料更新版本 = 0;  // 用於通知外部資料變更
        protected int _資料排序版本 = -1;

        protected BindingSource _公用BS = new BindingSource();
        public BindingSource 公用BS { get { return _公用BS; } }

        public int 資料版本
        {
            get
            {
                return _資料更新版本 + 篩選器.排序版本 + 篩選器.篩選版本;
            }
            protected set 
            {
                _資料更新版本++;      // 通知外部更新
                _資料排序版本 = -1;   // 通知重排
            }
        }

        protected int _資料列舉篩選版本 = -1;
        protected IEnumerable<TSource> _資料列舉 = null;
        public object 資料列舉 
        { 
            get 
            {
                if (_資料排序版本 != 篩選器.排序版本)
                {
                    _資料排序版本 = 篩選器.排序版本;
                    if (篩選器.是否排序)
                        資料列 = 篩選器.排序(資料列).ToList();

                    _資料列舉篩選版本 = -1;   // 通知重新篩選
                }

                if (_資料列舉篩選版本 != 篩選器.篩選版本)
                {
                    _資料列舉篩選版本 = 篩選器.篩選版本;

                    _資料列舉 = 篩選器.篩選(資料列);
                    if (_資料列舉.Any() == false)
                        _資料列舉 = new List<TSource>();

                    _公用BS.DataSource = _資料列舉;
                    _公用BS.ResetBindings(false);
                }

                return _資料列舉;
            } 
        }

        public bool 是否可編輯 { get { return true; } }
        public bool 是否編輯中 { get { return 資料列.Count > 0; } }
        public virtual bool 是否自動存檔 { get { return true; } }

        protected 可檢查介面 新增物件檢查器 = new 錯誤訊息檢查器();

        protected abstract 新版可篩選介面<TSource> 取得篩選器實體();
        public 新版可篩選介面<TSource> 篩選器 { get; protected set; }
        public 視窗可篩選介面 視窗篩選器 { get { return 篩選器; } }

        protected abstract 可新增介面<TValue> 記錄器 { get; }

        // 建構子
        public 可匯入資料管理器()
        {
            資料列 = new List<TSource>();
            篩選器 = 取得篩選器實體();
        }

        public void 新增(TSource 資料_)
        {
            資料_.初始化();
            資料_.合法檢查(新增物件檢查器);

            資料列.Add(資料_);

            資料版本++;
        }

        public void 新增(IEnumerable<TSource> 資料列舉_)
        {
            if (資料列舉_ == null || 資料列舉_.Any() == false)
                return;

            foreach (TSource 資料_ in 資料列舉_)
            {
                資料_.初始化();
                資料_.合法檢查(新增物件檢查器);

                資料列.Add(資料_);
            }

            資料版本++;
        }

        public bool 刪除(TSource 資料_)
        {
            if (資料列.Contains(資料_) == false)
            {
                訊息管理器.獨體.警告("無法刪除指定物件,找不到 " + 資料_.ToString());
                return false;
            }

            資料列.Remove(資料_);

            資料版本++;

            return true;
        }

        public void 完成編輯(bool 是否紀錄_)
        {
            if (是否紀錄_)
            {
                TSource 錯誤資料_ = 資料列.執行(Value => Value.合法檢查(新增物件檢查器)).Where(Value => string.IsNullOrEmpty(Value.錯誤訊息) == false).DefaultIfEmpty(null).First();
                if (錯誤資料_ != null)
                {
                    例外檢查器 例外檢查器_ = new 例外檢查器();
                    例外檢查器_.錯誤(錯誤資料_, 錯誤資料_.錯誤訊息);
                }

                foreach (TSource 資料_ in 資料列)
                {
                    資料_.紀錄編輯(true);
                }

                儲存();
            }
        }

        public void 合法檢查(可檢查介面 檢查器_)
        {
            foreach (TSource 資料_ in 資料列)
            {
                資料_.合法檢查(檢查器_);
            }
        }

        // 儲存檔案
        public virtual void 儲存()
        {
            記錄器.新增(資料列.Select(Value => Value.新增資料));

            if (是否自動存檔)
            {
                可儲存介面 儲存器_ = 記錄器 as 可儲存介面;
                if (儲存器_ != null)
                    儲存器_.儲存();
            }
        }
    }
}
