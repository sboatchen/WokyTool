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

        public override void 檢查合法(可處理合法介面 介面_)
        {
            if (String.IsNullOrEmpty(帳號))
                介面_.錯誤(this, "帳號不合法");

            if (String.IsNullOrEmpty(密碼))
                介面_.錯誤(this, "密碼不合法");

            if (String.IsNullOrEmpty(名稱))
                介面_.錯誤(this, "名稱不合法");
        }
    }
}
