using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.物品;

namespace WokyTool.商品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 商品組成資料
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

        public 商品組成資料 Self
        {
            get { return this; }
        }

        public override int GetHashCode()
        {
            return 數量 * 物品編號;
        }

        public static 商品組成資料 新增(商品組成匯入資料 Item_)
        {
            return new 商品組成資料
            {
                物品 = Item_.物品,
                數量 = Item_.數量,
            };
        }

        /********************************/

        public void 檢查合法()
        {
            if (物品.編號是否合法() == false)
                throw new Exception("商品組成資料:物品不合法:" + 物品編號);

            if(數量 <= 0)
                throw new Exception("商品組成資料:數量不合法:" + 物品編號);
        }

        public 商品組成資料 拷貝()
        {
            商品組成資料 Data_ = new 商品組成資料
            {
                _物品 = this._物品, //@@ 測試加速效果
                數量 = this.數量,
            };

            return Data_;
        }
    }
}
