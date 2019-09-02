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

namespace WokyTool.商品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 舊商品資料
    {
        [JsonProperty]
        public int 編號 { get; set; }

        [JsonProperty]
        public int 大類編號
        {
            get
            {
                return 大類.編號;
            }
            set
            {
                _大類 = 商品大類資料管理器.獨體.取得(value);
            }
        }

        protected 商品大類資料 _大類;
        public 商品大類資料 大類
        {
            get
            {
                return _大類;
            }
            set
            {
                _大類 = value;
            }
        }

        [JsonProperty]
        public int 小類編號
        {
            get
            {
                return 小類.編號;
            }
            set
            {
                _小類 = 商品小類資料管理器.獨體.取得(value);
            }
        }

        protected 商品小類資料 _小類;
        public 商品小類資料 小類
        {
            get
            {
                return _小類;
            }
            set
            {
                _小類 = value;
            }
        }

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
        public string 品號 { get; set; }   // 對方使用的產品編號
        [JsonProperty]
        public string 名稱 { get; set; }    // 對方使用的產品名稱

        [JsonProperty]
        public int 需求編號1
        {
            get
            {
                return _需求1.編號;
            }
            set
            {
                _需求1 = 物品資料管理器.獨體.取得(value);
            }
        }

        protected 物品資料 _需求1;
        public 物品資料 需求1
        {
            get
            {
                return _需求1;
            }
            set
            {
                _需求1 = value;
            }
        }

        [JsonProperty]
        public int 需求編號2
        {
            get
            {
                return _需求2.編號;
            }
            set
            {
                _需求2 = 物品資料管理器.獨體.取得(value);
            }
        }

        protected 物品資料 _需求2;
        public 物品資料 需求2
        {
            get
            {
                return _需求2;
            }
            set
            {
                _需求2 = value;
            }
        }

        [JsonProperty]
        public int 需求編號3
        {
            get
            {
                return _需求3.編號;
            }
            set
            {
                _需求3 = 物品資料管理器.獨體.取得(value);
            }
        }

        protected 物品資料 _需求3;
        public 物品資料 需求3
        {
            get
            {
                return _需求3;
            }
            set
            {
                _需求3 = value;
            }
        }

        [JsonProperty]
        public int 需求編號4
        {
            get
            {
                return _需求4.編號;
            }
            set
            {
                _需求4 = 物品資料管理器.獨體.取得(value);
            }
        }

        protected 物品資料 _需求4;
        public 物品資料 需求4
        {
            get
            {
                return _需求4;
            }
            set
            {
                _需求4 = value;
            }
        }

        [JsonProperty]
        public int 需求編號5
        {
            get
            {
                return _需求5.編號;
            }
            set
            {
                _需求5 = 物品資料管理器.獨體.取得(value);
            }
        }

        protected 物品資料 _需求5;
        public 物品資料 需求5
        {
            get
            {
                return _需求5;
            }
            set
            {
                _需求5 = value;
            }
        }

        [JsonProperty]
        public int 數量1 { get; set; }
        [JsonProperty]
        public int 數量2 { get; set; }
        [JsonProperty]
        public int 數量3 { get; set; }
        [JsonProperty]
        public int 數量4 { get; set; }
        [JsonProperty]
        public int 數量5 { get; set; }

        [JsonProperty]
        public decimal 售價 { get; set; }

        [JsonProperty]
        public int 寄庫數量 { get; set; }
    }
}
