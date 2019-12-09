using System;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public partial class 新版頁索引元件 : UserControl
    {
        protected BindingSource _資料BS = null;

        public 新版頁索引元件()
        {
            InitializeComponent();
        }

        public void 初始化(BindingSource 資料BS_)
        {
            this._資料BS = 資料BS_;
            this._資料BS.CurrentChanged += new EventHandler(this._選擇改變);
            _選擇改變(null, null);
        }

        private void 上一頁_Click(object sender, EventArgs e)
        {
            if (_資料BS.Position == 0)
                _資料BS.MoveLast();
            else
                _資料BS.MovePrevious();
        }

        private void 下一頁_Click(object sender, EventArgs e)
        {
            if (_資料BS.Position + 1 >= _資料BS.Count)
                _資料BS.MoveFirst();
            else
                _資料BS.MoveNext();
        }

        private void _選擇改變(object sender, EventArgs e)
        {
            索引.Text = String.Format("{0} / {1}", _資料BS.Position + 1, _資料BS.Count);
        }
    }
}
