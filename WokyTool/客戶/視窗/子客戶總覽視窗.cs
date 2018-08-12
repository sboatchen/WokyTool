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
    public partial class 子客戶總覽視窗 : 總覽視窗
    {
        public 子客戶總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.子客戶資料BindingSource, 子客戶資料管理器.獨體);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int 編號_ = ((子客戶資料)(this.子客戶資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.編號.子客戶, 列舉.視窗.詳細, 編號_);
        }
    }
}
