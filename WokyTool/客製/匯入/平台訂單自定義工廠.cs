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

        public 平台訂單自定義介面 取得自定義(客戶資料 客戶_, String 設定名稱_)
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

            String 名稱_ = 客戶_.名稱.ToLower().Replace(" ", "");

            switch (名稱_)
            {
                case "momo":
                    if (String.IsNullOrEmpty(設定名稱_) == false && 設定名稱_.ToLower().Contains("momo第三方"))
                        介面_ = new 平台訂單自定義_Momo第三方();
                    else
                        介面_ = new 平台訂單自定義_Momo();
                    break;
                case "momo摩天":
                case "摩天":
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
                case "udesign":
                    介面_ = new 平台訂單自定義_uDesign();
                    break;
                case "pc購物中心":
                    介面_ = new 平台訂單自定義_PC購物中心();
                    break;
                case "pc商店街":
                    介面_ = new 平台訂單自定義_PC商店街();
                    break;
                case "pc專櫃":
                    介面_ = new 平台訂單自定義_PC專櫃();
                    break;
                case "payeasy":
                    介面_ = new 平台訂單自定義_PayEasy();
                    break;
                case "myfone":
                    介面_ = new 平台訂單自定義_myfone();
                    break;
                case "ibonmart":
                    介面_ = new 平台訂單自定義_ibonMart();
                    break;
                case "gohappy":
                case "friday":
                    介面_ = new 平台訂單自定義_Friday();
                    break;
                case "東森":
                    介面_ = new 平台訂單自定義_東森();
                    break;
                case "森森":
                    介面_ = new 平台訂單自定義_森森();
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
