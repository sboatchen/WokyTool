using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.物品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 物品總覽更新匯入資料 : 可匯入資料
    {
        [JsonProperty]
        public 列舉.更新狀態 更新狀態 { get; set; } 

        [JsonProperty]
        public 物品資料 物品 { get; set; }

        public String 物品名稱 
        {
            get
            {
                return 物品.名稱;
            }
        }

        public override void 檢查合法()
        {
           if(更新狀態 == 列舉.更新狀態.錯誤)
                throw new Exception(錯誤訊息);
        }
    }
}