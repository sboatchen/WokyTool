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
//@@ 帶整理
namespace WokyTool
{
    public partial class 月結帳匯入視窗 : Form
    {
        private List<月結帳資料> _Source;
        private BindingSource _Binding;

        public 月結帳匯入視窗(IQueryable<月結帳資料> Query_)
        {
            InitializeComponent();

            _Source = Query_.ToList();

            _Binding = new BindingSource();
            _Binding.DataSource = _Source;
            this.dataGridView1.DataSource = _Binding;
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Source.Add(new 月結帳資料());   //@@
            _Binding.ResetBindings(true);
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                _Source.Remove((月結帳資料)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _Binding.ResetBindings(true);
            }
        }

        private void 月結帳匯入視窗_FormClosing(object sender, FormClosingEventArgs e)
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
                    Item_.編號 = 編碼管理器.Instance.Get(列舉.編碼類型.月結帳);
                    月結帳管理器.Instance.Add(Item_);
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            bool IsCheck_ =
               this.dataGridView1.Columns[e.ColumnIndex].Name == "商品名稱DataGridViewTextBoxColumn";

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

        private void 列錯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "錯誤月結帳";     // Default file name
            dlg.DefaultExt = ".csv";        // Default file extension
            dlg.Filter = "csv files (.csv)|*.csv"; // Filter files by extension

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName, false, Encoding.Default);

                var Error_ = _Source.Where(Value => Value.IsLegal() == false);

                CsvContext cc = new CsvContext();
                cc.Write(Error_, sw, 共用.OutputDefine);

                sw.Close();
            }
        }
    }
}