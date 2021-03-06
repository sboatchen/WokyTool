﻿using Newtonsoft.Json;
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

namespace WokyTool.月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳舊資料 : 可記錄資料<月結帳舊資料>
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        public string 訂單編號 { get; set; }

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

        public decimal 成本
        {
            get
            {
                return 商品.成本;
            }
        }

        public decimal 總成本
        {
            get { return 數量 * 成本; }
        }


        public decimal 利潤
        {
            get
            {
                return 含稅單價 - 成本;
            }
        }

        public decimal 總利潤
        {
            get
            {
                return 利潤 * 數量;
            }
        }

        /********************************/

        public 月結帳舊資料 Self
        {
            get { return this; }
        }

        private static readonly 月結帳舊資料 _NULL = new 月結帳舊資料
        {
            編號 = 常數.空白資料編碼,

            公司 = 公司資料.空白,
            客戶 = 客戶資料.空白,

            商品 = 商品資料.空白,

            數量 = 0,
            單價 = 0,
            含稅單價 = 0,
        };
        public static 月結帳舊資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 月結帳舊資料 _ERROR = new 月結帳舊資料
        {
            編號 = 常數.錯誤資料編碼,

            公司 = 公司資料.錯誤,
            客戶 = 客戶資料.錯誤,

            商品 = 商品資料.錯誤,

            數量 = 0,
            單價 = 0,
            含稅單價 = 0,
        };
        public static 月結帳舊資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override 月結帳舊資料 拷貝()
        {
            月結帳舊資料 Data_ = new 月結帳舊資料
            {
                編號 = this.編號,

                公司 = this.公司,
                客戶 = this.客戶,

                商品 = this.商品,

                數量 = this.數量,
                單價 = this.單價,
                含稅單價 = this.含稅單價,
            };

            return Data_;
        }

        public override void 覆蓋(月結帳舊資料 Data_)
        {
            編號 = Data_.編號;

            公司 = Data_.公司;
            客戶 = Data_.客戶;

            商品 = Data_.商品;

            數量 = Data_.數量;
            單價 = Data_.單價;
            含稅單價 = Data_.含稅單價;
        }

        public override bool 是否一致(月結帳舊資料 Data_)
        {
            return
                編號 == Data_.編號 &&

                公司 == Data_.公司 &&
                客戶 == Data_.客戶 &&

                商品 == Data_.商品 &&

                數量 == Data_.數量 &&
                單價 == Data_.單價 &&
                含稅單價 == Data_.含稅單價;
        }

        public override void 檢查合法()
        {
            if (公司.編號是否合法() == false)
                throw new Exception("月結帳舊資料:公司編號不合法:" + 公司編號);

            if (客戶.編號是否合法() == false)
                throw new Exception("月結帳舊資料:客戶編號不合法:" + 客戶編號);

            if (商品.編號是否合法() == false)
                throw new Exception("月結帳舊資料:商品不合法:" + 商品編號);

            if (商品.公司 != 公司)
                throw new Exception("月結帳舊資料:公司不一致:" + 商品.公司.名稱 + "," + 公司.名稱);

            if (商品.客戶 != 客戶)
                throw new Exception("月結帳舊資料:客戶不一致:" + 商品.客戶.名稱 + "," + 客戶.名稱);
        }
    }
}