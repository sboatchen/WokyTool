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
    public partial class 公司總覽視窗 : 總覽視窗
    {
        public 公司總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.公司資料BindingSource, 公司資料管理器.獨體);
        }
    }
}
