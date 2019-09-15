using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public abstract class 抽象資料列管理器<T> : 可編輯列舉資料管理介面
        where T : 可編輯資料
    {
        public List<T> 資料列 { get; protected set; }
        protected int _資料更新版本 = 0;  // 用於通知外部資料變更
        protected int _資料排序版本 = -1;

        public BindingSource 公用BS { get; protected set; }

        public int 資料版本
        {
            get
            {
                return _資料更新版本 + 篩選器.排序版本 + 篩選器.篩選版本;
            }
            protected set 
            {
                _資料更新版本++;      // 通知外部更新
                _資料排序版本 = -1;   // 通知重排
            }
        }

        protected int _資料列舉篩選版本 = -1;
        protected IEnumerable<T> _資料列舉 = null;
        public object 資料列舉 
        { 
            get 
            {
                if (_資料排序版本 != 篩選器.排序版本)
                {
                    _資料排序版本 = 篩選器.排序版本;
                    if (篩選器.是否排序)
                        資料列 = 篩選器.排序(資料列).ToList();

                    _資料列舉篩選版本 = -1;   // 通知重新篩選
                }

                if (_資料列舉篩選版本 != 篩選器.篩選版本)
                {
                    _資料列舉篩選版本 = 篩選器.篩選版本;

                    _資料列舉 = 篩選器.篩選(資料列);

                    公用BS.DataSource = _資料列舉;
                }

                return _資料列舉;
            } 
        }

        protected abstract void 新增物品處理(T 資料_);
        protected abstract void 刪除物品處理(T 資料_);

        protected abstract 新版可篩選介面<T> 取得篩選器實體();
        public 新版可篩選介面<T> 篩選器 { get; protected set; }
        public 視窗可篩選介面 視窗篩選器 { get { return 篩選器; } }

        public abstract bool 是否可編輯 { get; }
        public abstract bool 是否編輯中 { get; }
        public abstract void 完成編輯(bool 是否紀錄_);

        // 建構子
        public 抽象資料列管理器()
        {
            資料列 = new List<T>();
            公用BS = new BindingSource();
            篩選器 = 取得篩選器實體();
        }

        public virtual void 合法檢查(可檢查介面 檢查器_)
        {
            foreach (T 資料_ in 資料列)
            {
                資料_.合法檢查(檢查器_);
            }
        }

        public virtual void 新增(T 資料_)
        {
            新增物品處理(資料_);

            資料列.Add(資料_);

            資料版本++;
        }

        public virtual void 新增(IEnumerable<T> 資料列舉_)
        {
            if (資料列舉_ == null || 資料列舉_.Any() == false)
                return;

            foreach (T 資料_ in 資料列舉_)
            {
                新增物品處理(資料_);

                資料列.Add(資料_);
            }

            資料版本++;
        }

        public bool 刪除(T 資料_)
        {
            if (資料列.Contains(資料_) == false)
            {
                訊息管理器.獨體.警告("無法刪除指定物件,找不到 " + 資料_.ToString());
                return false;
            }

            刪除物品處理(資料_);

            資料列.Remove(資料_);

            資料版本++;

            return true;
        }

        public bool 刪除(IEnumerable<T> 資料列舉_)
        {
            if (資料列舉_ == null || 資料列舉_.Any() == false)
                return true;

            資料版本++;

            foreach (T 資料_ in 資料列舉_)
            {
                if (資料列.Contains(資料_) == false)
                {
                    訊息管理器.獨體.警告("無法刪除指定物件,找不到 " + 資料_.ToString());
                    return false;
                }

                資料列.Remove(資料_);
            }

            return true;
        }

        public virtual bool 包含(T 資料_)
        {
            return 資料列.Contains(資料_);
        }
    }
}
