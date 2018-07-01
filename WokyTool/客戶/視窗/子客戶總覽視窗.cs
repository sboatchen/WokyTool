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

namespace WokyTool.客戶
{
    public partial class 子客戶總覽視窗 : Form
    {
        public 子客戶總覽視窗()
        {
            InitializeComponent();

            this.子客戶資料BindingSource.DataSource = 子客戶資料管理器.獨體.BList;
        }

        private void 子客戶總覽視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (子客戶資料管理器.獨體.IsEditing() == false)
                return;

            var result = MessageBox.Show(字串.儲存確認內容, 字串.儲存確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            子客戶資料管理器.獨體.UpdateEdit(result == DialogResult.Yes);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int 索引_ = this.子客戶資料BindingSource.Position;
            視窗管理器.獨體.顯現(列舉.視窗類型.子客戶, 索引_);
        }

        private void 子客戶總覽視窗_Activated(object sender, EventArgs e)
        {
            this.子客戶資料BindingSource.ResetBindings(false);
        }
    }
}
