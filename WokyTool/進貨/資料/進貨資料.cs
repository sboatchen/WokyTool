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
using WokyTool.通用;
using WokyTool.幣值;
using WokyTool.廠商;

namespace WokyTool.進貨
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 進貨資料 : MyKeepableData<進貨資料>
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        [JsonProperty]
        public 列舉.進貨處理狀態 狀態 { get; set; }

        [JsonProperty]
        public DateTime 時間 { get; set; }

        [JsonProperty]
        public 列舉.進貨 類型 { get; set; }

        [JsonProperty]
        public int 廠商編號
        {
            get
            {
                return 廠商.編號;
            }
            set
            {
                _廠商 = 廠商資料管理器.獨體.Get(value);
            }
        }

        protected 廠商資料 _廠商;
        public 廠商資料 廠商
        {
            get
            {
                if (_廠商 == null)
                    _廠商 = 廠商資料.NULL;
                else if (廠商資料管理器.獨體.唯讀BList.Contains(_廠商) == false)
                    _廠商 = 廠商資料.ERROR;

                return _廠商;
            }
            set
            {
                _廠商 = value;
            }
        }

        [JsonProperty]
        public int 物品編號
        {
            get
            {
                return _物品.編號;
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
        public int 幣值編號
        {
            get
            {
                return 幣值.編號;
            }
            set
            {
                _幣值 = 幣值資料管理器.獨體.Get(value);
            }
        }

        protected 幣值資料 _幣值;
        public 幣值資料 幣值
        {
            get
            {
                if (_幣值 == null)
                    _幣值 = 幣值資料.NULL;
                else if (幣值資料管理器.獨體.唯讀BList.Contains(_幣值) == false)
                    _幣值 = 幣值資料.ERROR;

                return _幣值;
            }
            set
            {
                _幣值 = value;
            }
        }

        [JsonProperty]
        public decimal 成本 { get; set; }

        [JsonProperty]
        public string 成本備註 { get; set; }

        [JsonProperty]
        public string 備註 { get; set; }

        // for ui control
        private 列舉.進貨處理狀態 _狀態控制 = 列舉.進貨處理狀態.無;
        public 列舉.進貨處理狀態 狀態控制
        {
            get
            {
                if (_狀態控制 == 列舉.進貨處理狀態.無)
                    _狀態控制 = 狀態;

                return _狀態控制;
            }
            set
            {
                if (_狀態控制 == 列舉.進貨處理狀態.新增 && value == 列舉.進貨處理狀態.入帳)
                {
                    _狀態控制 = value;
                    狀態 = value;
                    物品.最後進貨成本 = 成本;
                    物品.成本備註 = 成本備註;
                    物品.內庫數量 += 數量;

                    物品資料管理器.獨體.資料異動();
                }
                else if (_狀態控制 == 列舉.進貨處理狀態.入帳 && value == 列舉.進貨處理狀態.新增)
                {
                    _狀態控制 = value;
                    狀態 = value;
                    物品.內庫數量 -= 數量;

                    物品資料管理器.獨體.資料異動();
                }
                else
                {
                    訊息管理器.獨體.警告("不支援此項操作: " + _狀態控制 + " -> " + value);
                }
            }
        }

        /********************************/

        public 進貨資料 Self
        {
            get { return this; }
        }

        private static readonly 進貨資料 _NULL = new 進貨資料
        {
            編號 = 常數.空白資料編碼,

            狀態 = 列舉.進貨處理狀態.忽略,

            時間 = new DateTime(),

            類型 = 列舉.進貨.一般,

            廠商 = 廠商資料.NULL,

            物品 = 物品資料.NULL,

            數量 = 0,
            單價 = 0,

            幣值 = 幣值資料.NULL,

            成本 = 0,
            成本備註 = 字串.空,

            備註 = 字串.空,
        };
        public static 進貨資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 進貨資料 _ERROR = new 進貨資料
        {
            編號 = 常數.錯誤資料編碼,

            狀態 = 列舉.進貨處理狀態.錯誤,

            時間 = new DateTime(),

            類型 = 列舉.進貨.錯誤,

            廠商 = 廠商資料.ERROR,

            物品 = 物品資料.ERROR,

            數量 = 0,
            單價 = 0,

            幣值 = 幣值資料.ERROR,

            成本 = 0,
            成本備註 = 字串.錯誤,

            備註 = 字串.錯誤,
        };
        public static 進貨資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override 進貨資料 拷貝()
        {
            進貨資料 Data_ = new 進貨資料
            {
                編號 = this.編號,

                狀態 = this.狀態,

                時間 = this.時間,

                類型 = this.類型,

                廠商 = this.廠商,

                物品 = this.物品,

                數量 = this.數量,
                單價 = this.單價,

                幣值 = this.幣值,

                成本 = this.成本,
                成本備註 = this.成本備註,

                備註 = this.備註,
            };

            return Data_;
        }

        public override void 覆蓋(進貨資料 Data_)
        {
            編號 = Data_.編號;

            狀態 = Data_.狀態;

            時間 = Data_.時間;

            類型 = Data_.類型;

            廠商 = Data_.廠商;

            物品 = Data_.物品;

            數量 = Data_.數量;
            單價 = Data_.單價;

            幣值 = Data_.幣值;

            成本 = Data_.成本;
            成本備註 = Data_.成本備註;

            備註 = Data_.備註;
        }

        public override bool 是否一致(進貨資料 Data_)
        {
            return
                編號 == Data_.編號 &&
                狀態 == Data_.狀態 &&
                時間 == Data_.時間 &&
                類型 == Data_.類型 &&
                廠商 == Data_.廠商 &&
                物品 == Data_.物品 &&
                數量 == Data_.數量 &&
                單價 == Data_.單價 &&
                幣值 == Data_.幣值 &&
                成本 == Data_.成本 &&
                成本備註 == Data_.成本備註 &&
                備註 == Data_.備註;
        }

        public override void 檢查合法()
        {
            if (廠商.編號是否合法() == false)
                throw new Exception("進貨資料:公司編號不合法:" + 廠商編號);

            if (物品.編號是否合法() == false)
                throw new Exception("進貨資料:物品編號不合法:" + 物品編號);

            if (幣值.編號是否合法() == false)
                throw new Exception("進貨資料:幣值編號不合法:" + 幣值編號);

            if (列舉.是否合法((int)類型) == false)
                throw new Exception("進貨資料:類型不合法:" + 類型);

            if (數量 <= 0)
                throw new Exception("進貨資料:數量不合法:" + 數量);
        }
    }
}
