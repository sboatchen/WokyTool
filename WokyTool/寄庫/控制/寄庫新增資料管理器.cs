using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.寄庫
{
    public class 寄庫新增資料管理器 : 可記錄資料管理器<寄庫新增資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.寄庫新增; } }

        public override bool 是否可編輯 { get { return 系統參數.匯入訂單; } }    //@@ 新增更新庫存

        public override string 檔案路徑 { get { return String.Format("進度/寄庫待封存/{0}_{1}.json", 系統參數.使用者名稱, 時間.目前完整時間); } }

        public override 寄庫新增資料 不篩選資料 { get { return null; } }
        public override 寄庫新增資料 空白資料 { get { return 寄庫新增資料.空白; } }
        public override 寄庫新增資料 錯誤資料 { get { return 寄庫新增資料.錯誤; } }

        protected override 新版可篩選介面<寄庫新增資料> 取得篩選器實體()
        {
            return new 寄庫新增資料篩選();
        }

        // 獨體
        private static readonly 寄庫新增資料管理器 _獨體 = new 寄庫新增資料管理器();
        public static 寄庫新增資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 寄庫新增資料管理器()
        {
        }

        protected override void 初始化資料()
        {
            _資料列 = new List<寄庫新增資料>();
        }

        // 儲存檔案
        public override void 儲存()
        {
            if (_資料列.Count != 0)
            {
                _目前資料列版本 = 資料版本;

                // 更新資料
                檔案.寫入(檔案路徑, JsonConvert.SerializeObject(_資料列, Formatting.Indented), 是否加密);

                _資料列.Clear();
            }
        }
    }
}

