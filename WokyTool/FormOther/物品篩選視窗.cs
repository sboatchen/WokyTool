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
    public partial class 物品篩選視窗 : Form, 子視窗
    {
        protected 父視窗 _父視窗 = null;

        public 物品篩選視窗()
        {
            InitializeComponent();

            this.篩選.Enabled = false;

            // wait SetParentForm
        }

        public void SetParentForm(父視窗 Parent_)
        {
            this._父視窗 = Parent_;
            this.篩選.Enabled = (Parent_ != null);

            InitData();
        }

        private void InitData()
        {
            this.大類.DataSource = 物品大類管理器.Instance.Map.Values.ToList();
            this.小類.DataSource = 物品小類管理器.Instance.Map.Values.ToList();
            this.品牌.DataSource = 物品品牌管理器.Instance.Map.Values.ToList();

            this.大類.SelectedItem = null;
            this.小類.SelectedItem = null;
            this.品牌.SelectedItem = null;

            this.原廠編號.Text = 字串.空;
            this.代理編號.Text = 字串.空;
            this.名稱.Text = 字串.空;
            this.縮寫.Text = 字串.空;
        }

        private void 物品篩選視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._父視窗 != null)
                this._父視窗.onChildClosing(this);
        }

        private void 篩選_Click(object sender, EventArgs e)
        {
            IEnumerable<物品資料> Source_ = 物品管理器.Instance.Map.Values.ToList();

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

            this._父視窗.onUpdateDataSource(Source_.ToList());
        }
    }
}