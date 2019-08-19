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
        private List<Form> _鎖住視窗列 = new List<Form>();

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
            foreach (Form 視窗_ in Application.OpenForms)
            {
                if (視窗_.Enabled == false)
                    continue;

                if (視窗_ is 鎖定視窗)
                    continue;

                訊息管理器.獨體.訊息("鎖定視窗:" + 視窗_.GetType().Name);

                視窗_.Enabled = false;
                _鎖住視窗列.Add(視窗_);
            }  

            this.Show();
            this.BringToFront();
        }

        public void 顯現(int 編號_)
        {
            訊息管理器.獨體.錯誤("不支援此功能");
        }

        public void 隱藏()
        {
            關閉();
        }

        public void 關閉()
        {
            foreach (Form 視窗_ in _鎖住視窗列)
            {
                視窗_.Enabled = true;

                訊息管理器.獨體.訊息("解除鎖定視窗:" + 視窗_.GetType().Name);
            }
            _鎖住視窗列.Clear();

            this.Close();
        }

        public bool 是否顯現
        {
            get
            {
                return this.Visible;
            }
        }
    }
}
