using Newtonsoft.Json;
using WokyTool.通用;

namespace WokyTool.商品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 自訂售價資料 : 基本資料
    {
        [JsonProperty]
        public string 索引 { get; set; }

        [JsonProperty]
        public decimal 售價 { get; set; }

        /********************************/

        public void 檢查合法(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            //基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (string.IsNullOrEmpty(索引))
                檢查器_.錯誤(資料_, "索引不合法");

            if (售價 < 0)
                檢查器_.錯誤(資料_, "售價不合法");
        }
    }
}
