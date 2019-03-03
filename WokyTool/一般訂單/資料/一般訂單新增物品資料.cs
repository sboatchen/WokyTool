using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.一般訂單;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 一般訂單新增物品資料
    {
        [JsonProperty]
        public int 物品編號
        {
            get
            {
                return 物品.編號;
            }
            set
            {
                _物品 = 物品資料管理器.獨體.Get(value);
            }
        }

        protected 物品資料 _物品;
        public 物品資料 物品
        {
            get
            {
                if (_物品 == null)
                    _物品 = 物品資料.NULL;
                else if (物品資料管理器.獨體.唯讀BList.Contains(_物品) == false)
                    _物品 = 物品資料.ERROR;

                return _物品;
            }
            set
            {
                _物品 = value;
            }
        }

        public String 物品名稱
        {
            get
            {
                return _物品.名稱;
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

        public 一般訂單新增物品資料 Self
        {
            get { return this; }
        }

        private static readonly 一般訂單新增物品資料 _NULL = new 一般訂單新增物品資料
        {
            /*編號 = 常數.T空白資料編碼,*/

            物品 = 物品資料.NULL,

            數量 = 0,
            單價 = 0,
        };
        public static 一般訂單新增物品資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 一般訂單新增物品資料 _ERROR = new 一般訂單新增物品資料
        {
            /*編號 = 常數.T錯誤資料編碼,*/

            物品 = 物品資料.ERROR,

            數量 = 0,
            單價 = 0,
        };
        public static 一般訂單新增物品資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        /*public override 一般訂單新增物品資料 拷貝()
        {
            一般訂單新增物品資料 Data_ = new 一般訂單新增物品資料
            {
                物品 = this.物品,

                數量 = this.數量,
                單價 = this.單價,
                含稅單價 = this.含稅單價,
            };

            return Data_;
        }

        public override void 覆蓋(一般訂單新增物品資料 Data_)
        {
            物品 = Data_.物品;

            數量 = Data_.數量;
            單價 = Data_.單價;
            含稅單價 = Data_.含稅單價;
        }

        public override Boolean 是否一致(一般訂單新增物品資料 Data_)
        {
            return
                物品 == Data_.物品 &&

                數量 == Data_.數量 &&
                單價 == Data_.單價 &&
                含稅單價 == Data_.含稅單價;
        }*/

        public /*override*/ void 檢查合法()
        {
            if (物品.編號是否合法() == false)
                throw new Exception("一般訂單新增物品資料:物品不合法:" + 物品編號);
        }
    }
}
