using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.通用
{
    public partial class 新版頁索引元件 : UserControl
    {
        protected 頁索引上層介面 _綁定介面;
        protected 可編輯列舉資料管理介面 _管理介面;

        protected BindingSource _資料BS = new BindingSource();
        protected int _資料版本 = -1;

        public object 目前資料 { get { return _資料BS.Current; } }

        public int 編號
        {
            get
            {
                if (_資料BS.Current == null)
                    return 常數.舊的錯誤資料編碼;

                可編號介面 可編號資料_ = 目前資料 as 可編號介面;
                if(可編號資料_ == null)
                    return 常數.舊的錯誤資料編碼;

                return 可編號資料_.編號;
            }
            set
            {
                if (this._綁定介面 == null) // 尚未初始化
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
                        更新資料();
                        return;
                    }
                }

                Console.WriteLine(Environment.StackTrace);
                訊息管理器.獨體.通知(字串.指定詳細視窗索引失敗);
            }
        }

        public int 位置
        {
            get
            {
                if (_資料BS.Current == null)
                    return 常數.舊的錯誤資料編碼;

                return _資料BS.Position;
            }
            set
            {
                if (this._綁定介面 == null) // 尚未初始化
                    return;

                if (value > _資料BS.Count || value < 0)
                {
                    Console.WriteLine(Environment.StackTrace);
                    訊息管理器.獨體.通知(字串.指定詳細視窗索引失敗);
                }
                else
                {
                    _資料BS.Position = value;
                    更新資料();
                }
            }
        }

        public 新版頁索引元件()
        {
            InitializeComponent();
        }

        public void 初始化(頁索引上層介面 綁定介面_, 可編輯列舉資料管理介面 管理介面_)
        {
            this._綁定介面 = 綁定介面_;
            this._管理介面 = 管理介面_;
        }

        private void 上一頁_Click(object sender, EventArgs e)
        {
            if (_資料BS.Position == 0)
                _資料BS.MoveLast();
            else
                _資料BS.MovePrevious();

            更新資料();
        }

        private void 下一頁_Click(object sender, EventArgs e)
        {
            if (_資料BS.Position + 1 >= _資料BS.Count)
                _資料BS.MoveFirst();
            else
                _資料BS.MoveNext();

            更新資料();
        }

        private void 更新資料()
        {
            if (false == this.Visible)
                return;

            索引.Text = String.Format("{0} of {1}", _資料BS.Position + 1, _資料BS.Count);
        }

        public void 視窗激活()
        {
            if (_資料版本 != _管理介面.資料版本)
            {
                _資料版本 = _管理介面.資料版本;
                _資料BS.DataSource = _管理介面.資料列舉;
                _資料BS.ResetBindings(false);
            }

            更新資料();
        }
    }
}
