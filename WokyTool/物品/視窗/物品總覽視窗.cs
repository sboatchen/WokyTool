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
using WokyTool.通用;

namespace WokyTool.物品
{
    public partial class 物品總覽視窗 : 總覽視窗
    {
        private int _物品大類資料版本 = -1;
        private int _物品小類資料版本 = -1;
        private int _物品品牌資料版本 = -1;

        public 物品總覽視窗()
        {
            InitializeComponent();

            this.初始化<物品資料>(this.物品資料BindingSource, 物品資料管理器.獨體);
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 總表ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 庫存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 盤點ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 自訂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能尚未實作", 字串.確認, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /********************************/
        // 詳細視窗樣板_子客戶

        protected override void 視窗激活()
        {
            if (_物品大類資料版本 != 物品大類資料管理器.獨體.BindingVersion)
            {
                _物品大類資料版本 = 物品大類資料管理器.獨體.BindingVersion;
                this.物品大類資料BindingSource.DataSource = 物品大類資料管理器.獨體.唯讀BList;
            }

            if (_物品小類資料版本 != 物品小類資料管理器.獨體.BindingVersion)
            {
                _物品小類資料版本 = 物品小類資料管理器.獨體.BindingVersion;
                this.物品小類資料BindingSource.DataSource = 物品小類資料管理器.獨體.唯讀BList;
            }

            if (_物品品牌資料版本 != 物品品牌資料管理器.獨體.BindingVersion)
            {
                _物品品牌資料版本 = 物品品牌資料管理器.獨體.BindingVersion;
                this.物品品牌資料BindingSource.DataSource = 物品品牌資料管理器.獨體.唯讀BList;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 編號_ = ((物品資料)(this.物品資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.編碼類型.物品, 編號_);
        }
    }
}
