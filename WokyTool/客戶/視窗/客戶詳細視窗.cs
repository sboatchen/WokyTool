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
    public partial class 客戶詳細視窗 : 客戶詳細視窗樣板
    {
        private int _子客戶資料版本 = -1;
        private int _聯絡人資料版本 = -1;

        private 資料列選取插件<子客戶資料> _子客戶資料列選取插件;
        private 資料列選取插件<聯絡人資料> _聯絡人資料列選取插件;


        public 客戶詳細視窗()
        {
            InitializeComponent();

            this.初始化(this.頁索引元件1, 客戶資料管理器.獨體);

            _子客戶資料列選取插件 = new 資料列選取插件<子客戶資料>(子客戶資料管理器.獨體, this.子客戶資料BindingSource, this.dataGridView1, 1);
            _聯絡人資料列選取插件 = new 資料列選取插件<聯絡人資料>(聯絡人資料管理器.獨體, this.聯絡人資料BindingSource, this.dataGridView2, 1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 編號_ = ((子客戶資料)(this.子客戶資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.視窗類型.子客戶, 編號_);
        }

        /********************************/
        // 詳細視窗樣板_子客戶

        protected override void 視窗激活()
        {
            if (_子客戶資料版本 != 子客戶資料管理器.獨體.BindingVersion)
            {
                _子客戶資料版本 = 子客戶資料管理器.獨體.BindingVersion;
                this.名稱DataGridViewTextBoxColumn.DataSource = 子客戶資料管理器.獨體.唯讀BList;    // this.聯絡人資料BindingSource 用在 dataGridView1 資料來源
            }

            if (_聯絡人資料版本 != 聯絡人資料管理器.獨體.BindingVersion)
            {
                _聯絡人資料版本 = 聯絡人資料管理器.獨體.BindingVersion;
                this.姓名DataGridViewTextBoxColumn.DataSource = 聯絡人資料管理器.獨體.唯讀BList;    // this.聯絡人資料BindingSource 用在 dataGridView1 資料來源
            }
        }

        /********************************/
        // 頁索引上層介面

        public override void 索引切換_異動儲存()
        {
            客戶資料 目前資料_ = (客戶資料)(this.頁索引元件1.目前資料);

            目前資料_.名稱 = this.名稱.Text;
            目前資料_.子客戶編號列 = _子客戶資料列選取插件.編號列;
            目前資料_.聯絡人編號列 = _聯絡人資料列選取插件.編號列;
        }

        public override void 索引切換_更新呈現()
        {
            客戶資料 目前資料_ = (客戶資料)(this.頁索引元件1.目前資料);

            this.名稱.Text = 目前資料_.名稱;

            _子客戶資料列選取插件.綁定(目前資料_.子客戶編號列);
            _聯絡人資料列選取插件.綁定(目前資料_.聯絡人編號列);
        }
    }
}
