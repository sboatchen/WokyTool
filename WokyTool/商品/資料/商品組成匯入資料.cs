using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.商品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 商品組成匯入資料
    { 
        [JsonProperty]
        public int 物品編號
        {
            get
            {
                return 物品.編號;
            }
            set
            {
                _物品 = 物品資料管理器.獨體.Get(value);
            }
        }

        protected 物品資料 _物品;
        public 物品資料 物品
        {
            get
            {
                if (_物品 == null)
                    _物品 = 物品資料.NULL;
                else if (物品資料管理器.獨體.唯讀BList.Contains(_物品) == false)
                    _物品 = 物品資料.ERROR;

                return _物品;
            }
            set
            {
                _物品 = value;
            }
        }

        public String 物品名稱
        {
            get
            {
                return _物品.名稱;
            }
        }

        [JsonProperty]
        public String 識別名稱 { get; set; }

        [JsonProperty]
        public int 數量 { get; set; }

        public decimal 成本
        {
            get
            {
                return 物品.成本 * 數量;
            }
        }

        public int 體積
        {
            get
            {
                return 物品.體積 * 數量;
            }
        }

        /********************************/

        public 商品組成匯入資料()
        {
        }

        public 商品組成匯入資料(string Value_)
        {
            識別名稱 = Value_;
            物品 = 物品資料.ERROR;
            數量 = 0;

            // 不支援空白資料
            if(String.IsNullOrEmpty(Value_))
                return;

            String[] Pair_ = Value_.Split('*');

            // 格式僅支援 XXX, XXX*數字
            if (Pair_.Length > 2)
                return;

            // 讀取數量
            if (Pair_.Length == 2)
            {
                int 數量_;
                if (Int32.TryParse(Pair_[1], out 數量_))
                    數量 = 數量_;
                else
                    return;
            }
            else    // Pair_.Length == 1
            {
                數量 = 1;
            }

            物品 = 物品資料管理器.獨體.GetByLike(Pair_[0]);
        }

        /********************************/

        public void 檢查合法()
        {
            if (物品.編號是否合法() == false)
                throw new Exception("商品組成匯入資料:物品不合法:" + 物品編號);

            if(數量 <= 0)
                throw new Exception("商品組成匯入資料:數量不合法:" + 物品編號);
        }
    }
}
