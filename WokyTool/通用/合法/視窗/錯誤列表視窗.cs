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
        private 列表處理合法管理器 _管理器;

        public 錯誤列表視窗(列表處理合法管理器 管理器_)
        {
            InitializeComponent();

            this._管理器 = 管理器_;

            this.dataGridView1.DataSource = _管理器.字串列.Select(Value => new 錯誤資料(Value)).ToList();
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_管理器.字串列.Count == 0)
            {
                訊息管理器.獨體.通知("沒有資料");
                return;
            }

            var 轉換_ = new 字串轉換("錯誤", _管理器.字串列);

            string 標題_ = String.Format("錯誤匯出_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }
    }
}
