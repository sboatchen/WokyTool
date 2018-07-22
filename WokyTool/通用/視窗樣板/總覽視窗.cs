﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.通用
{
    public class 總覽視窗 : Form, 通用視窗介面
    {
        protected System.Windows.Forms.BindingSource 資料BindingSource;

        protected int _資料版本;

        protected 資料管理器介面 _資料管理器;

        protected bool _是否準備關閉 = false;

        public void 初始化(System.Windows.Forms.BindingSource 資料BindingSource_, 資料管理器介面 資料管理器_)
        {
            this.資料BindingSource = 資料BindingSource_;
            this._資料管理器 = 資料管理器_;

            this.Activated += new System.EventHandler(this._視窗激活);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._視窗關閉);
        }

        private void _視窗激活(object sender, EventArgs e)
        {
            if (_是否準備關閉)
                return;

            視窗激活();

            if (_資料版本 != _資料管理器.編輯資料版本)
            {
                _資料版本 = _資料管理器.編輯資料版本;
                this.資料BindingSource.DataSource = _資料管理器.物件_可編輯BList;
                this.資料BindingSource.ResetBindings(false);
            }
        }

        protected virtual void 視窗激活()
        {
        }

        private void _視窗關閉(object sender, FormClosingEventArgs e)
        {
            _是否準備關閉 = true;

            視窗關閉();

            if (_資料管理器.IsEditing())
            {
                var result = MessageBox.Show(字串.儲存確認內容, 字串.儲存確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                _資料管理器.UpdateEdit(result == DialogResult.Yes);
            }

            this.Hide();

            if (e != null)
                e.Cancel = true;

            _是否準備關閉 = false;
        }

        protected virtual void 視窗關閉()
        {
 
        }

        /********************************/
        // 通用視窗介面

        public void 顯現()
        {
            this.Show();
            this.BringToFront();
        }

        public void 顯現(int Pos_)
        {
            this.Show();
            this.BringToFront();
        }

        public void 隱藏()
        {
            _視窗關閉(null, null);
        }

        public bool 是否顯現()
        {
            return this.Visible;
        }
    }
}
