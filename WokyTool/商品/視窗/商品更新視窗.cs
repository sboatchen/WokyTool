using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.商品
{
    public partial class 商品更新視窗 : 更新總覽視窗
    {
        public override Type 資料類型 { get { return typeof(商品更新資料); } }

        public override 可編輯列舉資料管理介面 更新管理器 { get { return 資料管理器; } }

        public override MyDataGridView 資料GV { get { return this.dataGridView1; } }
        public override ToolStripMenuItem 樣板MI { get { return this.樣板ToolStripMenuItem; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }

        public override 通用視窗介面 取得篩選視窗實體 { get { return null; } }
        public override 通用視窗介面 取得詳細視窗實體 { get { return new 商品更新詳細視窗(資料管理器); } }

        public 商品更新資料管理器 資料管理器 = new 商品更新資料管理器();

        public 商品更新視窗()
        {
            InitializeComponent();
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            通用更新匯入轉換<商品更新資料> 轉換_ = new 通用更新匯入轉換<商品更新資料>();  //@@ 可考慮 改制 更新管理器 處理
            IEnumerable<商品更新資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);

            資料管理器.新增(資料列舉_);

            更新資料();
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.商品
{
    public partial class 商品新增匯入視窗 : 匯入視窗
    {
        protected 商品新增匯入管理器 _商品新增匯入管理器 = new 商品新增匯入管理器();
        protected 商品新增匯入詳細視窗 _商品新增匯入詳細視窗 = null;

        public 商品新增匯入視窗()
        {
            InitializeComponent();

            this.初始化(商品新增匯入資料BindingSource, _商品新增匯入管理器);
        }

        private void 樣板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            舊函式.GetFile("商品新增匯入範本", "樣板/設定/商品新增匯入範本.xlsx");
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _商品新增匯入管理器.新增(商品新增匯入資料.匯入Excel<商品新增匯入資料>());
            if (_商品新增匯入管理器.是否正在編輯() == false)
                return;

            this.匯入ToolStripMenuItem.Enabled = false;

            this.OnActivated(null);
        }

        private void 檢查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            更新資料合法性();
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var 轉換_ = new 商品新增錯誤匯出轉換(_商品新增匯入管理器.可編輯BList.Where(Value => Value.錯誤訊息 != null));

            string 標題_ = String.Format("商品新增錯誤匯出_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//
        {
            if (_商品新增匯入詳細視窗 == null)
                _商品新增匯入詳細視窗 = new 商品新增匯入詳細視窗(_商品新增匯入管理器);

            _商品新增匯入詳細視窗.顯現(this.商品新增匯入資料BindingSource.Position);
        }
        protected override void 視窗激活()
        {
        }

        protected override void 視窗關閉()
        {
            if (_商品新增匯入詳細視窗 != null)
                _商品新增匯入詳細視窗.關閉();
        }
    }
}


*/