using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Data;
using WokyTool.DataMgr;

namespace WokyTool
{
    public partial class 商品總覽視窗 : Form
    {
        public 商品總覽視窗()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = 商品管理器.Instance.Binding;

            this.大類編號DataGridViewTextBoxColumn.DataSource = 商品大類管理器.Instance.Binding;
            this.小類編號DataGridViewTextBoxColumn.DataSource = 商品小類管理器.Instance.Binding;
            this.廠商編號DataGridViewTextBoxColumn.DataSource = 廠商管理器.Instance.Binding;
            this.需求編號1DataGridViewTextBoxColumn.DataSource = 物品管理器.Instance.Binding;
            this.需求編號2DataGridViewTextBoxColumn.DataSource = 物品管理器.Instance.Binding;
            this.需求編號3DataGridViewTextBoxColumn.DataSource = 物品管理器.Instance.Binding;
            this.需求編號4DataGridViewTextBoxColumn.DataSource = 物品管理器.Instance.Binding;
            this.需求編號5DataGridViewTextBoxColumn.DataSource = 物品管理器.Instance.Binding;

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onEventCellValueChanged);
        }

        // 註冊事件:資料異動
        private void onEventCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 資料有異動，記錄須進行更新
            商品管理器.Instance.IsDirty = true;
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            this.dataGridView1.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            商品管理器.Instance.Add();
            this.dataGridView1.Refresh();
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                商品管理器.Instance.Delete((商品資料)this.dataGridView1.SelectedRows[0].DataBoundItem);
                this.dataGridView1.Refresh();
            }
        }
    }
}
