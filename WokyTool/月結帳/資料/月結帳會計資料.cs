using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳會計資料 : MyKeepableData<月結帳會計資料>
    {
        [JsonProperty]
        public override int 編號 { get; set; }

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

        public String 名稱
        {
            get
            {
                return 設定.名稱;
            }
        }

        [JsonProperty]
        public decimal 營業額 { get; set; }

        [JsonProperty]
        public decimal 佣金 { get; set; }

        [JsonProperty]
        public decimal 作帳應收 { get; set; }

        [JsonProperty]
        public decimal 實收 { get; set; }

        [JsonProperty]
        public String 應收款日期 { get; set; }

        [JsonProperty]
        public decimal 本期欠收 { get; set; }

        [JsonProperty]
        public decimal 前期欠收 { get; set; }

        [JsonProperty]
        public decimal 前期實收 { get; set; }

        public decimal 利潤
        {
            get
            {
                return 作帳應收 - 進貨成本 - 營業額 * 0.07m - 佣金;
            }
        }

        [JsonProperty]
        public decimal 進貨成本 { get; set; }

        public decimal 毛利率 
        {
            get
            {
                if (營業額 == 0)
                    return 0m;
                return 利潤  * 100 / 營業額 ;
            }
        }

        private IEnumerable<月結帳資料> _資料列;
        public IEnumerable<月結帳資料> 資料列
        {
            get
            {
                return _資料列;
            }
            set
            {
                _資料列 = value;

                if (_資料列 == null)
                {
                    營業額 = 0;
                    進貨成本 = 0;
                }
                else
                {
                    營業額 = _資料列.Sum(Value => Value.總金額);
                    進貨成本 = _資料列.Sum(Value => Value.總成本);
                }
            }
        }

        /********************************/

        public 月結帳會計資料 Self
        {
            get { return this; }
        }

        private static readonly 月結帳會計資料 _NULL = new 月結帳會計資料
        {
            編號 = 常數.空白資料編碼,

            設定 = 月結帳匯入設定資料.NULL,

            營業額 = 0,
            佣金 = 0,
            作帳應收 = 0,
            實收 = 0,

            應收款日期 = 字串.空,

            本期欠收 = 0,
            前期欠收 = 0,
            前期實收 = 0,

            進貨成本 = 0,

            資料列 = null,
        };
        public static 月結帳會計資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 月結帳會計資料 _ERROR = new 月結帳會計資料
        {
            編號 = 常數.錯誤資料編碼,

            設定 = 月結帳匯入設定資料.ERROR,

            營業額 = 0,
            佣金 = 0,
            作帳應收 = 0,
            實收 = 0,

            應收款日期 = 字串.空,

            本期欠收 = 0,
            前期欠收 = 0,
            前期實收 = 0,

            進貨成本 = 0,

            資料列 = null,
        };
        public static 月結帳會計資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override 月結帳會計資料 拷貝()
        {
            月結帳會計資料 Data_ = new 月結帳會計資料
            {
                編號 = this.編號,

                設定 = this.設定,

                營業額 = this.營業額,
                佣金 = this.佣金,
                作帳應收 = this.作帳應收,
                實收 = this.實收,

                應收款日期 = this.應收款日期,

                本期欠收 = this.本期欠收,
                前期欠收 = this.前期欠收,
                前期實收 = this.前期實收,

                進貨成本 = this.進貨成本,

                資料列 = this.資料列,
            };

            return Data_;
        }

        public override void 覆蓋(月結帳會計資料 Data_)
        {
            編號 = Data_.編號;

            設定 = Data_.設定;

            營業額 = Data_.營業額;
            佣金 = Data_.佣金;
            作帳應收 = Data_.作帳應收;
            實收 = Data_.實收;

            應收款日期 = Data_.應收款日期;

            本期欠收 = Data_.本期欠收;
            前期欠收 = Data_.前期欠收;
            前期實收 = Data_.前期實收;

            進貨成本 = Data_.進貨成本;

            資料列 = Data_.資料列;
        }

        public override bool 是否一致(月結帳會計資料 Data_)
        {
            return
                編號 == Data_.編號 &&

                設定 == Data_.設定 &&

                營業額 == Data_.營業額 &&
                佣金 == Data_.佣金 &&
                作帳應收 == Data_.作帳應收 &&
                實收 == Data_.實收 &&

                應收款日期 == Data_.應收款日期 &&

                本期欠收 == Data_.本期欠收 &&
                前期欠收 == Data_.前期欠收 &&
                前期實收 == Data_.前期實收 &&

                進貨成本 == Data_.進貨成本 &&

                資料列 == Data_.資料列;
        }

        public override void 檢查合法()
        {
            if (設定.編號是否合法() == false)
                throw new Exception("月結帳會計資料:設定編號不合法:" + 設定編號);
        }
    }
}
