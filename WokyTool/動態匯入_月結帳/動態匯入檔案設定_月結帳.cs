using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;
using WokyTool.動態匯入;

namespace WokyTool.動態匯入_月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 動態匯入檔案設定_月結帳 : 動態匯入檔案設定
    {
        public 公司資料 公司;
        [JsonProperty]
        public int 公司編號
        {
            get
            {
                return 公司.編號;
            }
            set
            {
                公司 = 公司管理器.Instance.Get(value);
            }
        }

        public 廠商資料 廠商;
        [JsonProperty]
        public int 廠商編號
        {
            get
            {
                return 廠商.編號;
            }
            set
            {
                廠商 = 廠商管理器.Instance.Get(value);
            }
        }

        /********************************/

        public enum 動態匯入需求欄位_月結帳
        {
            識別碼 = 1,
            單價 = 2,
            數量 = 4,
        };

        protected static List<string> _需求欄位列表 = new List<string>();
        protected static int _合法遮罩 = 0;

        static 動態匯入檔案設定_月結帳()
        {
            foreach (動態匯入需求欄位_月結帳 x in Enum.GetValues(typeof(動態匯入需求欄位_月結帳)))
            {
                _需求欄位列表.Add(x.ToString());
                _合法遮罩 |= (int)x; 
            }
        }

        public static List<string> 需求欄位列表
        {
            get
            {
                return _需求欄位列表;
            }
        }

        public static int 合法遮罩
        {
            get
            {
                return _合法遮罩;
            }
        }

        public static int get遮罩(string name)
        {
            foreach (動態匯入需求欄位_月結帳 x in Enum.GetValues(typeof(動態匯入需求欄位_月結帳)))
            {
                if (x.ToString().CompareTo(name) == 0)
                    return (int)x;
            }

            return 0;
        }

        /********************************/

        public static 動態匯入檔案設定_月結帳 New()
        {
            return new 動態匯入檔案設定_月結帳
            {
                格式 = 列舉.檔案格式類型.無,
                名稱 = 字串.空,
                公司 = 公司資料.NULL,
                廠商 = 廠商資料.NULL
            };
        }

        private static readonly 動態匯入檔案設定_月結帳 _NULL = new 動態匯入檔案設定_月結帳
        {
            格式 = 列舉.檔案格式類型.無,
            名稱 = 字串.空,
            公司 = 公司資料.NULL,
            廠商 = 廠商資料.NULL
        };
        public static 動態匯入檔案設定_月結帳 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 動態匯入檔案設定_月結帳 _ERROR = new 動態匯入檔案設定_月結帳
        {
            格式 = 列舉.檔案格式類型.錯誤,
            名稱 = 字串.錯誤,
            公司 = 公司資料.ERROR,
            廠商 = 廠商資料.ERROR
        };
        public static 動態匯入檔案設定_月結帳 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        public override object 拷貝()
        {
            動態匯入檔案設定_月結帳 New_ = new 動態匯入檔案設定_月結帳
            {
                格式 = this.格式,
                開始位置 = this.開始位置,
                結束位置 = this.結束位置,
                標頭位置 = this.標頭位置,
                名稱 = this.名稱,
                公司 = this.公司,
                廠商 = this.廠商
            };

            foreach (動態匯入資料設定 Item_ in this.資料List)
            {
                New_.資料List.Add((動態匯入資料設定)Item_.拷貝());
            }

            return New_;
        }

        // 如果不合法 回傳例外
        public override string 檢查合法()
        {
            string Result_ = base.檢查合法();
            if (String.IsNullOrEmpty(Result_) == false)
                return Result_;

            if (公司編號 <= 常數.空白資料編碼)
                return "動態匯入檔案設定_月結帳:公司不合法:" + 公司編號;

            if (廠商編號 <= 常數.空白資料編碼)
                return "動態匯入檔案設定_月結帳:廠商不合法:" + 廠商編號;

            if (合法遮罩 == 0)
                return null;

            if (資料List == null)
                return "動態匯入檔案設定:沒欄位資料";

            int 目前遮罩_ = 0;
            foreach (動態匯入資料設定 資料 in 資料List)
            {
                int 遮罩_ = get遮罩(資料.名稱);
                if ((遮罩_ & 目前遮罩_) > 0)
                    return "動態匯入檔案設定:遮罩重複" + 遮罩_;

                目前遮罩_ |= 遮罩_;
            }

            if(合法遮罩 != 目前遮罩_)
                return "動態匯入檔案設定:遮罩不吻合" + 目前遮罩_;

            return null;
        }
    }
}
