using System;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.商品
{
    public partial class 商品小類總覽視窗 : 獨體總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.商品小類; } }
        public override Type 資料類型 { get { return typeof(商品小類資料); } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 商品小類資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.dataGridView1; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }
        public override ToolStripMenuItem 自訂MI { get { return this.自訂ToolStripMenuItem; } }

        public 商品小類總覽視窗()
        {
            InitializeComponent();
        }
    }
}