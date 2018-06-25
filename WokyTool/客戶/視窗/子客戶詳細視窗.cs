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
using WokyTool.聯絡人;

namespace WokyTool.客戶
{
    public partial class 子客戶詳細視窗 : 頁資料樣板視窗<子客戶資料>
    {
        private int _聯絡人資料版本;

        private 唯讀資料列選取插件<聯絡人資料> _唯讀資料列選取插件;

        public 子客戶詳細視窗() : base(子客戶資料管理器.獨體)
        {
            InitializeComponent();

            this.姓名DataGridViewTextBoxColumn.DataSource = 聯絡人資料管理器.獨體.BList;

            _聯絡人資料版本 = 聯絡人資料管理器.獨體.BindingVersion;

            _唯讀資料列選取插件 = new 唯讀資料列選取插件<聯絡人資料>(聯絡人資料管理器.獨體, this.dataGridView1, 1);
        }

        private void 下一個_Click(object sender, EventArgs e)
        {
            this.下一個();
        }

        private void 上一個_Click(object sender, EventArgs e)
        {
            this.上一個();
        }

        private void 子客戶詳細視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            儲存修改();

            this.Hide();
            e.Cancel = true;
        }

        private void 子客戶詳細視窗_Activated(object sender, EventArgs e)
        {
            if (_聯絡人資料版本 != 聯絡人資料管理器.獨體.BindingVersion)
            {
                _聯絡人資料版本 = 聯絡人資料管理器.獨體.BindingVersion;
                this.姓名DataGridViewTextBoxColumn.DataSource = 聯絡人資料管理器.獨體.BList;
            }

            目前資料 = null;
            嘗試更新資料();
        }
        /********************************/

        protected override void 更新資料()
        {
            this.名稱.Text = 目前資料.名稱;
            this.索引.Text = this.目前索引;

            _唯讀資料列選取插件.綁定(目前資料.聯絡人編號列);
        }

        protected override void 儲存修改()
        {
            if (目前資料 != null)
            {
                目前資料.名稱 = this.名稱.Text;
                目前資料.聯絡人編號列 = _唯讀資料列選取插件.編號列;
            }
        }
    }
}
