using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.聯絡人
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 聯絡人資料 : 新版可記錄資料<聯絡人資料>
    {
        [可匯出]
        [JsonProperty]
        public string 姓名 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 電話 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 手機 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 地址 { get; set; }

        [JsonProperty]
        public int 客戶編號
        {
            get
            {
                return 客戶.編號;
            }
            set
            {
                客戶 = 客戶資料管理器.獨體.取得(value);
            }
        }

        [JsonProperty]
        public int 子客戶編號
        {
            get
            {
                return 子客戶.編號;
            }
            set
            {
                子客戶 = 子客戶資料管理器.獨體.取得(value);
            }
        }

        /********************************/

        public 客戶資料 客戶 { get; set; }

        public 子客戶資料 子客戶 { get; set; }

        [可匯出(名稱 = "客戶")]
        public string 客戶名稱 { get { return 客戶.名稱; } }

        [可匯出(名稱 = "子客戶")]
        public string 子客戶名稱 { get { return 子客戶.名稱; } }

        public 聯絡人資料 Self { get { return this; } }

        public static readonly 聯絡人資料 不篩 = new 聯絡人資料
        {
            編號 = 常數.不篩資料編碼,
            姓名 = 字串.不篩選,
            電話 = 字串.空,
            手機 = 字串.空,
            地址 = 字串.空,
        };

        public static readonly 聯絡人資料 空白 = new 聯絡人資料
        {
            編號 = 常數.空白資料編碼,
            姓名 = 字串.無,
            電話 = 字串.無,
            手機 = 字串.無,
            地址 = 字串.無,
        };

        public static 聯絡人資料 錯誤 = new 聯絡人資料
        {
            編號 = 常數.錯誤資料編碼,
            姓名 = 字串.錯誤,
            電話 = 字串.錯誤,
            手機 = 字串.錯誤,
            地址 = 字串.錯誤,
        };

        /********************************/

        public override void 合法檢查(可處理檢查介面 介面_, IEnumerable<聯絡人資料> 資料列舉_)
        {
            if (String.IsNullOrEmpty(姓名))
                介面_.錯誤(this, "姓名不合法");
            else if (資料列舉_.Where(Value => 姓名.Equals(Value.姓名)).Count() > 1)
                介面_.錯誤(this, "姓名重複");

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                介面_.錯誤(this, "電話/手機不合法");

            if (String.IsNullOrEmpty(地址))
                介面_.錯誤(this, "地址不合法");

            if (false == 客戶.編號是否有值())
                介面_.錯誤(this, "客戶不合法");

            // 可以不設定子客戶, 但若設定了 必須屬於上層客戶
            if (子客戶.編號是否有值() && 子客戶.客戶 != 客戶)
                介面_.錯誤(this, "子客戶不屬於客戶");
        }
    }
}