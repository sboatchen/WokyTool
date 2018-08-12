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

namespace WokyTool.FormOther
{
    public partial class 商品篩選視窗 : Form, 子視窗<商品資料>
    {
        protected 父視窗<商品資料> _父視窗 = null;
        protected 監測綁定更新<商品大類資料> _商品大類資料Listener;
        protected 監測綁定更新<商品小類資料> _商品小類資料Listener;
        protected 監測綁定更新<公司資料> _公司資料Listener;
        protected 監測綁定更新<廠商資料> _廠商資料Listener;
        protected 監測綁定更新<商品資料> _商品資料Listener;

        public 商品篩選視窗(父視窗<商品資料> Parent_)
        {
            InitializeComponent();

            this._父視窗 = Parent_;
            this.篩選.Enabled = (Parent_ != null);

            InitData();
        }

        public bool IsVisible()
        {
            return this.Visible;
        }

        private void InitData()
        {
            _商品大類資料Listener = new 監測綁定更新<商品大類資料>(商品大類管理器.Instance.Binding, 舊列舉.監測類型.被動通知_值, 商品大類資料更新);
            _商品大類資料Listener.Refresh(true);

            _商品小類資料Listener = new 監測綁定更新<商品小類資料>(商品小類管理器.Instance.Binding, 舊列舉.監測類型.被動通知_值, 商品小類資料更新);
            _商品小類資料Listener.Refresh(true);

            _公司資料Listener = new 監測綁定更新<公司資料>(公司管理器.Instance.Binding, 舊列舉.監測類型.被動通知_值, 公司資料更新);
            _公司資料Listener.Refresh(true);

            _廠商資料Listener = new 監測綁定更新<廠商資料>(廠商管理器.Instance.Binding, 舊列舉.監測類型.被動通知_值, 廠商資料更新);
            _廠商資料Listener.Refresh(true);

            _商品資料Listener = new 監測綁定更新<商品資料>(商品管理器.Instance.Binding, 舊列舉.監測類型.被動通知_公式, 商品資料更新);
            _商品資料Listener.Refresh(true);

            this.廠商.SelectedItem = null;
            this.公司.SelectedItem = null;
            this.大類.SelectedItem = null;
            this.小類.SelectedItem = null;
            this.品名.SelectedItem = null;
            this.品號.Text = 字串.空;
        }

        public void 商品大類資料更新(IEnumerable<商品大類資料> Data_)
        {
            this.大類.DataSource = Data_;
        }

        public void 商品小類資料更新(IEnumerable<商品小類資料> Data_)
        {
            this.小類.DataSource = Data_;
        }

        public void 公司資料更新(IEnumerable<公司資料> Data_)
        {
            this.公司.DataSource = Data_;
        }

        public void 廠商資料更新(IEnumerable<廠商資料> Data_)
        {
            this.廠商.DataSource = Data_;
        }

        public void 商品資料更新(IEnumerable<商品資料> Data_)
        {
            if (this.品名.Text.Length == 0 || this.品名.Text.Equals(this.品名.SelectedText))
            {
                this.品名.DataSource = Data_.ToList();
            }
            else
            {
                this.品名.DataSource = Data_.Where(Value => Value.名稱.Contains(this.品名.Text)).ToList();
            }
        }
        
        private void 商品篩選視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

            if (this._父視窗 != null)
                this._父視窗.onChildClosing(this);
        }

        public IEnumerable<商品資料> Filt(IEnumerable<商品資料> Query_)
        {
            IEnumerable<商品資料> Source_ = Query_;

            if (this.廠商.SelectedItem != null)
            {
                int Value_ = (int)this.廠商.SelectedValue;
                Source_ = Source_.Where(Value => Value.廠商編號 == Value_);
            }

            if (this.公司.SelectedItem != null)
            {
                int Value_ = (int)this.公司.SelectedValue;
                Source_ = Source_.Where(Value => Value.公司編號 == Value_);
            }

            if (this.大類.SelectedItem != null)
            {
                int Value_ = (int)this.大類.SelectedValue;
                Source_ = Source_.Where(Value => Value.大類編號 == Value_);
            }

            if (this.小類.SelectedItem != null)
            {
                int Value_ = (int)this.小類.SelectedValue;
                Source_ = Source_.Where(Value => Value.小類編號 == Value_);
            }

            if (this.品號.Text.Length != 0)
            {
                Source_ = Source_.Where(Value => Value.品號.Contains(this.品號.Text));
            }

            if (this.品名.Text.Length != 0)
                Source_ = Source_.Where(Value => Value.名稱.Contains(this.品名.Text));

            return Source_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._父視窗.onClickFilter(this);
        }

        private void 品名_DropDown(object sender, EventArgs e)
        {
            _商品資料Listener.Refresh(true);
        }
    }
}
