using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.測試
{
    public class 讀寫測試資料篩選 : 新版可篩選介面<讀寫測試資料>
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

        private string _字串 = null;
        public string 字串
        {
            get { return _字串; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_字串 != value)
                {
                    _字串 = value;
                    篩選版本++;
                }
            }
        }

        private int? _最小整數 = null;
        public int? 最小整數
        {
            get { return _最小整數; }
            set
            {
                if (value < 0)
                    value = null;

                if (_最小整數 != value)
                {
                    _最小整數 = value;
                    篩選版本++;
                }
            }
        }

        private int? _最大整數 = null;
        public int? 最大整數
        {
            get { return _最大整數; }
            set
            {
                if (value < 0)
                    value = null;

                if (_最大整數 != value)
                {
                    _最大整數 = value;
                    篩選版本++;
                }
            }
        }

        public bool 是否排序
        {
            get { return null != 排序欄位; }
        }

        public bool 是否篩選
        {
            get
            {
                return
                    null != 字串 ||
                    null != 最小整數 ||
                    null != 最大整數;
            }
        }

        public int 排序版本 { get; protected set; }
        public int 篩選版本 { get; protected set; }

        public IEnumerable<讀寫測試資料> 排序(IEnumerable<讀寫測試資料> 資料列舉_)
        {
            IEnumerable<讀寫測試資料> 目前列舉_ = 資料列舉_;

            if (null != 排序欄位)
            {
                System.Reflection.PropertyInfo 屬性_ = typeof(讀寫測試資料).GetProperty(排序欄位);

                if (排序方向)
                    目前列舉_ = 目前列舉_.OrderBy(Value => 屬性_.GetValue(Value));
                else
                    目前列舉_ = 目前列舉_.OrderByDescending(Value => 屬性_.GetValue(Value));
            }

            return 目前列舉_;
        }

        public IEnumerable<讀寫測試資料> 篩選(IEnumerable<讀寫測試資料> 資料列舉_)
        {
            IEnumerable<讀寫測試資料> 目前列舉_ = 資料列舉_;

            if (null != 字串)
                目前列舉_ = 目前列舉_.Where(Value => 字串.Equals(Value.字串));

            if (null != 最小整數)
                目前列舉_ = 目前列舉_.Where(Value => 最小整數 <= Value.整數);

            if (null != 最大整數)
                目前列舉_ = 目前列舉_.Where(Value => 最大整數 >= Value.整數);

            return 目前列舉_;
        }
    }
}
