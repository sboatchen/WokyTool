using System;
using System.Linq;
using System.Collections.Generic;
using WokyTool.通用;
using Newtonsoft.Json;
using System.IO;
using WokyTool.單品;

namespace WokyTool.配送
{
    public class 配送資料管理器 : 可整理記錄資料管理器<配送資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.配送; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "進度/配送.json"; } }
        public override string 待整理資料夾路徑 { get { return "進度/配送新增待整理"; } }

        public override 配送資料 不篩選資料 { get { return null; } }
        public override 配送資料 空白資料 { get { return 配送資料.空白; } }
        public override 配送資料 錯誤資料 { get { return 配送資料.錯誤; } }

        protected override 新版可篩選介面<配送資料> 取得篩選器實體()
        {
            return null;// new 配送資料篩選();
        }

        // 獨體
        private static readonly 配送資料管理器 _獨體 = new 配送資料管理器();
        public static 配送資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 配送資料管理器()
        {
        }
    }
}

