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
        IEnumerable<讀寫測試資料> _資料列;

        public 資料綁定測試視窗(IEnumerable<讀寫測試資料> 資料列_)
        {
            InitializeComponent();

            this._資料列 = 資料列_;
            this.讀寫測試資料BindingSource.Filter = "字串 = '字串1'";
            //this.讀寫測試資料BindingSource.DataSource = _資料列.Where(Value => Value.整數 > 50);

            var listBinding = new BindingList<讀寫測試資料>(_資料列.Where(Value => Value.整數 > 50).ToList());
            this.讀寫測試資料BindingSource.DataSource = listBinding;
        }

        private void 列印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var 資料_ in _資料列)
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
            foreach (var 資料_ in _資料列)
            {
                Console.WriteLine(資料_.ToString(false));
            }
        }

        private void 執行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.讀寫測試資料BindingSource.Filter = this.過濾輸入.Text;
            this.讀寫測試資料BindingSource.ResetBindings(false);
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var col = dataGridView1.Columns[e.ColumnIndex];

            System.Reflection.PropertyInfo prop = typeof(讀寫測試資料).GetProperty(col.DataPropertyName);
            this.讀寫測試資料BindingSource.DataSource = _資料列.OrderBy(Value => prop.GetValue(Value));

            /*var col = dataGridView1.Columns[e.ColumnIndex];

            ListSortDirection direction;
            if (dataGridView1.SortOrder == (SortOrder.Descending | SortOrder.None))
            {
                direction = ListSortDirection.Ascending;
            }
            else
            {
                direction = ListSortDirection.Descending;
            }

            // Sort 只能指定單欄位排序
            dataGridView1.Sort(col, direction);

            // SortGlyphDirection 就是 Header 那個排序的三角符號
            col.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;*/

            //ShowSortInfo();
        }
    }
}
