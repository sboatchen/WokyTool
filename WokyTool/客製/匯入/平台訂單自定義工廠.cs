using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.客製
{
    public class 平台訂單自定義工廠
    {
        private Dictionary<客戶資料, 平台訂單自定義介面> _Map;

        private 客戶資料 _快取客戶;
        private 平台訂單自定義介面 _快取自定義;

        // 獨體
        private static readonly 平台訂單自定義工廠 _獨體 = new 平台訂單自定義工廠();
        public static 平台訂單自定義工廠 獨體
        {
            get
            {
                return _獨體;
            }
        }

        private 平台訂單自定義工廠()
        {
            _Map = new Dictionary<客戶資料, 平台訂單自定義介面>();

            _快取客戶 = null;
            _快取自定義 = null;
        }

        public 平台訂單自定義介面 取得自定義(客戶資料 客戶_)
        {
            if (客戶_ == _快取客戶)
                return _快取自定義;

            平台訂單自定義介面 介面_ = null;
            if (_Map.TryGetValue(客戶_, out 介面_))
            {
                _快取客戶 = 客戶_;
                _快取自定義 = 介面_;
                return 介面_;
            }

            switch (客戶_.名稱)
            {
                case "Momo摩天":
                    介面_ =  new 平台訂單自定義_摩天();
                    break;
                case "遠傳加購":
                    介面_ = new 平台訂單自定義_遠傳加購();
                    break;
                case "博客來":
                    介面_ = new 平台訂單自定義_博客來();
                    break;
                case "神坊":
                    介面_ = new 平台訂單自定義_神坊();
                    break;
                case "金石堂":
                    介面_ = new 平台訂單自定義_金石堂();
                    break;
                case "百利市":
                    介面_ = new 平台訂單自定義_百利市();
                    break;
                case "uDesign":
                    介面_ = new 平台訂單自定義_uDesign();
                    break;
                default:
                    訊息管理器.獨體.Error("平台訂單自定義工廠::不支援 " + 客戶_.名稱);
                    return null;
            }

            _快取客戶 = 客戶_;
            _快取自定義 = 介面_;
            _Map.Add(客戶_, 介面_);

            return 介面_;
        }
    }
}
