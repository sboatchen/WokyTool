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
using WokyTool.DataImport;
using WokyTool.DataMgr;

namespace WokyTool.ImportForm
{
    public partial class 雜支匯入視窗 : Form
    {
        private List<雜支匯入結構> _Source;
        private BindingSource _Binding;

        public 雜支匯入視窗(ExcelQueryFactory Data)
        {
            InitializeComponent();

            _Source = Data.Worksheet<雜支匯入結構>()
                            .ToList();

            foreach (var Item_ in _Source)
                Item_.Init();

            _Binding = new BindingSource();
            _Binding.DataSource = _Source;
            this.dataGridView1.DataSource = _Binding;

            this.廠商編號DataGridViewTextBoxColumn.DataSource = 廠商管理器.Instance.Binding;
            this.幣值編號DataGridViewTextBoxColumn.DataSource = 幣值管理器.Instance.Binding;

            this.廠商編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.幣值編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Source.Add(雜支匯入結構.New());
            _Binding.ResetBindings(true);
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                _Source.Remove((雜支匯入結構)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _Binding.ResetBindings(true);
            }
        }

        private void 列錯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "錯誤雜支";              // Default file name
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

        private void 雜支匯入視窗_FormClosing(object sender, FormClosingEventArgs e)
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
                    雜支管理器.Instance.Add(Item_.ToData());
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "數量DataGridViewTextBoxColumn")
            {
                if ((int)e.Value == 0)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
            else if(this.dataGridView1.Columns[e.ColumnIndex].Name == "廠商編號DataGridViewTextBoxColumn" ||
                this.dataGridView1.Columns[e.ColumnIndex].Name == "幣值編號DataGridViewTextBoxColumn")
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
