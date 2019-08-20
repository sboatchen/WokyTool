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
        public string 組成識別 { get; set; }

        public List<商品組成匯入資料> 組成 { get; set; }

        [JsonProperty]
        public decimal 進價 { get; set; }
        [JsonProperty]
        public decimal 售價 { get; set; }

        [JsonProperty]
        public int 寄庫數量 { get; set; }

        public decimal 成本
        {
            get
            {
                if (組成 == null)
                    return 0;
                return 組成.Sum(Value => Value.成本);
            }
        }

        public int 體積
        {
            get
            {
                if (組成 == null)
                    return 0;
                return 組成.Sum(Value => Value.體積);
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

            公司 = 公司資料管理器.獨體.取得(公司識別);
            客戶 = 客戶資料管理器.獨體.取得(客戶識別);

            if (String.IsNullOrEmpty(組成識別))
                return;

            組成 = 組成識別.Split(',', '+').Select(Value => new 商品組成匯入資料(Value)).ToList();
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

            if (String.IsNullOrEmpty(名稱))
                throw new Exception("名稱不合法");

            if (組成 != null)
            {
                foreach (商品組成匯入資料 Item_ in 組成)
                    Item_.檢查合法();
            }
        }
    }
}
