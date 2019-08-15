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
    public partial class 子客戶總覽視窗 : 新版總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.子客戶; } }

        public override 可編輯列舉資料管理介面 管理介面 { get { return 子客戶資料管理器.獨體.編輯管理器; } }
        public override BindingSource 資料BS { get { return this.子客戶資料BindingSource; } }
        public override DataGridView 資料GV { get { return this.dataGridView1; } }

        public 子客戶總覽視窗()
        {
            InitializeComponent();

            this.初始化();
        }
    }
}