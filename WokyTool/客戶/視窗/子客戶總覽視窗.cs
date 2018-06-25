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

namespace WokyTool.客戶
{
    public partial class 子客戶總覽視窗 : Form
    {
        private 子客戶詳細視窗 _子客戶詳細視窗 = null;

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
            if (_子客戶詳細視窗 == null)
                _子客戶詳細視窗 = new 子客戶詳細視窗();

            _子客戶詳細視窗.設定索引(this.子客戶資料BindingSource.Position);
            _子客戶詳細視窗.Show();
        }

        private void 子客戶總覽視窗_Activated(object sender, EventArgs e)
        {
            this.子客戶資料BindingSource.ResetBindings(false);
        }
    }
}
