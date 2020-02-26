using Newtonsoft.Json;
using System;
using System.Linq;
using WokyTool.Common;
using WokyTool.單品;
using WokyTool.通用;

namespace WokyTool.盤點
{
    public class 盤點資料管理器 : 可編號記錄資料管理器<盤點資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.盤點; } }

        public override bool 是否備份 { get { return false; } }
        public override bool 是否可編輯 { get { return 系統參數.匯入進貨; } }

        public override string 檔案路徑 { get { return String.Format("封存/盤點/{0}_{1}.json", 系統參數.使用者名稱, 時間.目前完整時間); } }

        public override 盤點資料 不篩選資料 { get { return null; } }
        public override 盤點資料 空白資料 { get { return 盤點資料.空白; } }
        public override 盤點資料 錯誤資料 { get { return 盤點資料.錯誤; } }

        protected override 新版可篩選介面<盤點資料> 取得篩選器實體()
        {
            return new 盤點資料篩選();
        }

        // 獨體
        private static readonly 盤點資料管理器 _獨體 = new 盤點資料管理器();
        public static 盤點資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 盤點資料管理器()
        {
        }

        protected override void 初始化資料()
        {
            _資料書 = 單品資料管理器.獨體.資料列舉2.ToDictionary(Value => Value.編號, Value => 盤點資料.建立(Value));
            資料版本++;
        }

        // 取得資料
        public 盤點資料 取得(string 名稱_)
        {
            if (String.IsNullOrEmpty(名稱_) || 字串.無.Equals(名稱_))
                return 空白資料;

            return _資料書.Values.Where(Value => 名稱_.Equals(Value.單品.名稱) || 名稱_.Equals(Value.單品.縮寫)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }

        // 儲存檔案
        public override void 儲存()
        {
            if (_目前資料書版本 != 資料版本)
            {
                _目前資料書版本 = 資料版本;

                // 紀錄盤點資料
                var 盤點封存資料列_ = _資料書.Select(Pair => new 盤點封存轉換(Pair.Value)).ToList();
                檔案.寫入(檔案路徑, JsonConvert.SerializeObject(盤點封存資料列_, Formatting.Indented), false);

                // 更新庫存
                單品資料管理器.獨體.更新庫存(_資料書.Select(Pair => Pair.Value));
            }
        }
    }
}

