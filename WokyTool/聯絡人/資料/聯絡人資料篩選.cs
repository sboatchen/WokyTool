using System.Collections.Generic;
using System.Linq;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.聯絡人
{
    public class 聯絡人資料篩選 : 通用可篩選介面<聯絡人資料>
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

        private 子客戶資料 _子客戶 = 子客戶資料.不篩選;
        public 子客戶資料 子客戶
        {
            get {
                return _子客戶; 
            }
            set
            {
                if (_子客戶 != value)
                {
                    _子客戶 = value;
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
                    null != _地址 ||
                    客戶資料.不篩選 != _客戶 ||
                    子客戶資料.不篩選 != _子客戶;
            }
        }

        public override IEnumerable<聯絡人資料> 篩選(IEnumerable<聯絡人資料> 資料列舉_)
        {
            IEnumerable<聯絡人資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.姓名.Contains(_文字));

            if (null != _電話)
                目前列舉_ = 目前列舉_.Where(Value => Value.電話 != null && Value.電話.Contains(_電話));

            if (null != _手機)
                目前列舉_ = 目前列舉_.Where(Value => Value.手機 != null && Value.手機.Contains(_手機));

            if (null != _地址)
                目前列舉_ = 目前列舉_.Where(Value => Value.地址.Contains(_地址));

            if (子客戶資料.不篩選 != _子客戶)
                目前列舉_ = 目前列舉_.Where(Value => Value.子客戶 == _子客戶);
            else if (客戶資料.不篩選 != _客戶)
                目前列舉_ = 目前列舉_.Where(Value => Value.客戶 == _客戶);

            if (目前列舉_ != 資料列舉_)
                return 目前列舉_.DefaultIfEmpty(聯絡人資料.空白);
            return 目前列舉_;
        }
    }
}
