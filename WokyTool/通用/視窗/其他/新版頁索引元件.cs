using System;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public partial class 新版頁索引元件 : UserControl
    {
        protected BindingSource _資料BS = null;

        /*public int 編號
        {
            get
            {
                if (_資料BS.Current == null)
                    return 常數.空白資料編碼;

                可編號介面 可編號資料_ = _資料BS.Current as 可編號介面;
                if (可編號資料_ == null)
                    return 常數.錯誤資料編碼;

                return 可編號資料_.編號;
            }
            set
            {
                if (_資料BS == null) // 尚未初始化
                    return;

                for (int i = 0; i < this._資料BS.Count; i++)
                {
                    可編號介面 可編號資料_ = this._資料BS[i] as 可編號介面;
                    if (可編號資料_ == null)
                    {
                        訊息管理器.獨體.錯誤("非可編號介面:" + this._資料BS[i].GetType().Name);
                        return;
                    }

                    if (可編號資料_.編號 == value)
                    {
                        _資料BS.Position = i;
                        return;
                    }
                }
            }
        }

        public int 位置
        {
            get
            {
                if (_資料BS.Current == null)
                    return 常數.空白資料編碼;

                return _資料BS.Position;
            }
            set
            {
                if (_資料BS == null) // 尚未初始化
                    return;

                if (value > _資料BS.Count || value < 0)
                {
                    訊息管理器.獨體.通知(字串.指定詳細視窗索引失敗);
                }
                else
                {
                    _資料BS.Position = value;
                }
            }
        }*/

        public 新版頁索引元件()
        {
            InitializeComponent();
        }

        public void 初始化(BindingSource 資料BS_)
        {
            this._資料BS = 資料BS_;
            this._資料BS.CurrentChanged += new EventHandler(this._選擇改變);
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
