using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 物品條碼更新匯入管理器 : 匯入資料管理器<物品條碼更新匯入資料>
    {
        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.是否允許修改基本資料;
            }
        }

        protected override void 匯入()
        {
            foreach(var Data_ in 可編輯BList){
                if (Data_.更新狀態 == 列舉.更新狀態.更新)
                    Data_.物品.條碼 = Data_.條碼;
            }

            物品資料管理器.獨體.資料異動();
        }
    }
}
