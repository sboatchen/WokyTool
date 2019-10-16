using System;
using System.Linq;
using System.Collections.Generic;
using WokyTool.通用;
using Newtonsoft.Json;

namespace WokyTool.一般訂單
{
    public class 一般訂單新增資料管理器 : 可記錄資料管理器<一般訂單新增資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.一般訂單新增; } }

        public override bool 是否可編輯 { get { return 系統參數.匯入訂單; } }

        public override string 檔案路徑 { get { return String.Format("進度/一般訂單新增/{0}.json", 系統參數.使用者名稱); } }

        public override 一般訂單新增資料 不篩選資料 { get { return null; } }
        public override 一般訂單新增資料 空白資料 { get { return 一般訂單新增資料.空白; } }
        public override 一般訂單新增資料 錯誤資料 { get { return 一般訂單新增資料.錯誤; } }

        protected override 新版可篩選介面<一般訂單新增資料> 取得篩選器實體()
        {
            return new 一般訂單新增資料篩選();
        }

        // 獨體
        private static readonly 一般訂單新增資料管理器 _獨體 = new 一般訂單新增資料管理器();
        public static 一般訂單新增資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 一般訂單新增資料管理器()
        {
        }

        public void 完成()
        {
            var Query_ = _資料列.Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.配送).Select(Value => 一般訂單資料.建立(Value).ToList()).ToList();
            List<一般訂單資料> 完成資料列_ = new List<一般訂單資料>();
            foreach (var List_ in Query_)
            {
                完成資料列_.AddRange(List_);
            }

            一般訂單資料管理器.獨體.待整理(完成資料列_);

            _資料列.RemoveAll(Value => Value.處理狀態 == 列舉.訂單處理狀態.配送 || Value.處理狀態 == 列舉.訂單處理狀態.忽略);
            資料版本++;
        }
    }
}

