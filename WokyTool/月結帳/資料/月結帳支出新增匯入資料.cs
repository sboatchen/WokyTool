using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;
using WokyTool.廠商;

namespace WokyTool.月結帳
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 月結帳支出新增匯入資料 : 靜態匯入資料
    {
        [JsonProperty]
        public string 傳票號碼 { get; set; }

        [JsonProperty]
        public string 廠商識別 { get; set; }

        public 廠商資料 廠商 { get; set; }

        [JsonProperty]
        public decimal 費用 { get; set; }

        /********************************/

        public override void 初始化()
        {
            廠商 = 廠商資料管理器.獨體.取得(廠商識別);
        }

        public override void 檢查合法()
        {
            if (廠商.編號是否合法() == false)
                throw new Exception("廠商編號不合法");
        }
    }
}
