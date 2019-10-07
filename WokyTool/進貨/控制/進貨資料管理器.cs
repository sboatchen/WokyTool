using System.Collections.Generic;
using WokyTool.通用;
using WokyTool.物品;

namespace WokyTool.進貨
{
    public class 進貨資料管理器 : 可整理記錄資料管理器<進貨資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.進貨; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "進度/進貨.json"; } }
        public override string 待整理資料夾路徑 { get { return "進度/進貨新增待整理"; } }

        public override 進貨資料 不篩選資料 { get { return null; } }
        public override 進貨資料 空白資料 { get { return 進貨資料.空白; } }
        public override 進貨資料 錯誤資料 { get { return 進貨資料.錯誤; } }

        protected override 新版可篩選介面<進貨資料> 取得篩選器實體()
        {
            return new 進貨資料篩選();
        }

        // 獨體
        private static readonly 進貨資料管理器 _獨體 = new 進貨資料管理器();
        public static 進貨資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 進貨資料管理器()
        {
        }

        public override void 新增(進貨資料 資料_)
        {
            base.新增(資料_);

            List<進貨資料> 資料列_ = new List<進貨資料>();
            資料列_.Add(資料_);

            物品資料管理器.獨體.更新庫存(資料列_);
        }

        public override void 新增(IEnumerable<進貨資料> 資料列舉_)
        {
            base.新增(資料列舉_);

            物品資料管理器.獨體.更新庫存(資料列舉_);
        }
    }
}

