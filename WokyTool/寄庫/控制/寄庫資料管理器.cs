using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.寄庫
{
    public class 寄庫資料管理器 //: 可編號記錄資料管理器<寄庫資料>
    {
        /*public string 暫存路徑 { get { return String.Format("進度/寄庫"); } }
        public override string 檔案路徑 { get { return String.Format("封存/寄庫/{0}.json", 時間.目前月); } }

        protected override 新版可篩選介面<寄庫資料> 取得篩選器實體()
        {
            return new 寄庫資料篩選();
        }

        // 獨體
        private static readonly 寄庫資料管理器 _獨體 = new 寄庫資料管理器();
        public static 寄庫資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 寄庫資料管理器()
        {
        }

        public override void 完成編輯(bool 是否紀錄_)
        {
            if (是否紀錄_)
            {
                例外檢查器 例外檢查器_ = new 例外檢查器();
                合法檢查(例外檢查器_);

                foreach (寄庫資料 資料_ in 資料列)
                {
                    資料_.紀錄編輯(true);
                }

                檔案.寫入(檔案路徑, JsonConvert.SerializeObject(資料列, Formatting.Indented), false);

                // 更新庫存
                商品資料管理器.獨體.更新庫存(資料列);
                物品資料管理器.獨體.更新庫存(資料列);

                資料列.Clear();
                資料版本++;
            }
        }*/
    }
}

