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
using WokyTool.DataImport;
using WokyTool.DataMgr;

namespace WokyTool.ImportForm
{
    public partial class 盤點出貨匯入視窗 : Form
    {
        protected BindingSource _Binding;
        protected List<盤點資料> _Source = null;
        protected 監測綁定更新<物品資料> _物品資料Listener;

        public 盤點出貨匯入視窗()
        {
            InitializeComponent();

            資料讀寫參數CSV Param_ = new 資料讀寫參數CSV()
            {
                檔案格式 = 列舉.檔案格式類型.CSV,
                CSV描述 = 資料讀寫參數CSV.無標頭讀取格式
            };
            IEnumerable<盤點資料> origin_ = 資料讀寫.ImportCSV<盤點資料>(Param_);
            if (origin_ == null) 
            {
                this.Close();
                return;
            }

            _Source = origin_.ToList();
            foreach (var item in _Source)
            {
                if (item.Init(列舉.盤點類型.出貨) == false)
                {
                    this.Close();
                    return;
                }
            }

            _物品資料Listener = new 監測綁定更新<物品資料>(物品管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品資料更新);
            _物品資料Listener.Refresh(true);
            this.物品編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            _Binding = new BindingSource();
            _Binding.DataSource = _Source;
            this.dataGridView1.DataSource = _Binding;

            this.Activated += new System.EventHandler(this.onEventActivated);

            this.Show();
            this.BringToFront();
        }

        public void 物品資料更新(IEnumerable<物品資料> Data_)
        {
            this.物品編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _物品資料Listener.Refresh();
        }

        private bool isLegal()
        {
            if (_Source == null)
                return false;

            foreach (var item in _Source)
            {
                if (item.isLegal() == false)
                    return false;
            }

            return true;
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            盤點資料 New_ = 盤點資料.New();
            New_.類型 = 列舉.盤點類型.出貨;

            _Source.Add(New_);
            _Binding.ResetBindings(true);

            this.dataGridView1.FirstDisplayedScrollingRowIndex = this.dataGridView1.RowCount - 1;
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                _Source.Remove((盤點資料)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _Binding.ResetBindings(true);
            }
        }

        private void 盤點出貨匯入視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_Source == null)
                return;

            // 檢查匯入資料的正確性
            if (isLegal() == false)
            {
                var result = MessageBox.Show(字串.匯入錯誤, 字串.匯入確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }

                return;
            }

            var result2 = MessageBox.Show(字串.匯入內容, 字串.匯入確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result2 == DialogResult.No)
                return;

            List<盤點歷史資料> History_ = new List<盤點歷史資料>();
            foreach (var Item_ in _Source)
            {
                盤點歷史資料 HistoryItem_ = 盤點歷史資料.New(Item_);
                Item_.物品.Sell(false, Item_.數量);
                History_.Add(HistoryItem_);
            }

            //@@ 應小胖需求，強制存檔
            函式.SaveAll();
        }
    }
}
