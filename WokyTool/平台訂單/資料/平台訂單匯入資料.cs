using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 平台訂單匯入資料 : MyData, 可下訂介面, 可配送介面, IComparable<平台訂單匯入資料>
    {
        /* 可下訂介面 */

        [JsonProperty]
        public int 公司編號
        {
            get
            {
                return 公司.編號;
            }
            set
            {
                _公司 = 公司資料管理器.獨體.Get(value);
            }
        }

        protected 公司資料 _公司;
        public 公司資料 公司
        {
            get
            {
                if (_公司 == null)
                    _公司 = 公司資料.NULL;
                else if (公司資料管理器.獨體.唯讀BList.Contains(_公司) == false)
                    _公司 = 公司資料.ERROR;

                return _公司;
            }
            set
            {
                _公司 = value;
            }
        }

        [JsonProperty]
        public int 客戶編號
        {
            get
            {
                return 客戶.編號;
            }
            set
            {
                _客戶 = 客戶資料管理器.獨體.Get(value);
            }
        }

        protected 客戶資料 _客戶;
        public 客戶資料 客戶
        {
            get
            {
                if (_客戶 == null)
                    _客戶 = 客戶資料.NULL;
                else if (客戶資料管理器.獨體.唯讀BList.Contains(_客戶) == false)
                    _客戶 = 客戶資料.ERROR;

                return _客戶;
            }
            set
            {
                _客戶 = value;
            }
        }

        [JsonProperty]
        public string 商品識別 { get; set; }

        [JsonProperty]
        public int 商品編號
        {
            get
            {
                return 商品.編號;
            }
            set
            {
                _商品 = 商品資料管理器.獨體.Get(value);
            }
        }

        protected 商品資料 _商品;
        public 商品資料 商品
        {
            get
            {
                if (_商品 == null)
                    _商品 = 商品資料.NULL;
                else if (商品資料管理器.獨體.唯讀BList.Contains(_商品) == false)
                    _商品 = 商品資料.ERROR;

                return _商品;
            }
            set
            {
                _商品 = value;
            }
        }

        [JsonProperty]
        public int 數量 { get; set; }

        [JsonProperty]
        public decimal 單價 { get; set; }

        [JsonProperty]
        public decimal 含稅單價 { get; set; }

        public decimal 總金額
        {
            get { return 數量 * 含稅單價; }
        }

        [JsonProperty]
        public decimal 成本 { get; set; }

        public decimal 利潤
        {
            get
            {
                return 含稅單價 - 成本;
            }
        }

        public decimal 總利潤
        {
            get
            {
                return 利潤 * 數量;
            }
        }

        [JsonProperty]
        public string 姓名 { get; set; }

        [JsonProperty]
        public string 地址 { get; set; }

        [JsonProperty]
        public string 電話 { get; set; }

        [JsonProperty]
        public string 手機 { get; set; }

        [JsonProperty]
        public string 訂單編號 { get; set; }

        [JsonProperty]
        public string 訂單內容 { get; set; }

        [JsonProperty]
        public string 備註 { get; set; }

        [JsonProperty]
        public 列舉.配送公司 配送公司 { get; set; }

        [JsonProperty]
        public string 配送單號 { get; set; }

        /* 可配送介面 */

        [JsonProperty]
        public string 配送姓名 { get; set; }

        [JsonProperty]
        public string 配送電話 { get; set; }

        [JsonProperty]
        public string 配送手機 { get; set; }

        [JsonProperty]
        public string 配送地址 { get; set; }

        [JsonProperty]
        public string 配送內容 { get; set; }

        [JsonProperty]
        public string 配送備註 { get; set; }

        [JsonProperty]
        public DateTime 指配日期 { get; set; }     // 指配日期.Ticks == 0 代表不指定

        [JsonProperty]
        public 列舉.指配時段 指配時段 { get; set; }

        [JsonProperty]
        public 列舉.代收方式 代收方式 { get; set; }

        [JsonProperty]
        public decimal 代收金額 { get; set; }

        /* 其他欄位 */

        public int 群組 { get; set; }

        public string 重要備註 { get; set; }

        public int 總體積
        {
            get
            {
                return 數量 * 商品.體積;
            }
        }

        /********************************/

        public 平台訂單匯入資料 Self
        {
            get { return this; }
        }

        /*
        private static readonly 平台訂單匯入資料 _NULL = new 平台訂單匯入資料
        {
            編號 = 常數.T空白資料編碼,

            公司 = 公司資料.NULL,
            客戶 = 客戶資料.NULL,

            商品 = 商品資料.NULL,

            數量 = 0,
            單價 = 0,
            含稅單價 = 0,
            成本 = 0,

            姓名 = 字串.無,
            地址 = 字串.無,
            電話 = 字串.無,
            手機 = 字串.無,

            訂單編號 = 字串.無,
            訂單內容 = 字串.無,
            備註 = 字串.無,

            配送公司 = 列舉.配送公司類型.無,
            配送單號 = 字串.無,
        };
        public static 平台訂單匯入資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 平台訂單匯入資料 _ERROR = new 平台訂單匯入資料
        {
            編號 = 常數.T錯誤資料編碼,

            公司 = 公司資料.ERROR,
            客戶 = 客戶資料.ERROR,

            商品 = 商品資料.ERROR,

            數量 = 0,
            單價 = 0,
            含稅單價 = 0,
            成本 = 0,

            姓名 = 字串.錯誤,
            地址 = 字串.錯誤,
            電話 = 字串.錯誤,
            手機 = 字串.錯誤,

            訂單編號 = 字串.錯誤,
            訂單內容 = 字串.錯誤,
            備註 = 字串.錯誤,

            配送公司 = 列舉.配送公司類型.錯誤,
            配送單號 = 字串.錯誤,
        };
        public static 平台訂單匯入資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }*/

        /********************************/
        // MyData

        public override void 檢查合法()
        {
            if (公司.編號是否合法() == false)
                throw new Exception("平台訂單匯入資料:公司編號不合法:" + 公司編號);

            if (客戶.編號是否合法() == false)
                throw new Exception("平台訂單匯入資料:客戶編號不合法:" + 客戶編號);

            if (商品.編號是否合法() == false)
                throw new Exception("平台訂單匯入資料:商品不合法:" + 商品編號);

            if (商品.公司 != 公司)
                throw new Exception("平台訂單匯入資料:公司不一致:" + 商品.公司.名稱 + "," + 公司.名稱);

            if (商品.客戶 != 客戶)
                throw new Exception("平台訂單匯入資料:客戶不一致:" + 商品.客戶.名稱 + "," + 客戶.名稱);

            if (String.IsNullOrEmpty(姓名))
                throw new Exception("平台訂單匯入資料:姓名不合法:" + this.ToString());

            if (String.IsNullOrEmpty(地址))
                throw new Exception("平台訂單匯入資料:地址不合法:" + this.ToString());

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                throw new Exception("平台訂單匯入資料:電話與手機不合法:" + this.ToString());

            if (String.IsNullOrEmpty(訂單編號))
                throw new Exception("平台訂單匯入資料:訂單編號不合法:" + this.ToString());
        }

        /********************************/
        // IComparable

        // 這個主要是用來做併單判斷
        virtual public int CompareTo(平台訂單匯入資料 Other_)
        {
            // A null value means that this object is greater.
            if (Other_ == null)
                return 1;

            return String.Compare(this.地址, Other_.地址);
        }

        /********************************/
        // 可配送介面

        // 準備配送
        virtual public void 準備配送()
        {
            if (是否處理() == false)
                return;

            if (String.IsNullOrEmpty(重要備註))
                配送姓名 = 姓名;
            else
                配送姓名 = string.Format("{0}({1})", 姓名, 重要備註);

            if(String.IsNullOrEmpty(電話))
                配送電話 = 手機;
            else
                配送電話 = 電話;

            配送手機 = 手機;
            配送地址 = 地址;

            物品組成資料 物品組成資料_ = new 物品組成資料(商品);
            配送內容 = 物品組成資料_.取得組合字串();

            if (String.IsNullOrEmpty(備註))
                配送備註 = 客戶.名稱;
            else
                配送備註 = string.Format("{0}({1})", 客戶.名稱, 備註);

            // 配送公司
            if (配送公司 == 列舉.配送公司.無)
            {
                if (總體積 >= 常數.宅配通配送最小體積)
                    配送公司 = 列舉.配送公司.宅配通;
                else
                    配送公司 = 列舉.配送公司.全速配;
            }
        }

        // 完成配送
        virtual public void 完成配送(string 配送單號_)
        {
            配送單號 = 配送單號_;
        }

        public bool 是否已配送()
        {
            return 是否處理() == false || String.IsNullOrEmpty(配送單號) == false;
        }

        /********************************/

        virtual public bool 是否處理()
        {
            return true;
        }

        virtual public void 初始化()
        {
            ;
        }
    }
}

