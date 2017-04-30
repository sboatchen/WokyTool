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

namespace WokyTool.FormOther
{
    public partial class 測試視窗 : Form
    {
        Dictionary<String, MyString> data = new Dictionary<String, MyString>();

        public 監測綁定廣播<MyString> Binding;
        public 監測綁定更新<MyString> Listener;

        public 測試視窗()
        {
            InitializeComponent();

            Binding = new 監測綁定廣播<MyString>(data.Values.Where(X => X.Contains('a')));
            Listener = new 監測綁定更新<MyString>(Binding, 資料更新);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.Add(this.textBox1.Text, new MyString(this.textBox1.Text));
            Binding.SetDirty();
            Listener.Update();
        }

        public void 資料更新<MyString>(List<MyString> Data_)
        {
            StringBuilder sb = new StringBuilder();
            foreach (MyString a in Data_)
            {
                if (sb.Length != 0)
                    sb.Append(",");
                sb.Append(a);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
