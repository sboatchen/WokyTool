using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WokyTool.物品;
using WokyTool.商品;

namespace WokyTool.測試
{
    public partial class 物品合併測試視窗 : Form
    {
        private 物品合併資料 物品合併資料_ = new 物品合併資料();
        private BindingSource _組合BS = new BindingSource();

        public 物品合併測試視窗()
        {
            InitializeComponent();

            this.物品.初始化();

            this.dataGridView1.DataSource = _組合BS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            物品資料 物品_ = (物品資料)(this.物品.SelectedItem);
            if (物品_ == null || 物品_.編號是否有值() == false)
                return;

            int 數量_ = (int)this.數量.Value;

            物品合併資料_.新增(物品_, 數量_);

            this.結果.Text = 物品合併資料_.ToString();
        }

        private void 解構_Click(object sender, EventArgs e)
        {
            List<商品組成資料> 資料列_ = 物品合併資料.共用.解構(this.結果.Text);
            if (資料列_ == null)
                資料列_ = new List<商品組成資料>();

            _組合BS.DataSource = 資料列_;
        }
    }
}
