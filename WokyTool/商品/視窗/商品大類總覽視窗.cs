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

namespace WokyTool.商品
{
    public partial class 商品大類總覽視窗 : 總覽視窗
    {
        public 商品大類總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.商品大類資料BindingSource, 商品大類資料管理器.獨體);
        }
    }
}
