using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳匯入管理器 : 匯入資料管理器<月結帳匯入資料>
    {
        public override bool 是否可編輯
        {
            get
            {
                return true;
            }
        }

        protected override void 匯入()
        {
            月結帳資料管理器.獨體.新增(可編輯BList.Select(Value => Value.匯入()));
        }
    }
}
