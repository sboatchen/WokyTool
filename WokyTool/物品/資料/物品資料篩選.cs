using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 物品資料篩選 : 通用可篩選介面<物品資料>
    {
        private 物品大類資料 _大類 = 物品大類資料.不篩選;
        public 物品大類資料 大類
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

        private 物品小類資料 _小類 = 物品小類資料.不篩選;
        public 物品小類資料 小類
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

        private string _國際條碼 = null;
        public string 國際條碼
        {
            get { return _國際條碼; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_國際條碼 != value)
                {
                    _國際條碼 = value;
                    篩選版本++;
                }
            }
        }

        private string _類別 = null;
        public string 類別
        {
            get { return _類別; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_類別 != value)
                {
                    _類別 = value;
                    篩選版本++;
                }
            }
        }

        private string _顏色 = null;
        public string 顏色
        {
            get { return _顏色; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_顏色 != value)
                {
                    _顏色 = value;
                    篩選版本++;
                }
            }
        }

        private int _最小庫存 = -1;
        public int 最小庫存
        {
            get { return _最小庫存; }
            set
            {
                if (_最小庫存 != value)
                {
                    _最小庫存 = value;
                    篩選版本++;
                }
            }
        }

        private int _最大庫存 = -1;
        public int 最大庫存
        {
            get { return _最大庫存; }
            set
            {
                if (_最大庫存 != value)
                {
                    _最大庫存 = value;
                    篩選版本++;
                }
            }
        }

        private string _儲位 = null;
        public string 儲位
        {
            get { return _儲位; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_儲位 != value)
                {
                    _儲位 = value;
                    篩選版本++;
                }
            }
        }

        public override bool 是否篩選
        {
            get
            {
                return
                    物品大類資料.不篩選 != _大類 ||
                    物品小類資料.不篩選 != _小類 ||
                    物品品牌資料.不篩選 != _品牌 ||
                    null != _國際條碼 ||
                    null != _文字 ||
                    null != _類別 ||
                    null != _顏色 ||
                    -1 != _最小庫存 ||
                    -1 != _最大庫存 ||
                    null != _儲位;
            }
        }

        public override IEnumerable<物品資料> 篩選(IEnumerable<物品資料> 資料列舉_)
        {
            //訊息管理器.獨體.訊息("物品篩選:" + this);

            IEnumerable<物品資料> 目前列舉_ = 資料列舉_;

            if (物品大類資料.不篩選 != _大類)
                目前列舉_ = 目前列舉_.Where(Value => Value.大類 == _大類);
            if (物品小類資料.不篩選 != _小類)
                目前列舉_ = 目前列舉_.Where(Value => Value.小類 == _小類);
            if (物品品牌資料.不篩選 != _品牌)
                目前列舉_ = 目前列舉_.Where(Value => Value.品牌 == _品牌);

            if (null != _國際條碼)
                目前列舉_ = 目前列舉_.Where(Value => Value.國際條碼 != null && Value.國際條碼.Contains(_國際條碼));

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(_文字) || Value.縮寫.Contains(_文字));

            if (null != _類別)
                目前列舉_ = 目前列舉_.Where(Value => Value.類別 != null && Value.類別.Contains(_類別));
            if (null != _顏色)
                目前列舉_ = 目前列舉_.Where(Value => Value.顏色 != null && Value.顏色.Contains(_顏色));

            if (-1 != _最小庫存)
                目前列舉_ = 目前列舉_.Where(Value => Value.庫存 >= _最小庫存);
            if (-1 != _最大庫存)
                目前列舉_ = 目前列舉_.Where(Value => Value.庫存 <= _最大庫存);

            if (null != _儲位)
                目前列舉_ = 目前列舉_.Where(Value => Value.儲位 != null && Value.儲位.Contains(_儲位));

            return 目前列舉_;
        }
    }
}

