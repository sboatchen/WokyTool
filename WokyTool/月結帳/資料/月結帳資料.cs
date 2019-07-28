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

        public string 訂單編號 { get; set; }

        [JsonProperty]
        public int 設定編號
        {
            get
            {
                return 設定.編號;
            }
            set
            {
                _設定 = 月結帳匯入設定資料管理器.獨體.Get(value);
            }
        }

        protected 月結帳匯入設定資料 _設定;
        public 月結帳匯入設定資料 設定
        {
            get
            {
                if (_設定 == null)
                    _設定 = 月結帳匯入設定資料.NULL;
                else if (月結帳匯入設定資料管理器.獨體.唯讀BList.Contains(_設定) == false)
                    _設定 = 月結帳匯入設定資料.ERROR;

                return _設定;
            }
            set
            {
                _設定 = value;
            }
        }

        public 公司資料 公司
        {
            get 
            {
                return 設定.公司;
            }
        }

        public 客戶資料 客戶
        {
            get
            {
                return 設定.客戶;
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

        public decimal 成本
        {
            get
            {
                return 商品.成本;
            }
        }

        public decimal 總成本
        {
            get { return 數量 * 成本; }
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

            設定 = 月結帳匯入設定資料.NULL,

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

            設定 = 月結帳匯入設定資料.ERROR,

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

                設定 = this.設定,

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

            設定 = Data_.設定;

            商品 = Data_.商品;

            數量 = Data_.數量;
            單價 = Data_.單價;
            含稅單價 = Data_.含稅單價;
        }

        public override bool 是否一致(月結帳資料 Data_)
        {
            return
                編號 == Data_.編號 &&

                公司 == Data_.公司 &&
                客戶 == Data_.客戶 &&

                商品 == Data_.商品 &&

                數量 == Data_.數量 &&
                單價 == Data_.單價 &&
                含稅單價 == Data_.含稅單價;
        }

        public override void 檢查合法()
        {
            if (設定.編號是否合法() == false)
                throw new Exception("月結帳資料:設定編號不合法:" + 設定編號);

            if (商品.編號是否合法() == false)
                throw new Exception("月結帳資料:商品不合法:" + 商品編號);

            if (商品.公司 != 公司)
                throw new Exception("月結帳資料:公司不一致:" + 商品.公司.名稱 + "," + 公司.名稱);

            if (商品.客戶 != 客戶)
                throw new Exception("月結帳資料:客戶不一致:" + 商品.客戶.名稱 + "," + 客戶.名稱);
        }
    }
}

