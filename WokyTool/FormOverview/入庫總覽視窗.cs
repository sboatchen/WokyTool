using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;

namespace WokyTool.FormOverview
{
    public partial class 入庫總覽視窗 : Form
    {
        protected 監測綁定更新<入庫資料> _入庫資料Listener;
        protected 監測綁定更新<商品資料> _商品資料Listener;

        public 入庫總覽視窗()
        {
            InitializeComponent();

            _入庫資料Listener = new 監測綁定更新<入庫資料>(入庫管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 入庫資料更新);
            _入庫資料Listener.Refresh(true);

            _商品資料Listener = new 監測綁定更新<商品資料>(商品管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 商品資料更新);
            _商品資料Listener.Refresh(true);

            this.商品.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onEventCellValueChanged);
        }

        public void 入庫資料更新(IEnumerable<入庫資料> Data_)
        {
            this.dataGridView1.DataSource = Data_;
            this.dataGridView1.Refresh();
        }

        public void 商品資料更新(IEnumerable<商品資料> Data_)
        {
            this.商品.DataSource = Data_;
        }

        // 註冊事件:資料異動
        private void onEventCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 資料有異動，記錄須進行更新
            入庫管理器.Instance.SetDirty();
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _入庫資料Listener.Refresh();
            _商品資料Listener.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            入庫管理器.Instance.Add();
            _入庫資料Listener.Refresh();

            this.dataGridView1.FirstDisplayedScrollingRowIndex = this.dataGridView1.RowCount - 1;
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                入庫管理器.Instance.Delete((入庫資料)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _入庫資料Listener.Refresh();
            }
        }
    }
}