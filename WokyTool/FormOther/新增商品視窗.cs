using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Data;
using WokyTool.DataMgr;

namespace WokyTool.OtherForm
{
    public partial class 新增商品視窗 : Form
    {
        private 商品資料 _資料 = new 商品資料();

        public 新增商品視窗()
        {
            InitializeComponent();

            this.廠商.DataSource = 廠商管理器.Instance.Map.Values.ToList();
            this.公司.DataSource = 公司管理器.Instance.Map.Values.ToList();

            this.大類.DataSource = 商品大類管理器.Instance.Map.Values.ToList();
            this.小類.DataSource = 商品小類管理器.Instance.Map.Values.ToList();

            this.參考.DataSource = 商品管理器.Instance.Map.Values.ToList();
            this.參考.SelectedValue = 0;

            // 這裡不能用物品管理器.Instance.Binding; 會所有的combobox同步更新 跟智障一樣
            this.需求1.DataSource = 物品管理器.Instance.Map.Values.ToList();
            this.需求2.DataSource = 物品管理器.Instance.Map.Values.ToList();
            this.需求3.DataSource = 物品管理器.Instance.Map.Values.ToList();
            this.需求4.DataSource = 物品管理器.Instance.Map.Values.ToList();
            this.需求5.DataSource = 物品管理器.Instance.Map.Values.ToList();

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
            if (this.參考.Text.Length == 0 || this.參考.Text.Equals(this.參考.SelectedText))
            {
                this.參考.DataSource = 商品管理器.Instance.Map.Values.ToList();
            }
            else
            {
                this.參考.DataSource = 商品管理器.Instance.Map.Values.Where(Value => Value.名稱.Contains(this.參考.Text)).ToList();
            }
        }

        private void 參考_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var Item_ = 商品管理器.Instance.Get((int)this.參考.SelectedValue);

            _資料.Copy(Item_);
            UpdateData();
        }

        private void 需求1_DropDown(object sender, EventArgs e)
        {
            if (this.需求1.Text.Length == 0 || this.需求1.Text.Equals(this.需求1.SelectedText))
            {
                this.需求1.DataSource = 物品管理器.Instance.Map.Values.ToList();

                // 重設資源須重設選定目標，不然會用預設值
                this.需求1.SelectedValue = _資料.需求1.編號;
            }
            else
            {
                this.需求1.DataSource = 物品管理器.Instance.Map.Values.Where(Value => Value.名稱.Contains(this.需求1.Text)).ToList();
            }
        }

        private void 需求1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.需求1 = 物品管理器.Instance.Get((int)this.需求1.SelectedValue);

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        private void 需求2_DropDown(object sender, EventArgs e)
        {
            if (this.需求2.Text.Length == 0 || this.需求2.Text.Equals(this.需求2.SelectedText))
            {
                this.需求2.DataSource = 物品管理器.Instance.Map.Values.ToList();

                // 重設資源須重設選定目標，不然會用預設值
                this.需求2.SelectedValue = _資料.需求2.編號;
            }
            else
            {
                this.需求2.DataSource = 物品管理器.Instance.Map.Values.Where(Value => Value.名稱.Contains(this.需求2.Text)).ToList();
            }
        }

        private void 需求2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.需求2 = 物品管理器.Instance.Get((int)this.需求2.SelectedValue);

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        private void 需求3_DropDown(object sender, EventArgs e)
        {
            if (this.需求3.Text.Length == 0 || this.需求3.Text.Equals(this.需求3.SelectedText))
            {
                this.需求3.DataSource = 物品管理器.Instance.Map.Values.ToList();

                // 重設資源須重設選定目標，不然會用預設值
                this.需求3.SelectedValue = _資料.需求3.編號;
            }
            else
            {
                this.需求3.DataSource = 物品管理器.Instance.Map.Values.Where(Value => Value.名稱.Contains(this.需求3.Text)).ToList();
            }
        }

        private void 需求3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.需求3 = 物品管理器.Instance.Get((int)this.需求3.SelectedValue);

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        private void 需求4_DropDown(object sender, EventArgs e)
        {
            if (this.需求4.Text.Length == 0 || this.需求4.Text.Equals(this.需求4.SelectedText))
            {
                this.需求4.DataSource = 物品管理器.Instance.Map.Values.ToList();

                // 重設資源須重設選定目標，不然會用預設值
                this.需求4.SelectedValue = _資料.需求4.編號;
            }
            else
            {
                this.需求4.DataSource = 物品管理器.Instance.Map.Values.Where(Value => Value.名稱.Contains(this.需求4.Text)).ToList();
            }
        }

        private void 需求4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.需求4 = 物品管理器.Instance.Get((int)this.需求4.SelectedValue);

            // 更新自動統計的資料
            UpdateAutoValue();
        }

        private void 需求5_DropDown(object sender, EventArgs e)
        {
            if (this.需求5.Text.Length == 0 || this.需求5.Text.Equals(this.需求5.SelectedText))
            {
                this.需求5.DataSource = 物品管理器.Instance.Map.Values.ToList();

                // 重設資源須重設選定目標，不然會用預設值
                this.需求5.SelectedValue = _資料.需求5.編號;
            }
            else
            {
                this.需求5.DataSource = 物品管理器.Instance.Map.Values.Where(Value => Value.名稱.Contains(this.需求5.Text)).ToList();
            }
        }

        private void 需求5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _資料.需求5 = 物品管理器.Instance.Get((int)this.需求5.SelectedValue);

            // 更新自動統計的資料
            UpdateAutoValue();
        }
    }
}
