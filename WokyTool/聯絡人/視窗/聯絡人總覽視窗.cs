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

namespace WokyTool.聯絡人
{
    public partial class 聯絡人總覽視窗 : Form
    {
        public 聯絡人總覽視窗()
        {
            InitializeComponent();

            this.聯絡人資料BindingSource.DataSource = 聯絡人資料管理器.獨體.BList;
        }

        private void 聯絡人總覽視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (聯絡人資料管理器.獨體.IsEditing() == false)
                return;

            var result = MessageBox.Show(字串.儲存確認內容, 字串.儲存確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            聯絡人資料管理器.獨體.UpdateEdit(result == DialogResult.Yes);
        }

        private void 聯絡人總覽視窗_Activated(object sender, EventArgs e)
        {
            this.聯絡人資料BindingSource.ResetBindings(false);
        }
    }
}
