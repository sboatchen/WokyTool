using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public partial class 鎖定視窗 : Form, 通用視窗介面
    {
        public 鎖定視窗()
        {
            InitializeComponent();

            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 161;
            const int WM_SYSCOMMAND = 274;
            const int HTCAPTION = 2;
            const int SC_MOVE = 61456;

            if ((m.Msg == WM_SYSCOMMAND) && (m.WParam.ToInt32() == SC_MOVE))
            {
                return;
            }

            if ((m.Msg == WM_NCLBUTTONDOWN) && (m.WParam.ToInt32() == HTCAPTION))
            {
                return;
            }

            base.WndProc(ref m);
        }

        /********************************/
        // 通用視窗介面

        public void 顯現()
        {
            this.Show();
            this.BringToFront();
        }

        public void 顯現(int Pos_)
        {
            this.Show();
            this.BringToFront();
        }

        public void 隱藏()
        {
            this.Close();
        }

        public void 關閉()
        {
            this.Close();
        }

        public bool 是否顯現()
        {
            return this.Visible;
        }
    }
}
