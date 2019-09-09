using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 配送轉換資料管理器 : 可轉換資料管理器<配送轉換資料, 配送資料>
    {
        protected override 新版可篩選介面<配送轉換資料> 取得篩選器實體()
        {
            return new 配送轉換資料篩選();
        }

        protected override 可新增介面<配送資料> 記錄器
        {
            get { return null;/*@@平台訂單新增資料管理器.獨體;*/ }
        }

        // 建構子
        public 配送轉換資料管理器()
        {
        }
    }
}
