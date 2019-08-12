using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.使用者;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳匯入設定資料 : 檔案匯入設定資料<月結帳匯入設定資料>
    {
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
        public int 業務編號
        {
            get
            {
                return 業務.編號;
            }
            set
            {
                _業務 = 使用者資料管理器.獨體.取得(value);
            }
        }

        protected 使用者資料 _業務;
        public 使用者資料 業務
        {
            get
            {
                if (_業務 == null)
                    _業務 = 使用者資料.空白;
                else if (使用者資料管理器.獨體.包含(_業務) == false)
                    _業務 = 使用者資料.錯誤;

                return _業務;
            }
            set
            {
                _業務 = value;
            }
        }

        [JsonProperty]
        public 列舉.商品識別 商品識別 { get; set; }

        /********************************/

        public 月結帳匯入設定資料 Self
        {
            get { return this; }
        }

        private static readonly 月結帳匯入設定資料 _NULL = new 月結帳匯入設定資料
        {
            編號 = 常數.空白資料編碼,
            格式 = 列舉.檔案格式.無,
            名稱 = 字串.無,
            開始位置 = 0,
            結束位置 = 0,
            標頭位置 = 0,
            公司 = 公司資料.NULL,
            客戶 = 客戶資料.NULL,
            業務 = 使用者資料.空白,
            商品識別 = 列舉.商品識別.無,
        };
        public static 月結帳匯入設定資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 月結帳匯入設定資料 _ERROR = new 月結帳匯入設定資料
        {
            編號 = 常數.錯誤資料編碼,
            格式 = 列舉.檔案格式.錯誤,
            名稱 = 字串.錯誤,
            開始位置 = 0,
            結束位置 = 0,
            標頭位置 = 0,
            公司 = 公司資料.ERROR,
            客戶 = 客戶資料.ERROR,
            業務 = 使用者資料.錯誤,
            商品識別 = 列舉.商品識別.錯誤,
        };
        public static 月結帳匯入設定資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override 月結帳匯入設定資料 拷貝()
        {
            月結帳匯入設定資料 New_ = new 月結帳匯入設定資料
            {
                編號 = this.編號,
                格式 = this.格式,
                名稱 = this.名稱,
                開始位置 = this.開始位置,
                結束位置 = this.結束位置,
                標頭位置 = this.標頭位置,
                公司 = this.公司,
                客戶 = this.客戶,
                業務 = this.業務,
                商品識別 = this.商品識別,
            };

            foreach (欄位匯入設定資料 Item_ in this.資料List)
            {
                New_.資料List.Add((欄位匯入設定資料)Item_.拷貝());
            }

            return New_;
        }

        public override void 覆蓋(月結帳匯入設定資料 Data_)
        {
            編號 = Data_.編號;
            格式 = Data_.格式;
            名稱 = Data_.名稱;
            開始位置 = Data_.開始位置;
            結束位置 = Data_.結束位置;
            標頭位置 = Data_.標頭位置;
            公司 = Data_.公司;
            客戶 = Data_.客戶;
            業務 = Data_.業務;
            商品識別 = Data_.商品識別;

            資料List.Clear();
            foreach (欄位匯入設定資料 Child_ in Data_.資料List)
            {
                資料List.Add((欄位匯入設定資料)Child_.拷貝());
            }
        }

        public override bool 是否一致(月結帳匯入設定資料 Data_)
        {
            bool Flag_ =
                編號 == Data_.編號 &&
                格式 == Data_.格式 &&
                名稱 == Data_.名稱 &&
                開始位置 == Data_.開始位置 &&
                結束位置 == Data_.結束位置 &&
                標頭位置 == Data_.標頭位置 &&
                公司 == Data_.公司 &&
                客戶 == Data_.客戶 &&
                業務 == Data_.業務 &&
                商品識別 == Data_.商品識別;

            if (Flag_ == false)
                return false;

            int Size_ = 資料List.Count;
            if (Size_ != Data_.資料List.Count)
                return false;

            for (int i = 0; i < Size_; i++)
            {
                if (資料List[i].是否一致(Data_.資料List[i]) == false)
                    return false;
            }

            return true;
        }

        // 如果不合法 回傳例外
        public override void 檢查合法()
        {
            base.檢查合法();

            if (公司.編號是否合法() == false)
                throw new Exception("月結帳匯入設定資料:公司不合法:" + 公司編號);

            if (客戶.編號是否合法() == false)
                throw new Exception("月結帳匯入設定資料:客戶不合法:" + 客戶編號);

            if (列舉.是否有值((int)商品識別) == false)
                throw new Exception("月結帳匯入設定資料:商品識別不合法:" + 商品識別);

            if (資料List.Count == 0)
                throw new Exception("月結帳匯入設定資料:沒欄位資料");

            switch (商品識別)
            {
                case 列舉.商品識別.商品編號:
                    if (名稱映射對應表.ContainsKey(月結帳列舉.匯入需求欄位.商品編號.ToString()) == false)
                        throw new Exception("月結帳匯入設定資料:未設定商品編號欄位");
                    break;
                case 列舉.商品識別.商品編號_顏色:
                    if (名稱映射對應表.ContainsKey(月結帳列舉.匯入需求欄位.商品編號.ToString()) == false)
                        throw new Exception("月結帳匯入設定資料:未設定商品編號欄位");
                    if (名稱映射對應表.ContainsKey(月結帳列舉.匯入需求欄位.顏色.ToString()) == false)
                        throw new Exception("月結帳匯入設定資料:未設定顏色欄位");
                    break;
                case 列舉.商品識別.商品名稱:
                    if (名稱映射對應表.ContainsKey(月結帳列舉.匯入需求欄位.商品名稱.ToString()) == false)
                        throw new Exception("月結帳匯入設定資料:未設定商品名稱欄位");
                    break;
                default:
                    throw new Exception("月結帳匯入設定資料:未知的商品識別類型:" + 商品識別);
            }

            if (名稱映射對應表.ContainsKey(月結帳列舉.匯入需求欄位.單價.ToString()) == false
                && 名稱映射對應表.ContainsKey(月結帳列舉.匯入需求欄位.含稅單價.ToString()) == false
                && 名稱映射對應表.ContainsKey(月結帳列舉.匯入需求欄位.總價.ToString()) == false
                && 名稱映射對應表.ContainsKey(月結帳列舉.匯入需求欄位.含稅總價.ToString()) == false)
                throw new Exception("月結帳匯入設定資料:未設定單價欄位");

            if (名稱映射對應表.ContainsKey(月結帳列舉.匯入需求欄位.數量.ToString()) == false)
                throw new Exception("月結帳匯入設定資料:未設定數量欄位");
        }

        public IEnumerable<月結帳匯入資料> 匯入Excel()
        {
            return 匯入Excel<月結帳匯入資料>(new 月結帳匯入轉換(), false);
        }
    }
}
