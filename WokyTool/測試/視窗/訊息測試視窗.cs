using System;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.測試
{
    public partial class 訊息測試視窗 : Form
    {
        public 訊息測試視窗()
        {
            InitializeComponent();
        }

        private void 錯誤_Click(object sender, EventArgs e)
        {
            if (this.是否為例外.Checked)
                訊息管理器.獨體.錯誤(new Exception(this.內容.Text));
            else
                訊息管理器.獨體.錯誤(this.內容.Text);
        }

        private void 警告_Click(object sender, EventArgs e)
        {
            if (this.是否為例外.Checked)
                訊息管理器.獨體.警告(new Exception(this.內容.Text));
            else
                訊息管理器.獨體.警告(this.內容.Text);
        }

        private void 追蹤_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.追蹤(this.內容.Text, this.是否為例外.Checked);
        }

        private void 訊息_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.訊息(this.內容.Text, this.是否為例外.Checked);
        }

        private void 通知_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.通知("通知", this.內容.Text);
        }

        private void 確認_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.確認("確認", this.確認.Text);
        }
    }
}
