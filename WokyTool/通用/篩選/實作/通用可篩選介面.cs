using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.通用
{
    public abstract class 通用可篩選介面<T> : 新版可篩選介面<T>
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

        public bool 是否排序
        {
            get { return null != 排序欄位; }
        }

        public abstract bool 是否篩選 { get; }

        public int 排序版本 { get; protected set; }
        public int 篩選版本 { get; protected set; }

        public IEnumerable<T> 排序(IEnumerable<T> 資料列舉_)
        {
            IEnumerable<T> 目前列舉_ = 資料列舉_;

            if (null != 排序欄位)
            {
                System.Reflection.PropertyInfo 屬性_ = typeof(T).GetProperty(排序欄位);

                if (排序方向)
                    目前列舉_ = 目前列舉_.OrderBy(Value => 屬性_.GetValue(Value));
                else
                    目前列舉_ = 目前列舉_.OrderByDescending(Value => 屬性_.GetValue(Value));
            }

            return 目前列舉_;
        }

        public abstract IEnumerable<T> 篩選(IEnumerable<T> 資料列舉_);
    }
}
