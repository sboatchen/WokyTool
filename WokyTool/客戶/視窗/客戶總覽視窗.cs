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

namespace WokyTool.客戶
{
    public partial class 客戶總覽視窗 : 客戶總覽視窗樣板
    {
        public 客戶總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.客戶資料BindingSource, 客戶資料管理器.獨體);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 編號_ = ((客戶資料)(this.客戶資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.視窗類型.客戶, 編號_);
        }
    }
}
