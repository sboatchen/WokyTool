using System;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.寄庫
{
    public partial class 寄庫總覽視窗: 獨體總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.寄庫; } }
        public override Type 資料類型 { get { return typeof(寄庫資料); } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 寄庫資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.myDataGridView1; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }
        public override ToolStripMenuItem 自訂MI { get { return this.自訂ToolStripMenuItem; } }

        public 寄庫總覽視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();
        }
    }
}



    