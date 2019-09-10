using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public partial class 錯誤列表視窗 : Form
    {
        private 列表檢查器 _檢查器;

        public 錯誤列表視窗(列表檢查器 檢查器_, string 標題_ = "錯誤列表視窗")
        {
            InitializeComponent();

            this.Text = 標題_;
            this._檢查器 = 檢查器_;

            this.dataGridView1.DataSource = _檢查器.字串列.Select(Value => new 錯誤資料(Value)).ToList();
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_檢查器.字串列.Count == 0)
            {
                訊息管理器.獨體.通知("沒有資料");
                return;
            }

            var 轉換_ = new 字串匯出轉換("錯誤", _檢查器.字串列);

            string 標題_ = String.Format("錯誤匯出_{0}", 時間.目前日期);
            if (檔案.詢問並寫入(標題_, 轉換_))
                訊息管理器.獨體.通知("匯出完成");
        }
    }
}
