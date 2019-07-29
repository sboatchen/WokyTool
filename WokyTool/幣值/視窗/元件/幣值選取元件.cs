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

namespace WokyTool.幣值
{
    public partial class 幣值選取元件 : 抽象選取元件
    {
        public override ComboBox 下拉選單
        {
            get
            {
                return this.comboBox1;
            } 
        }

        protected override BindingSource 綁定資源
        {
            get
            {
                return this.幣值資料BindingSource;
            }
        }

        protected override 可選取資料列管理介面 資料管理器
        {
            get
            {
                return 幣值資料管理器.獨體;
            }
        }

        protected override object 篩選(String Name_)
        {
            if (Name_ == null)
                return 幣值資料管理器.獨體.唯讀BList;
            return 幣值資料管理器.獨體.唯讀BList.Where(Value => Value.名稱.Contains(Name_)).ToList();
        }

        public 幣值選取元件()
        {
            InitializeComponent();
            初始化();
        }
    }
}
