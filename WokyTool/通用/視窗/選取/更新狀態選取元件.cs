﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public partial class 更新狀態選取元件 : 抽象列舉選取元件
    {
        public override ComboBox 下拉選單 { get { return this.comboBox1; } }
        public override Type 列舉類型 { get { return typeof(列舉.更新狀態); } }

        public 更新狀態選取元件()
        {
            InitializeComponent();
        }
    }
}