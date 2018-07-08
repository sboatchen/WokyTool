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
    public class 物品資料 : MyKeepableData<物品資料>
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
                大類 = 物品大類資料管理器.獨體.Get(value);
            }
        }

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
        public int 小類編號
        {
            get
            {
                return 小類.編號;
            }
            set
            {
                小類 = 物品小類資料管理器.獨體.Get(value);
            }
        }

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
        public int 品牌編號
        {
            get
            {
                return 品牌.編號;
            }
            set
            {
                品牌 = 物品品牌資料管理器.獨體.Get(value);
            }
        }

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

        /* @@
        public 物品資料 上層;
        [JsonProperty]
        public int 上層編號
        {
            get
            {
                return 上層.編號;
            }
            set
            {
                if (value <= 0)
                    上層 = 物品資料.NULL;
                else
                    上層 = 物品資料管理器.Instance.Get(value);
            }
        }
        */

        /********************************/

        public 物品資料 Self
        {
            get { return this; }
        }

        private static readonly 物品資料 _NULL = new 物品資料
        {
            編號 = 常數.T空白資料編碼,

            大類 = 物品大類資料.NULL,
            小類 = 物品小類資料.NULL,
            品牌 = 物品品牌資料.NULL,

            條碼 = 字串.無,
            原廠編號 = 字串.無,
            代理編號 = 字串.無,

            名稱 = 字串.無,
            縮寫 = 字串.無,

            體積 = 0,
            顏色 = 字串.無,

            內庫數量 = 0,
            外庫數量 = 0,

            庫存總成本 = 0,
            最後進貨成本 = 0,
            成本備註 = 字串.無,
        };
        public static 物品資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 物品資料 _ERROR = new 物品資料
        {
            編號 = 常數.T錯誤資料編碼,

            大類 = 物品大類資料.ERROR,
            小類 = 物品小類資料.ERROR,
            品牌 = 物品品牌資料.ERROR,

            條碼 = 字串.錯誤,
            原廠編號 = 字串.錯誤,
            代理編號 = 字串.錯誤,

            名稱 = 字串.錯誤,
            縮寫 = 字串.錯誤,

            體積 = 0,
            顏色 = 字串.錯誤,

            內庫數量 = 0,
            外庫數量 = 0,

            庫存總成本 = 0,
            最後進貨成本 = 0,
            成本備註 = 字串.錯誤,
        };
        public static 物品資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override 物品資料 拷貝()
        {
            物品資料 Data_ = new 物品資料
            {  
                編號 = this.編號,

                大類 = this.大類,
                小類 = this.小類,
                品牌 = this.品牌,

                條碼 = this.條碼,
                原廠編號 = this.原廠編號,
                代理編號 = this.代理編號,
                
                名稱 = this.名稱,
                縮寫 = this.縮寫,

                體積 = this.體積,
                顏色 = this.顏色,

                內庫數量 = this.內庫數量,
                外庫數量 = this.外庫數量,

                庫存總成本 = this.庫存總成本,
                最後進貨成本 = this.最後進貨成本,
                成本備註 = this.成本備註,
            };

            return Data_;
        }

        public override void 覆蓋(物品資料 Data_)
        {
            編號 = Data_.編號;

            大類 = Data_.大類;
            小類 = Data_.小類;
            品牌 = Data_.品牌;

            條碼 = Data_.條碼;
            原廠編號 = Data_.原廠編號;
            代理編號 = Data_.代理編號;
                
            名稱 = Data_.名稱;
            縮寫 = Data_.縮寫;

            體積 = Data_.體積;
            顏色 = Data_.顏色;

            內庫數量 = Data_.內庫數量;
            外庫數量 = Data_.外庫數量;

            庫存總成本 = Data_.庫存總成本;
            最後進貨成本 = Data_.最後進貨成本;
            成本備註 = Data_.成本備註;
        }

        public override Boolean 是否一致(物品資料 Data_)
        {
            return
                編號 == Data_.編號 &&

                大類 == Data_.大類 &&
                小類 == Data_.小類 &&
                品牌 == Data_.品牌 &&

                條碼 == Data_.條碼 &&
                原廠編號 == Data_.原廠編號 &&
                代理編號 == Data_.代理編號 &&

                名稱 == Data_.名稱 &&
                縮寫 == Data_.縮寫 &&

                體積 == Data_.體積 &&
                顏色 == Data_.顏色 &&

                內庫數量 == Data_.內庫數量 &&
                外庫數量 == Data_.外庫數量 &&
                庫存總成本 == Data_.庫存總成本 &&

                最後進貨成本 == Data_.最後進貨成本 &&
                成本備註 == Data_.成本備註;
        }

        public override void 檢查合法()
        {
            if (大類編號 <= 常數.T新建資料編碼)
                throw new Exception("月結帳資料:大類編號不合法:" + 大類編號);

            if (小類編號 <= 常數.T新建資料編碼)
                throw new Exception("月結帳資料:小類編號不合法:" + 小類編號);

            if (品牌編號 <= 常數.T新建資料編碼)
                throw new Exception("月結帳資料:品牌編號不合法:" + 品牌編號);

            if (String.IsNullOrEmpty(名稱))
                throw new Exception("物品資料:名稱不合法:" + this.ToString());

            if (String.IsNullOrEmpty(縮寫))
                throw new Exception("物品資料:縮寫不合法:" + this.ToString());
        }

        /*
        public override Boolean 篩選(物品資料 Item_)
        {
            物品資料 Data_ = Item_ as 物品資料;
            if (Data_ == null)
                throw new Exception("物品資料:比較失敗:" + this.GetType());

            return
                編號 == Data_.編號 &&

                大類 == Data_.大類 &&
                小類 == Data_.小類 &&
                品牌 == Data_.品牌 &&

                條碼 == Data_.條碼 &&
                原廠編號 == Data_.原廠編號 &&
                代理編號 == Data_.代理編號 &&

                名稱 == Data_.名稱 &&
                縮寫 == Data_.縮寫 &&

                體積 == Data_.體積 &&
                顏色 == Data_.顏色 &&

                內庫數量 == Data_.內庫數量 &&
                外庫數量 == Data_.外庫數量 &&
                庫存總成本 == Data_.庫存總成本 &&

                最後進貨成本 == Data_.最後進貨成本 &&
                成本備註 == Data_.成本備註;
        }*/

        /********************************/

        // 物品販賣
        public bool Sell(bool 寄庫出貨_, int 數量_)
        {
            //@@
            //if (數量_ <= 0)
            //{
            //    MessageBox.Show("物品資料::Sell 總數量參數不合法，請通知苦逼程式,", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            ////@@ should not direct control flag
            //物品管理器.Instance.SetDirty();

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
