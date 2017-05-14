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
    public partial class 銷售總覽視窗 : Form, 父視窗<銷售資料_編輯>
    {
        protected 子視窗<銷售資料_編輯> _子視窗 = null;
        protected 監測綁定更新<銷售資料_編輯> _Listener;

        public 銷售總覽視窗()
        {
            InitializeComponent();

            _Listener = new 監測綁定更新<銷售資料_編輯>(銷售管理器.Instance.Binding, 列舉.監測類型.被動通知_公式, 銷售資料更新);
            _Listener.Refresh(true);

            this.狀態DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.銷售狀態類型));

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onEventCellValueChanged);
        }

        public void 銷售資料更新(IEnumerable<銷售資料_編輯> Data_)
        {
            List<銷售資料_編輯> xxx = Data_.ToList();
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
            銷售管理器.Instance.SetDirty();
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _Listener.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("尚未實作", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("尚未實作", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("尚未實作", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("尚未實作", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void 結算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("尚未實作", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void onChildClosing(子視窗<銷售資料_編輯> Child_)
        {
        }

        public void onClickFilter(子視窗<銷售資料_編輯> Child_)
        {
            _Listener.Refresh(true);
        }

        private void 銷售總覽視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_子視窗 != null)
            {
                _子視窗.Close();
                _子視窗 = null;
            }
        }
    }
}
