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
//@@ 帶整理
namespace WokyTool
{
    public partial class 月結帳總覽視窗 : Form
    {
        protected 監測綁定更新<月結帳資料> _Listener;

        public 月結帳總覽視窗()
        {
            InitializeComponent();

            _Listener = new 監測綁定更新<月結帳資料>(月結帳管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 月結帳資料更新);
            _Listener.Refresh(true);

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onEventCellValueChanged);
        }

        public void 月結帳資料更新(IEnumerable<月結帳資料> Data_)
        {
            this.dataGridView1.DataSource = Data_;
            this.dataGridView1.Refresh();
        }

        // 註冊事件:資料異動
        private void onEventCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 資料有異動，記錄須進行更新
            月結帳管理器.Instance.SetDirty();
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _Listener.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            月結帳管理器.Instance.Add();
            _Listener.Refresh();
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                月結帳管理器.Instance.Delete((月結帳資料)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _Listener.Refresh();
            }
        }
    }
}
