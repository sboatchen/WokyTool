using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單新增匯入資料管理器 : 可轉換資料管理器<平台訂單新增匯入資料, 平台訂單新增資料>
    {
        protected override 新版可篩選介面<平台訂單新增匯入資料> 取得篩選器實體()
        {
            return new 平台訂單新增匯入資料篩選();
        }

        protected override 可新增介面<平台訂單新增資料> 記錄器
        {
            get { return 平台訂單新增資料管理器.獨體; }
        }

        // 建構子
        public 平台訂單新增匯入資料管理器()
        {
        }
    }
}
