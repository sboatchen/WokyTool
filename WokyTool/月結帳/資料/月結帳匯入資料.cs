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
    public class 月結帳匯入資料 : 可匯入資料
    {
        public string 訂單編號 { get; set; }

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

        [JsonProperty]
        public string 商品識別 { get; set; }

        protected 商品資料 _商品;
        public 商品資料 商品
        {
            get
            {
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

        /********************************/

        public 月結帳匯入資料 Self
        {
            get { return this; }
        }

        private static readonly 月結帳匯入資料 _NULL = new 月結帳匯入資料
        {
            設定 = 月結帳匯入設定資料.NULL,

            商品識別 = 字串.無,
            商品 = 商品資料.空白,

            數量 = 0,
            單價 = 0,
            含稅單價 = 0,
        };
        public static 月結帳匯入資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 月結帳匯入資料 _ERROR = new 月結帳匯入資料
        {
            設定 = 月結帳匯入設定資料.ERROR,

            商品識別 = 字串.錯誤,
            商品 = 商品資料.錯誤,

            數量 = 0,
            單價 = 0,
            含稅單價 = 0,
        };
        public static 月結帳匯入資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override void 檢查合法()
        {
            if (設定.編號是否合法() == false)
                throw new Exception("月結帳匯入資料:設定不合法");

            if (商品.編號是否合法() == false)
                throw new Exception("月結帳匯入資料:商品不合法");

            if (商品.公司 != 設定.公司)
                throw new Exception("月結帳匯入資料:公司不一致:" + 商品.公司.名稱 + "," + 設定.公司.名稱);

            if (商品.客戶 != 設定.客戶)
                throw new Exception("月結帳匯入資料:客戶不一致:" + 商品.客戶.名稱 + "," + 設定.客戶.名稱);
        }
    }
}

