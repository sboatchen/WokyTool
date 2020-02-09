using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.配送
{
    public partial class 宅配通匯入視窗 : Form
    {
        public 宅配通匯入視窗()
        {
            InitializeComponent();
        }

        public String 資料
        {
            get 
            {
                return this.內容.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.內容.Text) == false)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
