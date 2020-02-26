using System.Collections.Generic;
using System.Linq;
using WokyTool.單品;
using WokyTool.通用;

namespace WokyTool.進貨
{
    public class 進貨資料篩選 : 通用可處理資料篩選介面<進貨資料>
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

        private 供應商資料 _供應商 = 供應商資料.不篩選;
        public 供應商資料 供應商
        {
            get
            {
                return _供應商;
            }
            set
            {
                if (_供應商 != value)
                {
                    _供應商 = value;
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
                return base.是否篩選 ||
                    列舉.進貨類型.不篩選 != _類型 ||
                    供應商資料.不篩選 != _供應商 ||
                    單品資料.不篩選 != _單品 ||
                    null != _備註;
            }
        }

        public override IEnumerable<進貨資料> 篩選(IEnumerable<進貨資料> 資料列舉_)
        {
            IEnumerable<進貨資料> 目前列舉_ = base.篩選(資料列舉_);

            if (null != _文字)    // 單品名稱
                目前列舉_ = 目前列舉_.Where(Value => Value.單品名稱.Contains(_文字));

            if (列舉.進貨類型.不篩選 != _類型)
                目前列舉_ = 目前列舉_.Where(Value => Value.類型 == _類型);

            if (供應商資料.不篩選 != _供應商)
                目前列舉_ = 目前列舉_.Where(Value => Value.供應商名稱.Equals(_供應商.名稱));
            if (單品資料.不篩選 != _單品)
                目前列舉_ = 目前列舉_.Where(Value => Value.單品名稱.Equals(_單品.名稱));

            if (null != _備註)
                目前列舉_ = 目前列舉_.Where(Value => Value.備註 != null && Value.備註.Contains(_備註));

            return 目前列舉_;
        }
    }
}
