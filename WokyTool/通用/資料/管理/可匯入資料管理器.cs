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
    public abstract class 可匯入資料管理器<T> : 可管理資料管理器<T>, 可儲存介面 where T : 新版可匯入資料<T>
    {
        protected override IEnumerable<T> 取得清單特殊選項()
        {
            yield break;
        }

        protected List<T> _資料列 = null;
        protected int _目前資料列版本 = 0;

        public override object 資料列舉
        {
            get
            {
                return _資料列;
            }
        }

        public virtual 可處理合法介面 新增合法處理介面
        {
            get
            {
                return new 例外處理合法管理器();
            }
        }

        // 建構子
        public 可匯入資料管理器()
        {
            _資料列 = new List<T>();
        }

        // 建構子
        public 可匯入資料管理器(IEnumerable<T> 資料列_)
        {
            _資料列 = 資料列_.ToList();
        }

        // 儲存檔案
        public virtual void 儲存()
        {
            if (_目前資料列版本 != 資料版本)
            {
                _目前資料列版本 = 資料版本;

                //TODO
            }
        }

        public void 新增(T 資料_)
        {
            資料_.檢查合法(新增合法處理介面);
            資料_.紀錄編輯(true);

            _資料列.Add(資料_);

            資料版本++;
        }

        public void 新增(IEnumerable<T> 資料列舉_)
        {
            if (資料列舉_.Count() == 0)
                return;

            可處理合法介面 新增合法處理介面_ = 新增合法處理介面;

            foreach (T 資料_ in 資料列舉_)
            {
                資料_.檢查合法(新增合法處理介面_);
                資料_.紀錄編輯(true);

                _資料列.Add(資料_);
            }

            資料版本++;
        }

        public bool 刪除(T 資料_)
        {
            if (_資料列.Contains(資料_) == false)
            {
                訊息管理器.獨體.警告("無法刪除指定物件,找不到 " + 資料_.ToString());
                return false;
            }

            _資料列.Remove(資料_);

            資料版本++;

            return true;
        }

        public override void 更新資料(object 資料列obj_)
        {
            IEnumerable<T> 資料列_ = 資料列obj_ as IEnumerable<T>;
            if (資料列_ == null)
            {
                訊息管理器.獨體.錯誤("更新資料型別錯誤: " + 資料列obj_.GetType().Name);
                return;
            }

            _資料列.Clear();

            foreach (T 資料_ in 資料列_)
            {
                _資料列.Add(資料_);
            }

            資料版本++;
        }
    }
}
