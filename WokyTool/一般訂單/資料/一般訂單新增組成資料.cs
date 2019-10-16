using Newtonsoft.Json;
using System;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 一般訂單新增組成資料 : 基本資料
    {
        [JsonProperty]
        public int 商品編號
        {
            get
            {
                return 商品.編號;
            }
            set
            {
                商品 = 商品資料管理器.獨體.取得(value);
            }
        }

        [JsonProperty]
        public int 數量 { get; set; }

        [JsonProperty]
        public String 備註 { get; set; }

        /********************************/

        public 商品資料 商品 { get; set; }

        public string 商品名稱 { get { return 商品.名稱; } }

        //public decimal 成本
        //{
        //    get
        //    {
        //        return 商品.成本 * 數量;
        //    }
        //}

        //public int 體積
        //{
        //    get
        //    {
        //        return 商品.體積 * 數量;
        //    }
        //}

        /********************************/

        public 一般訂單新增組成資料 Self { get { return this; } }

        public 一般訂單新增組成資料()
        {
            商品 = 商品資料.空白;
        }

        /********************************/

        public void 檢查合法(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            //基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (false == 商品.編號是否合法())
                檢查器_.錯誤(資料_, "商品不合法");
        }
    }
}
