using System;
using System.Linq;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.參數
{
    public class 參數資料管理器 : 可記錄資料管理器<參數資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.參數; } }

        public override bool 是否可編輯 { get { return 系統參數.修改基本資料; } }

        public override string 檔案路徑 { get { return "設定/參數.json"; } }

        public override 參數資料 不篩選資料 { get { return null; } }
        public override 參數資料 空白資料 { get { return 參數資料.空白; } }
        public override 參數資料 錯誤資料 { get { return 參數資料.錯誤; } }

        protected override 新版可篩選介面<參數資料> 取得篩選器實體()
        {
            return new 參數資料篩選();
        }

        // 獨體
        private static readonly 參數資料管理器 _獨體 = new 參數資料管理器();
        public static 參數資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 參數資料管理器() : base()
        {
            系統參數.訊息路徑 = 取得("訊息路徑").參數;
            系統參數.備份路徑 = 取得("備份路徑").參數;
        }

        // 取得資料
        public 參數資料 取得(string 名稱_)
        {
            if (String.IsNullOrEmpty(名稱_) || 字串.無.Equals(名稱_))
                return 空白資料;

            return _資料列.Where(Value => 名稱_.Equals(Value.名稱)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }
    }
}
