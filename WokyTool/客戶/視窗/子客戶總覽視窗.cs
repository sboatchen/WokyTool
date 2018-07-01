﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.客戶
{
    public partial class 子客戶總覽視窗 : 子客戶總覽視窗樣板
    {
        public 子客戶總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.子客戶資料BindingSource, 子客戶資料管理器.獨體);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int 索引_ = this.子客戶資料BindingSource.Position;
            視窗管理器.獨體.顯現(列舉.視窗類型.子客戶, 索引_);
        }
    }
}
