﻿using System;
using System.Linq;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.商品
{
    public class 商品小類資料管理器 : 可編號記錄資料管理器<商品小類資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.商品小類; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "設定/商品小類.json"; } }

        public override 商品小類資料 不篩選資料 { get { return 商品小類資料.不篩選; } }
        public override 商品小類資料 空白資料 { get { return 商品小類資料.空白; } }
        public override 商品小類資料 錯誤資料 { get { return 商品小類資料.錯誤; } }

        protected override 新版可篩選介面<商品小類資料> 取得篩選器實體()
        {
            return new 商品小類資料篩選();
        }

        // 獨體
        private static readonly 商品小類資料管理器 _獨體 = new 商品小類資料管理器();
        public static 商品小類資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 商品小類資料管理器()
        {
        }

        // 取得資料
        public 商品小類資料 取得(string 名稱_)
        {
            if (String.IsNullOrEmpty(名稱_) || 字串.無.Equals(名稱_))
                return 空白資料;

            return _資料書.Values.Where(Value => 名稱_.Equals(Value.名稱)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }
    }
}