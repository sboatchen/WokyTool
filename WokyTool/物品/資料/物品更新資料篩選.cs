using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 物品更新資料篩選 : 通用可篩選介面<物品更新資料>
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

        private 物品大類資料 _大類 = null;
        public 物品大類資料 大類
        {
            get
            {
                if (_大類 == null)
                    return 物品大類資料.不篩;
                return _大類;
            }
            set
            {
                if (物品大類資料.不篩 == value)
                    value = null;

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
            get
            {
                if (_小類 == null)
                    return 物品小類資料.不篩;
                return _小類;
            }
            set
            {
                if (物品小類資料.不篩 == value)
                    value = null;

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
            get
            {
                if (_品牌 == null)
                    return 物品品牌資料.不篩;
                return _品牌;
            }
            set
            {
                if (物品品牌資料.不篩 == value)
                    value = null;

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
                    列舉.更新狀態.不篩選 != _更新狀態 ||
                    null != _大類 ||
                    null != _小類 ||
                    null != _品牌 ||
                    null != _條碼 ||
                    null != _原廠編號 ||
                    null != _代理編號 ||
                    null != _文字 ||
                    null != _類別 ||
                    null != _顏色 ||
                    -1 != _最小庫存 ||
                    -1 != _最大庫存;
            }
        }

        public override IEnumerable<物品更新資料> 篩選(IEnumerable<物品更新資料> 資料列舉_)
        {
            訊息管理器.獨體.訊息("物品篩選:" + this);

            IEnumerable<物品更新資料> 目前列舉_ = 資料列舉_;

            if (列舉.更新狀態.不篩選 != _更新狀態)
                目前列舉_ = 目前列舉_.Where(Value => Value.更新狀態 == _更新狀態);

            if (null != _大類)
                目前列舉_ = 目前列舉_.Where(Value => Value.大類 == _大類);
            if (null != _小類)
                目前列舉_ = 目前列舉_.Where(Value => Value.小類 == _小類);
            if (null != _品牌)
                目前列舉_ = 目前列舉_.Where(Value => Value.品牌 == _品牌);

            if (null != _條碼)
                目前列舉_ = 目前列舉_.Where(Value => Value.條碼 != null && Value.條碼.Contains(_條碼));
            if (null != _原廠編號)
                目前列舉_ = 目前列舉_.Where(Value => Value.原廠編號 != null && Value.原廠編號.Contains(_原廠編號));
            if (null != _代理編號)
                目前列舉_ = 目前列舉_.Where(Value => Value.代理編號 != null && Value.代理編號.Contains(_代理編號));

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(_文字) || Value.縮寫.Contains(_文字));

            if (null != _類別)
                目前列舉_ = 目前列舉_.Where(Value => Value.類別 != null && Value.類別.Contains(_類別));
            if (null != 顏色)
                目前列舉_ = 目前列舉_.Where(Value => Value.顏色 != null && Value.顏色.Contains(_顏色));

            if (-1 != _最小庫存)
                目前列舉_ = 目前列舉_.Where(Value => Value.庫存 >= _最小庫存);
            if (-1 != _最大庫存)
                目前列舉_ = 目前列舉_.Where(Value => Value.庫存 <= _最大庫存);

            return 目前列舉_;
        }
    }
}

