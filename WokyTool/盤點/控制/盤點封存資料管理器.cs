using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.庫存;
using WokyTool.通用;

namespace WokyTool.盤點
{
    public class 盤點封存資料管理器 : 可封存資料管理器<盤點封存資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.盤點封存; } }

        public override string 檔案路徑 { get { return String.Format("封存/盤點/{0}_{1}.json", 系統參數.使用者名稱, 時間.目前完整時間); } }

        protected override 新版可篩選介面<盤點封存資料> 取得篩選器實體()
        {
            return new 盤點封存資料篩選();
        }

        // 獨體
        private static readonly 盤點封存資料管理器 _獨體 = new 盤點封存資料管理器();
        public static 盤點封存資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 盤點封存資料管理器()
        {
        }
    }
}

