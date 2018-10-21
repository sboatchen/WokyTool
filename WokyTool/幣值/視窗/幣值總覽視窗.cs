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

namespace WokyTool.幣值
{
    public partial class 幣值總覽視窗 : 總覽視窗
    {
        public 幣值總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.幣值資料BindingSource, 幣值資料管理器.獨體);
        }
    }
}
