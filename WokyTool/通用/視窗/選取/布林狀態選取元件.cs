using System;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public partial class 布林狀態選取元件 : 抽象列舉選取元件
    {
        public override ComboBox 下拉選單{ get { return this.comboBox1; } }
        public override Type 列舉類型 { get { return typeof(列舉.布林狀態); } }

        public string 名稱
        {
            get { return this.標頭.Text; }
            set { this.標頭.Text = value; }
        }

        public 布林狀態選取元件()
        {
            InitializeComponent();
        }
    }
}