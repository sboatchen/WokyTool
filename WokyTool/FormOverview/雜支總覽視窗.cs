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

namespace WokyTool.DataForm
{
    public partial class 雜支總覽視窗 : Form
    {
        protected bool _HasNewItem_ = false;

        protected 監測綁定更新<廠商資料> _廠商資料Listener;
        protected 監測綁定更新<幣值資料> _幣值資料Listener;
        protected 監測綁定更新<雜支資料> _雜支資料Listener;

        public 雜支總覽視窗()
        {
            InitializeComponent();

            _廠商資料Listener = new 監測綁定更新<廠商資料>(廠商管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 廠商資料更新);
            _廠商資料Listener.Refresh(true);

            _幣值資料Listener = new 監測綁定更新<幣值資料>(幣值管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 幣值資料更新);
            _幣值資料Listener.Refresh(true);

            _雜支資料Listener = new 監測綁定更新<雜支資料>(雜支管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 雜支資料更新);
            _雜支資料Listener.Refresh(true);

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onEventCellValueChanged);
        }

        public void 廠商資料更新(IEnumerable<廠商資料> Data_)
        {
            this.廠商編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 幣值資料更新(IEnumerable<幣值資料> Data_)
        {
            this.幣值編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 雜支資料更新(IEnumerable<雜支資料> Data_)
        {
            this.dataGridView1.DataSource = Data_;
            this.dataGridView1.Refresh();
        }

        // 註冊事件:資料異動
        private void onEventCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 資料有異動，記錄須進行更新
            雜支管理器.Instance.SetDirty();
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _廠商資料Listener.Refresh();
            _幣值資料Listener.Refresh();
            _雜支資料Listener.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            雜支管理器.Instance.Add();
            _雜支資料Listener.Refresh();

            _HasNewItem_ = true;
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                雜支管理器.Instance.Delete((雜支資料)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _雜支資料Listener.Refresh();
            }
        }

        private void 雜支總覽視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_HasNewItem_)
            {
                雜支管理器.Instance.AddDone();
            }
        }
    }
}
