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

namespace WokyTool
{
    public partial class 物品品牌總覽視窗 : Form
    {
        protected 監測綁定更新<物品品牌資料> _Listener;

        public 物品品牌總覽視窗()
        {
            InitializeComponent();

            _Listener = new 監測綁定更新<物品品牌資料>(物品品牌管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品品牌資料更新);
            _Listener.Refresh(true);

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onEventCellValueChanged);
        }

        public void 物品品牌資料更新(IEnumerable<物品品牌資料> Data_)
        {
            this.dataGridView1.DataSource = Data_;
            this.dataGridView1.Refresh();
        }

        // 註冊事件:資料異動
        private void onEventCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 資料有異動，記錄須進行更新
            物品品牌管理器.Instance.SetDirty();
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _Listener.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            物品品牌管理器.Instance.Add();
            _Listener.Refresh();
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                物品品牌管理器.Instance.Delete((物品品牌資料)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _Listener.Refresh();
            }
        }
    }
}
