using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataMgr;

namespace WokyTool.通用
{
    public abstract class 可匯入資料管理器<TSource, TValue> : 抽象資料列管理器<TSource>, 可儲存介面
        where TSource : 新版可匯入資料<TValue>
        where TValue : 新版可記錄資料
    {

        public override bool 是否可編輯 { get { return true; } }
        public override bool 是否編輯中 { get { return 資料列.Count > 0; } }
        public virtual bool 是否自動存檔 { get { return true; } }

        protected 可檢查介面 新增物件檢查器 = new 錯誤訊息檢查器();

        protected abstract 可新增介面<TValue> 記錄器 { get; }

        protected override void 新增物品處理(TSource 資料_)
        {
            資料_.初始化();
            資料_.合法檢查(新增物件檢查器);
        }

        protected override void 刪除物品處理(TSource 資料_)
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
            記錄器.新增(資料列.Select(Value => Value.新增資料));

            if (是否自動存檔)
            {
                可儲存介面 儲存器_ = 記錄器 as 可儲存介面;
                if (儲存器_ != null)
                    儲存器_.儲存();
            }
        }
    }
}
