using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.寄庫
{
    public class 寄庫匯入資料篩選 : 通用可篩選介面<寄庫匯入資料>
    {
        private DateTime _最小處理時間 = default(DateTime);
        public DateTime 最小處理時間
        {
            get { return _最小處理時間; }
            set
            {
                if (_最小處理時間 != value)
                {
                    _最小處理時間 = value;
                    篩選版本++;
                }
            }
        }

        private DateTime _最大處理時間 = default(DateTime);
        public DateTime 最大處理時間
        {
            get { return _最大處理時間; }
            set
            {
                if (_最大處理時間 != value)
                {
                    _最大處理時間 = value;
                    篩選版本++;
                }
            }
        }

        private 公司資料 _公司 = 公司資料.不篩選;
        public 公司資料 公司
        {
            get
            {
                return _公司;
            }
            set
            {
                if (_公司 != value)
                {
                    _公司 = value;
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

        private 商品資料 _商品 = 商品資料.不篩選;
        public 商品資料 商品
        {
            get
            {
                return _商品;
            }
            set
            {
                if (_商品 != value)
                {
                    _商品 = value;
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
                    null != _文字 ||  // 入庫單號
                    0 != _最小處理時間.Ticks ||
                    0 != _最大處理時間.Ticks ||
                    公司資料.不篩選 != _公司 ||
                    客戶資料.不篩選 != _客戶 ||
                    商品資料.不篩選 != _商品 ||
                    null != _備註;
            }
        }

        public override IEnumerable<寄庫匯入資料> 篩選(IEnumerable<寄庫匯入資料> 資料列舉_)
        {
            IEnumerable<寄庫匯入資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)    // 入庫單號
                目前列舉_ = 目前列舉_.Where(Value => Value.入庫單號.Contains(_文字));

            if (0 != _最小處理時間.Ticks)
                目前列舉_ = 目前列舉_.Where(Value => Value.處理時間 >= _最小處理時間);
            if (0 != _最大處理時間.Ticks)
                目前列舉_ = 目前列舉_.Where(Value => Value.處理時間 <= _最大處理時間);

            if (公司資料.不篩選 != _公司)
                目前列舉_ = 目前列舉_.Where(Value => Value.公司 == _公司);
            if (客戶資料.不篩選 != _客戶)
                目前列舉_ = 目前列舉_.Where(Value => Value.客戶 == _客戶);
            if (商品資料.不篩選 != _商品)
                目前列舉_ = 目前列舉_.Where(Value => Value.商品 == _商品);

            if (null != _備註)
                目前列舉_ = 目前列舉_.Where(Value => Value.備註 != null && Value.備註.Contains(_備註));

            return 目前列舉_;
        }
    }
}
