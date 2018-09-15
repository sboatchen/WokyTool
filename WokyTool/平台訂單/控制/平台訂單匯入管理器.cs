using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單匯入管理器 : 匯入資料管理器<平台訂單匯入資料>
    {
        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.匯入訂單;
            }
        }

        protected override void 匯入()
        {
            平台訂單新增資料管理器.獨體.新增(可編輯BList.Select(Value => 平台訂單新增資料.新增(Value)));
        }
    }
}
