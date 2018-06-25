using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public abstract class 頁資料樣板視窗<T> : Form where T : MyKeepableData
    {
        protected System.Windows.Forms.BindingSource 資料BindingSource;
        public T 目前資料 { get; protected set; }
        public string 目前索引 { get; protected set; }

        public 頁資料樣板視窗(資料管理器<T> 資料管理器_)
        {

            this.資料BindingSource = new System.Windows.Forms.BindingSource();
            this.資料BindingSource.DataSource = 資料管理器_.BList;

            目前資料 = default(T);
        }

        public void 下一個()
        {
            if (資料BindingSource.Position+1 >= 資料BindingSource.Count)
                資料BindingSource.MoveFirst();
            else
                資料BindingSource.MoveNext();

            嘗試更新資料();
        }

        public void 上一個()
        {
            if (資料BindingSource.Position == 0)
                資料BindingSource.MoveLast();
            else
                資料BindingSource.MovePrevious();

            嘗試更新資料();
        }

        public void 設定索引(int 位置_)
        {
            this.資料BindingSource.Position = 位置_;

            嘗試更新資料();
        }

        protected void 嘗試更新資料()
        {
            T Now_ = (T)(資料BindingSource.Current);
            if (Now_ == 目前資料)
                return;

            儲存修改();

            目前資料 = Now_;
            目前索引 = String.Format("{0} of {1}", 資料BindingSource.Position + 1, 資料BindingSource.Count);

            更新資料();

            this.Refresh();
        }

        protected abstract void 更新資料();
        protected abstract void 儲存修改();
    }
}
