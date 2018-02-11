
using LINQtoCSV;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataImport;
using WokyTool.DataMgr;

namespace WokyTool
{
    public partial class 物品匯入視窗 : Form
    {
        private List<物品匯入結構> _Source;
        private BindingSource _Binding;

        protected 監測綁定更新<物品大類資料> _物品大類資料Listener;
        protected 監測綁定更新<物品小類資料> _物品小類資料Listener;
        protected 監測綁定更新<物品品牌資料> _物品品牌資料Listener;

        public 物品匯入視窗(ExcelQueryFactory Data)
        {
            InitializeComponent();

            _Source = Data.Worksheet<物品匯入結構>()
                            .ToList();

            foreach (var Item_ in _Source)
                Item_.Init();

            _Binding = new BindingSource();
            _Binding.DataSource = _Source;
            this.dataGridView1.DataSource = _Binding;

            _物品大類資料Listener = new 監測綁定更新<物品大類資料>(物品大類管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品大類資料更新);
            _物品大類資料Listener.Refresh(true);

            _物品小類資料Listener = new 監測綁定更新<物品小類資料>(物品小類管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品小類資料更新);
            _物品小類資料Listener.Refresh(true);

            _物品品牌資料Listener = new 監測綁定更新<物品品牌資料>(物品品牌管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品品牌資料更新);
            _物品品牌資料Listener.Refresh(true);

            this.大類編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.小類編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.品牌編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
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
            this.品牌編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _物品大類資料Listener.Refresh();
            _物品小類資料Listener.Refresh();
            _物品品牌資料Listener.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Source.Add(物品匯入結構.New());
            _Binding.ResetBindings(true);

            this.dataGridView1.FirstDisplayedScrollingRowIndex = this.dataGridView1.RowCount - 1;
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                _Source.Remove((物品匯入結構)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _Binding.ResetBindings(true);
            }
        }

        private void 列錯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "錯誤物品";              // Default file name
            dlg.DefaultExt = ".csv";                // Default file extension
            dlg.Filter = "csv files (.csv)|*.csv";  // Filter files by extension

            if (dlg.ShowDialog() == DialogResult.OK) 
            {
                StreamWriter sw = new StreamWriter(dlg.FileName, false, Encoding.Default);

                var Error_ = _Source.Where(Value => Value.IsLegal() == false)
                                    .Select(Value => Value.ToError());

                CsvContext cc = new CsvContext();
                cc.Write(Error_, sw, 共用.OutputDefine);

                sw.Close();
            }
        }

        private void 物品匯入視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 檢查匯入資料的正確性
            foreach (var Data in _Source)
            {
                // 資料有錯誤
                if (Data.IsLegal() == false)
                {
                    var result = MessageBox.Show(字串.匯入錯誤, 字串.匯入確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }

                    return;
                }
            }

            var result2 = MessageBox.Show(字串.匯入內容, 字串.匯入確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result2 == DialogResult.Yes)
            {
                foreach (var Item_ in _Source)
                {
                    物品管理器.Instance.Add(Item_.ToData());
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            bool IsCheck_ =
               this.dataGridView1.Columns[e.ColumnIndex].Name == "大類編號DataGridViewTextBoxColumn" ||
               this.dataGridView1.Columns[e.ColumnIndex].Name == "小類編號DataGridViewTextBoxColumn" ||
               this.dataGridView1.Columns[e.ColumnIndex].Name == "品牌編號DataGridViewTextBoxColumn";

            if (IsCheck_)
            {
                if ((string)e.Value == 字串.錯誤)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}

