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

namespace WokyTool.月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳匯入設定資料 : 檔案匯入設定資料<月結帳匯入設定資料>
    {
        public 公司資料 公司;
        [JsonProperty]
        public int 公司編號
        {
            get
            {
                return 公司.編號;
            }
            set
            {
                公司 = 公司管理器.Instance.Get(value);
            }
        }

        public 廠商資料 廠商;
        [JsonProperty]
        public int 廠商編號
        {
            get
            {
                return 廠商.編號;
            }
            set
            {
                廠商 = 廠商管理器.Instance.Get(value);
            }
        }

        [JsonProperty]
        public 列舉.商品識別類型 商品識別 { get; set; }

        public enum 動態匯入需求欄位_月結帳
        {
            訂單標號,

            商品編號,
            商品名稱,
            顏色,

            單價,

            含稅單價,
            總價,
            含稅總價,
            數量,
        };

        /********************************/

        private static readonly 月結帳匯入設定資料 _NULL = new 月結帳匯入設定資料
        {
            編號 = 常數.T空白資料編碼,
            格式 = 列舉.檔案格式類型.無,
            名稱 = 字串.空,
            公司 = 公司資料.NULL,
            廠商 = 廠商資料.NULL,
            商品識別 = 列舉.商品識別類型.無,
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
            編號 = 常數.T錯誤資料編碼,
            格式 = 列舉.檔案格式類型.錯誤,
            名稱 = 字串.錯誤,
            公司 = 公司資料.ERROR,
            廠商 = 廠商資料.ERROR,
            商品識別 = 列舉.商品識別類型.錯誤,
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
                開始位置 = this.開始位置,
                結束位置 = this.結束位置,
                標頭位置 = this.標頭位置,
                名稱 = this.名稱,
                公司 = this.公司,
                廠商 = this.廠商,
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
            開始位置 = Data_.開始位置;
            結束位置 = Data_.結束位置;
            標頭位置 = Data_.標頭位置;
            名稱 = Data_.名稱;
            公司 = Data_.公司;
            廠商 = Data_.廠商;
            商品識別 = Data_.商品識別;

            資料List.Clear();
            foreach (欄位匯入設定資料 Child_ in Data_.資料List)
            {
                資料List.Add((欄位匯入設定資料)Child_.拷貝());
            }
        }

        public override Boolean 是否一致(月結帳匯入設定資料 Data_)
        {
            // hard to compare 資料List, ingore it.
            return
                編號 == Data_.編號 &&
                格式 == Data_.格式 &&
                開始位置 == Data_.開始位置 &&
                結束位置 == Data_.結束位置 &&
                標頭位置 == Data_.標頭位置 &&
                名稱 == Data_.名稱 &&
                公司 == Data_.公司 &&
                廠商 == Data_.廠商 &&
                商品識別 == Data_.商品識別;
        }

        // 如果不合法 回傳例外
        public override void 檢查合法()
        {
            base.檢查合法();

            if (公司編號 <= 常數.T新建資料編碼)
                throw new Exception("月結帳匯入設定資料:公司不合法:" + 公司編號);

            if (廠商編號 <= 常數.T新建資料編碼)
                throw new Exception("月結帳匯入設定資料:廠商不合法:" + 廠商編號);

            if(商品識別 <= 列舉.商品識別類型.無)
                throw new Exception("月結帳匯入設定資料:商品識別不合法:" + 商品識別);

            if (資料List == null)
                throw new Exception("檔案匯入設定資料:沒欄位資料");

            switch (商品識別)
            {
                case 列舉.商品識別類型.商品編號:
                    if (名稱映射對應表.ContainsKey(動態匯入需求欄位_月結帳.商品編號.ToString()) == false)
                        throw new Exception("檔案匯入設定資料:未設定商品編號欄位");
                    break;
                case 列舉.商品識別類型.商品編號_顏色:
                    if (名稱映射對應表.ContainsKey(動態匯入需求欄位_月結帳.商品編號.ToString()) == false)
                        throw new Exception("檔案匯入設定資料:未設定商品編號欄位");
                     if (名稱映射對應表.ContainsKey(動態匯入需求欄位_月結帳.顏色.ToString()) == false)
                        throw new Exception("檔案匯入設定資料:未設定顏色欄位");
                    break;
                case 列舉.商品識別類型.商品名稱:
                    if (名稱映射對應表.ContainsKey(動態匯入需求欄位_月結帳.商品名稱.ToString()) == false)
                        throw new Exception("檔案匯入設定資料:未設定商品名稱欄位");
                    break;
                default:
                    throw new Exception("檔案匯入設定資料:未知的商品識別類型:" + 商品識別);
            }

            if (名稱映射對應表.ContainsKey(動態匯入需求欄位_月結帳.單價.ToString()) == false 
                && 名稱映射對應表.ContainsKey(動態匯入需求欄位_月結帳.含稅單價.ToString()) == false
                && 名稱映射對應表.ContainsKey(動態匯入需求欄位_月結帳.總價.ToString()) == false
                && 名稱映射對應表.ContainsKey(動態匯入需求欄位_月結帳.含稅總價.ToString()) == false)
                throw new Exception("檔案匯入設定資料:未設定單價欄位");

            if (名稱映射對應表.ContainsKey(動態匯入需求欄位_月結帳.數量.ToString()) == false)
                throw new Exception("檔案匯入設定資料:未設定數量欄位");
        }
    }
}
