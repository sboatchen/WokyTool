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
using WokyTool.通用;

namespace WokyTool.ImportForm
{
    public partial class 物品更新匯入視窗 : Form
    {
        private List<物品更新匯入結構> _Source;
        private BindingSource _Binding;

        public 物品更新匯入視窗(ExcelQueryFactory Data)
        {
            InitializeComponent();

            _Source = Data.Worksheet<物品更新匯入結構>()
                           .ToList();

            foreach (var Item_ in _Source)
                Item_.Init();

            _Binding = new BindingSource();
            _Binding.DataSource = _Source;
            this.dataGridView1.DataSource = _Binding;
        }

        private void 匯出檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Title_ = String.Format("物品更新匯出_{0}", 時間.目前日期);
            舊函式.ExportExcel<物品更新匯入結構>(Title_, _Source);
        }

        private void 更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.更新ToolStripMenuItem.Enabled = false;

            foreach (var Item_ in _Source)
                Item_.Import();
        }
    }
}