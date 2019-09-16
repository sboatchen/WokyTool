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
    public partial class 客戶詳細視窗 : 獨體詳細視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.客戶; } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 客戶資料管理器.獨體.編輯管理器; } }
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        public 客戶詳細視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            資料綁定(this.名稱, "名稱");
        }

        protected override void 選擇改變()
        {
            this.子客戶資料BindingSource.DataSource = ((客戶資料)(this.資料BS.Current)).子客戶列舉;
            this.聯絡人資料BindingSource.DataSource = ((客戶資料)(this.資料BS.Current)).聯絡人列舉;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 編號_ = ((聯絡人資料)(this.聯絡人資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.編號.聯絡人, 列舉.視窗.詳細, 編號_);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 編號_ = ((子客戶資料)(this.子客戶資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.編號.子客戶, 列舉.視窗.詳細, 編號_);
        }
    }
}
