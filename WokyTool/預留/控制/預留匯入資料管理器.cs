﻿using WokyTool.通用;

namespace WokyTool.預留
{
    public class 預留匯入資料管理器 : 可轉換資料管理器<預留匯入資料, 預留資料>
    {
        public override bool 是否自動存檔 { get { return false; } }

        protected override 新版可篩選介面<預留匯入資料> 取得篩選器實體()
        {
            return new 預留匯入資料篩選();
        }

        protected override 可新增介面<預留資料> 記錄器
        {
            get { return 預留新增資料管理器.獨體; }
        }

        // 建構子
        public 預留匯入資料管理器()
        {
        }
    }
}
