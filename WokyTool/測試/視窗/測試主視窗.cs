using System;
using System.Windows.Forms;
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.商品;
using WokyTool.通用;
using WokyTool.聯絡人;

namespace WokyTool.測試
{
    public partial class 測試主視窗 : Form
    {
        public 測試主視窗()
        {
            InitializeComponent();      
        }

        private void 時間ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 時間測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 檔案測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 綁定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 資料編輯總覽測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 拷貝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 拷貝測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 清單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 資料清單測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 合法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 合法性測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 訊息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 訊息測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 詳細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 資料編輯詳細測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 可匯出匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 可匯入匯出測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 快速_Click(object sender, EventArgs e)
        {
            var 轉換_ = new 平台訂單配送轉換資料_松果_全家(null);
            檔案.詢問並修改(轉換_, true);
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new PDF測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new Image測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 物品合併ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 物品合併測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 快速清除庫存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            物品資料管理器.獨體.清除庫存();
            物品資料管理器.獨體.儲存();
            商品資料管理器.獨體.清除庫存();
            商品資料管理器.獨體.儲存();
        }
    }
}
