using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.活動
{
    public partial class 活動總覽視窗: 獨體總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.活動; } }
        public override Type 資料類型 { get { return typeof(活動資料); } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 活動資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.myDataGridView1; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }
        public override ToolStripMenuItem 自訂MI { get { return this.自訂ToolStripMenuItem; } }

        public 活動總覽視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();
        }

        private void 張貼ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<活動資料> 資料列舉_ = (IEnumerable<活動資料>)編輯管理器.資料列舉;

            var 轉換列舉_ = 資料列舉_.GroupBy(Value => Value.合併識別).Select(Value => new 活動張貼匯出轉換(Value));

            foreach (var 轉換_ in 轉換列舉_)
            {
                string 標題_ = String.Format("活動_{0}", 轉換_.參考.名稱);
                檔案.詢問並寫入(標題_, 轉換_);
            }

            訊息管理器.獨體.通知("匯出完成");
        }
    }
}



    