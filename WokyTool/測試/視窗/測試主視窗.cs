using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.測試
{
    public partial class 測試主視窗 : Form
    {
        public 測試主視窗()
        {
            InitializeComponent();
        }

        private void 時間ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 時間測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 檔案測試視窗();
            i.Show();
            i.BringToFront();
        }
    }
}
