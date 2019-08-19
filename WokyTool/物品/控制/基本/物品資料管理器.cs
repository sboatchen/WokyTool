using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 物品資料管理器 : 可儲存資料管理器<物品資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.物品; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "設定/物品.json"; } }

        public override 物品資料 空白資料 { get { return 物品資料.空白; } }
        public override 物品資料 錯誤資料 { get { return 物品資料.錯誤; } }

        protected override 新版可篩選介面<物品資料> 取得篩選介面()
        {
            return new 物品資料篩選();
        }

        // 獨體
        private static readonly 物品資料管理器 _獨體 = new 物品資料管理器();
        public static 物品資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 物品資料管理器()
        {
        }

        // 取得資料
        public 物品資料 取得(string 名稱_)
        {
            if (String.IsNullOrEmpty(名稱_) || 字串.無.Equals(名稱_))
                return 空白資料;

            物品資料 資料_ = _資料書.Values
                                   .Where(Value => 名稱_.Equals(Value.名稱) || 名稱_.Equals(Value.縮寫))
                                   .FirstOrDefault();

            if (資料_ == null)
                return 錯誤資料;
            else
                return 資料_;
        }

        // 取得資料
        public 物品資料 取得_條碼(string 條碼_)
        {
            if (String.IsNullOrEmpty(條碼_))
                return 空白資料;

            物品資料 資料_ = _資料書.Values
                                .Where(Value => 條碼_.Equals(Value.條碼))
                                .FirstOrDefault();

            if (資料_ == null)
                return 錯誤資料;
            else
                return 資料_;
        }
    }
}