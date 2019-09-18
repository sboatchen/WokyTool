using System;
using System.Collections.Generic;
using WokyTool.通用;

namespace WokyTool.測試
{
    public partial class 資料編輯總覽測試視窗 : 獨體總覽視窗
    {
        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 讀寫測試資料管理器.獨體; } }
        public override MyDataGridView 資料GV { get { return this.dataGridView1; } }

        private 讀寫測試資料篩選 _視窗篩選器;
        private bool 是否未綁定_ = true;

        public 資料編輯總覽測試視窗()
        {
            InitializeComponent();

            初始化();

            _視窗篩選器 = (讀寫測試資料篩選)編輯管理器.視窗篩選器;

            this.列舉.DataSource = Enum.GetValues(typeof(列舉.編號));

            this.時間.MinDate = DateTime.MinValue;
            this.時間.MaxDate = DateTime.MaxValue;
        }

        protected override void 視窗激活()
        {
            if (是否未綁定_)
            {
                是否未綁定_ = false;

                this.字串.DataBindings.Add("Text", 資料BS, "字串");
                this.整數.DataBindings.Add("Value", 資料BS, "整數");
                this.浮點數.DataBindings.Add("Value", 資料BS, "浮點數");
                this.倍精準浮點數.DataBindings.Add("Value", 資料BS, "倍精準浮點數");
                //this.時間.DataBindings.Add("Value", 資料BS, "時間");
                this.列舉.DataBindings.Add("SelectedItem", 資料BS, "列舉");
            }
        }

        private void 列印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (讀寫測試資料 資料_ in (IEnumerable<讀寫測試資料>)編輯管理器.資料列舉)
            {
                Console.WriteLine(資料_.ToString(false));
            }
        }

        private void 最小整數_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.最小整數.Text))
                this._視窗篩選器.最小整數 = -1;
            else
                this._視窗篩選器.最小整數 = Int32.Parse(this.最小整數.Text);

            _視窗激活(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            資料BS.Position++;
        }
    }
}
