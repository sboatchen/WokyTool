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

namespace WokyTool.公司
{
    public partial class 公司總覽視窗 : 新版總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.公司; } }

        public override 可編輯列舉資料管理介面 管理介面 { get { return 公司資料管理器.獨體.編輯管理器; } }
        public override DataGridView 資料GV { get { return this.dataGridView1; } }

        public 公司總覽視窗()
        {
            InitializeComponent();

            this.初始化();
        }
    }
}