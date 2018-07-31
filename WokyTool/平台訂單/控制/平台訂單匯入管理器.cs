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
        protected override void 匯入()
        {
            //平台訂單資料管理器.獨體.新增(可編輯BList.Select(Value => Value.匯入()));
        }
    }
}
