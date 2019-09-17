using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 配送轉換資料管理器 : 可暫存資料管理器<配送轉換資料>
    {
        public string 檔案路徑 { get { return String.Format("進度/配送/{0}_{1}.json", 系統參數.使用者名稱, 時間.目前完整時間); } }

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

                例外檢查器 例外檢查器_ = new 例外檢查器();
                待封存資料列_.執行(Value => Value.合法檢查(例外檢查器_));

                foreach (配送轉換資料 資料_ in 待封存資料列_)
                {
                    資料_.紀錄編輯(true);
                }

                //@@ 庫存調整

                檔案.寫入(檔案路徑, JsonConvert.SerializeObject(檔案路徑, Formatting.Indented), false);
            }
        }
    }
}
