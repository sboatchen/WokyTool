using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 配送轉換資料管理器 : 可暫存資料管理器<配送轉換資料>
    {
        protected override 新版可篩選介面<配送轉換資料> 取得篩選器實體()
        {
            return new 配送轉換資料篩選();
        }

        // 建構子
        public 配送轉換資料管理器()
        {
        }

        public override void 完成編輯(bool 是否紀錄_)
        {
            if (是否紀錄_)
            {
                var 待封存資料列_ = 資料列.Where(Value => Value.更新來源()).ToList();
                if (待封存資料列_.Count == 0)
                    return;

                例外檢查器 例外檢查器_ = new 例外檢查器();
                待封存資料列_.執行(Value => Value.合法檢查(例外檢查器_));

                foreach (配送轉換資料 資料_ in 待封存資料列_)
                {
                    資料_.紀錄編輯(true);
                }

                List<配送資料> 完成資料列_ = 待封存資料列_.Select(Value => Value.轉換).ToList();
                配送資料管理器.獨體.待整理(完成資料列_);
            }
        }
    }
}
