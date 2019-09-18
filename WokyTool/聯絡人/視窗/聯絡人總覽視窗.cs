using System;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.聯絡人
{
    public partial class 聯絡人總覽視窗 : 獨體總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.聯絡人; } }
        public override Type 資料類型 { get { return typeof(聯絡人資料); } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 聯絡人資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.dataGridView1; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }
        public override ToolStripMenuItem 自訂MI { get { return this.自訂ToolStripMenuItem; } }

        public 聯絡人總覽視窗()
        {
            InitializeComponent();
        }

        private void 通用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var 視窗_ = new 聯絡人更新視窗();
            視窗_.初始化();
            視窗_.Show();
            視窗_.BringToFront();

        }

        private void 舊資料轉換ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (訊息管理器.獨體.確認("轉換確認", "是否用舊版資料覆蓋新資料?"))
                聯絡人資料管理器.獨體.舊資料轉換();
        }
    }
}