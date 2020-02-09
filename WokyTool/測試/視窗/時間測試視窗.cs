using System;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.測試
{
    public partial class 時間測試視窗 : Form
    {
        public 時間測試視窗()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(時間.今天);
            Console.WriteLine(時間.明天);
            Console.WriteLine(時間.五天後);
            Console.WriteLine(時間.目前日期);
            Console.WriteLine(時間.目前日期_斜線);
            Console.WriteLine(時間.目前時間);
            Console.WriteLine(時間.目前完整時間);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.myDateTimePicker1.Value);
        }
    }
}
