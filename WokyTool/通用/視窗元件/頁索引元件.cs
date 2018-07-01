using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public partial class 頁索引元件 : UserControl
    {
        protected System.Windows.Forms.BindingSource 資料BindingSource;
        protected 頁索引上層介面 _綁定介面;

        public object 目前資料 { get; protected set; }

        public 頁索引元件()
        {
            InitializeComponent();

            this.資料BindingSource = new System.Windows.Forms.BindingSource();

            目前資料 = null;
        }

        public void 初始化<T>(BindingList<T> 資料_, 頁索引上層介面 綁定介面_) where T : MyKeepableData
        {
            this.資料BindingSource.DataSource = 資料_;
            this._綁定介面 = 綁定介面_;
        }

        public void 是否合法()
        {
            if (_綁定介面 == null)
                throw new Exception("頁索引元件尚未初始化");
        }

        private void 上一頁_Click(object sender, EventArgs e)
        {
            是否合法();

            if (資料BindingSource.Position == 0)
                資料BindingSource.MoveLast();
            else
                資料BindingSource.MovePrevious();

            嘗試更新資料();
        }

        private void 下一頁_Click(object sender, EventArgs e)
        {
            是否合法();

            if (資料BindingSource.Position + 1 >= 資料BindingSource.Count)
                資料BindingSource.MoveFirst();
            else
                資料BindingSource.MoveNext();

            嘗試更新資料();
        }

        public void 設定編號(int 編號_)
        {
            是否合法();

            for(int i = 0 ; i < this.資料BindingSource.Count; i++)
            {
                MyKeepableData Item_ = (MyKeepableData)(this.資料BindingSource[i]);
                if(Item_.編號 == 編號_)
                {
                    this.資料BindingSource.Position = i;
                    break;
                }
            }

            if(this.Visible)
                嘗試更新資料();
        }

        public void 嘗試更新資料()
        {
            是否合法();

            object Now_ = 資料BindingSource.Current;
            if (Now_ == 目前資料)
                return;

            if (目前資料 != null)
                _綁定介面.索引切換_異動儲存();

            目前資料 = Now_;
            索引.Text = String.Format("{0} of {1}", 資料BindingSource.Position + 1, 資料BindingSource.Count);

            _綁定介面.索引切換_更新呈現();

            //this.Refresh();
        }

        public void 刷新()
        {
            this.資料BindingSource.ResetBindings(false);

            目前資料 = null;
            嘗試更新資料();
        }
    }
}
