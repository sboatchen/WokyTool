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

namespace WokyTool.測試
{
    public partial class 資料編輯總覽測試視窗 : 新版總覽視窗
    {
        public override 可編輯列舉資料管理介面 管理介面 { get { return 讀寫測試資料管理器.獨體.編輯管理器; } }
        public override BindingSource 資料BS { get { return this.讀寫測試資料BindingSource; } }
        public override DataGridView 資料GV { get { return this.dataGridView1; } }

        private 讀寫測試資料篩選 _篩選介面;
        private bool 是否未綁定_ = true;

        public 資料編輯總覽測試視窗()
        {
            InitializeComponent();

            初始化();

            _篩選介面 = (讀寫測試資料篩選)管理介面.篩選介面;

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
            foreach (var 資料_ in (IEnumerable<讀寫測試資料>)管理介面.資料列舉)
            {
                Console.WriteLine(資料_.ToString(false));
            }
        }

        private void 最小整數_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.最小整數.Text))
                this._篩選介面.最小整數 = -1;
            else
                this._篩選介面.最小整數 = Int32.Parse(this.最小整數.Text);

            _視窗激活(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            資料BS.Position++;
        }
    }
}
