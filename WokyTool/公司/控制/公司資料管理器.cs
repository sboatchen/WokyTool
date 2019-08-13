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

namespace WokyTool.公司
{
    public class 公司資料管理器 : 可儲存資料管理器<公司資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.公司; } }

        public override bool 是否可編輯 { get { return 系統參數.修改基本資料; } }

        public override string 檔案路徑 { get { return "設定/公司.json"; } }

        public override 公司資料 空白資料 { get { return 公司資料.空白; } }
        public override 公司資料 錯誤資料 { get { return 公司資料.錯誤; } }

        protected override 新版可篩選介面<公司資料> 取得篩選介面()
        {
            return new 公司資料篩選();
        }

        // 獨體
        private static readonly 公司資料管理器 _獨體 = new 公司資料管理器();
        public static 公司資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 公司資料管理器()
        {
        }

        // 取得資料
        public 公司資料 取得(string 名稱_)
        {
            if (String.IsNullOrEmpty(名稱_))
                return 錯誤資料;

            公司資料 資料_ = _資料書.Values
                                   .Where(Value => 名稱_.Equals(Value.名稱))
                                   .FirstOrDefault();

            if (資料_ == null)
                return 錯誤資料;
            else
                return 資料_;
        }
    }
}
