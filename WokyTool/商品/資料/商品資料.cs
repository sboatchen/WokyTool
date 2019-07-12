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
    public class 商品資料 : MyKeepableData<商品資料>
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        [JsonProperty]
        public int 大類編號
        {
            get
            {
                return 大類.編號;
            }
            set
            {
                _大類 = 商品大類資料管理器.獨體.Get(value);
            }
        }

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
        public int 小類編號
        {
            get
            {
                return 小類.編號;
            }
            set
            {
                _小類 = 商品小類資料管理器.獨體.Get(value);
            }
        }

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
        public int 公司編號
        {
            get
            {
                return 公司.編號;
            }
            set
            {
                _公司 = 公司資料管理器.獨體.Get(value);
            }
        }

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
        public int 客戶編號
        {
            get
            {
                return 客戶.編號;
            }
            set
            {
                _客戶 = 客戶資料管理器.獨體.Get(value);
            }
        }

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
        public List<商品組成資料> 組成 { get; set; }

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

        protected 物品品牌資料 _品牌 = null;
        public 物品品牌資料 品牌
        {
            get
            {
                if (_品牌 == null)
                {
                    foreach(商品組成資料 商品組成資料_ in 組成)
                    {
                        物品品牌資料 Temp_ = 商品組成資料_.物品.品牌;
                        if (_品牌 == Temp_)
                            continue;
                        if (Temp_.編號 <= 0)
                            continue;

                        if (_品牌 == null)
                            _品牌 = Temp_;
                        else
                            _品牌 = 物品品牌資料.MIX;
                    }

                    if(_品牌 == null)
                        _品牌 = 物品品牌資料.NULL;
                }

                return _品牌;
            }
        }

        /********************************/

        public 商品資料 Self
        {
            get { return this; }
        }

        private static readonly 商品資料 _NULL = new 商品資料
        {
            編號 = 常數.T空白資料編碼,

            大類 = 商品大類資料.NULL,
            小類 = 商品小類資料.NULL,

            公司 = 公司資料.NULL,
            客戶 = 客戶資料.NULL,

            品號 = 字串.無,
            名稱 = 字串.無,

            寄庫數量 = 0,
            售價 = 0,
        };
        public static 商品資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 商品資料 _ERROR = new 商品資料
        {
            編號 = 常數.T錯誤資料編碼,

            大類 = 商品大類資料.ERROR,
            小類 = 商品小類資料.ERROR,

            公司 = 公司資料.ERROR,
            客戶 = 客戶資料.ERROR,

            品號 = 字串.錯誤,
            名稱 = 字串.錯誤,

            寄庫數量 = 0,
            售價 = 0,
        };
        public static 商品資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        private static 商品資料 _折扣 = new 商品資料
        {
            編號 = 常數.商品折扣資料編碼,

            大類 = 商品大類資料.NULL,
            小類 = 商品小類資料.NULL,

            公司 = 公司資料.NULL,
            客戶 = 客戶資料.NULL,

            品號 = 字串.空,
            名稱 = 字串.折扣,

            寄庫數量 = 0,
            售價 = 0,
        };
        public static 商品資料 折扣
        {
            get
            {
                return _折扣;
            }
        }

        /********************************/

        public override 商品資料 拷貝()
        {
            商品資料 Data_ = new 商品資料
            {
                編號 = this.編號,

                大類 = this.大類,
                小類 = this.小類,

                公司 = this.公司,
                客戶 = this.客戶,

                品號 = this.品號,
                名稱 = this.名稱,

                寄庫數量 = this.寄庫數量,
                售價 = this.售價,
            };

            if(this.組成 != null)
            {
                Data_.組成 = this.組成.Select(Value => Value.拷貝()).ToList();

            }

            return Data_;
        }

        public override void 覆蓋(商品資料 Data_)
        {
            編號 = Data_.編號;

            大類 = Data_.大類;
            小類 = Data_.小類;

            公司 = Data_.公司;
            客戶 = Data_.客戶;

            品號 = Data_.品號;
            名稱 = Data_.名稱;

            組成 = Data_.組成;

            寄庫數量 = Data_.寄庫數量;
            售價 = Data_.售價;
        }

        public override Boolean 是否一致(商品資料 Data_)
        {
            Boolean 是否相同_ =
                編號 == Data_.編號 &&

                大類 == Data_.大類 &&
                小類 == Data_.小類 &&

                公司 == Data_.公司 &&
                客戶 == Data_.客戶 &&

                品號 == Data_.品號 &&
                名稱 == Data_.名稱 &&

                寄庫數量 == Data_.寄庫數量 &&
                售價 == Data_.售價;

            if (是否相同_ == false)
                return false;

            return 函式.是否一致(組成, Data_.組成);
        }

        public override void 檢查合法()
        {
            if (大類.編號是否合法() == false)
                throw new Exception("商品資料:大類編號不合法:" + 大類編號);

            if (小類.編號是否合法() == false)
                throw new Exception("商品資料:小類編號不合法:" + 小類編號);

            if (公司.編號是否合法() == false)
                throw new Exception("商品資料:公司編號不合法:" + 公司編號);

            if (客戶.編號是否合法() == false)
                throw new Exception("商品資料:客戶編號不合法:" + 客戶編號);

            if (String.IsNullOrEmpty(名稱))
                throw new Exception("商品資料:名稱不合法:" + this.ToString());

            if (組成 != null)
            {
                foreach (商品組成資料 Item_ in 組成)
                    Item_.檢查合法();
            }        
        }

        /********************************/

        // 商品販賣
        /*public bool Sell(bool 寄庫出貨_, int 數量_)
        {
            //@@
            //if (數量_ <= 0)
            //{
            //    MessageBox.Show("商品資料::Sell 總數量參數不合法，請通知苦逼程式,", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            ////@@ should not direct control flag
            //商品管理器.Instance.SetDirty();

            //if (寄庫出貨_)
            //{
            //    外庫數量 -= 數量_;
            //}
            //else
            //{
            //    內庫數量 -= 數量_;
            //    if (內庫數量 < 0)
            //        MessageBox.Show(this.名稱 + " 庫存數量不足", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            return true;
        }*/
    }
}
