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

namespace WokyTool.使用者
{
    public partial class 使用者總覽視窗 : 新版總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.使用者; } }
        public override Type 資料類型 { get { return typeof(使用者資料); } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 使用者資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.dataGridView1; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }
        public override ToolStripMenuItem 自訂MI { get { return this.自訂ToolStripMenuItem; } }

        public 使用者總覽視窗()
        {
            InitializeComponent();
        }

        protected override void _雙點擊資料(object sender, DataGridViewCellEventArgs e)
        {
            if (系統參數.修改基本資料 == false)
                return;

            使用者資料 目前使用者資料_ = (使用者資料)this.資料BS.Current;
            if (目前使用者資料_ == null)
                return;

            密碼修改視窗 密碼修改視窗_ = new 密碼修改視窗(目前使用者資料_);
            密碼修改視窗_.顯現();
        }
    }
}
