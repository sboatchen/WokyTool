using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.一般訂單;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    public partial class 一般訂單新增總覽視窗 : 總覽視窗
    {
        private int _公司資料版本 = -1;
        private int _客戶資料版本 = -1;
        private int _子客戶資料版本 = -1;

        public 一般訂單新增總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.一般訂單新增資料BindingSource, 一般訂單新增資料管理器.獨體);

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

        private void 配送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Queue_ = 一般訂單新增資料管理器.獨體.可編輯BList.Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.新增).Select(Value => new 一般訂單配送資料(Value));

            配送管理器.獨體.新增(Queue_);

            訊息管理器.獨體.Notify("已轉入配送系統");
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Queue_ = 一般訂單新增資料管理器.獨體.可編輯BList
                                    .Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.配送)
                                    .Select(Value => new 一般訂單銷售匯出結構(Value));

            foreach (var Item_ in Queue_)
            {
                string Title_ = String.Format("一般訂單銷售_{0}_{1}", Item_.資料.編號, 時間.目前日期);
                檔案.寫入Excel(Title_, Item_); ;
            }

            訊息管理器.獨體.Notify("已完成匯出");
        }

        private void 完成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            一般訂單新增資料管理器.獨體.完成();

            this.OnActivated(null);

            訊息管理器.獨體.Notify("已完成");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 編號_ = ((一般訂單新增資料)(this.一般訂單新增資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.編號.一般訂單新增, 列舉.視窗.詳細, 編號_);
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

            if (_子客戶資料版本 != 子客戶資料管理器.獨體.唯讀資料版本)
            {
                _子客戶資料版本 = 子客戶資料管理器.獨體.唯讀資料版本;
                this.子客戶資料BindingSource.DataSource = 子客戶資料管理器.獨體.唯讀BList;
            }
        }
    }
}
