using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.配送
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 宅配通匯入資料 : 靜態匯入資料
    {
        [JsonProperty]
        public string 姓名 { get; set; }

        [JsonProperty]
        public string 配送單號 { get; set; }

        /********************************/

        public override void 初始化()
        {
            ;
        }

        public override void 檢查合法()
        {
            ;
        }
    }
}
