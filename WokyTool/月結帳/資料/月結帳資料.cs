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

namespace WokyTool.月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳資料 : MyKeepableData<月結帳資料>
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

        public decimal 成本
        {
            get
            {
                return 商品.成本;
            }
        }

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

        /********************************/

        public 月結帳資料 Self
        {
            get { return this; }
        }

        private static readonly 月結帳資料 _NULL = new 月結帳資料
        {
            編號 = 常數.T空白資料編碼,

            公司 = 公司資料.NULL,
            客戶 = 客戶資料.NULL,

            商品識別 = 字串.無,
            商品 = 商品資料.NULL,

            數量 = 0,
            單價 = 0,
            含稅單價 = 0,
        };
        public static 月結帳資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 月結帳資料 _ERROR = new 月結帳資料
        {
            編號 = 常數.T錯誤資料編碼,

            公司 = 公司資料.ERROR,
            客戶 = 客戶資料.ERROR,

            商品識別 = 字串.錯誤,
            商品 = 商品資料.ERROR,

            數量 = 0,
            單價 = 0,
            含稅單價 = 0,
        };
        public static 月結帳資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override 月結帳資料 拷貝()
        {
            月結帳資料 Data_ = new 月結帳資料
            {
                編號 = this.編號,

                公司 = this.公司,
                客戶 = this.客戶,

                商品識別 = this.商品識別,
                商品 = this.商品,

                數量 = this.數量,
                單價 = this.單價,
                含稅單價 = this.含稅單價,
            };

            return Data_;
        }

        public override void 覆蓋(月結帳資料 Data_)
        {
            編號 = Data_.編號;

            公司 = Data_.公司;
            客戶 = Data_.客戶;

            商品識別 = Data_.商品識別;
            商品 = Data_.商品;

            數量 = Data_.數量;
            單價 = Data_.單價;
            含稅單價 = Data_.含稅單價;
        }

        public override Boolean 是否一致(月結帳資料 Data_)
        {
            return
                編號 == Data_.編號 &&

                公司 == Data_.公司 &&
                客戶 == Data_.客戶 &&

                商品識別 == Data_.商品識別 &&
                商品 == Data_.商品 &&

                數量 == Data_.數量 &&
                單價 == Data_.單價 &&
                含稅單價 == Data_.含稅單價;
        }

        public override void 檢查合法()
        {
            if (公司.編號是否合法() == false)
                throw new Exception("月結帳資料:公司編號不合法:" + 公司編號);

            if (客戶.編號是否合法() == false)
                throw new Exception("月結帳資料:客戶編號不合法:" + 客戶編號);

            if (商品.編號是否合法() == false)
                throw new Exception("月結帳資料:商品不合法:" + 商品編號);
        }
    }
}

