using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.庫存
{
    public class 物品庫存封存資料篩選 : 通用可處理資料篩選介面<物品庫存封存資料>
    {
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
                    null != _備註;
            }
        }

        public override IEnumerable<物品庫存封存資料> 篩選(IEnumerable<物品庫存封存資料> 資料列舉_)
        {
            IEnumerable<物品庫存封存資料> 目前列舉_ = base.篩選(資料列舉_);

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(_文字) || Value.縮寫.Contains(_文字));

            if (null != _備註)
                目前列舉_ = 目前列舉_.Where(Value => Value.備註 != null && Value.備註.Contains(_備註));

            return 目前列舉_;
        }
    }
}
