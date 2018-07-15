using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.公司;
using WokyTool.商品;
using WokyTool.客戶;
using WokyTool.通用;
using WokyTool.物品;

namespace WokyTool.商品{

    public partial class 商品篩選視窗 : Form, 通用視窗介面
    {
        protected 商品資料篩選設定 _商品資料篩選設定 = new 商品資料篩選設定();

        public 商品篩選視窗()
        {
            InitializeComponent();

            this.Activated += new System.EventHandler(this._視窗激活);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._視窗關閉);
        }

        private void _視窗激活(object sender, EventArgs e)
        {
            this.商品大類選取元件1.視窗激活();
            this.商品小類選取元件1.視窗激活();
            this.公司選取元件1.視窗激活();
            this.客戶選取元件1.視窗激活();
            this.物品選取元件1.視窗激活();

            //@@ 目前無法解決資料更新時 會預設選第一個當值
            this.商品大類選取元件1.SelectedItem = _商品資料篩選設定.大類;
            this.商品小類選取元件1.SelectedItem = _商品資料篩選設定.小類;
            this.公司選取元件1.SelectedItem = _商品資料篩選設定.公司;
            this.客戶選取元件1.SelectedItem = _商品資料篩選設定.客戶;
            this.物品選取元件1.SelectedItem = _商品資料篩選設定.物品;
        }

        private void _視窗關閉(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            if (e != null)
                e.Cancel = true;
        }

        private void 篩選_Click(object sender, EventArgs e)
        {
            _商品資料篩選設定.名稱 = this.名稱.Text;
            _商品資料篩選設定.品號 = this.品號.Text;

            _商品資料篩選設定.大類 = (商品大類資料)(this.商品大類選取元件1.SelectedItem);
            _商品資料篩選設定.小類 = (商品小類資料)(this.商品小類選取元件1.SelectedItem);

            _商品資料篩選設定.公司 = (公司資料)(this.公司選取元件1.SelectedItem);
            _商品資料篩選設定.客戶 = (客戶資料)(this.客戶選取元件1.SelectedItem);

            _商品資料篩選設定.物品 = (物品資料)(this.物品選取元件1.SelectedItem);

            if (_商品資料篩選設定.是否需篩選() == true)
                商品資料管理器.獨體.篩選介面 = _商品資料篩選設定;
            else
                商品資料管理器.獨體.篩選介面 = null;
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
