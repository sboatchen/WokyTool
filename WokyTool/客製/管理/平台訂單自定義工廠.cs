using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.公司;
using WokyTool.平台訂單;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.客製
{
    public class 平台訂單自定義工廠
    {
        public static 客戶資料 MOMO第三方假客戶資料 = new 客戶資料
        {
            編號 = -1,
            名稱 = "momo第三方",
        };

        private Dictionary<int, 平台訂單自定義介面> _Map;

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
            _Map = new Dictionary<int, 平台訂單自定義介面>();
        }

        public 平台訂單自定義介面 取得自定義(公司資料 公司_, 客戶資料 客戶_)
        {
            int Hash_ = 公司_.編號 * 10000 + 客戶_.編號;

            平台訂單自定義介面 介面_ = null;
            if (_Map.TryGetValue(Hash_, out 介面_))
                return 介面_;

            String 名稱_ = 客戶_.名稱.ToLower().Replace(" ", "");

            switch (名稱_)
            {
                case "momo":
                    介面_ = new 平台訂單自定義_Momo();   //!! 警告 取不到 平台訂單自定義_Momo第三方
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
                case "森森":
                    介面_ = new 平台訂單自定義_森森();
                    break;
                case "一休":
                    介面_ = new 平台訂單自定義_一休();
                    break;
                case "手作":
                    介面_ = new 平台訂單自定義_手作();
                    break; 
                case "陳沂":
                    介面_ = new 平台訂單自定義_陳沂();
                    break;


                case "momo第三方":
                    介面_ = new 平台訂單匯入轉換_Momo第三方(公司_);
                    break;
                case "中華電信":
                    介面_ = new 平台訂單匯入轉換_中華電信(公司_);
                    break;
                case "東森":
                    介面_ = new 平台訂單匯入轉換_東森(公司_);
                    break;
                case "friday":
                    介面_ = new 平台訂單匯入轉換_Friday(公司_);
                    break;
                case "udn":
                    介面_ = new 平台訂單匯入轉換_UDN(公司_);
                    break;
                case "ibonmart":
                    介面_ = new 平台訂單匯入轉換_ibonMart(公司_);
                    break;
                case "金石堂":
                    介面_ = new 平台訂單匯入轉換_金石堂(公司_);
                    break;
                case "百利市":
                    介面_ = new 平台訂單匯入轉換_百利市(公司_);
                    break;
                case "viva":
                    介面_ = new 平台訂單匯入轉換_viva(公司_);
                    break;
                case "特力屋":
                    介面_ = new 平台訂單匯入轉換_特力屋(公司_);
                    break;
                default:
                    訊息管理器.獨體.錯誤("平台訂單自定義工廠::不支援 " + 客戶_.名稱);
                    return null;
            }

            _Map.Add(Hash_, 介面_);

            return 介面_;
        }

        public 平台訂單自定義介面 取得自定義(平台訂單匯入設定資料 平台訂單匯入設定資料_)
        {
            return 取得自定義(平台訂單匯入設定資料_.公司, 平台訂單匯入設定資料_.客戶);
        }

        public 平台訂單自定義介面 取得自定義_momo三方(公司資料 公司資料_)
        {
            return 取得自定義(公司資料_, MOMO第三方假客戶資料);
        }
    }
}
