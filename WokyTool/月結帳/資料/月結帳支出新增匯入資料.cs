using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;
using WokyTool.單品;

namespace WokyTool.月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳支出新增匯入資料 : 靜態匯入資料
    {
        [JsonProperty]
        public string 傳票號碼 { get; set; }

        [JsonProperty]
        public string 供應商識別 { get; set; }

        public 供應商資料 供應商 { get; set; }

        [JsonProperty]
        public decimal 費用 { get; set; }

        /********************************/

        public override void 初始化()
        {
            供應商 = 供應商資料管理器.獨體.取得(供應商識別);
        }

        public override void 檢查合法()
        {
            if (供應商.編號是否合法() == false)
                throw new Exception("供應商編號不合法");
        }
    }
}
