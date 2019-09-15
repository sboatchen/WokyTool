using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.盤點
{
    public class 盤點封存資料篩選 : 通用可篩選介面<盤點封存資料>
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

        private string _更新者 = null;
        public string 更新者
        {
            get { return _更新者; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_更新者 != value)
                {
                    _更新者 = value;
                    篩選版本++;
                }
            }
        }

        public override bool 是否篩選
        {
            get
            {
                return
                    0 != _最小處理時間.Ticks ||
                    0 != _最大處理時間.Ticks ||
                    null != _文字 ||  // 物品名稱
                    null != _備註 ||
                    null != _更新者;
            }
        }

        public override IEnumerable<盤點封存資料> 篩選(IEnumerable<盤點封存資料> 資料列舉_)
        {
            IEnumerable<盤點封存資料> 目前列舉_ = 資料列舉_;

            if (0 != _最小處理時間.Ticks)
                目前列舉_ = 目前列舉_.Where(Value => Value.處理時間 >= _最小處理時間);
            if (0 != _最大處理時間.Ticks)
                目前列舉_ = 目前列舉_.Where(Value => Value.處理時間 <= _最大處理時間);

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.物品名稱.Contains(_文字) || Value.物品縮寫.Contains(_文字));

            if (null != _備註)
                目前列舉_ = 目前列舉_.Where(Value => Value.備註 != null && Value.備註.Contains(_備註));

            if (null != _更新者)
                目前列舉_ = 目前列舉_.Where(Value => Value.更新者.Contains(_更新者));

            return 目前列舉_;
        }
    }
}
