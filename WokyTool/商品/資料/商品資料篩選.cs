using System.Collections.Generic;
using System.Linq;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.商品
{
    public class 商品資料篩選 : 通用可篩選介面<商品資料>
    {
        private 商品大類資料 _大類 = 商品大類資料.不篩選;
        public 商品大類資料 大類
        {
            get
            {
                return _大類;
            }
            set
            {
                if (_大類 != value)
                {
                    _大類 = value;
                    篩選版本++;
                }
            }
        }

        private 商品小類資料 _小類 = 商品小類資料.不篩選;
        public 商品小類資料 小類
        {
            get
            {
                return _小類;
            }
            set
            {
                if (_小類 != value)
                {
                    _小類 = value;
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

        private 物品品牌資料 _品牌 = 物品品牌資料.不篩選;
        public 物品品牌資料 品牌
        {
            get
            {
                return _品牌;
            }
            set
            {
                if (_品牌 != value)
                {
                    _品牌 = value;
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

        private string _品號 = null;
        public string 品號
        {
            get { return _品號; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_品號 != value)
                {
                    _品號 = value;
                    篩選版本++;
                }
            }
        }


        private int _最小寄庫數量 = -1;
        public int 最小寄庫數量
        {
            get { return _最小寄庫數量; }
            set
            {
                if (_最小寄庫數量 != value)
                {
                    _最小寄庫數量 = value;
                    篩選版本++;
                }
            }
        }

        private int _最大寄庫數量 = -1;
        public int 最大寄庫數量
        {
            get { return _最大寄庫數量; }
            set
            {
                if (_最大寄庫數量 != value)
                {
                    _最大寄庫數量 = value;
                    篩選版本++;
                }
            }
        }

        private decimal _最小利潤 = -1;
        public decimal 最小利潤
        {
            get { return _最小利潤; }
            set
            {
                if (_最小利潤 != value)
                {
                    _最小利潤 = value;
                    篩選版本++;
                }
            }
        }

        private decimal _最大利潤 = -1;
        public decimal 最大利潤
        {
            get { return _最大利潤; }
            set
            {
                if (_最大利潤 != value)
                {
                    _最大利潤 = value;
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
                    商品大類資料.不篩選 != _大類 ||
                    商品小類資料.不篩選 != _小類 ||
                    公司資料.不篩選 != _公司 ||
                    客戶資料.不篩選 != _客戶 ||
                    物品品牌資料.不篩選 != _品牌 ||
                    物品資料.不篩選 != _物品 ||
                    null != _品號 ||
                    -1 != _最小寄庫數量 ||
                    -1 != _最大寄庫數量 ||
                    -1 != _最小利潤 ||
                    -1 != _最大利潤;
            }
        }

        public override IEnumerable<商品資料> 篩選(IEnumerable<商品資料> 資料列舉_)
        {
            //訊息管理器.獨體.訊息("商品篩選:" + this);

            IEnumerable<商品資料> 目前列舉_ = 資料列舉_;

            if (商品大類資料.不篩選 != _大類)
                目前列舉_ = 目前列舉_.Where(Value => Value.大類 == _大類);
            if (商品小類資料.不篩選 != _小類)
                目前列舉_ = 目前列舉_.Where(Value => Value.小類 == _小類);
            if (公司資料.不篩選 != _公司)
                目前列舉_ = 目前列舉_.Where(Value => Value.公司 == _公司);
            if (客戶資料.不篩選 != _客戶)
                目前列舉_ = 目前列舉_.Where(Value => Value.客戶 == _客戶);

            if (物品品牌資料.不篩選 != _品牌)
                目前列舉_ = 目前列舉_.Where(Value => Value.品牌 == _品牌);
            if (物品資料.不篩選 != _物品)
                目前列舉_ = 目前列舉_.Where(Value => Value.組成 != null && Value.組成.Where(Value2 => Value2.物品 == _物品).Any());

            if (null != _品號)
                目前列舉_ = 目前列舉_.Where(Value => Value.品號 != null && Value.品號.Contains(_品號));

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(_文字));

            if (-1 != _最小寄庫數量)
                目前列舉_ = 目前列舉_.Where(Value => Value.寄庫數量 >= _最小寄庫數量);
            if (-1 != _最大寄庫數量)
                目前列舉_ = 目前列舉_.Where(Value => Value.寄庫數量 <= _最大寄庫數量);

            if (-1 != _最小利潤)
                目前列舉_ = 目前列舉_.Where(Value => Value.利潤 >= _最小利潤);
            if (-1 != _最大利潤)
                目前列舉_ = 目前列舉_.Where(Value => Value.利潤 <= _最大利潤);

            return 目前列舉_;
        }
    }
}

