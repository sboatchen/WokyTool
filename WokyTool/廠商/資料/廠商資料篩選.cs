using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.廠商
{
    public class 廠商資料篩選 : 通用可篩選介面<廠商資料>
    {
        private string _電話 = null;
        public string 電話
        {
            get { return _電話; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_電話 != value)
                {
                    _電話 = value;
                    篩選版本++;
                }
            }
        }

        private string _手機 = null;
        public string 手機
        {
            get { return _手機; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_手機 != value)
                {
                    _手機 = value;
                    篩選版本++;
                }
            }
        }

        private string _地址 = null;
        public string 地址
        {
            get { return _地址; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_地址 != value)
                {
                    _地址 = value;
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
                    null != _電話 ||
                    null != _手機 ||
                    null != _地址;
            }
        }

        public override IEnumerable<廠商資料> 篩選(IEnumerable<廠商資料> 資料列舉_)
        {
            IEnumerable<廠商資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(_文字));

            if (null != _電話)
                目前列舉_ = 目前列舉_.Where(Value => Value.電話 != null && Value.電話.Contains(_電話));

            if (null != _手機)
                目前列舉_ = 目前列舉_.Where(Value => Value.手機 != null && Value.手機.Contains(_手機));

            if (null != _地址)
                目前列舉_ = 目前列舉_.Where(Value => Value.地址.Contains(_地址));

            return 目前列舉_;
        }
    }
}
