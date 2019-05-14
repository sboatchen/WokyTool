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
    public class 一般訂單新增資料 : MyKeepableData<一般訂單新增資料>, 可配送介面
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
        public int 子客戶編號
        {
            get
            {
                return 子客戶.編號;
            }
            set
            {
                _子客戶 = 子客戶資料管理器.獨體.Get(value);
            }
        }

        protected 子客戶資料 _子客戶;
        public 子客戶資料 子客戶
        {
            get
            {
                if (_子客戶 == null)
                    _子客戶 = 子客戶資料.NULL;
                else if (子客戶資料管理器.獨體.唯讀BList.Contains(_子客戶) == false)
                    _子客戶 = 子客戶資料.ERROR;

                return _子客戶;
            }
            set
            {
                _子客戶 = value;
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
        public String 發票號碼 { get; set; }

        [JsonProperty]
        public Boolean 列印單價 { get; set; }

        [JsonProperty]
        public List<一般訂單新增物品資料> 清單 { get; set; }

        /********************************/
        // 暫時性資訊

        public 物品合併資料 合併
        {
            get
            {
                物品合併資料 物品合併資料_ = new 物品合併資料();

                if (清單 != null)
                {
                    foreach (一般訂單新增物品資料 新增物品 in 清單)
                        物品合併資料_.新增(新增物品.物品, 新增物品.數量);
                }

                return 物品合併資料_;
            }
        }

        /********************************/

        public 一般訂單新增資料 Self
        {
            get { return this; }
        }

        private static readonly 一般訂單新增資料 _NULL = new 一般訂單新增資料
        {
            編號 = 常數.T空白資料編碼,
            處理狀態 = 列舉.訂單處理狀態.完成,

            公司 = 公司資料.NULL,
            客戶 = 客戶資料.NULL,

            姓名 = 字串.無,
            地址 = 字串.無,
            電話 = 字串.無,
            手機 = 字串.無,

            備註 = 字串.無,

            配送公司 = 列舉.配送公司.無,
            配送單號 = 字串.無,

            指配日期 = default(DateTime),
            指配時段 = 列舉.指配時段.無,

            代收方式 = 列舉.代收方式.無,
            代收金額 = 0,

            發票號碼 = null,

            列印單價 = true,
        };
        public static 一般訂單新增資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 一般訂單新增資料 _ERROR = new 一般訂單新增資料
        {
            編號 = 常數.T錯誤資料編碼,
            處理狀態 = 列舉.訂單處理狀態.錯誤,

            公司 = 公司資料.ERROR,
            客戶 = 客戶資料.ERROR,

            姓名 = 字串.錯誤,
            地址 = 字串.錯誤,
            電話 = 字串.錯誤,
            手機 = 字串.錯誤,

            備註 = 字串.錯誤,

            配送公司 = 列舉.配送公司.錯誤,
            配送單號 = 字串.錯誤,

            指配日期 = default(DateTime),
            指配時段 = 列舉.指配時段.錯誤,

            代收方式 = 列舉.代收方式.錯誤,
            代收金額 = 0,

            發票號碼 = null,

            列印單價 = true,
        };
        public static 一般訂單新增資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override 一般訂單新增資料 拷貝()
        {
            一般訂單新增資料 Data_ = new 一般訂單新增資料
            {
                處理狀態 = this.處理狀態,

                公司 = this.公司,
                客戶 = this.客戶,

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

                發票號碼 = this.發票號碼,

                列印單價 = this.列印單價,

                清單 = this.清單,
            };

            return Data_;
        }

        public override void 覆蓋(一般訂單新增資料 Data_)
        {
            處理狀態 = Data_.處理狀態;

            公司 = Data_.公司;
            客戶 = Data_.客戶;

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

            發票號碼 = Data_.發票號碼;

            列印單價 = Data_.列印單價;

            清單 = Data_.清單;
        }

        public override Boolean 是否一致(一般訂單新增資料 Data_)
        {
            return
                處理狀態 == Data_.處理狀態 &&

                公司 == Data_.公司 &&
                客戶 == Data_.客戶 &&

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

                代收金額 == Data_.代收金額 &&

                發票號碼 == Data_.發票號碼 &&

                列印單價 == Data_.列印單價 &&

                清單 == Data_.清單;
        }

        public override void 檢查合法()
        {
            if (列舉.是否合法((int)處理狀態) == false)
                throw new Exception("一般訂單新增資料:處理狀態不合法:" + 處理狀態);

            if (公司.編號是否合法() == false)
                throw new Exception("一般訂單新增資料:公司編號不合法:" + 公司編號);

            if (客戶.編號是否合法() == false)
                throw new Exception("一般訂單新增資料:客戶編號不合法:" + 客戶編號);

            if (String.IsNullOrEmpty(姓名))
                throw new Exception("一般訂單新增資料:姓名不合法:" + this.ToString());

            if (String.IsNullOrEmpty(地址))
                throw new Exception("一般訂單新增資料:地址不合法:" + this.ToString());

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                throw new Exception("一般訂單新增資料:電話與手機不合法:" + this.ToString());
        }
    }
}