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
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 配送轉換資料篩選 : 通用可篩選介面<配送轉換資料>
    {
        private 列舉.配送公司 _配送公司 = 列舉.配送公司.不篩選;
        public 列舉.配送公司 配送公司
        {
            get { return _配送公司; }
            set
            {
                if (_配送公司 != value)
                {
                    _配送公司 = value;
                    篩選版本++;
                }
            }
        }

        private string _配送單號 = null;
        public string 配送單號
        {
            get { return _配送單號; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_配送單號 != value)
                {
                    _配送單號 = value;
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

        private string _手機 = null;
        public string 手機
        {
            get { return _手機; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_手機 != value)
                {
                    _手機 = value;
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

        private DateTime _指配日期 = default(DateTime);
        public DateTime 指配日期
        {
            get { return _指配日期; }
            set
            {
                if (_指配日期 != value)
                {
                    _指配日期 = value;
                    篩選版本++;
                }
            }
        }

        private 列舉.指配時段 _指配時段 = 列舉.指配時段.不篩選;
        public 列舉.指配時段 指配時段
        {
            get { return _指配時段; }
            set
            {
                if (_指配時段 != value)
                {
                    _指配時段 = value;
                    篩選版本++;
                }
            }
        }

        private 列舉.代收方式 _代收方式 = 列舉.代收方式.不篩選;
        public 列舉.代收方式 代收方式
        {
            get { return _代收方式; }
            set
            {
                if (_代收方式 != value)
                {
                    _代收方式 = value;
                    篩選版本++;
                }
            }
        }

        private decimal _最小代收金額 = -1;       //@@ todo 換成 decimal?
        public decimal 最小代收金額
        {
            get { return _最小代收金額; }
            set
            {
                if (_最小代收金額 != value)
                {
                    _最小代收金額 = value;
                    篩選版本++;
                }
            }
        }

        private decimal _最大代收金額 = -1;
        public decimal 最大代收金額
        {
            get { return _最大代收金額; }
            set
            {
                if (_最大代收金額 != value)
                {
                    _最大代收金額 = value;
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

        private int _最小件數 = -1;
        public int 最小件數
        {
            get { return _最小件數; }
            set
            {
                if (_最小件數 != value)
                {
                    _最小件數 = value;
                    篩選版本++;
                }
            }
        }

        private int _最大件數 = -1;
        public int 最大件數
        {
            get { return _最大件數; }
            set
            {
                if (_最大件數 != value)
                {
                    _最大件數 = value;
                    篩選版本++;
                }
            }
        }

        public override bool 是否篩選
        {
            get
            {
                return
                    null != _文字 ||  // 內容
                     列舉.配送公司.不篩選 != _配送公司 ||
                    null != _配送單號 ||
                    null != _姓名 ||
                    null != _電話 ||
                    null != _手機 ||
                    null != _地址 ||
                    0 != _指配日期.Ticks ||
                    列舉.指配時段.不篩選 != _指配時段 ||
                    列舉.代收方式.不篩選 != _代收方式 ||
                    -1 != _最小代收金額 ||
                    -1 != _最大代收金額 ||
                     null != _備註 ||
                    -1 != _最小件數 ||
                    -1 != _最大件數
                    ;
            }
        }

        public override IEnumerable<配送轉換資料> 篩選(IEnumerable<配送轉換資料> 資料列舉_)
        {
            IEnumerable<配送轉換資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)    // 內容
                目前列舉_ = 目前列舉_.Where(Value => Value.內容.Contains(_文字));

            if (列舉.配送公司.不篩選 != _配送公司)
                目前列舉_ = 目前列舉_.Where(Value => Value.配送公司 == _配送公司);
            if (null != _配送單號)
                目前列舉_ = 目前列舉_.Where(Value => Value.配送單號 != null && Value.配送單號.Contains(_配送單號));

            if (null != _姓名)
                目前列舉_ = 目前列舉_.Where(Value => Value.姓名.Contains(_姓名));
            if (null != _地址)
                目前列舉_ = 目前列舉_.Where(Value => Value.地址.Contains(_地址));
            if (null != _電話)
                目前列舉_ = 目前列舉_.Where(Value => Value.電話 != null && Value.電話.Contains(_電話));
            if (null != _手機)
                目前列舉_ = 目前列舉_.Where(Value => Value.手機 != null && Value.手機.Contains(_手機));

            if (0 != _指配日期.Ticks)
                目前列舉_ = 目前列舉_.Where(Value => Value.指配日期 == _指配日期);
            if (列舉.指配時段.不篩選 != _指配時段)
                目前列舉_ = 目前列舉_.Where(Value => Value.指配時段 == _指配時段);

            if (列舉.代收方式.不篩選 != _代收方式)
                目前列舉_ = 目前列舉_.Where(Value => Value.代收方式 == _代收方式);
            if (-1 != _最小代收金額)
                目前列舉_ = 目前列舉_.Where(Value => Value.代收金額 >= _最小代收金額);
            if (-1 != _最大代收金額)
                目前列舉_ = 目前列舉_.Where(Value => Value.代收金額 <= _最大代收金額);

            if (null != _備註)
                目前列舉_ = 目前列舉_.Where(Value => Value.備註 != null && Value.備註.Contains(_備註));

            if (-1 != _最小件數)
                目前列舉_ = 目前列舉_.Where(Value => Value.件數 >= _最小件數);
            if (-1 != _最大件數)
                目前列舉_ = 目前列舉_.Where(Value => Value.件數 <= _最大件數);

            return 目前列舉_;
        }
    }
}
