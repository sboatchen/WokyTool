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
    public class 讀寫測試資料篩選
    {
        public string 排序欄位{ get; set; }
        public bool 排序方向 { get; set; }

        public string 字串 { get; set; }
        public int? 最小整數 { get; set; }
        public int? 最大整數 { get; set; }

        public bool 是否篩選()
        {
            return
                false == string.IsNullOrEmpty(字串) ||
                null != 最小整數 ||
                null != 最大整數;
        }

        public IEnumerable<讀寫測試資料> 篩選(IEnumerable<讀寫測試資料> 資料列舉_)
        {
            IEnumerable<讀寫測試資料> 目前列舉_ = 資料列舉_;
            if (false == string.IsNullOrEmpty(排序欄位))
            {
                System.Reflection.PropertyInfo 屬性_ = typeof(讀寫測試資料).GetProperty(排序欄位);

                if (排序方向)
                    目前列舉_ = 目前列舉_.OrderBy(Value => 屬性_.GetValue(Value));
                else
                    目前列舉_ = 目前列舉_.OrderByDescending(Value => 屬性_.GetValue(Value));
            }

            if (false == string.IsNullOrEmpty(字串))
                目前列舉_ = 目前列舉_.Where(Value => 字串.Equals(Value.字串));

            if (null != 最小整數)
                目前列舉_ = 目前列舉_.Where(Value => 最小整數 <= Value.整數);

            if (null != 最大整數)
                目前列舉_ = 目前列舉_.Where(Value => 最大整數 >= Value.整數);

            return 目前列舉_;
        }
    }
}
