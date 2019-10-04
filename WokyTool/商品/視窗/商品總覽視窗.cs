﻿using System;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.商品
{
    public partial class 商品總覽視窗: 獨體總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.商品; } }
        public override Type 資料類型 { get { return typeof(商品資料); } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 商品資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.myDataGridView1; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }
        public override ToolStripMenuItem 自訂MI { get { return this.自訂ToolStripMenuItem; } }
        public override ToolStripMenuItem 新增MI { get { return this.新增ToolStripMenuItem; } }

        public 商品總覽視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            this.更新ToolStripMenuItem.Enabled = 編輯管理器.是否可編輯;
        }

        private void 舊資料轉換ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(訊息管理器.獨體.確認("轉換確認", "是否用舊版資料覆蓋新資料?"))
                商品資料管理器.獨體.舊資料轉換();
        }

        private void 通用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var 視窗_ = new 商品更新視窗();
            視窗_.初始化();
            視窗_.Show();
            視窗_.BringToFront();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            商品資料管理器.獨體.更新組成();
        }
    }
}



    