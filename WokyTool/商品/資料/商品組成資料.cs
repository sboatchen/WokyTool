using Newtonsoft.Json;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.商品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 商品組成資料 : 基本資料
    {
        [JsonProperty]
        public int 群組 { get; set; }

        [JsonProperty]
        public string 規格 { get; set; }

        [JsonProperty]
        public int 物品編號
        {
            get
            {
                return 物品.編號;
            }
            set
            {
                物品 = 物品資料管理器.獨體.取得(value);
            }
        }

        [JsonProperty]
        public int 數量 { get; set; }

        /********************************/

        public 物品資料 物品 { get; set; }

        public string 物品名稱 { get { return 物品.名稱; } }

        public decimal 成本
        {
            get
            {
                return 物品.成本 * 數量;
            }
        }

        public int 體積
        {
            get
            {
                return 物品.體積 * 數量;
            }
        }

        /********************************/

        public 商品組成資料 Self { get { return this; } }

        public 商品組成資料()
        {
            物品 = 物品資料.空白;
        }

        /********************************/

        public void 檢查合法(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            //基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (false == 物品.編號是否合法())
                檢查器_.錯誤(資料_, "物品不合法");

            if (群組 < 0)
                檢查器_.錯誤(資料_, "群組不合法");

            if (群組 > 0 && string.IsNullOrEmpty(規格))
                檢查器_.錯誤(資料_, "規格不合法");

            if (數量 <= 0)
                檢查器_.錯誤(資料_, "數量不合法");
        }
    }
}
