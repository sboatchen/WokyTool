using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 物品資料篩選 : 通用可篩選介面<物品資料>
    {
        private 物品大類資料 _大類 = null;
        public 物品大類資料 大類
        {
            get { return _大類; }
            set
            {
                if (_大類 != value)
                {
                    _大類 = value;
                    篩選版本++;
                }
            }
        }

        private 物品小類資料 _小類 = null;
        public 物品小類資料 小類
        {
            get { return _小類; }
            set
            {
                if (_小類 != value)
                {
                    _小類 = value;
                    篩選版本++;
                }
            }
        }

        private 物品品牌資料 _品牌 = null;
        public 物品品牌資料 品牌
        {
            get { return _品牌; }
            set
            {
                if (_品牌 != value)
                {
                    _品牌 = value;
                    篩選版本++;
                }
            }
        }

        private string _條碼 = null;
        public string 條碼
        {
            get { return _條碼; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_條碼 != value)
                {
                    _條碼 = value;
                    篩選版本++;
                }
            }
        }

        private string _原廠編號 = null;
        public string 原廠編號
        {
            get { return _原廠編號; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_原廠編號 != value)
                {
                    _原廠編號 = value;
                    篩選版本++;
                }
            }
        }

        private string _代理編號 = null;
        public string 代理編號
        {
            get { return _代理編號; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_代理編號 != value)
                {
                    _代理編號 = value;
                    篩選版本++;
                }
            }
        }

        private string _名稱 = null;
        public string 名稱
        {
            get { return _名稱; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_名稱 != value)
                {
                    _名稱 = value;
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

        public override bool 是否篩選
        {
            get
            {
                return
                    null != 大類 ||
                    null != 小類 ||
                    null != 品牌 ||
                    null != 條碼 ||
                    null != 原廠編號 ||
                    null != 代理編號 ||
                    null != 名稱 ||
                    null != 類別 ||
                    null != 顏色 ||
                    -1 != 最小庫存 ||
                    -1 != 最大庫存;
            }
        }

        public override IEnumerable<物品資料> 篩選(IEnumerable<物品資料> 資料列舉_)
        {
            IEnumerable<物品資料> 目前列舉_ = 資料列舉_;

            if (null != 大類)
                目前列舉_ = 目前列舉_.Where(Value => Value.大類 == 大類);
            if (null != 小類)
                目前列舉_ = 目前列舉_.Where(Value => Value.小類 == 小類);
            if (null != 品牌)
                目前列舉_ = 目前列舉_.Where(Value => Value.品牌 == 品牌);

            if (null != 條碼)
                目前列舉_ = 目前列舉_.Where(Value => Value.條碼.Contains(條碼));
            if (null != 原廠編號)
                目前列舉_ = 目前列舉_.Where(Value => Value.原廠編號.Contains(原廠編號));
            if (null != 代理編號)
                目前列舉_ = 目前列舉_.Where(Value => Value.代理編號.Contains(代理編號));

            if (null != 名稱)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(名稱) || Value.縮寫.Contains(名稱));

            if (null != 類別)
                目前列舉_ = 目前列舉_.Where(Value => Value.類別.Contains(類別));
            if (null != 顏色)
                目前列舉_ = 目前列舉_.Where(Value => Value.顏色.Contains(顏色));

            if (-1 != 最小庫存)
                目前列舉_ = 目前列舉_.Where(Value => Value.庫存 >= 最小庫存);
            if (-1 != 最大庫存)
                目前列舉_ = 目前列舉_.Where(Value => Value.庫存 <= 最大庫存);

            return 目前列舉_;
        }
    }
}

