﻿using System;
using System.Linq;
using System.Collections.Generic;
using WokyTool.通用;
using Newtonsoft.Json;
using System.IO;
using WokyTool.單品;

namespace WokyTool.平台訂單
{
    public class 平台訂單資料管理器 : 可整理記錄資料管理器<平台訂單資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.平台訂單; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "進度/平台訂單.json"; } }
        public override string 待整理資料夾路徑 { get { return "進度/平台訂單新增待整理"; } }

        public override 平台訂單資料 不篩選資料 { get { return null; } }
        public override 平台訂單資料 空白資料 { get { return 平台訂單資料.空白; } }
        public override 平台訂單資料 錯誤資料 { get { return 平台訂單資料.錯誤; } }

        protected override 新版可篩選介面<平台訂單資料> 取得篩選器實體()
        {
            return new 平台訂單資料篩選();
        }

        // 獨體
        private static readonly 平台訂單資料管理器 _獨體 = new 平台訂單資料管理器();
        public static 平台訂單資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 平台訂單資料管理器()
        {
        }

        public override void 新增(平台訂單資料 資料_)
        {
            base.新增(資料_);

            List<平台訂單資料> 資料列_ = new List<平台訂單資料>();
            資料列_.Add(資料_);

            單品資料管理器.獨體.更新庫存(資料列_);
        }

        public override void 新增(IEnumerable<平台訂單資料> 資料列舉_)
        {
            base.新增(資料列舉_);

            單品資料管理器.獨體.更新庫存(資料列舉_);
        }
    }
}

