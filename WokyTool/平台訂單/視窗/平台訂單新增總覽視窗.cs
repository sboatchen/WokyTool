using Newtonsoft.Json;
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
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.客製;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public partial class 平台訂單新增總覽視窗 : 總覽視窗
    {
        private int _公司資料版本 = -1;
        private int _客戶資料版本 = -1;

        public 平台訂單新增總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.平台訂單新增資料BindingSource, 平台訂單新增資料管理器.獨體);

            this.處理狀態DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.訂單處理狀態));

            this.指配時段DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.指配時段));
            this.代收方式DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.代收方式));
            this.配送公司DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.配送公司));
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.Notify("功能尚未實作");
            //視窗管理器.獨體.顯現(列舉.編號.平台訂單新增, 列舉.視窗.篩選);
        }

        private void 系統分組ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 清除所有舊的配送分組
            foreach(var Item_ in 平台訂單新增資料管理器.獨體.可編輯BList)
            {
                if (Item_.處理狀態 == 列舉.訂單處理狀態.新增)
                    Item_.重新分組();
            }

            int StartGroup_ = 1;
            var GroupQueue_ = 平台訂單新增資料管理器.獨體.可編輯BList.Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.新增).GroupBy(Value => Value.分組識別);
            foreach (var Group_ in GroupQueue_)
            {
                if (Group_.Count() == 1)
                    continue;

                foreach (var Item_ in Group_)
                    Item_.配送分組 = StartGroup_;
                
                StartGroup_++;

                var x = Group_.ToList();
            }

            this.dataGridView1.Refresh();

            訊息管理器.獨體.Notify("已完成系統分組");
        }

        private void 配送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var GroupQueue_ = 平台訂單新增資料管理器.獨體.可編輯BList.Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.新增).GroupBy(Value => Value.配送分組);

            List<可配送資料> 配送列表_ = new List<可配送資料>();
            foreach (var Group_ in GroupQueue_)
            {
                if (Group_.Key == 0)
                {
                    foreach (var Item_ in Group_)
                    {
                        配送列表_.Add(new 平台訂單配送資料(Item_));
                    }
                }
                else
                {
                    平台訂單新增資料 主單_ = Group_.First();

                    if (Group_.Count() == 1)
                        配送列表_.Add(new 平台訂單配送資料(主單_));
                    else
                        配送列表_.Add(new 平台合併訂單配送資料(Group_.ToList()));
                }
            }

            配送管理器.獨體.新增(配送列表_);

            訊息管理器.獨體.Notify("已轉入配送系統");
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var GroupQueue_ = 平台訂單新增資料管理器.獨體.可編輯BList
                                    .Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.配送 || Value.處理狀態 == 列舉.訂單處理狀態.忽略)
                                    .GroupBy(Value => Value.公司.編號 * 1000 + Value.客戶.編號);

            foreach (var Group_ in GroupQueue_)
            {
                平台訂單自定義介面 平台訂單自定義介面_ = Group_.First().自定義介面;

                平台訂單自定義介面_.回單(Group_);
            }

            訊息管理器.獨體.Notify("已完成匯出");
        }

        private void 完成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單新增資料管理器.獨體.完成();

            this.OnActivated(null);

            訊息管理器.獨體.Notify("已完成");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 設定群組顏色
            foreach (DataGridViewRow Myrow in dataGridView1.Rows)
            {
                int value = Convert.ToInt32(Myrow.Cells[1].Value);
                Myrow.DefaultCellStyle.BackColor = 顏色處理.GetRandomColor(value);
            }
        }

        //@@ move to parent 排序功能試做
        /*private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dataGridView1.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dataGridView1.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn && dataGridView1.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            dataGridView1.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }*/

        //@@ move to parent
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //訊息管理器.獨體.Notify("功能尚未實作");
            //int 編號_ = ((平台訂單新增資料)(this.平台訂單新增資料BindingSource.Current)).編號;
            //視窗管理器.獨體.顯現(列舉.編號.平台訂單新增, 列舉.視窗.詳細, 編號_);
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_公司資料版本 != 公司資料管理器.獨體.唯讀資料版本)
            {
                _公司資料版本 = 公司資料管理器.獨體.唯讀資料版本;
                this.公司資料BindingSource.DataSource = 公司資料管理器.獨體.唯讀BList;
            }

            if (_客戶資料版本 != 客戶資料管理器.獨體.唯讀資料版本)
            {
                _客戶資料版本 = 客戶資料管理器.獨體.唯讀資料版本;
                this.客戶資料BindingSource.DataSource = 客戶資料管理器.獨體.唯讀BList;
            }
        }
    }
}
