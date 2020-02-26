using System.Collections.Generic;
using WokyTool.單品;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.寄庫
{
    public class 寄庫資料管理器 : 可整理記錄資料管理器<寄庫資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.寄庫; } }

        public override bool 是否可編輯 { get { return 系統參數.匯入進貨; } }

        public override string 檔案路徑 { get { return "進度/寄庫.json"; } }
        public override string 待整理資料夾路徑 { get { return "進度/寄庫待整理"; } }

        public override 寄庫資料 不篩選資料 { get { return null; } }
        public override 寄庫資料 空白資料 { get { return 寄庫資料.空白; } }
        public override 寄庫資料 錯誤資料 { get { return 寄庫資料.錯誤; } }

        protected override 新版可篩選介面<寄庫資料> 取得篩選器實體()
        {
            return new 寄庫資料篩選();
        }

        // 獨體
        private static readonly 寄庫資料管理器 _獨體 = new 寄庫資料管理器();
        public static 寄庫資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 寄庫資料管理器()
        {
        }

        public override void 新增(寄庫資料 資料_)
        {
            base.新增(資料_);

            商品資料管理器.獨體.更新庫存(資料_.取得列舉());
            單品資料管理器.獨體.更新庫存(資料_.取得列舉());
        }

        public override void 新增(IEnumerable<寄庫資料> 資料列舉_)
        {
            base.新增(資料列舉_);

            商品資料管理器.獨體.更新庫存(資料列舉_);
            單品資料管理器.獨體.更新庫存(資料列舉_);
        }
    }
}
