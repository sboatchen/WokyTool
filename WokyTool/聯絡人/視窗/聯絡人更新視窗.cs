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

namespace WokyTool.聯絡人
{
    public partial class 聯絡人更新視窗 : 更新總覽視窗
    {
        public override 可編輯列舉資料管理介面 更新管理器 { get { return 資料管理器; } }
        public override MyDataGridView 資料GV { get { return this.dataGridView1; } }
        public Type 資料類型 { get { return typeof(聯絡人更新資料); } }

        public 聯絡人更新資料管理器 資料管理器 = new 聯絡人更新資料管理器();

        public 聯絡人更新視窗()
        {
            InitializeComponent();

            this.初始化();
        }

        private void 樣板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var 轉換_ = new 通用標頭匯出轉換(資料類型);
            String 標題_ = String.Format("{0}更新樣板", 資料類型.Name);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            通用更新匯入轉換<聯絡人更新資料> 轉換_ = new 通用更新匯入轉換<聯絡人更新資料>();
            IEnumerable<聯絡人更新資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);

            資料管理器.新增(資料列舉_);

            更新資料();
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.通知("尚未實作");
        }

        private void 檢查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            列表檢查器 檢查器_ = new 列表檢查器();
            更新管理器.合法檢查(檢查器_);

            var i = new 錯誤列表視窗(檢查器_, 資料類型.ToString());
            i.Show();
            i.BringToFront();
        }
    }
}