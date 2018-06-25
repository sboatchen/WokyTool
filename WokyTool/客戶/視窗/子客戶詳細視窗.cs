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
using WokyTool.聯絡人;

namespace WokyTool.客戶
{
    public partial class 子客戶詳細視窗 : Form, 可更新儲存介面
    {
        private int _聯絡人資料版本;

        private 唯讀資料列選取插件<聯絡人資料> _唯讀資料列選取插件;

        public 子客戶詳細視窗()// : base(子客戶資料管理器.獨體)
        {
            InitializeComponent();

            this.頁索引元件1.初始化<子客戶資料>(子客戶資料管理器.獨體.BList, this);

            this.姓名DataGridViewTextBoxColumn.DataSource = 聯絡人資料管理器.獨體.BList;

            _聯絡人資料版本 = 聯絡人資料管理器.獨體.BindingVersion;

            _唯讀資料列選取插件 = new 唯讀資料列選取插件<聯絡人資料>(聯絡人資料管理器.獨體, this.dataGridView1, 1);
        }

        private void 子客戶詳細視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            儲存修改();

            if (子客戶資料管理器.獨體.IsEditing())
            {
                var result = MessageBox.Show(字串.儲存確認內容, 字串.儲存確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                子客戶資料管理器.獨體.UpdateEdit(result == DialogResult.Yes);
            }

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

            this.頁索引元件1.刷新();
        }

        /********************************/

        public void 更新資料()
        {
            子客戶資料 目前資料_ = (子客戶資料)(this.頁索引元件1.目前資料);

            this.名稱.Text = 目前資料_.名稱;

            _唯讀資料列選取插件.綁定(目前資料_.聯絡人編號列);
        }

        public void 儲存修改()
        {
            子客戶資料 目前資料_ = (子客戶資料)(this.頁索引元件1.目前資料);

            if (目前資料_ != null)
            {
                目前資料_.名稱 = this.名稱.Text;
                目前資料_.聯絡人編號列 = _唯讀資料列選取插件.編號列;
            }
        }

        public void 設定索引(int 位置_)
        {
            this.頁索引元件1.設定索引(位置_);
        }
    }
}
