﻿using System;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.使用者
{
    public partial class 密碼修改視窗 : 鎖定視窗
    {
        private 使用者資料 _使用者資料;

        public 密碼修改視窗(使用者資料 使用者資料_)
        {
            InitializeComponent();

            this._使用者資料 = 使用者資料_;
        }

        private void 確認_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.新密碼.Text) || String.IsNullOrEmpty(this.再次確認.Text))
            {
                訊息管理器.獨體.通知(字串.密碼不可無空白);
                return;
            }

            if (this.新密碼.Text.CompareTo(this.再次確認.Text) != 0)
            {
                訊息管理器.獨體.通知(字串.密碼輸入不一致);
                return;
            }

            _使用者資料.BeginEdit();
            _使用者資料.密碼 = this.新密碼.Text;

            this.關閉();
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            this.關閉();
        }
    }
}
