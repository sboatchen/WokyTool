using System;
using System.Linq;
using System.Collections.Generic;
using WokyTool.通用;
using Newtonsoft.Json;

namespace WokyTool.進貨
{
    public class 進貨新增資料管理器 : 可暫存資料管理器<進貨新增資料>
    {
        public override bool 是否可編輯 { get { return 系統參數.匯入進貨; } }

        protected override 新版可篩選介面<進貨新增資料> 取得篩選器實體()
        {
            return new 進貨新增資料篩選();
        }

        // 獨體
        private static readonly 進貨新增資料管理器 _獨體 = new 進貨新增資料管理器();
        public static 進貨新增資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 進貨新增資料管理器()
        {
        }

        public override void 完成編輯(bool 是否紀錄_)
        {
            if (是否紀錄_)
            {
                例外檢查器 例外檢查器_ = new 例外檢查器();
                合法檢查(例外檢查器_);

                foreach (進貨新增資料 資料_ in 資料列)
                {
                    資料_.紀錄編輯(true);
                }

                List<進貨資料> 完成資料列_ = 資料列.Select(Value => 進貨資料.建立(Value)).ToList();
                進貨資料管理器.獨體.待整理(完成資料列_);

                資料列.Clear();
                資料版本++;
            }
        }
    }
}

