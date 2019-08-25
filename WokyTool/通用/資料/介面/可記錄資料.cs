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
    public abstract class 新版可記錄資料<T> : 可編輯資料, 可編號介面 where T : 基本資料
    {
        [可匯出]
        [JsonProperty]
        public int 編號 { get; set; }

        protected string _副本;

        public virtual bool 編號是否合法()
        {
            return 編號 != 常數.新建資料編碼 && 編號 != 常數.錯誤資料編碼 && 編號 != 常數.不篩資料編碼;  //@@
        }

        public bool 編號是否有值()
        {
            return 編號 > 常數.新建資料編碼;
        }

        public override void BeginEdit()
        {
            if (_副本 == null)
                _副本 = this.ToString(false);
        }

        public override void CancelEdit()
        {
        }

        public override void EndEdit()
        {
            //@@todo    //更新編輯狀態()
        }

        public override void 取消編輯()
        {
            if (是否編輯中)
            {
                T 資料_ = _副本.轉成物件<T>();
                this.完全拷貝(資料_);

                _副本 = null;
            }
        }

        public override void 紀錄編輯(bool 是否列印_ = false)
        {
            if (是否列印_ && 是否編輯中)
            {
                訊息管理器.獨體.訊息("資料修改");

                訊息管理器.獨體.訊息(_副本);

                訊息管理器.獨體.訊息(this.ToString(false));

                訊息管理器.獨體.訊息("---------");
            }

            _副本 = null;
        }

        public override bool 更新編輯狀態()
        {
            if (_副本 == null)
            {
                是否編輯中 = false;
                return false;
            }

            string 資料_ = this.ToString(false);
            if (_副本.Equals(資料_))
            {
                _副本 = null;
                是否編輯中 = false;
                return false;
            }

            是否編輯中 = true;
            return true;
        }
    }
}
