using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳資料 : MyKeepableData
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        public 公司資料 公司;
        [JsonProperty]
        public int 公司編號
        {
            get
            {
                if (公司 == null)
                    return 常數.T錯誤資料編碼;
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
                    return 常數.T錯誤資料編碼;
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

        private static readonly 月結帳資料 _NULL = new 月結帳資料
        {
            編號 = 常數.T空白資料編碼,
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
            編號 = 常數.T錯誤資料編碼,
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

        /********************************/

        public override object 拷貝()
        {
            月結帳資料 Data_ = new 月結帳資料
            {
                編號 = this.編號,
                公司 = this.公司,
                廠商 = this.廠商,
                商品識別 = this.商品識別,
                商品 = this.商品,
                數量 = this.數量,
                單價 = this.單價,
                含稅單價 = this.含稅單價,
            };

            return Data_;
        }

        public override void 覆蓋(object Item_)
        {
            月結帳資料 Data_ = Item_ as 月結帳資料;
            if (Data_ == null)
                throw new Exception("月結帳資料:覆蓋失敗:" + this.GetType());

            編號 = Data_.編號;
            公司 = Data_.公司;
            廠商 = Data_.廠商;
            商品識別 = Data_.商品識別;
            商品 = Data_.商品;
            數量 = Data_.數量;
            單價 = Data_.單價;
            含稅單價 = Data_.含稅單價;
        }

        public override Boolean 是否一致(object Item_)
        {
            月結帳資料 Data_ = Item_ as 月結帳資料;
            if (Data_ == null)
                throw new Exception("月結帳資料:比較失敗:" + this.GetType());

            return
                編號 == Data_.編號 &&
                公司 == Data_.公司 &&
                廠商 == Data_.廠商 &&
                商品識別 == Data_.商品識別 &&
                商品 == Data_.商品 &&
                數量 == Data_.數量 &&
                單價 == Data_.單價 &&
                含稅單價 == Data_.含稅單價;
        }

        public override void 檢查合法()
        {
            if (公司編號 <= 常數.T新建資料編碼)
                throw new Exception("月結帳資料:公司不合法:" + 公司編號);

            if (廠商編號 <= 常數.T新建資料編碼)
                throw new Exception("月結帳資料:廠商不合法:" + 廠商編號);

            if (商品編號 <= 常數.T新建資料編碼)
                throw new Exception("月結帳資料:商品不合法:" + 商品編號);
        }
    }
}
