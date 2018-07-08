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

namespace WokyTool.聯絡人
{
    public partial class 聯絡人總覽視窗 : 總覽視窗
    {
        public 聯絡人總覽視窗()
        {
            InitializeComponent();

            this.初始化<聯絡人資料>(this.聯絡人資料BindingSource, 聯絡人資料管理器.獨體);
        }
    }
}
