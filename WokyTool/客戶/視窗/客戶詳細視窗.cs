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
    public partial class 客戶詳細視窗 : Form, 頁索引上層介面
    {
        private int _子客戶資料版本;
        private int _聯絡人資料版本;

        private 唯讀資料列選取插件<子客戶資料> _子客戶唯讀資料列選取插件;
        private 唯讀資料列選取插件<聯絡人資料> _聯絡人唯讀資料列選取插件;


        public 客戶詳細視窗()
        {
            InitializeComponent();

            this.頁索引元件1.初始化<客戶資料>(客戶資料管理器.獨體.BList, this);

            this.名稱DataGridViewTextBoxColumn.DataSource = 子客戶資料管理器.獨體.BList;
            this.姓名DataGridViewTextBoxColumn.DataSource = 聯絡人資料管理器.獨體.BList;

            _子客戶資料版本 = 子客戶資料管理器.獨體.BindingVersion;
            _聯絡人資料版本 = 聯絡人資料管理器.獨體.BindingVersion;

            _子客戶唯讀資料列選取插件 = new 唯讀資料列選取插件<子客戶資料>(子客戶資料管理器.獨體, this.dataGridView1, 1);
            _聯絡人唯讀資料列選取插件 = new 唯讀資料列選取插件<聯絡人資料>(聯絡人資料管理器.獨體, this.dataGridView2, 1);
        }

        private void 客戶詳細視窗_Activated(object sender, EventArgs e)
        {
            if (_子客戶資料版本 != 子客戶資料管理器.獨體.BindingVersion)
            {
                _子客戶資料版本 = 子客戶資料管理器.獨體.BindingVersion;
                this.名稱DataGridViewTextBoxColumn.DataSource = 子客戶資料管理器.獨體.BList;
            }

            if (_聯絡人資料版本 != 聯絡人資料管理器.獨體.BindingVersion)
            {
                _聯絡人資料版本 = 聯絡人資料管理器.獨體.BindingVersion;
                this.姓名DataGridViewTextBoxColumn.DataSource = 聯絡人資料管理器.獨體.BList;
            }

            this.頁索引元件1.刷新();
        }

        private void 客戶詳細視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            索引切換_異動儲存();

            if (客戶資料管理器.獨體.IsEditing())
            {
                var result = MessageBox.Show(字串.儲存確認內容, 字串.儲存確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                客戶資料管理器.獨體.UpdateEdit(result == DialogResult.Yes);
            }

            this.Hide();
            e.Cancel = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //@@
        }

        /********************************/

        public void 索引切換_更新呈現()
        {
            客戶資料 目前資料_ = (客戶資料)(this.頁索引元件1.目前資料);

            this.名稱.Text = 目前資料_.名稱;

            _子客戶唯讀資料列選取插件.綁定(目前資料_.子客戶編號列);
            _聯絡人唯讀資料列選取插件.綁定(目前資料_.聯絡人編號列);
        }

        public void 索引切換_異動儲存()
        {
            客戶資料 目前資料_ = (客戶資料)(this.頁索引元件1.目前資料);

            if (目前資料_ != null)
            {
                目前資料_.名稱 = this.名稱.Text;
                目前資料_.子客戶編號列 = _子客戶唯讀資料列選取插件.編號列;
                目前資料_.聯絡人編號列 = _聯絡人唯讀資料列選取插件.編號列;
            }
        }

        public void 設定索引(int 位置_)
        {
            this.頁索引元件1.設定索引(位置_);
        }
    }
}
