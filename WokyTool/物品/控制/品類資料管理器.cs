using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 品類資料管理器 : 可編號記錄資料管理器<品類資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.品類; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "設定/品類.json"; } }

        public override 品類資料 不篩選資料 { get { return 品類資料.不篩選; } }
        public override 品類資料 空白資料 { get { return 品類資料.空白; } }
        public override 品類資料 錯誤資料 { get { return 品類資料.錯誤; } }

        protected override IEnumerable<品類資料> 取得清單特殊選項()
        {
            yield return 品類資料.混和;
            yield return 空白資料;
            yield return 錯誤資料;
        }

        protected override IEnumerable<品類資料> 取得篩選特殊選項()
        {
            yield return 不篩選資料;
            yield return 品類資料.混和;
            yield return 空白資料;
            yield return 錯誤資料;
        }

        protected override 新版可篩選介面<品類資料> 取得篩選器實體()
        {
            return new 品類資料篩選();
        }

        // 獨體
        private static readonly 品類資料管理器 _獨體 = new 品類資料管理器();
        public static 品類資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 品類資料管理器()
        {
        }

        protected override void 初始化資料()
        {
            if (File.Exists("設定/品類.json"))
                base.初始化資料();
            else
            {
                string json = 檔案.讀出("設定/物品大類.json");
                if (String.IsNullOrEmpty(json))
                    _資料書 = new Dictionary<int, 品類資料>();
                else
                    _資料書 = JsonConvert.DeserializeObject<Dictionary<int, 品類資料>>(json);

                if (_資料書.Count == 0)
                    _下個編號 = 1;
                else
                    _下個編號 = _資料書.Max(Value => Value.Key) + 1;

                資料版本++;
                儲存();
            }
        }

        public override 品類資料 取得(int ID_)
        {
            if (ID_ == 常數.空白資料編碼)
                return 空白資料;

            if (ID_ == 常數.錯誤資料編碼)
                return 錯誤資料;

            if (ID_ == 常數.混和資料編碼)
                return 品類資料.混和;

            品類資料 Item_;
            if (_資料書.TryGetValue(ID_, out Item_))
            {
                return Item_;
            }

            return 錯誤資料;
        }

        // 取得資料
        public 品類資料 取得(string 名稱_)
        {
            if (String.IsNullOrEmpty(名稱_) || 字串.無.Equals(名稱_))
                return 空白資料;

            return _資料書.Values.Where(Value => 名稱_.Equals(Value.名稱)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }
    }
}