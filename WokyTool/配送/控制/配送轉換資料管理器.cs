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
    public class 配送轉換資料管理器 : 可轉換資料管理器<配送轉換資料, 配送資料>
    {
        protected override 新版可篩選介面<配送轉換資料> 取得篩選器實體()
        {
            return new 配送轉換資料篩選();
        }

        protected override 可新增介面<配送資料> 記錄器
        {
            get { return null; }
        }

        public string 封存檔案路徑 { get { return String.Format("進度/配送待封存/{0}_{1}.json", 系統參數.使用者名稱, 時間.目前完整時間); } }  //@@ 是否抽成獨立管理氣

        // 建構子
        public 配送轉換資料管理器()
        {
        }

        public override void 完成編輯(bool 是否紀錄_)
        {
            if (是否紀錄_)
            {
                var 待封存資料列_ = 資料列.Where(Value => Value.更新來源()).ToList();


                待封存資料列_.執行(Value => Value.合法檢查(新增物件檢查器));

                foreach (配送轉換資料 資料_ in 待封存資料列_)
                {
                    資料_.紀錄編輯(true);
                }

                檔案.寫入(封存檔案路徑, JsonConvert.SerializeObject(待封存資料列_, Formatting.Indented), false);
            }
        }
    }
}
