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
using WokyTool.DataExport;
using WokyTool.DataMgr;

namespace WokyTool
{
    public partial class 物品總覽視窗 : Form, 父視窗<物品資料>
    {
        protected 子視窗<物品資料> _子視窗 = null;
        protected 監測綁定更新<物品資料> _物品資料Listener;
        protected 監測綁定更新<物品大類資料> _物品大類資料Listener;
        protected 監測綁定更新<物品小類資料> _物品小類資料Listener;
        protected 監測綁定更新<物品品牌資料> _物品品牌資料Listener;

        public 物品總覽視窗()
        {
            InitializeComponent();

            _物品資料Listener = new 監測綁定更新<物品資料>(物品管理器.Instance.Binding, 列舉.監測類型.被動通知_公式, 物品資料更新);
            _物品資料Listener.Refresh(true);

            _物品大類資料Listener = new 監測綁定更新<物品大類資料>(物品大類管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品大類資料更新);
            _物品大類資料Listener.Refresh(true);

            _物品小類資料Listener = new 監測綁定更新<物品小類資料>(物品小類管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品小類資料更新);
            _物品小類資料Listener.Refresh(true);

            _物品品牌資料Listener = new 監測綁定更新<物品品牌資料>(物品品牌管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品品牌資料更新);
            _物品品牌資料Listener.Refresh(true);

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onEventCellValueChanged);
        }

        public void 物品資料更新(IEnumerable<物品資料> Data_)
        {
            if (_子視窗 != null && _子視窗.IsVisible() == true)
                this.dataGridView1.DataSource = _子視窗.Filt(Data_).ToList();
            else
                this.dataGridView1.DataSource = Data_.ToList();

            this.dataGridView1.Refresh();
        }

        public void 物品大類資料更新(IEnumerable<物品大類資料> Data_)
        {
            this.大類編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 物品小類資料更新(IEnumerable<物品小類資料> Data_)
        {
            this.小類編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 物品品牌資料更新(IEnumerable<物品品牌資料> Data_)
        {
            this.品牌編號.DataSource = Data_;
        }

        // 註冊事件:資料異動
        private void onEventCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 資料有異動，記錄須進行更新
            物品管理器.Instance.SetDirty();
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _物品資料Listener.Refresh();
            _物品大類資料Listener.Refresh();
            _物品小類資料Listener.Refresh();
            _物品品牌資料Listener.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            物品管理器.Instance.Add();
            _物品資料Listener.Refresh();
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                物品管理器.Instance.Delete((物品資料)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _物品資料Listener.Refresh();
            }
        }

        private void 庫存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ItemGroup_ = _物品資料Listener.Query
                                .Where(Value => Value.編號 > 0)
                                .GroupBy(
                                    Value => Value.品牌.名稱,
                                    Value => new 物品庫存匯出結構(Value));

            string Title_ = String.Format("物品庫存_{0}", 共用.NowYMDDec);
            函式.ExportExcel<物品庫存匯出結構>(Title_, ItemGroup_);
        }

        private void 總覽ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ItemGroup_ = _物品資料Listener.Query
                                .Where(Value => Value.編號 > 0)
                                .GroupBy(
                                    Value => Value.品牌.名稱,
                                    Value => new 物品總覽匯出結構(Value));

            string Title_ = String.Format("物品總覽_{0}", 共用.NowYMDDec);
            函式.ExportExcel<物品總覽匯出結構>(Title_, ItemGroup_);
        }

        public void onChildClosing(子視窗<物品資料> Child_)
        {
            // reuse, not close
            /*if (_子視窗 == Child_)
            {
                _子視窗 = null;
                return;
            }*/
        }

        public void onClickFilter(子視窗<物品資料> Child_)
        {
            _物品資料Listener.Refresh(true);
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_子視窗 == null)
            {
                _子視窗 = new WokyTool.FormOther.物品篩選視窗(this);
            }

            _子視窗.Show();
            _子視窗.BringToFront();
        }

        private void 物品總覽視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_子視窗 != null)
            {
                _子視窗.Close();
                _子視窗 = null;
            }
        }
    }
}
