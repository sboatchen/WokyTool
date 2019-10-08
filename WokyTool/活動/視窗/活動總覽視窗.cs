using System;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.活動
{
    public partial class 活動總覽視窗: 獨體總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.活動; } }
        public override Type 資料類型 { get { return typeof(活動資料); } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 活動資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.myDataGridView1; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }
        public override ToolStripMenuItem 自訂MI { get { return this.自訂ToolStripMenuItem; } }
        public override ToolStripMenuItem 新增MI { get { return this.新增ToolStripMenuItem; } }

        public 活動總覽視窗()
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
            var 視窗_ = new 活動匯入視窗();
            視窗_.初始化();
            視窗_.Show();
            視窗_.BringToFront();
        }
    }
}



    