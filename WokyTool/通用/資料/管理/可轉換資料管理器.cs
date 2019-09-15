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
    public abstract class 可轉換資料管理器<TCovert, TValue> : 抽象資料列管理器<TCovert>, 可儲存介面
        where TCovert : 可轉換資料<TValue>
        where TValue : 可編輯資料
    {
        public override bool 是否可編輯 { get { return true; } }
        public override bool 是否編輯中 { get { return 資料列.Count > 0; } }

        protected 可檢查介面 新增物件檢查器 = new 例外檢查器();

        protected abstract 可新增介面<TValue> 記錄器 { get; }

        protected override void 新增物品處理(TCovert 資料_)
        {
            資料_.初始化();
            資料_.合法檢查(新增物件檢查器);
        }

        protected override void 刪除物品處理(TCovert 資料_)
        {
        }

        public override void 完成編輯(bool 是否紀錄_)
        {
            if (是否紀錄_)
            {
                資料列.執行(Value => Value.合法檢查(新增物件檢查器));

                foreach (TCovert 資料_ in 資料列)
                {
                    資料_.紀錄編輯(true);
                }

                儲存();
            }
        }

        // 儲存檔案
        public virtual void 儲存()
        {
            記錄器.新增(資料列.Select(Value => Value.目標資料));

            可儲存介面 儲存器_ = 記錄器 as 可儲存介面;
            if (儲存器_ != null)
                儲存器_.儲存();
        }
    }
}
