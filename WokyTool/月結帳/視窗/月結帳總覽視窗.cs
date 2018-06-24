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

namespace WokyTool.月結帳
{
    public partial class 月結帳總覽視窗 : Form
    {
        protected int _BindingVersion;

        public 月結帳總覽視窗()
        {
            InitializeComponent();

            this.月結帳資料BindingSource.DataSource = 月結帳資料管理器.獨體.BList;
            this._BindingVersion = 月結帳資料管理器.獨體.BindingVersion;
        }

        private void 月結帳總覽視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (月結帳資料管理器.獨體.IsEditing() == false)
                return;

            var result = MessageBox.Show(字串.儲存確認內容, 字串.儲存確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            月結帳資料管理器.獨體.UpdateEdit(result == DialogResult.Yes);
        }

        private void 月結帳總覽視窗_Activated(object sender, EventArgs e)
        {
            // 檢查資料版本是否異動
            int NowVersion_ = 月結帳資料管理器.獨體.BindingVersion;
            if (NowVersion_ == _BindingVersion)
                return;

            // 沒有更改內容，直接刷新資料
            if (月結帳資料管理器.獨體.IsEditing() == false)
            {
                this.月結帳資料BindingSource.DataSource = 月結帳資料管理器.獨體.BList;
                this.dataGridView1.Refresh();
                return;
            }

            // 通知使用者資料衝突，需進行重開
            this.dataGridView1.Enabled = false;

            MessageBox.Show(字串.資料異動內容, 字串.資料異動, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  this.月結帳資料BindingSource.Filter
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ItemGroup_ = ((BindingList<月結帳資料>)(this.月結帳資料BindingSource.DataSource))
                                .GroupBy(
                                    Value => Value.廠商名稱,
                                    Value => new 月結帳資料匯出結構(Value));

            string Title_ = String.Format("月結帳匯出_{0}", 共用.NowYMDDec);
            函式.ExportExcel<月結帳資料匯出結構>(Title_, ItemGroup_);
        }
    }
}
