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
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;
using WokyTool.單品;

namespace WokyTool.月結帳
{
    public partial class 月結帳支出總覽視窗 : 總覽視窗
    {
        private 可清單列舉資料管理介面 _供應商清單管理器 = 供應商資料管理器.獨體.清單管理器;
        private int _供應商資料版本 = -1;

        public 月結帳支出總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.月結帳支出資料BindingSource, 月結帳支出資料管理器.獨體);
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 月結帳支出新增匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            可寫入介面_EXCEL 轉換_ = new 月結帳支出匯出轉換(月結帳支出資料管理器.獨體.可編輯BList);

            string 標題_ = String.Format("月結帳支出總覽_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_供應商資料版本 != _供應商清單管理器.資料版本)
            {
                _供應商資料版本 = _供應商清單管理器.資料版本;
                this.供應商資料BindingSource.DataSource = _供應商清單管理器.資料列舉;
            }
        }
    }
}
