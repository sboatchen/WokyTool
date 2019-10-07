using System.Collections.Generic;
using System.Linq;
using WokyTool.物品;
using WokyTool.通用;
using WokyTool.廠商;

namespace WokyTool.進貨
{
    public class 進貨新增匯入資料篩選 : 通用可篩選介面<進貨新增匯入資料>
    {
        private 列舉.進貨類型 _類型 = 列舉.進貨類型.不篩選;
        public 列舉.進貨類型 類型
        {
            get { return _類型; }
            set
            {
                if (_類型 != value)
                {
                    _類型 = value;
                    篩選版本++;
                }
            }
        }

        private 廠商資料 _廠商 = 廠商資料.不篩選;
        public 廠商資料 廠商
        {
            get
            {
                return _廠商;
            }
            set
            {
                if (_廠商 != value)
                {
                    _廠商 = value;
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
                    null != _文字 ||  // 物品名稱
                    列舉.進貨類型.不篩選 != _類型 ||
                    廠商資料.不篩選 != _廠商 ||
                    物品資料.不篩選 != _物品 ||
                    null != _備註;
            }
        }

        public override IEnumerable<進貨新增匯入資料> 篩選(IEnumerable<進貨新增匯入資料> 資料列舉_)
        {
            IEnumerable<進貨新增匯入資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)    // 物品名稱
                目前列舉_ = 目前列舉_.Where(Value => Value.物品名稱.Contains(_文字));

            if (列舉.進貨類型.不篩選 != _類型)
                目前列舉_ = 目前列舉_.Where(Value => Value.類型 == _類型);

            if (廠商資料.不篩選 != _廠商)
                目前列舉_ = 目前列舉_.Where(Value => Value.廠商 == _廠商);
            if (物品資料.不篩選 != _物品)
                目前列舉_ = 目前列舉_.Where(Value => Value.物品 == _物品);

            if (null != _備註)
                目前列舉_ = 目前列舉_.Where(Value => Value.備註 != null && Value.備註.Contains(_備註));

            return 目前列舉_;
        }
    }
}
