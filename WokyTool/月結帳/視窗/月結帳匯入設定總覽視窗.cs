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
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public partial class 月結帳匯入設定總覽視窗 : 總覽視窗
    {
        private int _公司資料版本 = -1;
        private int _客戶資料版本 = -1;

        public 月結帳匯入設定總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.月結帳匯入設定資料BindingSource, 月結帳匯入設定資料管理器.獨體);

            this.檔案格式類型BindingSource.DataSource = Enum.GetValues(typeof(列舉.檔案格式類型));
            this.商品識別類型BindingSource.DataSource = Enum.GetValues(typeof(列舉.商品識別類型));
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 編號_ = ((月結帳匯入設定資料)(this.月結帳匯入設定資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.編碼類型.月結帳設定, 列舉.視窗類型.詳細, 編號_);
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_公司資料版本 != 公司資料管理器.獨體.唯讀資料版本)
            {
                _公司資料版本 = 公司資料管理器.獨體.唯讀資料版本;
                this.公司資料BindingSource.DataSource = 公司資料管理器.獨體.唯讀BList;
            }

            if (_客戶資料版本 != 客戶資料管理器.獨體.唯讀資料版本)
            {
                _客戶資料版本 = 客戶資料管理器.獨體.唯讀資料版本;
                this.客戶資料BindingSource.DataSource = 客戶資料管理器.獨體.唯讀BList;
            }
        }
    }
}