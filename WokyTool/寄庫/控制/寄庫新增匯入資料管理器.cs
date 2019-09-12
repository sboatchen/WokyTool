using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.寄庫
{
    public class 寄庫新增匯入資料管理器 : 可匯入資料管理器<寄庫新增匯入資料, 寄庫新增資料>
    {
        public override bool 是否自動存檔 { get { return false; } }

        protected override 新版可篩選介面<寄庫新增匯入資料> 取得篩選器實體()
        {
            return new 寄庫新增匯入資料篩選();
        }

        protected override 可新增介面<寄庫新增資料> 記錄器
        {
            get { return 寄庫新增資料管理器.獨體; }
        }

        // 建構子
        public 寄庫新增匯入資料管理器()
        {
        }
    }
}
