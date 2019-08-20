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
    public class 平台訂單匯入資料 : 可匯入資料
    {
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
        public string 商品識別 { get; set; }

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
        public String 分組識別 { get; set; }

        [JsonProperty]
        public String 發票號碼 { get; set; }

        public 平台訂單自定義介面 自定義介面 { get; set; }

        [JsonProperty]
        public string[] 標頭 { get; set; }

        [JsonProperty]
        public string[] 內容 { get; set; }

        /********************************/

        public 平台訂單匯入資料 Self
        {
            get { return this; }
        }

        /********************************/

        public override void 檢查合法()
        {
            if (公司.編號是否合法() == false)
                throw new Exception("平台訂單匯入資料:公司編號不合法:" + 公司編號);

            if (客戶.編號是否合法() == false)
                throw new Exception("平台訂單匯入資料:客戶編號不合法:" + 客戶編號);

            if (商品.編號是否合法() == false)
                throw new Exception("平台訂單匯入資料:商品不合法:" + 商品編號);

            /*if (商品.編號 != 常數.商品折扣資料編碼)
            {
                if (商品.公司 != 公司)
                    throw new Exception("平台訂單匯入資料:公司不一致:" + 商品.公司.名稱 + "," + 公司.名稱);

                if (商品.客戶 != 客戶)
                    throw new Exception("平台訂單匯入資料:客戶不一致:" + 商品.客戶.名稱 + "," + 客戶.名稱);
            }*/

            if (String.IsNullOrEmpty(姓名))
                throw new Exception("平台訂單匯入資料:姓名不合法:" + this.ToString());

            if (String.IsNullOrEmpty(地址))
                throw new Exception("平台訂單匯入資料:地址不合法:" + this.ToString());

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                throw new Exception("平台訂單匯入資料:電話與手機不合法:" + this.ToString());

            if (String.IsNullOrEmpty(訂單編號))
                throw new Exception("平台訂單匯入資料:訂單編號不合法:" + this.ToString());
        }
    }
}

