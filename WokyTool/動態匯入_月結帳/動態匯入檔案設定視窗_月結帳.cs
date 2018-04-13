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
using WokyTool.DataMgr;

namespace WokyTool.動態匯入_月結帳
{
    public partial class 動態匯入檔案設定視窗_月結帳 : Form
    {
        protected 監測綁定更新<動態匯入檔案設定_月結帳> _動態匯入檔案設定_月結帳Listener;
        protected 監測綁定更新<公司資料> _公司資料Listener;
        protected 監測綁定更新<廠商資料> _廠商資料Listener;
        protected 動態匯入檔案設定_月結帳 _目前資料;

        public 動態匯入檔案設定視窗_月結帳()
        {
            InitializeComponent();

            /*
             *         
             private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown 開始位置;
        private System.Windows.Forms.NumericUpDown 標頭位置;
        private System.Windows.Forms.NumericUpDown 結束位置;
        private System.Windows.Forms.TextBox 名稱;
        private System.Windows.Forms.ComboBox 格式;
        private System.Windows.Forms.ComboBox 公司;
        private System.Windows.Forms.ComboBox 廠商;
        private System.Windows.Forms.BindingSource 資料格式類型BindingSource;
             * 
             * 
             *  this.公司.DataSource = this.公司資料BindingSource;
            this.公司.DisplayMember = "名稱";
            this.公司.FormattingEnabled = true;
            this.公司.Location = new System.Drawing.Point(72, 164);
            this.公司.Name = "公司";
            this.公司.Size = new System.Drawing.Size(104, 20);
            this.公司.TabIndex = 14;
            this.公司.ValueMember = "編號";
             * 
             */

            _動態匯入檔案設定_月結帳Listener = new 監測綁定更新<動態匯入檔案設定_月結帳>(動態匯入檔案設定管理器_月結帳.Instance.Binding, 列舉.監測類型.被動通知_值, 設定資料更新);
            _動態匯入檔案設定_月結帳Listener.Refresh(true);

            _公司資料Listener = new 監測綁定更新<公司資料>(公司管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 公司資料更新);
            _公司資料Listener.Refresh(true);

            _廠商資料Listener = new 監測綁定更新<廠商資料>(廠商管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 廠商資料更新);
            _廠商資料Listener.Refresh(true);

            格式.DataSource = Enum.GetValues(typeof(列舉.檔案格式類型));
            格式DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.資料格式類型));

        }

        private void 設定資料更新(IEnumerable<動態匯入檔案設定_月結帳> Data_)
        {
            清單.DataSource = Data_;
        }

        public void 公司資料更新(IEnumerable<公司資料> Data_)
        {
            公司.DataSource = Data_;
        }

        public void 廠商資料更新(IEnumerable<廠商資料> Data_)
        {
            廠商.DataSource = Data_;
        }

        private void 儲存_Click(object sender, EventArgs e)
        {
            string Error_ = _目前資料.檢查合法();
            if(String.IsNullOrEmpty(Error_) == false)
            {
                MessageBox.Show(Error_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var x in 動態匯入檔案設定管理器_月結帳.Instance.Map.Values)
                Console.WriteLine(x.ToString());
        }

        private void 選單_Click(object sender, EventArgs e)
        {

        }

        private void 新增_Click(object sender, EventArgs e)
        {

        }

        private void 刪除_Click(object sender, EventArgs e)
        {

        }

        private void 清單_SelectedIndexChanged(object sender, EventArgs e)
        {
            _目前資料 = (動態匯入檔案設定_月結帳)((動態匯入檔案設定_月結帳)this.清單.SelectedItem).拷貝();

            this.名稱.Text = _目前資料.名稱;
            this.格式.SelectedItem = _目前資料.格式;
            this.開始位置.Value = _目前資料.開始位置;
            this.結束位置.Value = _目前資料.結束位置;
            this.標頭位置.Value = _目前資料.標頭位置;
            this.公司.SelectedItem = _目前資料.公司;
            this.廠商.SelectedItem = _目前資料.廠商;
            this.設定.DataSource = _目前資料.資料List;
        }
    }
}
