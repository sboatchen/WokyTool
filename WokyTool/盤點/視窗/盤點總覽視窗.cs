using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataExport;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.盤點
{
    public partial class 盤點總覽視窗: 新版總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.盤點; } }
        public override Type 資料類型 { get { return typeof(盤點資料); } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 盤點資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.myDataGridView1; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }
        public override ToolStripMenuItem 自訂MI { get { return this.自訂ToolStripMenuItem; } }

        public 盤點總覽視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            this.更新ToolStripMenuItem.Enabled = 編輯管理器.是否可編輯;
            this.myDataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(_onCellFormatting);
        }

        private void _onCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow 資料_ in myDataGridView1.Rows)
            {
                if (資料_.Cells[2].Value == null)
                    return;

                if (資料_.Cells[2].Value.Equals(資料_.Cells[6].Value))
                    資料_.DefaultCellStyle.BackColor = Color.Empty;
                else
                    資料_.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void 通用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var 視窗_ = new 盤點更新視窗();
            視窗_.初始化();
            視窗_.Show();
            視窗_.BringToFront();
        }
    }
}



    