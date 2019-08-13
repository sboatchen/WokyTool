using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.公司
{
    public partial class 公司選取元件 : 新版抽象選取元件
    {
        public override BindingSource 資料BS { get { return this.公司資料BindingSource; } }
        public override ComboBox 下拉選單 { get { return this.comboBox1; } }

        public override string 篩選文字
        {
            get { return 篩選.名稱; }
            set { 篩選.名稱 = value; }
        }

        protected override 可清單列舉資料管理介面 取得管理介面實體()
        {
            return 公司資料管理器.獨體.清單管理器;
        }

        public 公司資料篩選 篩選 { get; protected set; } 

        public 公司選取元件()
        {
            InitializeComponent();
            初始化();

            篩選 = (公司資料篩選)管理介面.篩選介面;
        }
    }
}