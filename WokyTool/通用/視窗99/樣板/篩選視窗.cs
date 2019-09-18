using System;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public class 篩選視窗 : Form, 通用視窗介面
    {
        protected bool _是否關閉 = false;

        public void 初始化()
        {
            this.Activated += new System.EventHandler(this._視窗激活);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._視窗關閉);
        }

        private void _視窗激活(object sender, EventArgs e)
        {
            if (_是否關閉)
                return;

            視窗激活();
        }

        protected virtual void 視窗激活()
        {
        }

        private void _視窗關閉(object sender, FormClosingEventArgs e)
        {
            _是否關閉 = true;

            if (!(e is 視窗關閉事件))
            {
                e.Cancel = true;
                this.Hide();
            }

            視窗關閉();
        }

        protected virtual void 視窗關閉()
        {

        }

        /********************************/
        // 通用視窗介面

        public void 顯現()
        {
            this._是否關閉 = false;

            this.Show();
            this.BringToFront();
        }

        public void 顯現(int 編號_)
        {
            this._是否關閉 = false;

            this.Show();
            this.BringToFront();
        }

        public void 隱藏()
        {
            _視窗關閉(null, new 視窗隱藏事件());
        }

        public void 關閉()
        {
            _視窗關閉(null, new 視窗關閉事件());
        }

        public bool 是否顯現
        {
            get
            {
                return this.Visible;
            }
        }
    }
}

