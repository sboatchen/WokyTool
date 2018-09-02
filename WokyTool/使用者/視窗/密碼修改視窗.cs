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
using WokyTool.通用;

namespace WokyTool.使用者
{
    public partial class 密碼修改視窗 : 鎖定視窗
    {
        private 使用者資料 _使用者資料;

        public 密碼修改視窗(使用者資料 使用者資料_)
        {
            InitializeComponent();

            this._使用者資料 = 使用者資料_;

            this.確認.Enabled = (使用者資料_ != null);
        }

        private void 確認_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.新密碼.Text) || String.IsNullOrEmpty(this.再次確認.Text))
            {
                訊息管理器.獨體.Notify(字串.密碼不可無空白);
                return;
            }

            if (this.新密碼.Text.CompareTo(this.再次確認.Text) != 0)
            {
                訊息管理器.獨體.Notify(字串.密碼輸入不一致);
                return;
            }

            _使用者資料.密碼 = this.新密碼.Text;
            使用者資料管理器.獨體.資料異動();

            this.Close();
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
