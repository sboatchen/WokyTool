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

namespace WokyTool.DataForm
{
    public partial class 進貨總覽視窗 : Form
    {
        protected bool _HasNewItem_ = false;

        public 進貨總覽視窗()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = 進貨管理器.Instance.Binding;

            this.廠商編號DataGridViewTextBoxColumn.DataSource = 廠商管理器.Instance.Binding;
            this.物品編號DataGridViewTextBoxColumn.DataSource = 物品管理器.Instance.Binding;
            this.幣值編號DataGridViewTextBoxColumn.DataSource = 幣值管理器.Instance.Binding;

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onEventCellValueChanged);
        }

        // 註冊事件:資料異動
        private void onEventCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 資料有異動，記錄須進行更新
            進貨管理器.Instance.IsDirty = true;
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            this.dataGridView1.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            進貨管理器.Instance.Add();
            this.dataGridView1.Refresh();

            _HasNewItem_ = true;
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                進貨管理器.Instance.Delete((進貨資料)this.dataGridView1.SelectedRows[0].DataBoundItem);
                this.dataGridView1.Refresh();
            }
        }

        private void 進貨總覽視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_HasNewItem_)
            {
                進貨管理器.Instance.AddDone();
            }
        }
    }
}
