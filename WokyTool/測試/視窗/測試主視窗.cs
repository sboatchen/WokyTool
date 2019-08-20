using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.物品;
using WokyTool.通用;

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
            //可匯出匯入ToolStripMenuItem_Click(null, null);

            var i = new 通用匯出視窗(typeof(物品資料), 物品資料管理器.獨體.資料列舉2);
            i.Show();
            i.BringToFront();
        }
    }
}
