using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.客戶
{
    public class 子客戶資料篩選 : 通用可篩選介面<子客戶資料>
    {
        private 客戶資料 _客戶 = 客戶資料.不篩選;
        public 客戶資料 客戶
        {
            get
            {
                return _客戶;
            }
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
                    null != _文字 ||
                    客戶資料.不篩選 != _客戶;
            }
        }

        public override IEnumerable<子客戶資料> 篩選(IEnumerable<子客戶資料> 資料列舉_)
        {
            IEnumerable<子客戶資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(_文字));

            if (客戶資料.不篩選 != _客戶)
                目前列舉_ = 目前列舉_.Where(Value => Value.客戶 == _客戶);

            return 目前列舉_;
        }
    }
}
