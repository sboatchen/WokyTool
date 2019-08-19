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
    public class 物品條碼更新匯入資料 : 靜態匯入資料
    {
        [JsonProperty]
        public string 物品縮寫識別 { get; set; }

        protected 物品資料 _物品;
        public 物品資料 物品
        {
            get
            {
                if (_物品 == null)
                    _物品 = 物品資料.空白;
                else if (物品資料管理器.獨體.包含(_物品) == false)
                    _物品 = 物品資料.錯誤;

                return _物品;
            }
            set
            {
                _物品 = value;
            }
        }

        [JsonProperty]
        public string 條碼 { get; set; }

        [JsonProperty]
        public 列舉.更新狀態 更新狀態 { get; protected set; }

        /********************************/

        public override void 初始化()
        {
            物品 = 物品資料管理器.獨體.取得(物品縮寫識別);

            if (條碼 == _物品.條碼)
                更新狀態 = 列舉.更新狀態.相同;
            else if (條碼 != null && 條碼.CompareTo(_物品.條碼) == 0)
                更新狀態 = 列舉.更新狀態.相同;
            else
                更新狀態 = 列舉.更新狀態.更新;
        }

        public override void 檢查合法()
        {
            if (物品.編號是否有值() == false)
            {
                更新狀態 = 列舉.更新狀態.錯誤;
                throw new Exception("物品不合法");
            }

            if (條碼 == _物品.條碼)
                更新狀態 = 列舉.更新狀態.相同;
            else if (條碼 != null && 條碼.CompareTo(_物品.條碼) == 0)
                更新狀態 = 列舉.更新狀態.相同;
            else
                更新狀態 = 列舉.更新狀態.更新;
        }
    }
}