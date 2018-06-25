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
    public partial class 客戶總覽視窗 : Form
    {
        private 客戶詳細視窗 _客戶詳細視窗 = null;

        public 客戶總覽視窗()
        {
            InitializeComponent();

            this.客戶資料BindingSource.DataSource = 客戶資料管理器.獨體.BList;
        }

        private void 客戶總覽視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (客戶資料管理器.獨體.IsEditing() == false)
                return;

            var result = MessageBox.Show(字串.儲存確認內容, 字串.儲存確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            客戶資料管理器.獨體.UpdateEdit(result == DialogResult.Yes);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_客戶詳細視窗 == null)
                _客戶詳細視窗 = new 客戶詳細視窗();

            _客戶詳細視窗.設定索引(this.客戶資料BindingSource.Position);
            _客戶詳細視窗.Show();
        }

        private void 客戶總覽視窗_Activated(object sender, EventArgs e)
        {
            this.客戶資料BindingSource.ResetBindings(false);
        }
    }
}
