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
using WokyTool.FormOther;
using Excel = Microsoft.Office.Interop.Excel;


namespace WokyTool
{
    public partial class 商品總覽視窗 : Form, 父視窗<商品資料>
    {
        protected 子視窗<商品資料> _子視窗 = null;

        protected 監測綁定更新<商品大類資料> _商品大類資料Listener;
        protected 監測綁定更新<商品小類資料> _商品小類資料Listener;
        protected 監測綁定更新<公司資料> _公司資料Listener;
        protected 監測綁定更新<廠商資料> _廠商資料Listener;
        protected 監測綁定更新<物品資料> _物品資料Listener;
        protected 監測綁定更新<商品資料> _商品資料Listener;

        public 商品總覽視窗()
        {
            InitializeComponent();

            _商品大類資料Listener = new 監測綁定更新<商品大類資料>(商品大類管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 商品大類資料更新);
            _商品大類資料Listener.Refresh(true);

            _商品小類資料Listener = new 監測綁定更新<商品小類資料>(商品小類管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 商品小類資料更新);
            _商品小類資料Listener.Refresh(true);

            _公司資料Listener = new 監測綁定更新<公司資料>(公司管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 公司資料更新);
            _公司資料Listener.Refresh(true);

            _廠商資料Listener = new 監測綁定更新<廠商資料>(廠商管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 廠商資料更新);
            _廠商資料Listener.Refresh(true);

            _物品資料Listener = new 監測綁定更新<物品資料>(物品管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品資料更新);
            _物品資料Listener.Refresh(true);

            _商品資料Listener = new 監測綁定更新<商品資料>(商品管理器.Instance.Binding, 列舉.監測類型.被動通知_公式, 商品資料更新);
            _商品資料Listener.Refresh(true);

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onEventCellValueChanged);
        }

        public void 商品大類資料更新(IEnumerable<商品大類資料> Data_)
        {
            this.大類編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 商品小類資料更新(IEnumerable<商品小類資料> Data_)
        {
            this.小類編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 公司資料更新(IEnumerable<公司資料> Data_)
        {
            this.公司編號.DataSource = Data_;
        }

        public void 廠商資料更新(IEnumerable<廠商資料> Data_)
        {
            this.廠商編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 物品資料更新(IEnumerable<物品資料> Data_)
        {
            this.需求編號1DataGridViewTextBoxColumn.DataSource = Data_;
            this.需求編號2DataGridViewTextBoxColumn.DataSource = Data_;
            this.需求編號3DataGridViewTextBoxColumn.DataSource = Data_;
            this.需求編號4DataGridViewTextBoxColumn.DataSource = Data_;
            this.需求編號5DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 商品資料更新(IEnumerable<商品資料> Data_)
        {
            if (_子視窗 != null && _子視窗.IsVisible() == true)
                this.dataGridView1.DataSource = _子視窗.Filt(Data_).ToList();
            else
                this.dataGridView1.DataSource = Data_.ToList();

            this.dataGridView1.Refresh();
        }

        // 註冊事件:資料異動
        private void onEventCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 資料有異動，記錄須進行更新
            商品管理器.Instance.SetDirty();
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _商品大類資料Listener.Refresh();
            _商品小類資料Listener.Refresh();
            _公司資料Listener.Refresh();
            _廠商資料Listener.Refresh();
            _物品資料Listener.Refresh();
            _商品資料Listener.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            商品管理器.Instance.Add();
            _商品資料Listener.Refresh();

            this.dataGridView1.FirstDisplayedScrollingRowIndex = this.dataGridView1.RowCount - 1;
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                商品管理器.Instance.Delete((商品資料)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _商品資料Listener.Refresh();
            }
        }

        private void 庫存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ItemGroup_ = _商品資料Listener.Query
                                .Where(Value => Value.廠商.編號 > 0)  
                                .GroupBy(
                                Value => Value.廠商.名稱,
                                Value => new 商品庫存匯出結構(Value));

            string Title_ = String.Format("商品庫存_{0}", 共用.NowYMDDec);
            函式.ExportExcel<商品庫存匯出結構>(Title_, ItemGroup_);
        }

        public void onChildClosing(子視窗<商品資料> Child_)
        {
            // reuse, not close
            /*if (_子視窗 == Child_)
            {
                _子視窗 = null;
                return;
            }*/
        }

        public void onClickFilter(子視窗<商品資料> Child_)
        {
            _商品資料Listener.Refresh(true);
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_子視窗 == null)
                _子視窗 = new WokyTool.FormOther.商品篩選視窗(this);

            _子視窗.Show();
            _子視窗.BringToFront();
        }

        private void 商品總覽視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_子視窗 != null)
            {
                _子視窗.Close();
                _子視窗 = null;
            }
        }
    }
}
