using LinqToExcel;
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
using WokyTool.DataImport;
using WokyTool.DataMgr;

namespace WokyTool.ImportForm
{
    public partial class 條碼更新匯入視窗 : Form
    {
        private Boolean _isInit = false;
        private List<條碼更新匯入結構> _Source;
        private BindingSource _Binding;

        public 條碼更新匯入視窗()
        {
            InitializeComponent();
        }

        private void 條碼更新匯入視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_Source == null)
                return;

            var result = MessageBox.Show(字串.匯入內容, 字串.匯入確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            // 檢查匯入資料的正確性
            foreach (var Data in _Source)
            {
                Data.Save();
            }

            //@@ 應小胖需求，強制存檔
            物品管理器.Instance.SetDirty();
            函式.SaveAll();
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

                    _Source = Excel_.Worksheet<條碼更新匯入結構>().ToList();
                    foreach (var Item_ in _Source)
                        Item_.Init();

                    _Binding = new BindingSource();
                    _Binding.DataSource = _Source;
                    this.dataGridView1.DataSource = _Binding;

                    _isInit = true;
                    this.匯入ToolStripMenuItem.Enabled = false;

                }
                catch (Exception Error_)
                {
                    MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能目前不支援");
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                _Source.Remove((條碼更新匯入結構)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _Binding.ResetBindings(true);
            }
        }

        private void 列錯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isInit == false)
                return;

            var Items_ = _Source.Where(Value => Value.狀態 == 列舉.更新狀態.錯誤);

            string Title_ = String.Format("條碼更新匯入列錯_{0}", 共用.NowYMDDec);
            函式.ExportExcel<條碼更新匯入結構>(Title_, Items_);

        }

        private void 樣板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            函式.GetFile("進貨匯入範本", "Template/OtherImport/條碼更新範本.xlsx");
        }

        /*private void 列錯ToolStripMenuItem_Click(object sender, EventArgs e)
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

        }*/
    }
}
