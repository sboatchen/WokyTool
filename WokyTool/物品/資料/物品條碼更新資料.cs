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
    public class 物品條碼更新資料 : 靜態匯入資料
    {
        [JsonProperty]
        public string 縮寫 { get; set; }

        [JsonProperty]
        public string 條碼 { get; set; }

        [JsonProperty]
        public 列舉.更新狀態 狀態 { get; set; }

        [JsonProperty]
        public string 更新訊息 { get; set; }

        public 物品資料 目標物品 { get; set; }

        /********************************/

        override public void 檢查合法()
        {
            if (狀態 == 列舉.更新狀態.錯誤)
                throw new Exception("物品條碼更新資料::資料不合法" + this.ToString());
        }

        override public void 初始化()
        {
            if (String.IsNullOrEmpty(縮寫) == true)
            {
                狀態 = 列舉.更新狀態.錯誤;
                更新訊息 = 字串.名稱不合法;
                return;
            }

            目標物品 = 物品資料管理器.獨體.GetBySName(縮寫);
            if (目標物品 == 物品資料.ERROR)
            {
                狀態 = 列舉.更新狀態.錯誤;
                更新訊息 = 字串.物件不存在;
                return;
            }

            if (條碼 == 目標物品.條碼)
                狀態 = 列舉.更新狀態.相同;
            else if (條碼 != null && 條碼.CompareTo(目標物品.條碼) == 0)
                狀態 = 列舉.更新狀態.相同;
            else 
                狀態 = 列舉.更新狀態.更新;
        }

        override public void 更新()
        {
            if (狀態 != 列舉.更新狀態.更新)
                return;

            目標物品.條碼 = 條碼;
        }
    }
}