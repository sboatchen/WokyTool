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
    public partial class 物品選擇視窗 : Form, 可選擇子視窗<物品資料>
    {
        protected 可選擇父視窗<物品資料> _父視窗 = null;
        protected 監測綁定更新<物品資料> _物品資料Listener;

        public 物品選擇視窗(可選擇父視窗<物品資料> Parent_)
        {
            InitializeComponent();

            this._父視窗 = Parent_;

            _物品資料Listener = new 監測綁定更新<物品資料>(物品管理器.Instance.Binding, 舊列舉.監測類型.被動通知_值, 物品資料更新);
            _物品資料Listener.Refresh(true);

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
        }

        private void onEventActivated(object sender, EventArgs e)
        {
            _物品資料Listener.Refresh();
        }

        private void 物品資料更新(IEnumerable<物品資料> Data_)
        {
            this.comboBox1.DataSource = Data_;
        }

        public bool IsVisible()
        {
            return this.Visible;
        }

        private void 物品選擇視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

            if (this._父視窗 != null)
            {
                this._父視窗.onChildClosing(this);
                物品資料 Item_ = 物品管理器.Instance.Get((int)this.comboBox1.SelectedValue);
                this._父視窗.onSelect(Item_);
            }
        }

        public void SetDefaultSelect(物品資料 Item_)
        {
            this.comboBox1.SelectedValue = Item_.編號;
        }

        public IEnumerable<物品資料> Filt(IEnumerable<物品資料> Query_)
        {
            Console.WriteLine("not support");
            return null;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedValue != null && (int)this.comboBox1.SelectedValue <= 0)
            {
                this.comboBox1.DataSource = _物品資料Listener.Data.ToList();

                // 重設資源須重設選定目標，不然會用預設值
                this.comboBox1.SelectedValue = 0;
            }
            else
            {
                this.comboBox1.DataSource = _物品資料Listener.Query.Where(Value => Value.名稱.Contains(this.comboBox1.Text)).ToList();
            }
        }
    }
}
