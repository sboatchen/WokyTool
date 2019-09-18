using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.測試
{
    public partial class 資料編輯詳細測試視窗 : Form
    {
        public 可編輯列舉資料管理介面 編輯管理器;
        public BindingList<讀寫測試資料> 資料BS = new BindingList<讀寫測試資料>();

        public 資料編輯詳細測試視窗()
        {
            InitializeComponent();

            編輯管理器 = 讀寫測試資料管理器.獨體;

            foreach (讀寫測試資料 x in (IEnumerable<讀寫測試資料>)編輯管理器.資料列舉)
                資料BS.Add(x);

            //資料BS..Position = 0;

            this.字串.DataBindings.Add("Text", 資料BS, "字串", true);
        }

        private void 列印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(資料BS.Current.ToString());
        }
    }
}
