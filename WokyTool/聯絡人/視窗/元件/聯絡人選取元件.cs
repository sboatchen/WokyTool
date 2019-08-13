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
using WokyTool.客戶;

namespace WokyTool.聯絡人
{
    public partial class 聯絡人選取元件 : 新版抽象選取元件
    {
        public override BindingSource 資料BS { get { return this.聯絡人資料BindingSource; } }
        public override ComboBox 下拉選單 { get { return this.comboBox1; } }

        public override string 篩選文字
        {
            get { return 篩選.姓名; }
            set { 篩選.姓名 = value; }
        }

        protected override 可清單列舉資料管理介面 取得管理介面實體()
        {
            return 聯絡人資料管理器.獨體.清單管理器;
        }

        public 聯絡人資料篩選 篩選 { get; protected set; } 

        public 聯絡人選取元件()
        {
            InitializeComponent();
            初始化();

            篩選 = (聯絡人資料篩選)管理介面.篩選介面;
        }
    }
}