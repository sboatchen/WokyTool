using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 平台訂單資料 : MyKeepableData<平台訂單資料>, 可下訂介面
    {
        [JsonProperty]
        public override int 編號 { get; set; }

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
        public 列舉.配送公司類型 配送公司 { get; set; }

        [JsonProperty]
        public string 配送單號 { get; set; }

        /********************************/

        public 平台訂單資料 Self
        {
            get { return this; }
        }

        private static readonly 平台訂單資料 _NULL = new 平台訂單資料
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
        public static 平台訂單資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 平台訂單資料 _ERROR = new 平台訂單資料
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
        public static 平台訂單資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override 平台訂單資料 拷貝()
        {
            平台訂單資料 Data_ = new 平台訂單資料
            {
                編號 = this.編號,

                公司 = this.公司,
                客戶 = this.客戶,

                商品 = this.商品,

                數量 = this.數量,
                單價 = this.單價,
                含稅單價 = this.含稅單價,
                成本 = this.成本,

                姓名 = this.姓名,
                地址 = this.地址,
                電話 = this.電話,
                手機 = this.手機,

                訂單編號 = this.訂單編號,
                訂單內容 = this.訂單內容,
                備註 = this.備註,

                配送公司 = this.配送公司,
                配送單號 = this.配送單號,
            };

            return Data_;
        }

        public override void 覆蓋(平台訂單資料 Data_)
        {
            編號 = Data_.編號;

            公司 = Data_.公司;
            客戶 = Data_.客戶;

            商品 = Data_.商品;

            數量 = Data_.數量;
            單價 = Data_.單價;
            含稅單價 = Data_.含稅單價;
            成本 = Data_.成本;

            姓名 = Data_.姓名;
            地址 = Data_.地址;
            電話 = Data_.電話;
            手機 = Data_.手機;

            訂單編號 = Data_.訂單編號;
            訂單內容 = Data_.訂單內容;
            備註 = Data_.備註;

            配送公司 = Data_.配送公司;
            配送單號 = Data_.配送單號;
        }

        public override Boolean 是否一致(平台訂單資料 Data_)
        {
            return
                編號 == Data_.編號 &&

                公司 == Data_.公司 &&
                客戶 == Data_.客戶 &&

                商品 == Data_.商品 &&

                數量 == Data_.數量 &&
                單價 == Data_.單價 &&
                含稅單價 == Data_.含稅單價 &&
                成本 == Data_.成本 &&

                姓名 == Data_.姓名 &&
                地址 == Data_.地址 &&
                電話 == Data_.電話 &&
                手機 == Data_.手機 &&

                訂單編號 == Data_.訂單編號 &&
                訂單內容 == Data_.訂單內容 &&
                備註 == Data_.備註 &&

                配送公司 == Data_.配送公司 &&
                配送單號 == Data_.配送單號;
        }

        public override void 檢查合法()
        {
            if (公司.編號是否合法() == false)
                throw new Exception("平台訂單資料:公司編號不合法:" + 公司編號);

            if (客戶.編號是否合法() == false)
                throw new Exception("平台訂單資料:客戶編號不合法:" + 客戶編號);

            if (商品.編號是否合法() == false)
                throw new Exception("平台訂單資料:商品不合法:" + 商品編號);

            if (商品.公司 != 公司)
                throw new Exception("平台訂單資料:公司不一致:" + 商品.公司.名稱 + "," + 公司.名稱);

            if (商品.客戶 != 客戶)
                throw new Exception("平台訂單資料:客戶不一致:" + 商品.客戶.名稱 + "," + 客戶.名稱);

            if (String.IsNullOrEmpty(姓名))
                throw new Exception("平台訂單資料:姓名不合法:" + this.ToString());

            if (String.IsNullOrEmpty(地址))
                throw new Exception("平台訂單資料:地址不合法:" + this.ToString());

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                throw new Exception("平台訂單資料:電話與手機不合法:" + this.ToString());

            if (String.IsNullOrEmpty(訂單編號))
                throw new Exception("平台訂單資料:訂單編號不合法:" + this.ToString());

            if (String.IsNullOrEmpty(訂單內容))
                throw new Exception("平台訂單資料:訂單內容不合法:" + this.ToString());

            if ((int)配送公司 <= 常數.列舉空白編碼)
                throw new Exception("平台訂單資料:配送公司不合法:" + this.ToString());

            if (String.IsNullOrEmpty(配送單號))
                throw new Exception("平台訂單資料:配送單號不合法:" + this.ToString());
        }
    }
}

