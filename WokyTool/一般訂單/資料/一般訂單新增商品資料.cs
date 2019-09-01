using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.一般訂單;
using WokyTool.公司;
using WokyTool.商品;
using WokyTool.客戶;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 一般訂單新增商品資料
    {
        [JsonProperty]
        public int 商品編號
        {
            get
            {
                return 商品.編號;
            }
            set
            {
                _商品 = 商品資料管理器.獨體.取得(value);
            }
        }

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

        public String 商品名稱
        {
            get
            {
                return _商品.名稱;
            }
        }

        [JsonProperty]
        public int 數量 { get; set; }

        [JsonProperty]
        public decimal 單價 { get; set; }

        public decimal 總金額
        {
            get
            {
                return 數量 * 單價;
            }
        }

        [JsonProperty]
        public String 備註 { get; set; }

        /********************************/

        public 一般訂單新增商品資料 Self
        {
            get { return this; }
        }

        private static readonly 一般訂單新增商品資料 _NULL = new 一般訂單新增商品資料
        {
            /*編號 = 常數.空白資料編碼,*/

            商品 = 商品資料.空白,

            數量 = 0,
            單價 = 0,
        };
        public static 一般訂單新增商品資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 一般訂單新增商品資料 _ERROR = new 一般訂單新增商品資料
        {
            /*編號 = 常數.錯誤資料編碼,*/

            商品 = 商品資料.錯誤,

            數量 = 0,
            單價 = 0,
        };
        public static 一般訂單新增商品資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        /*public override 一般訂單新增商品資料 拷貝()
        {
            一般訂單新增商品資料 Data_ = new 一般訂單新增商品資料
            {
                商品 = this.商品,

                數量 = this.數量,
                單價 = this.單價,
                含稅單價 = this.含稅單價,
            };

            return Data_;
        }

        public override void 覆蓋(一般訂單新增商品資料 Data_)
        {
            商品 = Data_.商品;

            數量 = Data_.數量;
            單價 = Data_.單價;
            含稅單價 = Data_.含稅單價;
        }

        public override bool 是否一致(一般訂單新增商品資料 Data_)
        {
            return
                商品 == Data_.商品 &&

                數量 == Data_.數量 &&
                單價 == Data_.單價 &&
                含稅單價 == Data_.含稅單價;
        }*/

        public /*override*/ void 檢查合法()
        {
            if (商品.編號是否合法() == false)
                throw new Exception("一般訂單新增商品資料:商品不合法:" + 商品編號);
        }
    }
}
