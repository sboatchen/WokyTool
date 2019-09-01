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

namespace WokyTool.一般訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 一般訂單資料 : 可記錄資料<一般訂單資料>
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
                _公司 = 公司資料管理器.獨體.取得(value);
            }
        }

        protected 公司資料 _公司;
        public 公司資料 公司
        {
            get
            {
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
                _客戶 = 客戶資料管理器.獨體.取得(value);
            }
        }

        protected 客戶資料 _客戶;
        public 客戶資料 客戶
        {
            get
            {
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
                _子客戶 = 子客戶資料管理器.獨體.取得(value);
            }
        }

        protected 子客戶資料 _子客戶;
        public 子客戶資料 子客戶
        {
            get
            {
                return _子客戶;
            }
            set
            {
                _子客戶 = value;
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

        /********************************/
        // 暫時性資訊

        private String _分組識別 = null;
        public String 分組識別
        {
            get
            {
                if (_分組識別 == null)
                {
                    _分組識別 = String.Format("{0}_{1}_{2}_{3}", 公司.名稱, 客戶.名稱, 子客戶.名稱, 姓名);
                }

                return _分組識別;
            }
        }

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

        public 一般訂單資料 Self
        {
            get { return this; }
        }

        private static readonly 一般訂單資料 _NULL = new 一般訂單資料
        {
            編號 = 常數.空白資料編碼,
            處理狀態 = 列舉.訂單處理狀態.完成,
            處理時間 = new DateTime(),

            公司 = 公司資料.空白,
            客戶 = 客戶資料.空白,
            子客戶 = 子客戶資料.空白,

            商品 = 商品資料.空白,

            數量 = 0,
            單價 = 0,

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
        };
        public static 一般訂單資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 一般訂單資料 _ERROR = new 一般訂單資料
        {
            編號 = 常數.錯誤資料編碼,
            處理狀態 = 列舉.訂單處理狀態.錯誤,
            處理時間 = new DateTime(),

            公司 = 公司資料.錯誤,
            客戶 = 客戶資料.錯誤,
            子客戶 = 子客戶資料.錯誤,

            商品 = 商品資料.錯誤,

            數量 = 0,
            單價 = 0,

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
        };
        public static 一般訂單資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        public static IEnumerable<一般訂單資料> 新增(一般訂單新增資料 Value)
        {
            foreach (var 一般訂單新增商品資料_ in Value.清單)
            {
                一般訂單資料 Data_ = new 一般訂單資料
                {
                    處理時間 = Value.處理時間,

                    公司 = Value.公司,
                    客戶 = Value.客戶,
                    子客戶 = Value.子客戶,

                    商品 = 一般訂單新增商品資料_.商品,

                    數量 = 一般訂單新增商品資料_.數量,
                    單價 = 一般訂單新增商品資料_.單價,

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

                    發票號碼 = Value.發票號碼,
                };

                Data_.處理狀態 = Value.處理狀態 == 列舉.訂單處理狀態.退貨 ? 列舉.訂單處理狀態.退貨 : 列舉.訂單處理狀態.完成;

                yield return Data_;

            }
        }

        /********************************/

        public override 一般訂單資料 拷貝()
        {
            一般訂單資料 Data_ = new 一般訂單資料
            {
                處理時間 = this.處理時間,
                處理狀態 = this.處理狀態,

                公司 = this.公司,
                客戶 = this.客戶,
                子客戶 = this.子客戶,

                商品 = this.商品,

                數量 = this.數量,
                單價 = this.單價,

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
            };

            return Data_;
        }

        public override void 覆蓋(一般訂單資料 Data_)
        {
            處理時間 = Data_.處理時間;
            處理狀態 = Data_.處理狀態;

            公司 = Data_.公司;
            客戶 = Data_.客戶;
            子客戶 = Data_.子客戶;

            商品 = Data_.商品;

            數量 = Data_.數量;
            單價 = Data_.單價;

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
        }

        public override bool 是否一致(一般訂單資料 Data_)
        {
            return
                處理時間 == Data_.處理時間 &&
                處理狀態 == Data_.處理狀態 &&

                公司 == Data_.公司 &&
                客戶 == Data_.客戶 &&
                子客戶 == Data_.子客戶 &&

                商品 == Data_.商品 &&

                數量 == Data_.數量 &&
                單價 == Data_.單價 &&

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
                throw new Exception("一般訂單資料:處理狀態不合法:" + 處理狀態);

            if (公司.編號是否合法() == false)
                throw new Exception("一般訂單資料:公司編號不合法:" + 公司編號);

            if (客戶.編號是否合法() == false)
                throw new Exception("一般訂單資料:客戶編號不合法:" + 客戶編號);

            if (子客戶.編號是否合法() == false)
                throw new Exception("一般訂單資料:子客戶編號不合法:" + 子客戶編號);

            if (商品.編號是否合法() == false)
                throw new Exception("一般訂單資料:商品不合法:" + 商品編號);

            if (String.IsNullOrEmpty(姓名))
                throw new Exception("一般訂單資料:姓名不合法:" + this.ToString());

            if (String.IsNullOrEmpty(地址))
                throw new Exception("一般訂單資料:地址不合法:" + this.ToString());

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                throw new Exception("一般訂單資料:電話與手機不合法:" + this.ToString());
        }
    }
}

