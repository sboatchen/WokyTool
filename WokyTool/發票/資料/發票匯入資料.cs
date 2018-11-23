using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.發票
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 發票匯入資料 : 可匯入資料
    {
        [JsonProperty]
        public string 發票號碼 { get; set; }

        [JsonProperty]
        public string 發票字軌 { get; set; }

        [JsonProperty]
        public int 發票數值 { get; set; }

        [JsonProperty]
        public string 註記 { get; set; }

        [JsonProperty]
        public string 格式代號 { get; set; }

        [JsonProperty]
        public string 發票狀態 { get; set; }

        [JsonProperty]
        public string 發票日期 { get; set; }

        [JsonProperty]
        public string 買方統一編號 { get; set; }

        [JsonProperty]
        public string 買方名稱 { get; set; }

        [JsonProperty]
        public string 賣方統一編號 { get; set; }

        [JsonProperty]
        public string 賣方名稱 { get; set; }

        [JsonProperty]
        public string 寄送日期 { get; set; }

        [JsonProperty]
        public decimal 銷售額合計 { get; set; }

        [JsonProperty]
        public decimal 營業稅 { get; set; }

        [JsonProperty]
        public decimal 總計 { get; set; }

        [JsonProperty]
        public string 課稅別 { get; set; }

        [JsonProperty]
        public decimal 匯率 { get; set; }

        [JsonProperty]
        public string 載具號碼1 { get; set; }

        [JsonProperty]
        public string 載具號碼2 { get; set; }

        [JsonProperty]
        public string 總備註 { get; set; }

        /********************************/

        public override void 檢查合法()
        {
            if(String.IsNullOrEmpty(發票號碼))
                throw new Exception("發票匯入資料:發票號碼不合法:" + this.ToString());
        }

        public static 發票匯入資料 空白(String 發票號碼_)
        {
            return new 發票匯入資料
            {
                發票號碼 = 發票號碼_,
                註記 = 字串.空白,
                銷售額合計 = 0,
                營業稅 = 0,
                總計 = 0,
            };
        }
    }
}
