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
    public partial class 使用者總覽視窗 : 新版總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.使用者; } }

        public override 可編輯列舉資料管理介面 管理介面 { get { return 使用者資料管理器.獨體.編輯管理器; } }
        public override DataGridView 資料GV { get { return this.dataGridView1; } }


        public 使用者總覽視窗()
        {
            InitializeComponent();

            this.初始化();
        }

        protected override void _雙點擊資料(object sender, DataGridViewCellEventArgs e)
        {
            使用者資料 目前使用者資料_ = (使用者資料)this.使用者資料BindingSource.Current;

            if (系統參數.修改基本資料 == false)
                return;

            密碼修改視窗 密碼修改視窗_ = new 密碼修改視窗((使用者資料)this.使用者資料BindingSource.Current);
            密碼修改視窗_.顯現();
        }
    }
}
