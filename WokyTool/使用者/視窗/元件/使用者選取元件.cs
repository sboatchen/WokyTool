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
using WokyTool.Common;

namespace WokyTool.使用者
{
    public partial class 使用者選取元件 : 新版抽象選取元件
    {
        protected override 可清單列舉資料管理介面 管理介面設定 { get { return 使用者資料管理器.獨體.清單管理器; } }

        public override BindingSource 資料BS { get { return this.使用者資料BindingSource; } }
        public override ComboBox 下拉選單 { get { return this.comboBox1; } }

        public override string 篩選文字
        {
            get { return 篩選.名稱; }
            set { 篩選.名稱 = value; }
        }

        public 使用者資料篩選 篩選 { get; protected set; } 

        public 使用者選取元件()
        {
            InitializeComponent();
            初始化();

            篩選 = (使用者資料篩選)管理介面.篩選介面;
        }
    }
}
