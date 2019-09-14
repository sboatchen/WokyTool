using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.盤點
{
    public class 盤點更新資料管理器 : 可更新資料管理器<盤點更新資料, 盤點資料>
    {
        public override bool 是否自動存檔 { get { return false; } }

        protected override 新版可篩選介面<盤點更新資料> 取得篩選器實體()
        {
            return new 盤點更新資料篩選();
        }

        protected override 可編號記錄資料管理器<盤點資料> 記錄器 { get { return 盤點資料管理器.獨體; } }

        // 建構子
        public 盤點更新資料管理器()
        {
        }
    }
}
