using System;
using System.Collections.Generic;
using System.Linq;

namespace WokyTool.通用
{
    public abstract class 通用可處理資料篩選介面<T> : 基本資料, 新版可篩選介面<T> where T : 可處理介面
    {
        private string _排序欄位 = null;
        public string 排序欄位 
        {
            get { return _排序欄位; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_排序欄位 != value)
                {
                    _排序欄位 = value;
                    _排序方向 = true;
                }
                else
                    _排序方向 = !_排序方向;

                排序版本++;
            }
        }

        private bool _排序方向;
        public bool 排序方向
        {
            get { return _排序方向; }
            set
            {
                if (_排序方向 != value)
                {
                    _排序方向 = value;
                    排序版本++;
                }
            }
        }

        private DateTime _最小處理時間 = default(DateTime);
        public DateTime 最小處理時間
        {
            get { return _最小處理時間; }
            set
            {
                if (_最小處理時間 != value)
                {
                    _最小處理時間 = value;
                    篩選版本++;
                }
            }
        }

        private DateTime _最大處理時間 = default(DateTime);
        public DateTime 最大處理時間
        {
            get { return _最大處理時間; }
            set
            {
                if (_最大處理時間 != value)
                {
                    _最大處理時間 = value;
                    篩選版本++;
                }
            }
        }

        private string _處理者 = null;
        public string 處理者
        {
            get { return _處理者; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_處理者 != value)
                {
                    _處理者 = value;
                    篩選版本++;
                }
            }
        }

        protected string _文字 = null;
        public string 文字
        {
            get { return _文字; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_文字 != value)
                {
                    _文字 = value;
                    篩選版本++;
                }
            }
        }

        public bool 是否排序
        {
            get { return null != _排序欄位; }
        }

        public virtual bool 是否篩選
        {
            get { return 
                    0 != _最小處理時間.Ticks ||
                    0 != _最大處理時間.Ticks ||
                    null != _處理者 ||
                    null != _文字;
            }
        }

        public int 排序版本 { get; protected set; }
        public int 篩選版本 { get; protected set; }

        public IEnumerable<T> 排序(IEnumerable<T> 資料列舉_)
        {
            IEnumerable<T> 目前列舉_ = 資料列舉_;

            if (null != _排序欄位)
            {
                System.Reflection.PropertyInfo 屬性_ = typeof(T).GetProperty(_排序欄位);

                if (排序方向)
                    目前列舉_ = 目前列舉_.OrderBy(Value => 屬性_.GetValue(Value));
                else
                    目前列舉_ = 目前列舉_.OrderByDescending(Value => 屬性_.GetValue(Value));
            }

            return 目前列舉_;
        }

        public virtual IEnumerable<T> 篩選(IEnumerable<T> 資料列舉_)
        {
            IEnumerable<T> 目前列舉_ = 資料列舉_;

            if (0 != _最小處理時間.Ticks)
                目前列舉_ = 目前列舉_.Where(Value => Value.處理時間 >= _最小處理時間);
            if (0 != _最大處理時間.Ticks)
                目前列舉_ = 目前列舉_.Where(Value => Value.處理時間 <= _最大處理時間);

            if (null != _處理者)
                目前列舉_ = 目前列舉_.Where(Value => Value.處理者.Contains(_處理者));

            return 目前列舉_;
        }
    }
}
