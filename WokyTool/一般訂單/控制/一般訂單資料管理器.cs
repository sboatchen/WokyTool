using System.Collections.Generic;
using WokyTool.通用;
using WokyTool.物品;

namespace WokyTool.一般訂單
{
    public class 一般訂單資料管理器 : 可整理記錄資料管理器<一般訂單資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.一般訂單; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "進度/一般訂單.json"; } }
        public override string 待整理資料夾路徑 { get { return "進度/一般訂單新增待整理"; } }

        public override 一般訂單資料 不篩選資料 { get { return null; } }
        public override 一般訂單資料 空白資料 { get { return 一般訂單資料.空白; } }
        public override 一般訂單資料 錯誤資料 { get { return 一般訂單資料.錯誤; } }

        protected override 新版可篩選介面<一般訂單資料> 取得篩選器實體()
        {
            return new 一般訂單資料篩選();
        }

        // 獨體
        private static readonly 一般訂單資料管理器 _獨體 = new 一般訂單資料管理器();
        public static 一般訂單資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 一般訂單資料管理器()
        {
        }

        public override void 新增(一般訂單資料 資料_)
        {
            base.新增(資料_);

            List<一般訂單資料> 資料列_ = new List<一般訂單資料>();
            資料列_.Add(資料_);

            物品資料管理器.獨體.更新庫存(資料列_);
        }

        public override void 新增(IEnumerable<一般訂單資料> 資料列舉_)
        {
            base.新增(資料列舉_);

            物品資料管理器.獨體.更新庫存(資料列舉_);
        }
    }
}

