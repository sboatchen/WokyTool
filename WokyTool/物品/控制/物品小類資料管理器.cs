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
    public class 物品小類資料管理器 : 可儲存資料管理器<物品小類資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.物品小類; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "設定/物品小類.json"; } }

        public override 物品小類資料 不篩選資料 { get { return 物品小類資料.不篩選; } }
        public override 物品小類資料 空白資料 { get { return 物品小類資料.空白; } }
        public override 物品小類資料 錯誤資料 { get { return 物品小類資料.錯誤; } }

        protected override 新版可篩選介面<物品小類資料> 取得篩選器實體()
        {
            return new 物品小類資料篩選();
        }

        // 獨體
        private static readonly 物品小類資料管理器 _獨體 = new 物品小類資料管理器();
        public static 物品小類資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 物品小類資料管理器()
        {
        }

        // 取得資料
        public 物品小類資料 取得(string 名稱_)
        {
            if (String.IsNullOrEmpty(名稱_) || 字串.無.Equals(名稱_))
                return 空白資料;

            return _資料書.Values.Where(Value => 名稱_.Equals(Value.名稱)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }
    }
}