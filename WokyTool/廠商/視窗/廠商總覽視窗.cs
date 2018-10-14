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

namespace WokyTool.廠商
{
    public partial class 廠商總覽視窗 : 總覽視窗
    {
        public 廠商總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.廠商資料BindingSource, 廠商資料管理器.獨體);
        }
    }
}
