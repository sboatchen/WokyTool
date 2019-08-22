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
    public partial class 聯絡人更新視窗 : Form//: 新版總覽視窗
    {
        public 列舉.編號 編號類型 { get { return 列舉.編號.聯絡人; } }

        //public override 可編輯列舉資料管理介面 管理介面 { get { return 聯絡人資料管理器.獨體.編輯管理器; } }
        //public override DataGridView 資料GV { get { return this.dataGridView1; } }

        public 聯絡人更新視窗()
        {
            InitializeComponent();

            //this.初始化();
        }

        private void 樣板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var 轉換_ = new 通用標頭匯出轉換(typeof(聯絡人更新資料));
            String 標題_ = String.Format("{0}更新樣板匯出", 編號類型);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            通用更新匯入轉換<聯絡人更新資料> 轉換_ = new 通用更新匯入轉換<聯絡人更新資料>();
            IEnumerable<聯絡人更新資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            資料列舉_.Count();
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.通知("尚未實作");
        }

        private void 檢查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*列表處理檢查管理器 檢查管理器_ = new 列表處理檢查管理器();
            管理介面.合法檢查(檢查管理器_);

            var i = new 錯誤列表視窗(檢查管理器_, 編號類型.ToString());
            i.Show();
            i.BringToFront();*/
        }
    }
}