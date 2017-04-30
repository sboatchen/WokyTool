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
    public partial class 物品總覽視窗 : Form, 父視窗
    {
        protected 子視窗 _子視窗 = null;

        public 物品總覽視窗()
        {
            InitializeComponent();

             this.dataGridView1.DataSource = 物品管理器.Instance.Binding;

             this.大類編號DataGridViewTextBoxColumn.DataSource = 物品大類管理器.Instance.Binding;
             this.小類編號DataGridViewTextBoxColumn.DataSource = 物品小類管理器.Instance.Binding;
             this.品牌編號.DataSource = 物品品牌管理器.Instance.Binding;

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onEventCellValueChanged);
        }

        // 註冊事件:資料異動
        private void onEventCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 資料有異動，記錄須進行更新
            物品管理器.Instance.IsDirty = true;
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            this.dataGridView1.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            物品管理器.Instance.Add();
            this.dataGridView1.Refresh();
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                物品管理器.Instance.Delete((物品資料)this.dataGridView1.SelectedRows[0].DataBoundItem);
                this.dataGridView1.Refresh();
            }
        }

        private void 庫存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ItemGroup_ = 物品管理器.Instance.Map.Values  //.Where(Value => Value.庫存總量 > 0)
                                .Where(Value => Value.編號 > 0)
                                .GroupBy(
                                Value => Value.品牌.名稱,
                                Value => new 物品庫存匯出結構(Value)
                               );

            string Title_ = String.Format("物品庫存_{0}", 共用.NowYMDDec);
            函式.ExportExcel<物品庫存匯出結構>(Title_, ItemGroup_);
        }

        private void 總覽ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             var ItemGroup_ = 物品管理器.Instance.Map.Values
                                .Where(Value => Value.編號 > 0)
                                .GroupBy(
                                    Value => Value.品牌.名稱,
                                    Value => new 物品總覽匯出結構(Value)
                                );

            string Title_ = String.Format("物品總覽_{0}", 共用.NowYMDDec);
            函式.ExportExcel<物品總覽匯出結構>(Title_, ItemGroup_);
        }

        public void onChildClosing(子視窗 Child_)
        {
            if (_子視窗 == Child_)
            {
                _子視窗 = null;
                return;
            }
        }

        public void onUpdateDataSource(Object DataSource_)
        {
            this.dataGridView1.DataSource = DataSource_;
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_子視窗 == null)
            {
                _子視窗 = new WokyTool.FormOther.物品篩選視窗();
                _子視窗.SetParentForm(this);
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
