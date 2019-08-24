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
    public abstract class 新版可匯入資料<T> : 可編輯資料<T>, 可初始化介面 where T : 基本資料
    {
        [可匯出]
        [JsonProperty]
        public string 錯誤訊息 { get; set; }

        public virtual void 初始化()
        {
            是否編輯中 = true;
        }

        public override void BeginEdit()
        {
        }

        public override void 取消編輯()
        {
        }

        public override void 紀錄編輯(bool 是否列印_ = false)
        {
        }

        public override bool 更新編輯狀態()
        {
            是否編輯中 = true;
            return true;
        }
    }
}
