using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WokyTool.公司;
using WokyTool.通用;

namespace WokyTool.預留
{
    public partial class 預留匯入視窗 : 新增總覽視窗
    {
        public override Type 資料類型 { get { return typeof(預留匯入資料); } }

        public override 可編輯列舉資料管理介面 更新管理器 { get { return 資料管理器; } }

        public override MyDataGridView 資料GV { get { return this.myDataGridView1; } }
        public override ToolStripMenuItem 樣板MI { get { return this.樣板ToolStripMenuItem; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }

        public override 通用視窗介面 取得篩選視窗實體
        {
            get
            {
                var 視窗_ = new 預留匯入篩選視窗(資料管理器.視窗篩選器);
                視窗_.初始化();
                return 視窗_;
            }
        }

        public override 通用視窗介面 取得詳細視窗實體
        {
            get
            {
                var 視窗_ = new 預留匯入詳細視窗(資料管理器);
                視窗_.初始化();
                return 視窗_;
            }
        }

        public 預留匯入資料管理器 資料管理器 = new 預留匯入資料管理器();

        public 預留匯入視窗()
        {
            InitializeComponent();
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            通用更新匯入轉換<預留匯入資料> 轉換_ = new 通用更新匯入轉換<預留匯入資料>();
            IEnumerable<預留匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);

            資料管理器.新增(資料列舉_);

            更新資料();
        }
    }
}