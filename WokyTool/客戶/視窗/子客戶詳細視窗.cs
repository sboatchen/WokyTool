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
    public partial class 子客戶詳細視窗 : 詳細視窗
    {
        private int _聯絡人資料版本 = -1;

        private 資料列選取插件<聯絡人資料> _資料列選取插件;

        public 子客戶詳細視窗()
        {
            InitializeComponent();

            this.初始化(this.頁索引元件1, 子客戶資料管理器.獨體);

            _資料列選取插件 = new 資料列選取插件<聯絡人資料>(聯絡人資料管理器.獨體, this.聯絡人資料BindingSource, this.dataGridView1, 1);
        }

        /********************************/
        // 子客戶詳細視窗樣板

        protected override void 視窗激活()
        {
            if (_聯絡人資料版本 != 聯絡人資料管理器.獨體.唯讀資料版本)
            {
                _聯絡人資料版本 = 聯絡人資料管理器.獨體.唯讀資料版本;
                this.姓名DataGridViewTextBoxColumn.DataSource = 聯絡人資料管理器.獨體.唯讀BList;    // this.聯絡人資料BindingSource 用在 dataGridView1 資料來源
            }
        }

        /********************************/
        // 頁索引上層介面

        public override void 索引切換_異動儲存()
        {
            子客戶資料 目前資料_ = (子客戶資料)(this.頁索引元件1.目前資料);

            目前資料_.名稱 = this.名稱.Text;
            目前資料_.聯絡人編號列 = _資料列選取插件.編號列;
        }

        public override void 索引切換_更新呈現()
        {
            子客戶資料 目前資料_ = (子客戶資料)(this.頁索引元件1.目前資料);

            this.名稱.Text = 目前資料_.名稱;

            _資料列選取插件.綁定(目前資料_.聯絡人編號列);
        }
    }
}
