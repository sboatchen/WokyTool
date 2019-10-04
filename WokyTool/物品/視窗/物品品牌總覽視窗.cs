using System;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.物品
{
    public partial class 物品品牌總覽視窗 : 獨體總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.物品品牌; } }
        public override Type 資料類型 { get { return typeof(物品品牌資料); } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 物品品牌資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.dataGridView1; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }
        public override ToolStripMenuItem 自訂MI { get { return this.自訂ToolStripMenuItem; } }
        public override ToolStripMenuItem 新增MI { get { return this.新增ToolStripMenuItem; } }

        public 物品品牌總覽視窗()
        {
            InitializeComponent();
        }
    }
}