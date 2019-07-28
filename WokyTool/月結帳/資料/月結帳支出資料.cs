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
using WokyTool.廠商;

namespace WokyTool.月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳支出資料 : 可記錄資料<月結帳支出資料>
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        [JsonProperty]
        public string 傳票號碼 { get; set; }

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
        public decimal 費用 { get; set; }

        /********************************/

        public 月結帳支出資料 Self
        {
            get { return this; }
        }

        private static readonly 月結帳支出資料 _NULL = new 月結帳支出資料
        {
            編號 = 常數.空白資料編碼,

            廠商 = 廠商資料.NULL,

            費用 = 0,
        };
        public static 月結帳支出資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 月結帳支出資料 _ERROR = new 月結帳支出資料
        {
            編號 = 常數.錯誤資料編碼,

            廠商 = 廠商資料.ERROR,

            費用 = 0,
        };
        public static 月結帳支出資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override 月結帳支出資料 拷貝()
        {
            月結帳支出資料 Data_ = new 月結帳支出資料
            {
                編號 = this.編號,

                廠商 = this.廠商,

                費用 = this.費用,
            };

            return Data_;
        }

        public override void 覆蓋(月結帳支出資料 Data_)
        {
            編號 = Data_.編號;

            廠商 = Data_.廠商;

            費用 = Data_.費用;
        }

        public override bool 是否一致(月結帳支出資料 Data_)
        {
            return
                編號 == Data_.編號 &&

                廠商 == Data_.廠商 &&

                費用 == Data_.費用;
        }

        public override void 檢查合法()
        {
            if (廠商.編號是否合法() == false)
                throw new Exception("月結帳支出資料:廠商不合法:" + 廠商編號);
        }
    }
}

