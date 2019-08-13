using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.公司
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class 公司資料 : 新版可記錄資料<公司資料>
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        /********************************/

        public 公司資料 Self { get { return this; } }

        public static readonly 公司資料 空白 = new 公司資料
        {
            編號 = 常數.空白資料編碼,
            名稱 = 字串.無,
        };

        public static 公司資料 錯誤 = new 公司資料
        {
            編號 = 常數.錯誤資料編碼,
            名稱 = 字串.錯誤,
        };

        /********************************/

        public override void 檢查合法(可處理合法介面 介面_)
        {
            if (String.IsNullOrEmpty(名稱))
                介面_.錯誤(this, "名稱不合法");
        }
    }
}
