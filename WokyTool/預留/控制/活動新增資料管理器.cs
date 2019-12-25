using System;
using System.Linq;
using System.Collections.Generic;
using WokyTool.通用;
using Newtonsoft.Json;

namespace WokyTool.活動
{
    public class 活動新增資料管理器 : 可暫存資料管理器<活動資料>
    {
        public override bool 是否可編輯 { get { return 系統參數.匯入進貨; } }

        protected override 新版可篩選介面<活動資料> 取得篩選器實體()
        {
            return new 活動資料篩選();
        }

        // 獨體
        private static readonly 活動新增資料管理器 _獨體 = new 活動新增資料管理器();
        public static 活動新增資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 活動新增資料管理器()
        {
        }

        public override void 完成編輯(bool 是否紀錄_)
        {
            if (是否紀錄_)
            {
                例外檢查器 例外檢查器_ = new 例外檢查器();
                合法檢查(例外檢查器_);

                foreach (活動資料 資料_ in 資料列)
                {
                    資料_.紀錄編輯(true);
                }

                活動資料管理器.獨體.待整理(資料列);

                資料列.Clear();
                資料版本++;
            }
        }
    }
}

