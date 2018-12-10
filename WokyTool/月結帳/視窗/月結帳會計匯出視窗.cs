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

namespace WokyTool.月結帳
{
    public partial class 月結帳會計匯出視窗 : 匯入視窗
    {
        protected 月結帳會計匯出管理器 _月結帳會計匯出管理器 = new 月結帳會計匯出管理器();

        public 月結帳會計匯出視窗(List<月結帳會計資料> List_)
        {
            InitializeComponent();

            _月結帳會計匯出管理器.新增(List_);

            this.初始化(月結帳會計資料BindingSource, _月結帳會計匯出管理器);
        }
    }
}
