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
    public class 商品新增匯入資料 : 靜態匯入資料
    {
        [JsonProperty]
        public string 大類識別 { get; set; }

        protected 商品大類資料 _大類;
        public 商品大類資料 大類
        {
            get
            {
                if (_大類 == null)
                    _大類 = 商品大類資料.NULL;
                else if (商品大類資料管理器.獨體.唯讀BList.Contains(_大類) == false)
                    _大類 = 商品大類資料.ERROR;

                return _大類;
            }
            set
            {
                _大類 = value;
            }
        }

        [JsonProperty]
        public string 小類識別 { get; set; }

        protected 商品小類資料 _小類;
        public 商品小類資料 小類
        {
            get
            {
                if (_小類 == null)
                    _小類 = 商品小類資料.NULL;
                else if (商品小類資料管理器.獨體.唯讀BList.Contains(_小類) == false)
                    _小類 = 商品小類資料.ERROR;

                return _小類;
            }
            set
            {
                _小類 = value;
            }
        }

        [JsonProperty]
        public string 公司識別 { get; set; }

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
        public string 客戶識別 { get; set; }

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
        public string 品號 { get; set; }   // 對方使用的產品編號
        [JsonProperty]
        public string 名稱 { get; set; }    // 對方使用的產品名稱

        [JsonProperty]
        public string 需求識別1 { get; set; }

        protected 物品資料 _需求1;
        public 物品資料 需求1
        {
            get
            {
                if (_需求1 == null)
                    _需求1 = 物品資料.NULL;
                else if (物品資料管理器.獨體.唯讀BList.Contains(_需求1) == false)
                    _需求1 = 物品資料.ERROR;

                return _需求1;
            }
            set
            {
                _需求1 = value;
            }
        }

        [JsonProperty]
        public string 需求識別2 { get; set; }

        protected 物品資料 _需求2;
        public 物品資料 需求2
        {
            get
            {
                if (_需求2 == null)
                    _需求2 = 物品資料.NULL;
                else if (物品資料管理器.獨體.唯讀BList.Contains(_需求2) == false)
                    _需求2 = 物品資料.ERROR;

                return _需求2;
            }
            set
            {
                _需求2 = value;
            }
        }

        [JsonProperty]
        public string 需求識別3 { get; set; }

        protected 物品資料 _需求3;
        public 物品資料 需求3
        {
            get
            {
                if (_需求3 == null)
                    _需求3 = 物品資料.NULL;
                else if (物品資料管理器.獨體.唯讀BList.Contains(_需求3) == false)
                    _需求3 = 物品資料.ERROR;

                return _需求3;
            }
            set
            {
                _需求3 = value;
            }
        }

        [JsonProperty]
        public string 需求識別4 { get; set; }

        protected 物品資料 _需求4;
        public 物品資料 需求4
        {
            get
            {
                if (_需求4 == null)
                    _需求4 = 物品資料.NULL;
                else if (物品資料管理器.獨體.唯讀BList.Contains(_需求4) == false)
                    _需求4 = 物品資料.ERROR;

                return _需求4;
            }
            set
            {
                _需求4 = value;
            }
        }

        [JsonProperty]
        public string 需求識別5 { get; set; }

        protected 物品資料 _需求5;
        public 物品資料 需求5
        {
            get
            {
                if (_需求5 == null)
                    _需求5 = 物品資料.NULL;
                else if (物品資料管理器.獨體.唯讀BList.Contains(_需求5) == false)
                    _需求5 = 物品資料.ERROR;

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

        public decimal 成本
        {
            get
            {
                return 需求1.成本 * 數量1 + 需求2.成本 * 數量2 + 需求3.成本 * 數量3 + 需求4.成本 * 數量4 + 需求5.成本 * 數量5;
            }
        }

        public int 體積
        {
            get
            {
                return 需求1.體積 * 數量1 + 需求2.體積 * 數量2 + 需求3.體積 * 數量3 + 需求4.體積 * 數量4 + 需求5.體積 * 數量5;
            }
        }

        public decimal 利潤
        {
            get
            {
                return 售價 - 成本;
            }
        }

        /********************************/

        public override void 初始化() 
        {
            大類 = 商品大類資料管理器.獨體.Get(大類識別);
            小類 = 商品小類資料管理器.獨體.Get(小類識別);
            
            公司 = 公司資料管理器.獨體.Get(公司識別);
            客戶 = 客戶資料管理器.獨體.Get(客戶識別);

            需求1 = 物品資料管理器.獨體.GetByLike(需求識別1);
            需求2 = 物品資料管理器.獨體.GetByLike(需求識別2);
            需求3 = 物品資料管理器.獨體.GetByLike(需求識別3);
            需求4 = 物品資料管理器.獨體.GetByLike(需求識別4);
            需求5 = 物品資料管理器.獨體.GetByLike(需求識別5);
        }

        public override void 檢查合法()
        {
            if (大類.編號是否合法() == false)
                throw new Exception("大類編號不合法");

            if (小類.編號是否合法() == false)
                throw new Exception("小類編號不合法");

            if (公司.編號是否合法() == false)
                throw new Exception("公司編號不合法");

            if (客戶.編號是否合法() == false)
                throw new Exception("客戶編號不合法");

            if (需求1.編號是否合法() == false)
                throw new Exception("需求編號1不合法");

            if (需求2.編號是否合法() == false)
                throw new Exception("需求編號2不合法");

            if (需求3.編號是否合法() == false)
                throw new Exception("需求編號3不合法");

            if (需求4.編號是否合法() == false)
                throw new Exception("需求編號4不合法");

            if (需求5.編號是否合法() == false)
                throw new Exception("需求編號5不合法");

            //if (String.IsNullOrEmpty(品號))
            //    throw new Exception("品號不合法");

            if (String.IsNullOrEmpty(名稱))
                throw new Exception("名稱不合法");

            if (數量1 < 0 || 數量2 < 0 || 數量3 < 0 || 數量4 < 0 || 數量5 < 0)
                throw new Exception("數量不合法");
        }
    }
}
