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
    public abstract class 可封存資料 : 可編輯資料
    {
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
