using System;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.物品
{
    public partial class 物品總覽視窗 : 獨體總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.物品; } }
        public override Type 資料類型 { get { return typeof(物品資料); } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 物品資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.dataGridView1; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }
        public override ToolStripMenuItem 自訂MI { get { return this.自訂ToolStripMenuItem; } }

        public 物品總覽視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            this.更新ToolStripMenuItem.Enabled = 編輯管理器.是否可編輯;
        }

        private void 盤點ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.通知("此報表無視篩選設定");

            var 轉換_ = new 物品盤點匯出轉換();
            String 標題_ = String.Format("盤點匯出_{0}", 時間.目前日期);
            if (檔案.詢問並寫入(標題_, 轉換_))
                訊息管理器.獨體.通知("匯出完成");
        }

        private void 通用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var 視窗_ = new 物品更新視窗();
            視窗_.初始化();
            視窗_.Show();
            視窗_.BringToFront();
        }
    }
}
