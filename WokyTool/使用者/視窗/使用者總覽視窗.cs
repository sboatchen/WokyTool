﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.使用者
{
    public partial class 使用者總覽視窗 : 新版總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.使用者; } }

        public override 可編輯列舉資料管理介面 管理介面 { get { return 使用者資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.dataGridView1; } }


        public 使用者總覽視窗()
        {
            InitializeComponent();

            this.初始化();
        }

        protected override void _雙點擊資料(object sender, DataGridViewCellEventArgs e)
        {
            if (系統參數.修改基本資料 == false)
                return;

            使用者資料 目前使用者資料_ = (使用者資料)this.資料BS.Current;
            if (目前使用者資料_ == null)
                return;

            密碼修改視窗 密碼修改視窗_ = new 密碼修改視窗(目前使用者資料_);
            密碼修改視窗_.顯現();
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.通知("尚未實作");
        }

        private void 檢查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            列表檢查器 檢查器_ = new 列表檢查器();
            管理介面.合法檢查(檢查器_);

            var i = new 錯誤列表視窗(檢查器_, 編號類型.ToString());
            i.Show();
            i.BringToFront();
        }

        private void 自訂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 通用匯出視窗(typeof(使用者資料), 管理介面.資料列舉);
            i.Show();
            i.BringToFront();
        }
    }
}
