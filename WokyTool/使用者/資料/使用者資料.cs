using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.使用者
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 使用者資料 : MyKeepableData<使用者資料>
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        [JsonProperty]
        public string 帳號 { get; set; }

        [JsonProperty]
        public string 密碼 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        [JsonProperty]
        public bool 修改基本資料 { get; set; }

        [JsonProperty]
        public bool 修改設定資料 { get; set; }

        [JsonProperty]
        public bool 匯入訂單 { get; set; }

        [JsonProperty]
        public bool 匯入進貨 { get; set; }

        [JsonProperty]
        public bool 匯入月結帳 { get; set; }

        public string 顯示密碼
        {
            get 
            {
                if (String.IsNullOrEmpty(密碼))
                    return 字串.無;
                return 字串.保密字串;
            }
        }

        /********************************/

        public 使用者資料 Self
        {
            get { return this; }
        }

        private static readonly 使用者資料 _NULL = new 使用者資料
        {
            編號 = 常數.T空白資料編碼,

            帳號 = 字串.無,
            密碼 = 字串.無,

            名稱 = 字串.無,

            修改基本資料 = false,
            修改設定資料 = false,
            匯入訂單 = false,
            匯入進貨 = false,
            匯入月結帳 = false,
        };
        public static 使用者資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 使用者資料 _ERROR = new 使用者資料
        {
            編號 = 常數.T錯誤資料編碼,

            帳號 = 字串.錯誤,
            密碼 = 字串.無,

            名稱 = 字串.錯誤,

            修改基本資料 = false,
            修改設定資料 = false,
            匯入訂單 = false,
            匯入進貨 = false,
            匯入月結帳 = false,
        };
        public static 使用者資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override 使用者資料 拷貝()
        {
            使用者資料 Data_ = new 使用者資料
            {
                編號 = this.編號,

                帳號 = this.帳號,
                密碼 = this.密碼,

                名稱 = this.名稱,

                修改基本資料 = this.修改基本資料,
                修改設定資料 = this.修改設定資料,
                匯入訂單 = this.匯入訂單,
                匯入進貨 = this.匯入進貨,
                匯入月結帳 = this.匯入月結帳,
            };

            return Data_;
        }

        public override void 覆蓋(使用者資料 Data_)
        {
            編號 = Data_.編號;

            帳號 = Data_.帳號;
            密碼 = Data_.密碼;

            名稱 = Data_.名稱;

            修改基本資料 = Data_.修改基本資料;
            修改設定資料 = Data_.修改設定資料;
            匯入訂單 = Data_.匯入訂單;
            匯入進貨 = Data_.匯入進貨;
            匯入月結帳 = Data_.匯入月結帳;
        }

        public override Boolean 是否一致(使用者資料 Data_)
        {
            return
                編號 == Data_.編號 &&

                帳號 == Data_.帳號 &&
                密碼 == Data_.密碼 &&

                名稱 == Data_.名稱 &&

                修改基本資料 == Data_.修改基本資料 &&
                修改設定資料 == Data_.修改設定資料 &&
                匯入訂單 == Data_.匯入訂單 &&
                匯入進貨 == Data_.匯入進貨 &&
                匯入月結帳 == Data_.匯入月結帳;
        }

        public override void 檢查合法()
        {
            if (String.IsNullOrEmpty(帳號))
                throw new Exception("使用者資料:帳號不合法");

            if (String.IsNullOrEmpty(密碼))
                throw new Exception("使用者資料:密碼不合法");

            if (String.IsNullOrEmpty(名稱))
                throw new Exception("使用者資料:名稱不合法");
        }
    }
}
