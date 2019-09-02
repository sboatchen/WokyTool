using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                目前列舉_ = 目前列舉_.Where(Value => Value.電話.Contains(_電話) || Value.手機.Contains(_電話));

            if (null != _地址)
                目前列舉_ = 目前列舉_.Where(Value => Value.地址.Contains(_地址));

            if (子客戶資料.不篩選 != _子客戶)
                目前列舉_ = 目前列舉_.Where(Value => Value.子客戶 == _子客戶);
            else if (客戶資料.不篩選 != _客戶)
                目前列舉_ = 目前列舉_.Where(Value => Value.客戶 == _客戶);

            return 目前列舉_;
        }
    }
}
