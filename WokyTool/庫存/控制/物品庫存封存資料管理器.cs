﻿using System;
using WokyTool.通用;

namespace WokyTool.庫存
{
    public class 單品庫存封存資料管理器 : 可封存資料管理器<單品庫存封存資料>
    {
        public override string 檔案路徑 { get { return String.Format("進度/單品庫存/{0}_{1}.json", 系統參數.使用者名稱, 時間.目前完整時間); } }

        protected override 新版可篩選介面<單品庫存封存資料> 取得篩選器實體()
        {
            return new 單品庫存封存資料篩選();
        }

        // 獨體
        private static readonly 單品庫存封存資料管理器 _獨體 = new 單品庫存封存資料管理器();
        public static 單品庫存封存資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 單品庫存封存資料管理器()
        {
        }
    }
}

