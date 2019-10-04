using Newtonsoft.Json;
using System;
using System.Linq;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.參數
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 參數資料 : 新版可記錄資料
    {
        [可匯出]
        [JsonProperty]
        public string 名稱 { get; set; }

        [可匯出]
        [JsonProperty]
        public string 參數 { get; set; }

        /********************************/

        public 參數資料 Self { get { return this; } }

        public static readonly 參數資料 空白 = new 參數資料
        {
            名稱 = 字串.無,
            參數 = 字串.無,
        };

        public static 參數資料 錯誤 = new 參數資料
        {
            名稱 = 字串.錯誤,
            參數 = 字串.錯誤,
        };

        /********************************/

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (String.IsNullOrEmpty(名稱))
                檢查器_.錯誤(資料_, "名稱不合法");
            else if (參數資料管理器.獨體.資料列舉2.Where(Value => Value != 參考_ && 名稱.Equals(Value.名稱)).Any())
                檢查器_.錯誤(資料_, "名稱重複");

            if (String.IsNullOrEmpty(參數))
                檢查器_.錯誤(資料_, "參數不合法");
        }
    }
}
