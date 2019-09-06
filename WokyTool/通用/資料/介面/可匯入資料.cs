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
    public abstract class 新版可匯入資料<T> : 可編輯資料, 可初始化介面, 可記錄錯誤介面 where T : 可編輯資料
    {
        [可匯出]
        [JsonProperty]
        public string 錯誤訊息 { get; set; }

        /********************************/

        public T 新增資料 { get; protected set; }

        /********************************/

        public 新版可匯入資料()
        {
            新增資料 = (T)Activator.CreateInstance(typeof(T));
        }

        public virtual void 初始化()
        {
            是否編輯中 = true;
            更新編輯狀態();
        }

        public override void BeginEdit()
        {
        }

        public override void CancelEdit()
        {
        }

        public override void EndEdit()
        {
            更新編輯狀態();
        }

        private static 可檢查介面 更新檢查器 = new 錯誤訊息檢查器();
        public override bool 更新編輯狀態()
        {
            合法檢查(更新檢查器);
            return true;
        }

        public override void 取消編輯()
        {
        }

        public override void 紀錄編輯(bool 是否列印_ = false)
        {
            if (是否列印_)
            {
                訊息管理器.獨體.訊息("資料新增");
                訊息管理器.獨體.訊息(新增資料.ToString(false));
                訊息管理器.獨體.訊息("---------");
            }
        }

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            錯誤訊息 = null;
            新增資料.合法檢查(檢查器_, 資料_);
        }
    }
}
