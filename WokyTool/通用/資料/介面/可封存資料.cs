using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class 可封存資料 : 可編輯資料
    {
        [JsonProperty]
        public DateTime 處理時間 { get; set; }

        [JsonProperty]
        public string 更新者 { get; set; }

        public 可封存資料()
        {
            處理時間 = DateTime.Now;
            更新者 = 系統參數.使用者名稱;
        }

        public override void 取消編輯()
        {
        }

        public override void 紀錄編輯(bool 是否列印_ = false)
        {
        }

        public override bool 更新編輯狀態()
        {
            return false;
        }
    }
}
