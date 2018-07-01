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
    public class 平台訂單匯入檔案設定 : 檔案匯入設定資料
    {
        [JsonProperty]
        public override int 編號 { get; set; }


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

        public enum 平台訂單匯入需求欄位
        {
            商品編號,
            商品名稱,
            顏色,
            數量,

            收件姓名,
            收件地址,
            收件電話,
            收件手機,

            訂單編號,
        };

        /********************************/

        public static 平台訂單匯入檔案設定 New()
        {
            return new 平台訂單匯入檔案設定
            {
                格式 = 列舉.檔案格式類型.無,
                名稱 = 字串.空,
                公司 = 公司資料.NULL,
                廠商 = 廠商資料.NULL,
                商品識別 = 列舉.商品識別類型.無,
            };
        }

        private static readonly 平台訂單匯入檔案設定 _NULL = new 平台訂單匯入檔案設定
        {
            格式 = 列舉.檔案格式類型.無,
            名稱 = 字串.無,
            公司 = 公司資料.NULL,
            廠商 = 廠商資料.NULL,
            商品識別 = 列舉.商品識別類型.無,
        };
        public static 平台訂單匯入檔案設定 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 平台訂單匯入檔案設定 _ERROR = new 平台訂單匯入檔案設定
        {
            格式 = 列舉.檔案格式類型.錯誤,
            名稱 = 字串.錯誤,
            公司 = 公司資料.ERROR,
            廠商 = 廠商資料.ERROR,
            商品識別 = 列舉.商品識別類型.錯誤,
        };
        public static 平台訂單匯入檔案設定 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/
        
        public override object 拷貝()
        {
            //聯絡人資料 Data_ = new 聯絡人資料
            //{
            //    編號 = this.編號,
            //    姓名 = this.姓名,
            //    電話 = this.電話,
            //    手機 = this.手機,
            //    地址 = this.地址,
            //};

            //return Data_;
            return null;
        }

        public override void 覆蓋(object Item_)
        {
            //聯絡人資料 Data_ = Item_ as 聯絡人資料;
            //if (Data_ == null)
            //    throw new Exception("聯絡人資料:覆蓋失敗:" + this.GetType());

            //編號 = Data_.編號;
            //姓名 = Data_.姓名;
            //電話 = Data_.電話;
            //手機 = Data_.手機;
            //地址 = Data_.地址;
        }

        public override Boolean 是否一致(object Item_)
        {
            //聯絡人資料 Data_ = Item_ as 聯絡人資料;
            //if (Data_ == null)
            //    throw new Exception("聯絡人資料:比較失敗:" + this.GetType());

            //return
            //    編號 == Data_.編號 &&
            //    姓名 == Data_.姓名 &&
            //    電話 == Data_.電話 &&
            //    手機 == Data_.手機 &&
            //    地址 == Data_.地址;
            return true;
        }

        public override void 檢查合法()
        {
            //if (String.IsNullOrEmpty(姓名))
            //    throw new Exception("聯絡人資料:公司不合法:" + this.ToString());

            //if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
            //    throw new Exception("聯絡人資料:電話/手機不合法:" + this.ToString());

            //if (String.IsNullOrEmpty(地址))
            //    throw new Exception("聯絡人資料:地址不合法:" + this.ToString());
        }
    }
}
