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

namespace WokyTool.月結帳
{
    public partial class 月結帳會計總覽視窗 : 總覽視窗
    {
        public 月結帳會計總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.月結帳會計資料BindingSource, 月結帳會計資料管理器.獨體);
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<可序列化_Excel> List_ = new List<可序列化_Excel>();

            var tempList_ = 月結帳會計資料管理器.獨體.可編輯BList.Where(Value => Value.資料列 != null && Value.資料列.Count() != 0);
            foreach (var x in tempList_)
            {
                月結帳分頁匯出轉換 月結帳分頁匯出轉換_ = new 月結帳分頁匯出轉換(x);
                List_.Add(月結帳分頁匯出轉換_);
            }

            // 支出資料
            可序列化_Excel 月結帳支出匯出轉換_ = new 月結帳支出匯出轉換(月結帳支出資料管理器.獨體.可編輯BList);
            List_.Add(月結帳支出匯出轉換_);

            // 會計資料
            可序列化_Excel 月結帳會計匯出轉換_ = new 月結帳會計匯出轉換(tempList_);
            List_.Add(月結帳會計匯出轉換_);

            string Title_ = String.Format("月結帳總覽_{0}", 時間.目前日期);
            檔案.寫入Excel(Title_, List_);

            訊息管理器.獨體.Notify("匯出完成");
        }

        /********************************/

        protected override void 視窗激活()
        {
            月結帳會計資料管理器.獨體.更新();
        }
    }
}
