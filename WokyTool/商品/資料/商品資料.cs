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
        public int 需求編號1
        {
            get
            {
                return _需求1.編號;
            }
            set
            {
                _需求1 = 物品資料管理器.獨體.Get(value);
            }
        }

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
        public int 需求編號2
        {
            get
            {
                return _需求2.編號;
            }
            set
            {
                _需求2 = 物品資料管理器.獨體.Get(value);
            }
        }

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
        public int 需求編號3
        {
            get
            {
                return _需求3.編號;
            }
            set
            {
                _需求3 = 物品資料管理器.獨體.Get(value);
            }
        }

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
        public int 需求編號4
        {
            get
            {
                return _需求4.編號;
            }
            set
            {
                _需求4 = 物品資料管理器.獨體.Get(value);
            }
        }

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
        public int 需求編號5
        {
            get
            {
                return _需求5.編號;
            }
            set
            {
                _需求5 = 物品資料管理器.獨體.Get(value);
            }
        }

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

            需求1 = 物品資料.NULL,
            需求2 = 物品資料.NULL,
            需求3 = 物品資料.NULL,
            需求4 = 物品資料.NULL,
            需求5 = 物品資料.NULL,

            數量1 = 0,
            數量2 = 0,
            數量3 = 0,
            數量4 = 0,
            數量5 = 0,

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

            需求1 = 物品資料.ERROR,
            需求2 = 物品資料.ERROR,
            需求3 = 物品資料.ERROR,
            需求4 = 物品資料.ERROR,
            需求5 = 物品資料.ERROR,

            數量1 = 0,
            數量2 = 0,
            數量3 = 0,
            數量4 = 0,
            數量5 = 0,

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

                需求1 = this.需求1,
                需求2 = this.需求2,
                需求3 = this.需求3,
                需求4 = this.需求4,
                需求5 = this.需求5,

                數量1 = this.數量1,
                數量2 = this.數量2,
                數量3 = this.數量3,
                數量4 = this.數量4,
                數量5 = this.數量5,

                寄庫數量 = this.寄庫數量,
                售價 = this.售價,
            };

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

            需求1 = Data_.需求1;
            需求2 = Data_.需求2;
            需求3 = Data_.需求3;
            需求4 = Data_.需求4;
            需求5 = Data_.需求5;

            數量1 = Data_.數量1;
            數量2 = Data_.數量2;
            數量3 = Data_.數量3;
            數量4 = Data_.數量4;
            數量5 = Data_.數量5;

            寄庫數量 = Data_.寄庫數量;
            售價 = Data_.售價;
        }

        public override Boolean 是否一致(商品資料 Data_)
        {
            return
                編號 == Data_.編號 &&

                大類 == Data_.大類 &&
                小類 == Data_.小類 &&

                公司 == Data_.公司 &&
                客戶 == Data_.客戶 &&

                品號 == Data_.品號 &&
                名稱 == Data_.名稱 &&

                需求1 == Data_.需求1 &&
                需求2 == Data_.需求2 &&
                需求3 == Data_.需求3 &&
                需求4 == Data_.需求4 &&
                需求5 == Data_.需求5 &&

                數量1 == Data_.數量1 &&
                數量2 == Data_.數量2 &&
                數量3 == Data_.數量3 &&
                數量4 == Data_.數量4 &&
                數量5 == Data_.數量5 &&

                寄庫數量 == Data_.寄庫數量 &&
                售價 == Data_.售價;
        }

        public override void 檢查合法()
        {
            if (大類.編號是否合法() == false)
                throw new Exception("月結帳資料:大類編號不合法:" + 大類編號);

            if (小類.編號是否合法() == false)
                throw new Exception("月結帳資料:小類編號不合法:" + 小類編號);

            if (公司.編號是否合法() == false)
                throw new Exception("月結帳資料:公司編號不合法:" + 公司編號);

            if (客戶.編號是否合法() == false)
                throw new Exception("月結帳資料:客戶編號不合法:" + 客戶編號);

            if (需求1.編號是否合法() == false)
                throw new Exception("月結帳資料:需求編號1不合法:" + 需求編號1);

            if (需求2.編號是否合法() == false)
                throw new Exception("月結帳資料:需求編號2不合法:" + 需求編號2);

            if (需求3.編號是否合法() == false)
                throw new Exception("月結帳資料:需求編號3不合法:" + 需求編號3);

            if (需求4.編號是否合法() == false)
                throw new Exception("月結帳資料:需求編號4不合法:" + 需求編號4);

            if (需求5.編號是否合法() == false)
                throw new Exception("月結帳資料:需求編號5不合法:" + 需求編號5);

            if (String.IsNullOrEmpty(品號))
                throw new Exception("商品資料:品號不合法:" + this.ToString());

            if (String.IsNullOrEmpty(名稱))
                throw new Exception("商品資料:名稱不合法:" + this.ToString());

            if (數量1 < 0 || 數量2 < 0 || 數量3 < 0 || 數量4 < 0 || 數量5 < 0)
                throw new Exception("商品資料:數量不合法:" + this.ToString());
        }

        /********************************/

        // 商品販賣
        public bool Sell(bool 寄庫出貨_, int 數量_)
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
        }
    }
}
