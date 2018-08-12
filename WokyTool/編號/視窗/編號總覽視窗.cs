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

namespace WokyTool.編號
{
    public partial class 編號總覽視窗 : 總覽視窗
    {
        public 編號總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.編號資料BindingSource, 編號資料管理器.獨體);
        }
    }
}
