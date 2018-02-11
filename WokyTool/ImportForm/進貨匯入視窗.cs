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

namespace WokyTool.ImportForm
{
    public partial class 進貨匯入視窗 : Form
    {
        private bool _IsImport = false;

        private List<進貨匯入結構> _Source;
        private BindingSource _Binding;
        private 列舉.進貨類型 _Type;

        protected 監測綁定更新<廠商資料> _廠商資料Listener;
        protected 監測綁定更新<物品資料> _物品資料Listener;
        protected 監測綁定更新<幣值資料> _幣值資料Listener;

        public 進貨匯入視窗(列舉.進貨類型 Type_)
        {
            InitializeComponent();

            _Type = Type_;

            this.Text = _Type.ToString() + "匯入視窗";

            _廠商資料Listener = new 監測綁定更新<廠商資料>(廠商管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 廠商資料更新);
            _廠商資料Listener.Refresh(true);

            _物品資料Listener = new 監測綁定更新<物品資料>(物品管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品資料更新);
            _物品資料Listener.Refresh(true);

            _幣值資料Listener = new 監測綁定更新<幣值資料>(幣值管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 幣值資料更新);
            _幣值資料Listener.Refresh(true);

            //this.類型.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.廠商編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.物品編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.幣值編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            UpdateState(_IsImport);

            this.Activated += new System.EventHandler(this.onEventActivated);
        }

        public void 廠商資料更新(IEnumerable<廠商資料> Data_)
        {
            this.廠商編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 物品資料更新(IEnumerable<物品資料> Data_)
        {
            this.物品編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 幣值資料更新(IEnumerable<幣值資料> Data_)
        {
            this.幣值編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _廠商資料Listener.Refresh();
            _物品資料Listener.Refresh();
            _幣值資料Listener.Refresh();
        }

        private void UpdateState(bool IsImport_)
        {
            _IsImport = IsImport_;

            if (_IsImport)
            {
                匯入ToolStripMenuItem.Enabled = false;
                新增ToolStripMenuItem.Enabled = true;
                刪除ToolStripMenuItem.Enabled = true;
                列錯ToolStripMenuItem.Enabled = true;
            }
            else
            {
                匯入ToolStripMenuItem.Enabled = true;
                新增ToolStripMenuItem.Enabled = false;
                刪除ToolStripMenuItem.Enabled = false;
                列錯ToolStripMenuItem.Enabled = false;
            }
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);

                    _Source = Excel_.Worksheet<進貨匯入結構>().ToList();
                    foreach (var Item_ in _Source)
                        Item_.Init(_Type);

                    _Binding = new BindingSource();
                    _Binding.DataSource = _Source;
                    this.dataGridView1.DataSource = _Binding;

                    UpdateState(true);
                }
                catch (Exception Error_)
                {
                    MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Source.Add(進貨匯入結構.New());
            _Binding.ResetBindings(true);

            this.dataGridView1.FirstDisplayedScrollingRowIndex = this.dataGridView1.RowCount - 1;
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                _Source.Remove((進貨匯入結構)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _Binding.ResetBindings(true);
            }
        }

        private void 列錯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "錯誤進貨";              // Default file name
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

        private void 進貨匯入視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_Source == null)
                return;

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
                    進貨管理器.Instance.Add(Item_.Import());
                }

                //@@ 應小胖需求，強制存檔
                函式.SaveAll();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "物品編號DataGridViewTextBoxColumn" ||
                this.dataGridView1.Columns[e.ColumnIndex].Name == "幣值編號DataGridViewTextBoxColumn")
            {
                if ((string)e.Value == 字串.錯誤 || (string)e.Value == 字串.無)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "廠商編號DataGridViewTextBoxColumn")
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
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "數量DataGridViewTextBoxColumn")
            {
                if (_Type != 列舉.進貨類型.庫存調整 && (int)e.Value == 0)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void 樣板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch(_Type){
                case 列舉.進貨類型.一般:
                    函式.GetFile("進貨匯入範本", "Template/OtherImport/進貨匯入範本.xlsx");
                    break;
                case 列舉.進貨類型.退貨重進:
                    函式.GetFile("退貨重進匯入範本", "Template/OtherImport/進貨匯入範本.xlsx");
                    break;
                case 列舉.進貨類型.庫存調整:
                    函式.GetFile("庫存調整匯入範本", "Template/OtherImport/進貨匯入範本.xlsx");
                    break;
            }
        }
    }
}
