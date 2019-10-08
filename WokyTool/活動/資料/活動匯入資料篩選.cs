using System.Collections.Generic;
using System.Linq;
using WokyTool.物品;
using WokyTool.通用;
using System;

namespace WokyTool.活動
{
    public class 活動匯入資料篩選 : 通用可篩選介面<活動匯入資料>
    {
        private DateTime _最小活動日期 = default(DateTime);
        public DateTime 最小活動日期
        {
            get { return _最小活動日期; }
            set
            {
                if (_最小活動日期 != value)
                {
                    _最小活動日期 = value;
                    篩選版本++;
                }
            }
        }

        private DateTime _最大活動日期 = default(DateTime);
        public DateTime 最大活動日期
        {
            get { return _最大活動日期; }
            set
            {
                if (_最大活動日期 != value)
                {
                    _最大活動日期 = value;
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
        
        private 物品資料 _物品 = 物品資料.不篩選;
        public 物品資料 物品
        {
            get
            {
                return _物品;
            }
            set
            {
                if (_物品 != value)
                {
                    _物品 = value;
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
                    0 != _最小活動日期.Ticks ||
                    0 != _最大活動日期.Ticks ||
                    null != _姓名 ||
                    物品資料.不篩選 != _物品 ||
                    null != _備註;
            }
        }

        public override IEnumerable<活動匯入資料> 篩選(IEnumerable<活動匯入資料> 資料列舉_)
        {
            IEnumerable<活動匯入資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)    // 名稱
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(_文字));

            if (0 != _最小活動日期.Ticks)
                目前列舉_ = 目前列舉_.Where(Value => Value.開始日期 <= _最小活動日期 &&  Value.結束日期 >= _最小活動日期);
            if (0 != _最大活動日期.Ticks)
                目前列舉_ = 目前列舉_.Where(Value => Value.開始日期 <= _最大活動日期 &&  Value.結束日期 >= _最大活動日期);

            if (null != _姓名)
                目前列舉_ = 目前列舉_.Where(Value => Value.姓名 != null && Value.姓名.Contains(_姓名));

            if (物品資料.不篩選 != _物品)
                目前列舉_ = 目前列舉_.Where(Value => Value.物品 == _物品);

            if (null != _備註)
                目前列舉_ = 目前列舉_.Where(Value => Value.備註 != null && Value.備註.Contains(_備註));

            return 目前列舉_;
        }
    }
}
