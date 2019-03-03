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
using WokyTool.客製;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 平台訂單新增資料 : MyKeepableData<平台訂單新增資料>, 可配送介面
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        [JsonProperty]
        public DateTime 處理時間 { get; set; }

        [JsonProperty]
        public 列舉.訂單處理狀態 處理狀態 { get; set; }

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
            private set
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

        [JsonProperty]
        public decimal 含稅單價 { get; set; }

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
        public string 備註 { get; set; }


        [JsonProperty]
        public 列舉.配送公司 配送公司 { get; set; }

        [JsonProperty]
        public string 配送單號 { get; set; }

        [JsonProperty]
        public DateTime 指配日期 { get; set; }     // 指配日期.Ticks == 0 代表不指定

        [JsonProperty]
        public 列舉.指配時段 指配時段 { get; set; }

        [JsonProperty]
        public 列舉.代收方式 代收方式 { get; set; }

        [JsonProperty]
        public decimal 代收金額 { get; set; }

        [JsonProperty]
        public Dictionary<int, Object> 額外資訊 { get; set; }

        [JsonProperty]
        public int 配送分組 { get; set; }

        [JsonProperty]
        public String 發票號碼 { get; set; }

        /********************************/
        // 暫時性資訊

        private 平台訂單自定義介面 _自定義介面 = null;
        public 平台訂單自定義介面 自定義介面
        {
            get
            {
                if (_自定義介面 == null)
                    _自定義介面 = 平台訂單自定義工廠.獨體.取得自定義(this.客戶);
                return _自定義介面;
            }
            set 
            {
                _自定義介面 = value;
            }
        }

        public String 分組識別 { get; private set; }

        public 物品合併資料 合併 
        {
            get
            {
                物品合併資料 物品合併資料_ = new 物品合併資料();
                物品合併資料_.新增(商品, 數量);

                return 物品合併資料_;
            }
        }

        /********************************/

        public 平台訂單新增資料 Self
        {
            get { return this; }
        }

        private static readonly 平台訂單新增資料 _NULL = new 平台訂單新增資料
        {
            編號 = 常數.T空白資料編碼,
            處理狀態 = 列舉.訂單處理狀態.新增,
            處理時間 = new DateTime(),

            公司 = 公司資料.NULL,
            客戶 = 客戶資料.NULL,

            商品 = 商品資料.NULL,

            數量 = 0,
            單價 = 0,
            含稅單價 = 0,

            姓名 = 字串.無,
            地址 = 字串.無,
            電話 = 字串.無,
            手機 = 字串.無,

            訂單編號 = 字串.無,
            備註 = 字串.無,

            配送公司 = 列舉.配送公司.無,
            配送單號 = 字串.無,

            指配日期 = default(DateTime),
            指配時段 = 列舉.指配時段.無,

            代收方式 = 列舉.代收方式.無,
            代收金額 = 0,

            額外資訊 = null,

            配送分組 = 0,

            發票號碼 = null,
        };
        public static 平台訂單新增資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 平台訂單新增資料 _ERROR = new 平台訂單新增資料
        {
            編號 = 常數.T錯誤資料編碼,
            處理狀態 = 列舉.訂單處理狀態.錯誤,
            處理時間 = new DateTime(),

            公司 = 公司資料.ERROR,
            客戶 = 客戶資料.ERROR,

            商品 = 商品資料.ERROR,

            數量 = 0,
            單價 = 0,
            含稅單價 = 0,

            姓名 = 字串.錯誤,
            地址 = 字串.錯誤,
            電話 = 字串.錯誤,
            手機 = 字串.錯誤,

            訂單編號 = 字串.錯誤,
            備註 = 字串.錯誤,

            配送公司 = 列舉.配送公司.錯誤,
            配送單號 = 字串.錯誤,

            指配日期 = default(DateTime),
            指配時段 = 列舉.指配時段.錯誤,

            代收方式 = 列舉.代收方式.錯誤,
            代收金額 = 0,

            額外資訊 = null,

            配送分組 = 0,

            發票號碼 = null,
        };
        public static 平台訂單新增資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        public static 平台訂單新增資料 新增(平台訂單匯入資料 Value)
        {
            平台訂單新增資料 Data_ = new 平台訂單新增資料
            {
                處理時間 = Value.處理時間,
                處理狀態 = Value.處理狀態,

                公司 = Value.公司,
                客戶 = Value.客戶,

                訂單編號 = Value.訂單編號,
                商品 = Value.商品,

                數量 = Value.數量,
                單價 = Value.單價,
                含稅單價 = Value.含稅單價,

                姓名 = Value.姓名,
                地址 = Value.地址,
                電話 = Value.電話,
                手機 = Value.手機,

                備註 = Value.備註,

                配送公司 = Value.配送公司,

                指配日期 = Value.指配日期,
                指配時段 = Value.指配時段,

                代收方式 = Value.代收方式,
                代收金額 = Value.代收金額,

                額外資訊 = Value.額外資訊,

                發票號碼 = Value.發票號碼,

                自定義介面 = Value.自定義介面,
            };

            return Data_;
        }

        /********************************/

        public override 平台訂單新增資料 拷貝()
        {
            平台訂單新增資料 Data_ = new 平台訂單新增資料
            {
                處理時間 = this.處理時間,
                處理狀態 = this.處理狀態,

                公司 = this.公司,
                客戶 = this.客戶,

                訂單編號 = this.訂單編號,
                商品 = this.商品,

                數量 = this.數量,
                單價 = this.單價,
                含稅單價 = this.含稅單價,

                姓名 = this.姓名,
                地址 = this.地址,
                電話 = this.電話,
                手機 = this.手機,

                備註 = this.備註,

                配送公司 = this.配送公司,
                配送單號 = this.配送單號,

                指配日期 = this.指配日期,
                指配時段 = this.指配時段,

                代收方式 = this.代收方式,
                代收金額 = this.代收金額,

                額外資訊 = this.額外資訊,

                發票號碼 = this.發票號碼,
            };

            return Data_;
        }

        public override void 覆蓋(平台訂單新增資料 Data_)
        {
            處理時間 = Data_.處理時間;
            處理狀態 = Data_.處理狀態;

            公司 = Data_.公司;
            客戶 = Data_.客戶;

            訂單編號 = Data_.訂單編號;
            商品 = Data_.商品;

            數量 = Data_.數量;
            單價 = Data_.單價;
            含稅單價 = Data_.含稅單價;

            姓名 = Data_.姓名;
            地址 = Data_.地址;
            電話 = Data_.電話;
            手機 = Data_.手機;

            備註 = Data_.備註;

            配送公司 = Data_.配送公司;
            配送單號 = Data_.配送單號;

            指配日期 = Data_.指配日期;
            指配時段 = Data_.指配時段;

            代收方式 = Data_.代收方式;
            代收金額 = Data_.代收金額;

            額外資訊 = Data_.額外資訊;

            發票號碼 = Data_.發票號碼;
        }

        public override Boolean 是否一致(平台訂單新增資料 Data_)
        {
            return
                處理時間 == Data_.處理時間 &&
                處理狀態 == Data_.處理狀態 &&

                公司 == Data_.公司 &&
                客戶 == Data_.客戶 &&

                訂單編號 == Data_.訂單編號 &&
                商品 == Data_.商品 &&

                數量 == Data_.數量 &&
                單價 == Data_.單價 &&
                含稅單價 == Data_.含稅單價 &&

                姓名 == Data_.姓名 &&
                地址 == Data_.地址 &&
                電話 == Data_.電話 &&
                手機 == Data_.手機 &&

                備註 == Data_.備註 &&

                配送公司 == Data_.配送公司 &&
                配送單號 == Data_.配送單號 &&

                指配日期 == Data_.指配日期 &&
                指配時段 == Data_.指配時段 &&

                代收方式 == Data_.代收方式 &&
                代收金額 == Data_.代收金額 &&

                發票號碼 == Data_.發票號碼;
        }

        public override void 檢查合法()
        {
            if (列舉.是否合法((int)處理狀態) == false)
                throw new Exception("平台訂單新增資料:處理狀態不合法:" + 處理狀態);

            if (公司.編號是否合法() == false)
                throw new Exception("平台訂單新增資料:公司編號不合法:" + 公司編號);

            if (客戶.編號是否合法() == false)
                throw new Exception("平台訂單新增資料:客戶編號不合法:" + 客戶編號);

            if (商品.編號是否合法() == false)
                throw new Exception("平台訂單新增資料:商品不合法:" + 商品編號);

            if (商品.編號 != 常數.商品折扣資料編碼)
            {
                if (商品.公司 != 公司)
                    throw new Exception("平台訂單新增資料:公司不一致:" + 商品.公司.名稱 + "," + 公司.名稱);

                if (商品.客戶 != 客戶)
                    throw new Exception("平台訂單新增資料:客戶不一致:" + 商品.客戶.名稱 + "," + 客戶.名稱);
            }

            if (String.IsNullOrEmpty(姓名))
                throw new Exception("平台訂單新增資料:姓名不合法:" + this.ToString());

            if (String.IsNullOrEmpty(地址))
                throw new Exception("平台訂單新增資料:地址不合法:" + this.ToString());

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                throw new Exception("平台訂單新增資料:電話與手機不合法:" + this.ToString());

            if (String.IsNullOrEmpty(訂單編號))
                throw new Exception("平台訂單新增資料:訂單編號不合法:" + this.ToString());
        }

        public void 重新分組()
        {
            配送分組 = 0;
            分組識別 = 自定義介面.取得分組識別(this);
        }
    }
}

