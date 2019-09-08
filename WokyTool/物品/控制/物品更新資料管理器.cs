using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 物品更新資料管理器 : 可更新資料管理器<物品更新資料, 物品資料>
    {
        protected override 新版可篩選介面<物品更新資料> 取得篩選器實體()
        {
            return new 物品更新資料篩選();
        }

        protected override 可編號記錄資料管理器<物品資料> 儲存器 { get { return 物品資料管理器.獨體; } }

        // 建構子
        public 物品更新資料管理器()
        {
        }
    }
}