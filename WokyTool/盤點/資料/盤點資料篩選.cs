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
    public class 盤點資料篩選 : 通用可篩選介面<盤點資料>
    {
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
                    null != _文字 ||
                    物品資料.不篩選 != _物品 ||
                    null != _備註;
            }
        }

        public override IEnumerable<盤點資料> 篩選(IEnumerable<盤點資料> 資料列舉_)
        {
            IEnumerable<盤點資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.物品名稱.Contains(_文字) || (Value.備註 != null && Value.備註.Contains(_備註)));

            if (物品資料.不篩選 != _物品)
                目前列舉_ = 目前列舉_.Where(Value => Value.物品 == _物品);

            if (null != _備註)
                目前列舉_ = 目前列舉_.Where(Value => Value.備註 != null && Value.備註.Contains(_備註));

            return 目前列舉_;
        }
    }
}
