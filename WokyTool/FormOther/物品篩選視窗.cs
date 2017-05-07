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
    public partial class 物品篩選視窗 : Form, 子視窗<物品資料>
    {
        protected 父視窗<物品資料> _父視窗 = null;
        protected 監測綁定更新<物品大類資料> _物品大類資料Listener;
        protected 監測綁定更新<物品小類資料> _物品小類資料Listener;
        protected 監測綁定更新<物品品牌資料> _物品品牌資料Listener;

        public 物品篩選視窗(父視窗<物品資料> Parent_)
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
            _物品大類資料Listener = new 監測綁定更新<物品大類資料>(物品大類管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品大類資料更新);
            _物品大類資料Listener.Refresh(true);

            _物品小類資料Listener = new 監測綁定更新<物品小類資料>(物品小類管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品小類資料更新);
            _物品小類資料Listener.Refresh(true);

            _物品品牌資料Listener = new 監測綁定更新<物品品牌資料>(物品品牌管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品品牌資料更新);
            _物品品牌資料Listener.Refresh(true);

            this.大類.SelectedItem = null;
            this.小類.SelectedItem = null;
            this.品牌.SelectedItem = null;

            this.原廠編號.Text = 字串.空;
            this.代理編號.Text = 字串.空;
            this.名稱.Text = 字串.空;
            this.縮寫.Text = 字串.空;
        }

        public void 物品大類資料更新(IEnumerable<物品大類資料> Data_)
        {
            this.大類.DataSource = Data_;
        }

        public void 物品小類資料更新(IEnumerable<物品小類資料> Data_)
        {
            this.小類.DataSource = Data_;
        }

        public void 物品品牌資料更新(IEnumerable<物品品牌資料> Data_)
        {
            this.品牌.DataSource = Data_;
        }

        private void 物品篩選視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

            if (this._父視窗 != null)
                this._父視窗.onChildClosing(this);
        }

        public IEnumerable<物品資料> Filt(IEnumerable<物品資料> Query_)
        {
            IEnumerable<物品資料> Source_ = Query_;

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

            if (this.品牌.SelectedItem != null)
            {
                int Value_ = (int)this.品牌.SelectedValue;
                Source_ = Source_.Where(Value => Value.品牌編號 == Value_);
            }

            if (this.原廠編號.Text.Length != 0)
                Source_ = Source_.Where(Value => (Value.原廠編號 != null) && (Value.原廠編號.Contains(this.原廠編號.Text)));

            if (this.代理編號.Text.Length != 0)
                Source_ = Source_.Where(Value => (Value.代理編號 != null) && (Value.代理編號.Contains(this.代理編號.Text)));

            if (this.名稱.Text.Length != 0)
                Source_ = Source_.Where(Value => Value.名稱.Contains(this.名稱.Text));

            if (this.縮寫.Text.Length != 0)
                Source_ = Source_.Where(Value => Value.縮寫.Contains(this.縮寫.Text));

            return Source_;
        }

        private void 篩選_Click(object sender, EventArgs e)
        {
            this._父視窗.onClickFilter(this);
        }
    }
}