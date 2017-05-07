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

namespace WokyTool.OtherForm
{
    public partial class 新增商品視窗 : Form
    {
        protected 商品資料 _資料 = new 商品資料();
        protected 監測綁定更新<商品大類資料> _商品大類資料Listener;
        protected 監測綁定更新<商品小類資料> _商品小類資料Listener;
        protected 監測綁定更新<公司資料> _公司資料Listener;
        protected 監測綁定更新<廠商資料> _廠商資料Listener;
        protected 監測綁定更新<物品資料> _物品資料Listener;
        protected 監測綁定更新<商品資料> _商品資料Listener;

        public 新增商品視窗()
        {
            InitializeComponent();

            _商品大類資料Listener = new 監測綁定更新<商品大類資料>(商品大類管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 商品大類資料更新);
            _商品大類資料Listener.Refresh(true);

            _商品小類資料Listener = new 監測綁定更新<商品小類資料>(商品小類管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 商品小類資料更新);
            _商品小類資料Listener.Refresh(true);

            _公司資料Listener = new 監測綁定更新<公司資料>(公司管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 公司資料更新);
            _公司資料Listener.Refresh(true);

            _廠商資料Listener = new 監測綁定更新<廠商資料>(廠商管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 廠商資料更新);
            _廠商資料Listener.Refresh(true);

            _物品資料Listener = new 監測綁定更新<物品資料>(物品管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品資料更新);
            _物品資料Listener.Refresh(true);

            _商品資料Listener = new 監測綁定更新<商品資料>(商品管理器.Instance.Binding, 列舉.監測類型.被動通知_公式, 商品資料更新);
            _商品資料Listener.Refresh(true);

            UpdateData();

            //this.參考.SelectedValue = 0;
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

        public void 物品資料更新(IEnumerable<物品資料> Data_)
        {
            this.需求1.DataSource = Data_.ToList();   // combobox彼此之間的binding會連在一起
            this.需求2.DataSource = Data_.ToList();
            this.需求3.DataSource = Data_.ToList();
            this.需求4.DataSource = Data_.ToList();
            this.需求5.DataSource = Data_.ToList();
        }

        public void 商品資料更新(IEnumerable<商品資料> Data_)
        {
            if (this.參考.Text.Length == 0 || this.參考.Text.Equals(this.參考.SelectedText))
            {
                this.參考.DataSource = Data_.ToList();
            }
            else
            {
                this.參考.DataSource = Data_.Where(Value => Value.名稱.Contains(this.參考.Text)).ToList();
            }
        }

        private void 新增商品視窗_Activated(object sender, EventArgs e)
        {
            _商品大類資料Listener.Refresh();
            _商品小類資料Listener.Refresh();
            _公司資料Listener.Refresh();
            _廠商資料Listener.Refresh();
            _物品資料Listener.Refresh();
            _商品資料Listener.Refresh();

            UpdateData();
        }

        private void UpdateData()
        {
            this.品號.Text = _資料.品號;
            this.名稱.Text = _資料.名稱;

            this.數量1.Value = _資料.數量1;
            this.數量2.Value = _資料.數量2;
            this.數量3.Value = _資料.數量3;
            this.數量4.Value = _資料.數量4;
            this.數量5.Value = _資料.數量5;

            this.廠商.SelectedValue = _資料.廠商.編號;
            this.公司.SelectedValue = _資料.公司.編號;

            this.大類.SelectedValue = _資料.大類.編號;
            this.小類.SelectedValue = _資料.小類.編號;

            this.需求1.SelectedValue = _資料.需求1.編號;
            this.需求2.SelectedValue = _資料.需求2.編號;
            this.需求3.SelectedValue = _資料.需求3.編號;
            this.需求4.SelectedValue = _資料.需求4.編號;
            this.需求5.SelectedValue = _資料.需求5.編號;

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        // 更新自動統計的資料
        private void UpdateAutoValue()
        {
            this.成本.Text = _資料.成本.ToString();
            this.體積.Text = _資料.體積.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            商品資料 New_ = 商品資料.New();
            New_.Copy(_資料);
            商品管理器.Instance.Add(New_);
        }

        private void 品號_TextChanged(object sender, EventArgs e)
        {
            _資料.品號 = this.品號.Text;
        }

        private void 名稱_TextChanged(object sender, EventArgs e)
        {
            _資料.名稱 = this.名稱.Text;
        }

        private void 數量1_ValueChanged(object sender, EventArgs e)
        {
            _資料.數量1 = (int)this.數量1.Value;

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        private void 數量2_ValueChanged(object sender, EventArgs e)
        {
            _資料.數量2 = (int)this.數量2.Value;

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        private void 數量3_ValueChanged(object sender, EventArgs e)
        {
            _資料.數量3 = (int)this.數量3.Value;

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        private void 數量4_ValueChanged(object sender, EventArgs e)
        {
            _資料.數量4 = (int)this.數量4.Value;

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        private void 數量5_ValueChanged(object sender, EventArgs e)
        {
            _資料.數量5 = (int)this.數量5.Value;

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        private void 公司_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.公司 = 公司管理器.Instance.Get((int)this.公司.SelectedValue);
        }

        private void 廠商_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.廠商 = 廠商管理器.Instance.Get((int)this.廠商.SelectedValue);
        }

        private void 大類_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.大類 = 商品大類管理器.Instance.Get((int)this.大類.SelectedValue);
        }

        private void 小類_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.小類 = 商品小類管理器.Instance.Get((int)this.小類.SelectedValue);
        }

        private void 參考_DropDown(object sender, EventArgs e)
        {
            //@@ 檢查參考的值是否有異動來決定是否更新
            _商品資料Listener.Refresh(true);
        }

        private void 參考_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var Item_ = 商品管理器.Instance.Get((int)this.參考.SelectedValue);

            _資料.Copy(Item_);
            UpdateData();
        }

        private void 需求ComboBoxDropDown(ComboBox 需求, 物品資料 物品)
        {
            if (需求.Text.Length == 0 || 需求.Text.Equals(需求.SelectedText))
            {
                需求.DataSource = _物品資料Listener.Data.ToList();

                // 重設資源須重設選定目標，不然會用預設值
                需求.SelectedValue = 物品.編號;
            }
            else
            {
                需求.DataSource = _物品資料Listener.Query.Where(Value => Value.名稱.Contains(需求.Text)).ToList();
            }
        }

        private void 需求1_DropDown(object sender, EventArgs e)
        {
            需求ComboBoxDropDown(需求1, _資料.需求1);
        }

        private void 需求1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.需求1 = 物品管理器.Instance.Get((int)this.需求1.SelectedValue);

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        private void 需求2_DropDown(object sender, EventArgs e)
        {
            需求ComboBoxDropDown(需求2, _資料.需求2);
        }

        private void 需求2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.需求2 = 物品管理器.Instance.Get((int)this.需求2.SelectedValue);

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        private void 需求3_DropDown(object sender, EventArgs e)
        {
            需求ComboBoxDropDown(需求3, _資料.需求3);
        }

        private void 需求3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.需求3 = 物品管理器.Instance.Get((int)this.需求3.SelectedValue);

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        private void 需求4_DropDown(object sender, EventArgs e)
        {
            需求ComboBoxDropDown(需求4, _資料.需求4);
        }

        private void 需求4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.需求4 = 物品管理器.Instance.Get((int)this.需求4.SelectedValue);

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        private void 需求5_DropDown(object sender, EventArgs e)
        {
            需求ComboBoxDropDown(需求5, _資料.需求5);
        }

        private void 需求5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.需求5 = 物品管理器.Instance.Get((int)this.需求5.SelectedValue);

            // 更新自動統計的資料
            UpdateAutoValue();
        } 
    }
}
