using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.物品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 物品新增匯入資料 : 靜態匯入資料
    {
        [JsonProperty]
        public string 大類識別 { get; set; }

        protected 物品大類資料 _大類;
        public 物品大類資料 大類
        {
            get
            {
                if (_大類 == null)
                    _大類 = 物品大類資料.NULL;
                else if (物品大類資料管理器.獨體.唯讀BList.Contains(_大類) == false)
                    _大類 = 物品大類資料.ERROR;

                return _大類;
            }
            set
            {
                _大類 = value;
            }
        }

        [JsonProperty]
        public string 小類識別 { get; set; }

        protected 物品小類資料 _小類;
        public 物品小類資料 小類
        {
            get
            {
                if (_小類 == null)
                    _小類 = 物品小類資料.NULL;
                else if (物品小類資料管理器.獨體.唯讀BList.Contains(_小類) == false)
                    _小類 = 物品小類資料.ERROR;

                return _小類;
            }
            set
            {
                _小類 = value;
            }
        }

        [JsonProperty]
        public string 品牌識別 { get; set; }

        protected 物品品牌資料 _品牌;
        public 物品品牌資料 品牌
        {
            get
            {
                if (_品牌 == null)
                    _品牌 = 物品品牌資料.NULL;
                else if (物品品牌資料管理器.獨體.唯讀BList.Contains(_品牌) == false)
                    _品牌 = 物品品牌資料.ERROR;

                return _品牌;
            }
            set
            {
                _品牌 = value;
            }
        }

        [JsonProperty]
        public string 條碼 { get; set; }
        [JsonProperty]
        public string 原廠編號 { get; set; }
        [JsonProperty]
        public string 代理編號 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }
        [JsonProperty]
        public string 縮寫 { get; set; }

        [JsonProperty]
        public int 體積 { get; set; }
        [JsonProperty]
        public string 顏色 { get; set; }

        [JsonProperty]
        public int 內庫數量 { get; set; }
        [JsonProperty]
        public int 外庫數量 { get; set; }

        public int 庫存總量 { get { return 內庫數量 + 外庫數量; } }

        [JsonProperty]
        public decimal 庫存總成本 { get; set; }
        [JsonProperty]
        public decimal 最後進貨成本 { get; set; }
        [JsonProperty]
        public string 成本備註 { get; set; }

        public decimal 成本
        {
            get
            {
                if (庫存總量 == 0)
                    return 最後進貨成本;
                else
                    return 庫存總成本 / 庫存總量;
            }
        }

        /********************************/

        public override void 初始化()
        {
            大類 = 物品大類資料管理器.獨體.Get(大類識別);
            小類 = 物品小類資料管理器.獨體.Get(小類識別);
            品牌 = 物品品牌資料管理器.獨體.Get(品牌識別);
        }

        public override void 檢查合法()
        {
            if (大類.編號是否合法() == false)
                throw new Exception("大類編號不合法");

            if (小類.編號是否合法() == false)
                throw new Exception("小類編號不合法");

            if (品牌.編號是否合法() == false)
                throw new Exception("品牌編號不合法");

            if (String.IsNullOrEmpty(名稱))
                throw new Exception("名稱不合法");

            if (String.IsNullOrEmpty(縮寫))
                throw new Exception("縮寫不合法");
        }
    }
}
