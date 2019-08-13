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

namespace WokyTool.聯絡人
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class 聯絡人資料 : 新版可記錄資料<聯絡人資料>
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        [JsonProperty]
        public string 姓名 { get; set; }

        [JsonProperty]
        public string 電話 { get; set; }

        [JsonProperty]
        public string 手機 { get; set; }

        [JsonProperty]
        public string 地址 { get; set; }

        /********************************/

        public 聯絡人資料 Self { get { return this; } }

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

        public override void 檢查合法(可處理合法介面 介面_)
        {
            if (String.IsNullOrEmpty(姓名))
                介面_.錯誤(this, "姓名不合法");

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                介面_.錯誤(this, "電話/手機不合法");

            if (String.IsNullOrEmpty(地址))
                介面_.錯誤(this, "地址不合法");
        }
    }
}