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
    public partial class 商品篩選視窗 : Form
    {
        protected 商品總覽視窗 _TargetForm;

        public 商品篩選視窗(商品總覽視窗 TargetForm_)
        {
            InitializeComponent();

            this._TargetForm = TargetForm_;

            this.廠商.DataSource = 廠商管理器.Instance.Map.Values.ToList();
            this.公司.DataSource = 公司管理器.Instance.Map.Values.ToList();

            this.大類.DataSource = 商品大類管理器.Instance.Map.Values.ToList();
            this.小類.DataSource = 商品小類管理器.Instance.Map.Values.ToList();

            this.品名.DataSource = 商品管理器.Instance.Map.Values.ToList();

            InitData();
        }

        private void InitData()
        {
            this.廠商.SelectedItem = null;
            this.公司.SelectedItem = null;

            this.大類.SelectedItem = null;
            this.小類.SelectedItem = null;

            this.品名.SelectedItem = null;
            this.品號.Text = 字串.空;
        }

        private void 商品篩選視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._TargetForm.on商品篩選視窗Closing();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<商品資料> Source_ = 商品管理器.Instance.Map.Values.ToList();

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

            if(this.品名.Text.Length != 0)
                Source_ = Source_.Where(Value => Value.名稱.Contains(this.品名.Text));

            this._TargetForm.SetDataSource(Source_.ToList());
        }

        private void 品名_DropDown(object sender, EventArgs e)
        {
            if (this.品名.Text.Length == 0 || this.品名.Text.Equals(this.品名.SelectedText))
            {
                this.品名.DataSource = 商品管理器.Instance.Map.Values.ToList();
            }
            else
            {
                this.品名.DataSource = 商品管理器.Instance.Map.Values.Where(Value => Value.名稱.Contains(this.品名.Text)).ToList();
            }
        }
    }
}
