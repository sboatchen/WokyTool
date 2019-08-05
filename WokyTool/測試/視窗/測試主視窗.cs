using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

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

        private void 綁定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 資料綁定測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 拷貝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 拷貝測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 選擇ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 資料選擇測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 合法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 合法性測試視窗();
            i.Show();
            i.BringToFront();
        }
    }
}
