using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.測試
{
    public partial class 資料綁定測試視窗 : Form
    {
        private 可篩選列舉資料管理介面 _管理介面;
        private 讀寫測試資料篩選 _篩選介面;
        private int _資料版本 = -1;

        public 資料綁定測試視窗()
        {
            InitializeComponent();

            _管理介面 = 讀寫測試資料管理器.獨體.編輯;
            _篩選介面 = (讀寫測試資料篩選)_管理介面.篩選介面;
            _資料版本 = _管理介面.資料版本;

            this.讀寫測試資料BindingSource.DataSource = _管理介面.資料列舉;
        }

        private void 列印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var 資料_ in (IEnumerable<讀寫測試資料>)_管理介面.資料列舉)
            {
                Console.WriteLine(資料_.ToString(false));
            }
        }

        private void 資料綁定測試視窗_Activated(object sender, EventArgs e)
        {
            this.讀寫測試資料BindingSource.ResetBindings(false);
        }

        private void 取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var 資料_ in (IEnumerable<讀寫測試資料>)_管理介面.資料列舉)
            {
                Console.WriteLine(資料_.ToString(false));
            }
        }

        private void 執行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.讀寫測試資料BindingSource.Filter = this.最小整數.Text;
            this.讀寫測試資料BindingSource.ResetBindings(false);
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var col = dataGridView1.Columns[e.ColumnIndex];
            this._篩選介面.排序欄位 = col.DataPropertyName;

            更新呈現();
        }

        private void 更新呈現()
        {

            if (_資料版本 != _管理介面.資料版本)
            {
                _資料版本 = _管理介面.資料版本;
                this.讀寫測試資料BindingSource.DataSource = _管理介面.資料列舉;

                Console.WriteLine("更新選單");
            }
        }

        private void 最小整數_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.最小整數.Text))
                this._篩選介面.最小整數 = -1;
            else
                this._篩選介面.最小整數 = Int32.Parse(this.最小整數.Text);

            更新呈現();
        }
    }
}
