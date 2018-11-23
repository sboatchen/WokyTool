using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.發票
{
    public class 發票匯入管理器 : 匯入資料管理器<發票匯入資料>
    {
        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.修改設定資料;
            }
        }

        protected override void 匯入()
        {
            //發票資料管理器.獨體.新增(可編輯BList.Select(Value => 建立資料(Value)));
        }
    }
}
