using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.盤點
{
    public partial class 盤點更新視窗 : 新增總覽視窗
    {
        public override Type 資料類型 { get { return typeof(盤點更新資料); } }

        public override 可編輯列舉資料管理介面 更新管理器 { get { return 資料管理器; } }

        public override MyDataGridView 資料GV { get { return this.myDataGridView1; } }
        public override ToolStripMenuItem 樣板MI { get { return null; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }

        public override 通用視窗介面 取得篩選視窗實體
        {
            get
            {
                var 視窗_ = new 盤點更新篩選視窗(資料管理器.視窗篩選器);
                視窗_.初始化();
                return 視窗_;
            }
        }

        public override 通用視窗介面 取得詳細視窗實體
        {
            get
            {
                var 視窗_ = new 盤點更新詳細視窗(資料管理器);
                視窗_.初始化();
                return 視窗_;
            }
        }

        public 盤點更新資料管理器 資料管理器 = new 盤點更新資料管理器();

        public 盤點更新視窗()
        {
            InitializeComponent();
        }

        private void 匯入完成(IEnumerable<盤點更新資料> 資料列舉_)
        {
            if(資料列舉_ == null)
                return;

            List<盤點更新資料> 資料列_ = 資料列舉_.ToList(); // 先將資料確實轉換出來

            if (資料列_.Count == 0)
            {
                訊息管理器.獨體.通知("沒有資料");
                return;
            }

            資料管理器.新增(資料列_);

            更新資料();

            訊息管理器.獨體.通知("匯入完成");
        }

        private void 大料架ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            盤點更新轉換_大料架 轉換器_ = new 盤點更新轉換_大料架();
            IEnumerable<盤點更新資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(資料列舉_);
        }

        private void 小料架ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            盤點更新轉換_小料架 轉換器_ = new 盤點更新轉換_小料架();
            IEnumerable<盤點更新資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(資料列舉_);
        }

        private void 萬通ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            盤點更新轉換_萬通 轉換器_ = new 盤點更新轉換_萬通();
            IEnumerable<盤點更新資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(資料列舉_);
        }
    }
}