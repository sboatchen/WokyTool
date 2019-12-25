using System;
using System.Collections.Generic;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.活動
{
    public class 活動資料管理器 : 可整理記錄資料管理器<活動資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.活動; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "進度/活動.json"; } }
        public override string 待整理資料夾路徑 { get { return "進度/活動新增待整理"; } }

        public override 活動資料 不篩選資料 { get { return null; } }
        public override 活動資料 空白資料 { get { return 活動資料.空白; } }
        public override 活動資料 錯誤資料 { get { return 活動資料.錯誤; } }

        protected override 新版可篩選介面<活動資料> 取得篩選器實體()
        {
            return new 活動資料篩選();
        }

        // 獨體
        private static readonly 活動資料管理器 _獨體 = new 活動資料管理器();
        public static 活動資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 活動資料管理器()
        {
        }

        public override void 新增(活動資料 資料_)
        {
            base.新增(資料_);

            更新();
        }

        public override void 新增(IEnumerable<活動資料> 資料列舉_)
        {
            base.新增(資料列舉_);

            更新();
        }

        public void 更新()
        {
            物品資料管理器.獨體.更新保留();
        }
    }
}

