using System.Collections.Generic;
using System.Linq;
using WokyTool.單品;
using WokyTool.通用;
using System;

namespace WokyTool.預留
{
    public class 預留匯入資料篩選 : 通用可篩選介面<預留匯入資料>
    {
        private DateTime _最小預留日期 = default(DateTime);
        public DateTime 最小預留日期
        {
            get { return _最小預留日期; }
            set
            {
                if (_最小預留日期 != value)
                {
                    _最小預留日期 = value;
                    篩選版本++;
                }
            }
        }

        private DateTime _最大預留日期 = default(DateTime);
        public DateTime 最大預留日期
        {
            get { return _最大預留日期; }
            set
            {
                if (_最大預留日期 != value)
                {
                    _最大預留日期 = value;
                    篩選版本++;
                }
            }
        }

        private string _姓名 = null;
        public string 姓名
        {
            get { return _姓名; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_姓名 != value)
                {
                    _姓名 = value;
                    篩選版本++;
                }
            }
        }
        
        private 單品資料 _單品 = 單品資料.不篩選;
        public 單品資料 單品
        {
            get
            {
                return _單品;
            }
            set
            {
                if (_單品 != value)
                {
                    _單品 = value;
                    篩選版本++;
                }
            }
        }

        private string _備註 = null;
        public string 備註
        {
            get { return _備註; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_備註 != value)
                {
                    _備註 = value;
                    篩選版本++;
                }
            }
        }

        public override bool 是否篩選
        {
            get
            {
                return
                    null != _文字 ||  // 名稱
                    0 != _最小預留日期.Ticks ||
                    0 != _最大預留日期.Ticks ||
                    null != _姓名 ||
                    單品資料.不篩選 != _單品 ||
                    null != _備註;
            }
        }

        public override IEnumerable<預留匯入資料> 篩選(IEnumerable<預留匯入資料> 資料列舉_)
        {
            IEnumerable<預留匯入資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)    // 名稱
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(_文字));

            if (0 != _最小預留日期.Ticks)
                目前列舉_ = 目前列舉_.Where(Value => Value.開始日期 <= _最小預留日期 &&  Value.結束日期 >= _最小預留日期);
            if (0 != _最大預留日期.Ticks)
                目前列舉_ = 目前列舉_.Where(Value => Value.開始日期 <= _最大預留日期 &&  Value.結束日期 >= _最大預留日期);

            if (null != _姓名)
                目前列舉_ = 目前列舉_.Where(Value => Value.姓名 != null && Value.姓名.Contains(_姓名));

            if (單品資料.不篩選 != _單品)
                目前列舉_ = 目前列舉_.Where(Value => Value.單品 == _單品);

            if (null != _備註)
                目前列舉_ = 目前列舉_.Where(Value => Value.備註 != null && Value.備註.Contains(_備註));

            return 目前列舉_;
        }
    }
}
