using System;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.使用者
{
    public partial class 登入視窗 : 鎖定視窗
    {
        public 登入視窗()
        {
            InitializeComponent();
        }

        private void 確認_Click(object sender, EventArgs e)
        {
            使用者資料 使用者資料_ = 使用者資料管理器.獨體.登入(使用者.Text, 密碼.Text);

            if (使用者資料_ == null)
                return;

            this.DialogResult = DialogResult.OK;
            this.關閉();
        }
    }
}
