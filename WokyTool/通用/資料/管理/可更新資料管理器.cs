﻿using System.Linq;

namespace WokyTool.通用
{
    public abstract class 可更新資料管理器<TSource, TValue> : 抽象資料列管理器<TSource>, 可儲存介面
        where TSource : 可更新資料<TSource, TValue> 
		where TValue : 可編號記錄資料
    {

        public override bool 是否可編輯 { get { return true; } }
        public override bool 是否編輯中 { get { return 資料列.Count > 0; } }
        public virtual bool 是否自動存檔 { get { return true; } }

        protected 可檢查介面 新增物件檢查器 = new 錯誤訊息檢查器();

        protected abstract 可編號記錄資料管理器<TValue> 記錄器 { get; }

        protected override void 新增資料處理(TSource 資料_)
        {
            資料_.管理器 = this;
            資料_.初始化();
            資料_.合法檢查(新增物件檢查器);
        }

        protected override void 刪除資料處理(TSource 資料_)
        {
        }

        public override void 完成編輯(bool 是否紀錄_)
        {
            if (是否紀錄_)
            {
                合法檢查(新增物件檢查器);

                TSource 錯誤資料_ = 資料列.Where(Value => string.IsNullOrEmpty(Value.錯誤訊息) == false).DefaultIfEmpty(null).First();
                if (錯誤資料_ != null)
                {
                    例外檢查器 例外檢查器_ = new 例外檢查器();
                    例外檢查器_.錯誤(錯誤資料_, 錯誤資料_.錯誤訊息);
                }

                foreach (TSource 資料_ in 資料列)
                {
                    資料_.紀錄編輯(true);
                }

                儲存();
            }
        }

        // 儲存檔案
        public virtual void 儲存()
        {
            記錄器.更新(資料列.Where(Value => Value.更新狀態 == 列舉.更新狀態.更新).Select(Value => Value.修改));
            記錄器.新增(資料列.Where(Value => Value.更新狀態 == 列舉.更新狀態.新增).Select(Value => Value.修改));
            記錄器.刪除(資料列.Where(Value => Value.更新狀態 == 列舉.更新狀態.刪除).Select(Value => Value.修改));

            if (是否自動存檔)
                記錄器.儲存();
        }

        public override void 合法檢查(可檢查介面 檢查器_)
        {
            可檢查介面 錯誤訊息檢查器 = new 錯誤訊息檢查器();
            foreach (TSource 資料_ in 資料列)
            {
                資料_.合法檢查(錯誤訊息檢查器);
            }

            if ((檢查器_ is 錯誤訊息檢查器) == false)
            {
                foreach (TSource 資料_ in 資料列)
                {
                    資料_.合法檢查(檢查器_);
                }
            }
        }
    }
}
