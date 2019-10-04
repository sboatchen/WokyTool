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
    public class 進貨新增匯入資料 : 靜態匯入資料
    {
        [JsonProperty]
        public string 類型識別 { get; set; }

        public 列舉.進貨 類型 { get; set; }

        [JsonProperty]
        public string 廠商識別 { get; set; }

        public 廠商資料 廠商 { get; set; }

        [JsonProperty]
        public string 物品識別 { get; set; }

        public 物品資料 物品 { get; set; }

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
        public string 幣值識別 { get; set; }

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
        public string 備註 { get; set; }

        /********************************/

        public override void 初始化() 
        {
            廠商 = 廠商資料管理器.獨體.取得(廠商識別);
            物品 = 物品資料管理器.獨體.取得(物品識別);
            幣值 = 幣值資料管理器.獨體.Get(幣值識別);

            類型 = 列舉.進貨.錯誤;
            try
            {
                類型 = (列舉.進貨)Enum.Parse(typeof(列舉.進貨), 類型識別);
            }
            catch 
            {
                訊息管理器.獨體.追蹤("找不到進貨類型: " + 類型識別);
            }

            switch (類型)
            {
                case 列舉.進貨.退貨重進:
                    單價 = 物品.成本;
                    break;
                default:
                    break;
            }
        }

        public override void 檢查合法()
        {
            if (廠商.編號是否合法() == false)
                throw new Exception("進貨新增匯入資料:廠商不合法:" + 廠商識別);

            if (物品.編號是否合法() == false)
                throw new Exception("進貨新增匯入資料:物品不合法:" + 物品識別);

            if (幣值.編號是否合法() == false)
                throw new Exception("進貨新增匯入資料:幣值不合法:" + 幣值識別);

            if (列舉.是否合法((int)類型) == false)
                throw new Exception("進貨新增匯入資料:類型不合法:" + 類型);

            if (數量 <= 0)
                throw new Exception("進貨新增匯入資料:數量不合法:" + 數量);
        }
    }
}
