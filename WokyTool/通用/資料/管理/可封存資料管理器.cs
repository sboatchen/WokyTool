using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WokyTool.通用
{
    public abstract class 可封存資料管理器<T> : 抽象資料列管理器<T>, 可儲存介面, 可新增介面<T> where T : 可封存資料    //@@ 支援讀檔
    {
        public abstract string 檔案路徑 { get; }

        public override bool 是否可編輯 { get { return false; } }
        public override bool 是否編輯中 { get { return false; } }

        protected 可檢查介面 新增物件檢查器 = new 例外檢查器();

         // 建構子
        public 可封存資料管理器()
        {
        }

        protected override void 新增物品處理(T 資料_)
        {
            資料_.合法檢查(新增物件檢查器);
        }

        protected override void 刪除物品處理(T 資料_)
        {
        }

        public override void 完成編輯(bool 是否紀錄_)
        {
            throw new Exception("目前不支援");
        }

         public override void 新增(T 資料_)
        {
            base.新增(資料_);
            儲存();
        }

         public override void 新增(IEnumerable<T> 資料列舉_)
         {
             base.新增(資料列舉_);
             儲存();
         }

        // 儲存檔案
        public virtual void 儲存()
        {
            if (資料列.Count == 0)
                return;

            檔案.寫入(檔案路徑, JsonConvert.SerializeObject(資料列, Formatting.Indented));
            資料列.Clear();

            資料版本++;
        }
    }
}
