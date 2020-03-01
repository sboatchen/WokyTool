using System.Collections.Generic;
using System.Linq;
using WokyTool.單品;
using WokyTool.通用;

namespace WokyTool.盤點
{
    public class 盤點更新資料篩選 : 通用可篩選介面<盤點更新資料>
    {
        private 列舉.更新狀態 _更新狀態 = 列舉.更新狀態.不篩選;
        public 列舉.更新狀態 更新狀態
        {
            get
            {
                return _更新狀態;
            }
            set
            {
                if (_更新狀態 != value)
                {
                    _更新狀態 = value;
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
                    null != _文字 ||  // 單品名稱
                    列舉.更新狀態.不篩選 != _更新狀態 ||
                    單品資料.不篩選 != _單品 ||
                    null != _備註;
            }
        }

        public override IEnumerable<盤點更新資料> 篩選(IEnumerable<盤點更新資料> 資料列舉_)
        {
            IEnumerable<盤點更新資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.單品名稱.Contains(_文字));

            if (列舉.更新狀態.不篩選 != _更新狀態)
                目前列舉_ = 目前列舉_.Where(Value => Value.更新狀態 == _更新狀態);

            if (單品資料.不篩選 != _單品)
                目前列舉_ = 目前列舉_.Where(Value => Value.單品 == _單品);

            if (null != _備註)
                目前列舉_ = 目前列舉_.Where(Value => Value.備註 != null && Value.備註.Contains(_備註));

            if (目前列舉_ != 資料列舉_)
                return 目前列舉_.DefaultIfEmpty(盤點更新資料.空白);
            return 目前列舉_;
        }
    }
}
