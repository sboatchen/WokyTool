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
    public partial class 商品總覽視窗 : Form
    {
        protected 商品篩選視窗 _商品篩選視窗 = null;

        public 商品總覽視窗()
        {
            InitializeComponent();

            SetDataSource();

            this.大類編號DataGridViewTextBoxColumn.DataSource = 商品大類管理器.Instance.Binding;
            this.小類編號DataGridViewTextBoxColumn.DataSource = 商品小類管理器.Instance.Binding;
            this.公司編號.DataSource = 公司管理器.Instance.Binding;
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

        public void SetDataSource()
        {
            this.dataGridView1.DataSource = 商品管理器.Instance.Binding;
        }

        public void SetDataSource(object DataSource)
        {
            this.dataGridView1.DataSource = DataSource;
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

        private void 庫存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ItemGroup_ = 商品管理器.Instance.Map.Values  //.Where(Value => Value.寄庫 > 0)
                                .Where(Value => Value.廠商.編號 > 0)  
                                .GroupBy(
                                Value => Value.廠商.名稱,
                                Value => new 商品庫存匯出結構(Value)
                               );

            string Title_ = String.Format("商品庫存_{0}", 共用.NowYMDDec);
            函式.ExportExcel<商品庫存匯出結構>(Title_, ItemGroup_);
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_商品篩選視窗 == null)
            {
                _商品篩選視窗 = new WokyTool.FormOther.商品篩選視窗(this);
            }

            _商品篩選視窗.Show();
            _商品篩選視窗.BringToFront();
        }

        private void 商品總覽視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_商品篩選視窗 != null)
            {
                _商品篩選視窗.Close();
                _商品篩選視窗 = null;
            }
        }

        public void on商品篩選視窗Closing()
        {
            if (_商品篩選視窗 != null)
            {
                _商品篩選視窗 = null;
            }
        }
    }
}
