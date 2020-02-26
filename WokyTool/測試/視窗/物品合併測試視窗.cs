using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WokyTool.單品;
using WokyTool.商品;

namespace WokyTool.測試
{
    public partial class 單品合併測試視窗 : Form
    {
        private 單品合併資料 單品合併資料_ = new 單品合併資料();
        private BindingSource _組合BS = new BindingSource();

        public 單品合併測試視窗()
        {
            InitializeComponent();

            this.單品.初始化();

            this.dataGridView1.DataSource = _組合BS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            單品資料 單品_ = (單品資料)(this.單品.SelectedItem);
            if (單品_ == null || 單品_.編號是否有值() == false)
                return;

            int 數量_ = (int)this.數量.Value;

            單品合併資料_.新增(單品_, 數量_);

            this.結果.Text = 單品合併資料_.ToString();
        }

        private void 解構_Click(object sender, EventArgs e)
        {
            List<商品組成資料> 資料列_ = 單品合併資料.共用.解構(this.結果.Text);
            if (資料列_ == null)
                資料列_ = new List<商品組成資料>();

            _組合BS.DataSource = 資料列_;
        }
    }
}
