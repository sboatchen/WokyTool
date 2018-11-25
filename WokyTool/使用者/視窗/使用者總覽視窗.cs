using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.使用者
{
    public partial class 使用者總覽視窗 : 總覽視窗
    {
        public 使用者總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.使用者資料BindingSource, 使用者資料管理器.獨體);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            使用者資料 目前使用者資料_ = (使用者資料)this.使用者資料BindingSource.Current;

            if (系統參數.修改基本資料 == false)
                return;

            密碼修改視窗 密碼修改視窗_ = new 密碼修改視窗((使用者資料)this.使用者資料BindingSource.Current);
            密碼修改視窗_.Show();
            密碼修改視窗_.BringToFront();
        }
    }
}
