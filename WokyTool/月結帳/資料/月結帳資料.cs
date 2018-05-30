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

namespace WokyTool.月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳資料 : MyData
    {
        [JsonProperty]
        public int 編號 { get; set; }

        public 公司資料 公司;
        [JsonProperty]
        public int 公司編號
        {
            get
            {
                if (公司 == null)
                    return 常數.錯誤資料編碼;
                return 公司.編號;
            }
            set
            {
                公司 = 公司管理器.Instance.Get(value);
            }
        }

        public String 公司名稱 
        {
            get { return 公司.名稱; }
        }

        public 廠商資料 廠商;
        [JsonProperty]
        public int 廠商編號
        {
            get
            {
                if (廠商 == null)
                    return 常數.錯誤資料編碼;
                return 廠商.編號;
            }
            set
            {
                廠商 = 廠商管理器.Instance.Get(value);
            }
        }

        public String 廠商名稱
        {
            get { return 廠商.名稱; }
        }

        [JsonProperty]
        public string 商品識別 { get; set; }

        public 商品資料 商品 { get; set; }
        [JsonProperty]
        public int 商品編號
        {
            get
            {
                return 商品.編號;
            }
            set
            {
                商品 = 商品管理器.Instance.Get(value);
            }
        }

        public String 商品名稱
        {
            get { return 商品.名稱; }
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

        /*
        public static 月結帳資料 New()   //@@ 拔掉所有的New
        {
            return new 月結帳資料
            {
                編號 = 編碼管理器.Instance.Get(列舉.編碼類型.物品),
                公司 = 公司資料.NULL,
                廠商 = 廠商資料.NULL,
                商品識別 = 字串.無,
                商品 = 商品資料.NULL,
                數量 = 0,
                單價 = 0,
                含稅單價 = 0,
            };
        }
        */

        private static readonly 月結帳資料 _NULL = new 月結帳資料
        {
            編號 = 常數.空白資料編碼,
            公司 = 公司資料.NULL,
            廠商 = 廠商資料.NULL,
            商品識別 = 字串.空,
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
            編號 = 常數.錯誤資料編碼,
            公司 = 公司資料.ERROR,
            廠商 = 廠商資料.ERROR,
            商品識別 = 字串.空,
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

        public override object 拷貝()
        {
            throw new Exception("Not support copy");
        }

        public override void 檢查合法()
        {
            if (公司編號 <= 常數.空白資料編碼)
                throw new Exception("月結帳資料:公司不合法:" + 公司編號);

            if (廠商編號 <= 常數.空白資料編碼)
                throw new Exception("月結帳資料:廠商不合法:" + 廠商編號);

            if(商品編號 <= 常數.空白資料編碼)
                throw new Exception("月結帳資料:商品不合法:" + 商品編號);
        }
    }
}
