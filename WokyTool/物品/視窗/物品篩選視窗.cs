using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.物品
{
    public partial class 物品篩選視窗 : Form, 通用視窗介面
    {
        protected 物品資料篩選設定 _物品資料篩選設定 = new 物品資料篩選設定();

        public 物品篩選視窗()
        {
            InitializeComponent();

            this.Activated += new System.EventHandler(this._視窗激活);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._視窗關閉);
        }

        private void _視窗激活(object sender, EventArgs e)
        {
            this.物品大類選取元件1.視窗激活();
            this.物品小類選取元件1.視窗激活();
            this.物品品牌選取元件1.視窗激活();

            //@@ 目前無法解決資料更新時 會預設選第一個當值
            this.物品大類選取元件1.SelectedItem = _物品資料篩選設定.大類;
            this.物品小類選取元件1.SelectedItem = _物品資料篩選設定.小類;
            this.物品品牌選取元件1.SelectedItem = _物品資料篩選設定.品牌;
        }

        private void _視窗關閉(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            if (e != null)
                e.Cancel = true;
        }

        private void 篩選_Click(object sender, EventArgs e)
        {
            _物品資料篩選設定.名稱 = this.名稱.Text;
            _物品資料篩選設定.縮寫 = this.縮寫.Text;

            _物品資料篩選設定.大類 = (物品大類資料)(this.物品大類選取元件1.SelectedItem);
            _物品資料篩選設定.小類 = (物品小類資料)(this.物品小類選取元件1.SelectedItem);
            _物品資料篩選設定.品牌 = (物品品牌資料)(this.物品品牌選取元件1.SelectedItem);

            _物品資料篩選設定.條碼 = this.條碼.Text;
            _物品資料篩選設定.原廠編號 = this.原廠編號.Text;
            _物品資料篩選設定.代理編號 = this.代理編號.Text;

            if (_物品資料篩選設定.是否需篩選() == true)
                物品資料管理器.獨體.篩選介面 = _物品資料篩選設定;
            else
                物品資料管理器.獨體.篩選介面 = null;
        }

        /********************************/
        // 通用視窗介面

        public void 顯現()
        {
            this.Show();
            this.BringToFront();
        }

        public void 顯現(int Pos_)
        {
            this.Show();
            this.BringToFront();
        }

        public void 隱藏()
        {
            _視窗關閉(null, null);
        }

        public bool 是否顯現()
        {
            return this.Visible;
        }
    }
}
