using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.客戶
{
    public class 子客戶資料篩選 : 通用可篩選介面<子客戶資料>
    {
        private string _名稱 = null;
        public string 名稱
        {
            get { return _名稱; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_名稱 != value)
                {
                    _名稱 = value;
                    篩選版本++;
                }
            }
        }

        private 客戶資料 _客戶 = null;
        public 客戶資料 客戶
        {
            get { return _客戶; }
            set
            {
                if (_客戶 != value)
                {
                    _客戶 = value;
                    篩選版本++;
                }
            }
        }

        public override bool 是否篩選
        {
            get
            {
                return
                    null != 名稱 ||
                    null != 客戶;
            }
        }

        public override IEnumerable<子客戶資料> 篩選(IEnumerable<子客戶資料> 資料列舉_)
        {
            IEnumerable<子客戶資料> 目前列舉_ = 資料列舉_;

            if (null != 名稱)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(名稱));

            if (null != 客戶)
                目前列舉_ = 目前列舉_.Where(Value => Value.客戶 == 客戶);

            return 目前列舉_;
        }
    }
}
