using System;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.通用
{
    public partial class 頁索引元件 : UserControl
    {
        protected System.Windows.Forms.BindingSource 資料BindingSource;
        protected 頁索引上層介面 _綁定介面;
        protected 可編輯資料列管理介面 _資料管理器;
        protected int _資料版本 = -1;

        public object 目前資料 { get; protected set; }

        public 頁索引元件()
        {
            InitializeComponent();

            this.資料BindingSource = new System.Windows.Forms.BindingSource();

            目前資料 = null;
        }

        public void 初始化(可編輯資料列管理介面 資料管理器_, 頁索引上層介面 綁定介面_)
        {
            this._資料管理器 = 資料管理器_;
            this._綁定介面 = 綁定介面_;

            this.資料BindingSource.DataSource = 資料管理器_.可編輯資料列;
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

            bool 是否找到_ = false;
            for(int i = 0 ; i < this.資料BindingSource.Count; i++)
            {
                可編號介面 Item_ = (可編號介面)(this.資料BindingSource[i]);
                if(Item_.編號 == 編號_)
                {
                    this.資料BindingSource.Position = i;
                    是否找到_ = true;
                    break;
                }
            }

            if (是否找到_ == false)
                訊息管理器.獨體.通知(字串.指定詳細視窗索引失敗);

            目前資料 = null;
            if(this.Visible)
                嘗試更新資料();
        }

        public void 設定位置(int 位置_)
        {
            是否合法();

            if (位置_ > this.資料BindingSource.Count || 位置_ < 0)
            {
                訊息管理器.獨體.通知(字串.指定詳細視窗索引失敗);
            }
            else
            {
                this.資料BindingSource.Position = 位置_;
            }

            目前資料 = null;
            if (this.Visible)
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

        public void 視窗激活()
        {
            if (_資料版本 != _資料管理器.可編輯資料列版本)
            {
                _資料版本 = _資料管理器.可編輯資料列版本;
                this.資料BindingSource.DataSource = _資料管理器.可編輯資料列;
                this.資料BindingSource.ResetBindings(false);
            }

            目前資料 = null;
            嘗試更新資料();
        }
    }
}
