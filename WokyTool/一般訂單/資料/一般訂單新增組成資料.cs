using Newtonsoft.Json;
using System;
using WokyTool.單品;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 一般訂單新增組成資料 : 基本資料
    {
        [JsonProperty]
        public int 單品編號
        {
            get
            {
                return 單品.編號;
            }
            set
            {
                單品 = 單品資料管理器.獨體.取得(value);
            }
        }

        [JsonProperty]
        public int 數量 { get; set; }

        [JsonProperty]
        public decimal 售價 { get; set; }

        [JsonProperty]
        public String 備註 { get; set; }

        /********************************/

        public 單品資料 單品 { get; set; }

        public string 單品名稱 { get { return 單品.名稱; } }

        public decimal 總金額
        {
            get
            {
                return 數量 * 售價;
            }
        }

        /********************************/

        public 一般訂單新增組成資料 Self { get { return this; } }

        public 一般訂單新增組成資料()
        {
            單品 = 單品資料.空白;
        }

        /********************************/

        public void 檢查合法(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            一般訂單新增資料 資料_ = (一般訂單新增資料)資料上層_;
            //基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (false == 單品.編號是否合法())
                檢查器_.錯誤(資料_, "單品不合法");

            if (數量 == 0)
                檢查器_.錯誤(資料_, "數量不合法");
        }
    }
}
