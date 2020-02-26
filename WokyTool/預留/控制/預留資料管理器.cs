using System;
using System.Collections.Generic;
using WokyTool.單品;
using WokyTool.通用;

namespace WokyTool.預留
{
    public class 預留資料管理器 : 可整理記錄資料管理器<預留資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.預留; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "進度/預留.json"; } }
        public override string 待整理資料夾路徑 { get { return "進度/預留新增待整理"; } }

        public override 預留資料 不篩選資料 { get { return null; } }
        public override 預留資料 空白資料 { get { return 預留資料.空白; } }
        public override 預留資料 錯誤資料 { get { return 預留資料.錯誤; } }

        protected override 新版可篩選介面<預留資料> 取得篩選器實體()
        {
            return new 預留資料篩選();
        }

        // 獨體
        private static readonly 預留資料管理器 _獨體 = new 預留資料管理器();
        public static 預留資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 預留資料管理器()
        {
        }

        public override void 新增(預留資料 資料_)
        {
            base.新增(資料_);

            更新();
        }

        public override void 新增(IEnumerable<預留資料> 資料列舉_)
        {
            base.新增(資料列舉_);

            更新();
        }

        public void 更新()
        {
            單品資料管理器.獨體.更新保留();
        }
    }
}

