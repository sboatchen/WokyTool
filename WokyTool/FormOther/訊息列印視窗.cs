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
using WokyTool.Data;
using WokyTool.通用;

namespace WokyTool.FormOther
{
    public partial class 訊息列印視窗 : Form
    {
        protected List<訊息資料> _Data;

        public 訊息列印視窗(String Title, List<訊息資料> Data_)
        {
            InitializeComponent();

            this.Text = Title;
            this._Data = Data_;

            this.dataGridView1.DataSource = _Data;
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Title_ = String.Format("訊息_{0}_{1}", this.Text, 時間.目前日期);
            舊函式.ExportExcel<訊息資料>(Title_, _Data);
        }
    }
}
