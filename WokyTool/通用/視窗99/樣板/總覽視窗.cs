﻿using System;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.通用
{
    public class 總覽視窗 : Form, 通用視窗介面
    {
        protected BindingSource 資料BindingSource;

        protected int _資料版本;

        protected 可編輯資料列管理介面 _資料管理器;

        protected bool _是否關閉 = false;

        public void 初始化()
        {
        }

        public void 初始化(BindingSource 資料BindingSource_, 可編輯資料列管理介面 資料管理器_)
        {
            this.資料BindingSource = 資料BindingSource_;
            this._資料管理器 = 資料管理器_;

            this.Activated += new System.EventHandler(this._視窗激活);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._視窗關閉);
        }

        private void _視窗激活(object sender, EventArgs e)
        {
            if (_是否關閉)
                return;

            視窗激活();

            if (_資料版本 != _資料管理器.可編輯資料列版本)
            {
                _資料版本 = _資料管理器.可編輯資料列版本;
                this.資料BindingSource.DataSource = _資料管理器.可編輯資料列;
                this.資料BindingSource.ResetBindings(false);
            }
        }

        protected virtual void 視窗激活()
        {
        }

        private void _視窗關閉(object sender, FormClosingEventArgs e)
        {
            _是否關閉 = true;

            if (_資料管理器.是否正在編輯())
            {
                bool Result_ = 訊息管理器.獨體.確認(字串.儲存確認, 字串.儲存確認內容);

                try
                {
                    _資料管理器.完成編輯(Result_);
                }
                catch (Exception ex)
                {
                    訊息管理器.獨體.通知(字串.儲存失敗, ex.Message);
                    e.Cancel = true;
                    _是否關閉 = false;
                    return;
                }
            }

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
