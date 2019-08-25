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
    public class 使用者資料 : 新版可記錄資料<使用者資料>
    {
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

        /********************************/

        public string 顯示密碼
        {
            get 
            {
                if (String.IsNullOrEmpty(密碼))
                    return 字串.無;
                return 字串.保密字串;
            }
        }

        public 使用者資料 Self { get { return this; } }

        public static readonly 使用者資料 不篩 = new 使用者資料
        {
            編號 = 常數.不篩資料編碼,

            帳號 = 字串.不篩選,
            密碼 = 字串.無,

            名稱 = 字串.不篩選,

            修改基本資料 = false,
            修改設定資料 = false,
            匯入訂單 = false,
            匯入進貨 = false,
            匯入月結帳 = false,
        };

        public static readonly 使用者資料 空白 = new 使用者資料
        {
            編號 = 常數.空白資料編碼,

            帳號 = 字串.無,
            密碼 = 字串.無,

            名稱 = 字串.無,

            修改基本資料 = false,
            修改設定資料 = false,
            匯入訂單 = false,
            匯入進貨 = false,
            匯入月結帳 = false,
        };

        public static 使用者資料 錯誤 = new 使用者資料
        {
            編號 = 常數.錯誤資料編碼,

            帳號 = 字串.錯誤,
            密碼 = 字串.無,

            名稱 = 字串.錯誤,

            修改基本資料 = false,
            修改設定資料 = false,
            匯入訂單 = false,
            匯入進貨 = false,
            匯入月結帳 = false,
        };

        /********************************/

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;

            if (String.IsNullOrEmpty(帳號))
                檢查器_.錯誤(資料_, "帳號不合法");
            else if (使用者資料管理器.獨體.資料列舉2.Where(Value => 帳號.Equals(Value.帳號)).Count() > 1)
                檢查器_.錯誤(資料_, "帳號重複");

            if (String.IsNullOrEmpty(密碼))
                檢查器_.錯誤(資料_, "密碼不合法");

            if (String.IsNullOrEmpty(名稱))
                檢查器_.錯誤(資料_, "名稱不合法");
            else if (使用者資料管理器.獨體.資料列舉2.Where(Value => 名稱.Equals(Value.名稱)).Count() > 1)
                檢查器_.錯誤(資料_, "名稱重複");
        }
    }
}
