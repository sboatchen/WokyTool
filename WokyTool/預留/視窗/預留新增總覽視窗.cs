using System;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.預留
{
    public partial class 預留新增總覽視窗: 獨體總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.預留新增; } }
        public override Type 資料類型 { get { return typeof(預留資料); } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 預留新增資料管理器.獨體; } }
        public override MyDataGridView 資料GV { get { return this.myDataGridView1; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }
        public override ToolStripMenuItem 自訂MI { get { return this.自訂ToolStripMenuItem; } }
        public override ToolStripMenuItem 新增MI { get { return this.新增ToolStripMenuItem; } }

        public 預留新增總覽視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            this.更新ToolStripMenuItem.Enabled = 編輯管理器.是否可編輯;
        }

        private void 通用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var 視窗_ = new 預留匯入視窗();
            視窗_.初始化();
            視窗_.Show();
            視窗_.BringToFront();
        }
    }
}



    