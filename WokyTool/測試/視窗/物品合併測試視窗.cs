using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.物品;

namespace WokyTool.測試
{
    public partial class 物品合併測試視窗 : Form
    {
        private 物品合併資料 物品合併資料_ = new 物品合併資料();

        public 物品合併測試視窗()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            物品資料 物品_ = (物品資料)(this.物品選取元件1.SelectedItem);
            if (物品_ == null || 物品_.編號是否有值() == false)
                return;

            int 數量_ = (int)this.數量.Value;

            物品合併資料_.新增(物品_, 數量_);

            this.結果.Text = 物品合併資料_.ToString();
        }
    }
}
