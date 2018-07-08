﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.物品
{
    public partial class 物品大類選取元件 : UserControl, 選取元件介面
    {
        private int _資料版本 = -1;

        public 物品大類選取元件()
        {
            InitializeComponent();
        }

        public object SelectedValue
        {
            get
            {
                return this.comboBox1.SelectedValue;
            }

            set
            {
                if (this.comboBox1.SelectedValue != value)
                    this.comboBox1.SelectedValue = value;
            }
        }

        public void 視窗激活()
        {
            if (_資料版本 != 物品大類資料管理器.獨體.BindingVersion)
            {
                _資料版本 = 物品大類資料管理器.獨體.BindingVersion;
                this.物品大類資料BindingSource.DataSource = 物品大類資料管理器.獨體.唯讀BList;
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedValue != null)
            {
                this.物品大類資料BindingSource.DataSource = 物品大類資料管理器.獨體.唯讀BList;
            }
            else
            {
                this.物品大類資料BindingSource.DataSource = 物品大類資料管理器.獨體.唯讀BList.Where(Value => Value.名稱.Contains(this.comboBox1.Text)).ToList();
            }
        }
    }
}
