﻿using Newtonsoft.Json;
using Remotion.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataExport;
using WokyTool.通用;

namespace WokyTool.物品
{
    public partial class 物品總覽視窗 : 新版總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.物品; } }

        public override 可編輯列舉資料管理介面 管理介面 { get { return 物品資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.dataGridView1; } }

        public 物品總覽視窗()
        {
            InitializeComponent();

            this.初始化();

            this.更新ToolStripMenuItem.Enabled = 管理介面.是否可編輯;
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.物品, 列舉.視窗.篩選);
        }

        private void 檢查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            列表檢查器 檢查器_ = new 列表檢查器();
            管理介面.合法檢查(檢查器_);

            var i = new 錯誤列表視窗(檢查器_, 編號類型.ToString());
            i.Show();
            i.BringToFront();
        }

        private void 自訂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 通用匯出視窗(typeof(物品資料), 管理介面.資料列舉);
            i.Show();
            i.BringToFront();
        }

        private void 盤點ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.通知("此報表無視篩選設定");

            var 轉換_ = new 物品盤點匯出轉換();
            String 標題_ = String.Format("盤點匯出_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }











        private void 物品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 物品新增匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void 條碼ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 物品條碼更新匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void 重新匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 物品總覽更新匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void 類別ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD_ = new OpenFileDialog();
            OFD_.Filter = "json files (.json)|*.json";
            if (OFD_.ShowDialog() != DialogResult.OK)
                return;

            string 內容_ = 檔案.讀出(OFD_.FileName);
            Dictionary<int, 物品資料> 資料書_ = JsonConvert.DeserializeObject<Dictionary<int, 物品資料>>(內容_);
            
            列表檢查器 檢查器_ = new 列表檢查器();

            foreach(物品資料 更新資料_ in 資料書_.Values)
            {
                if(string.IsNullOrEmpty(更新資料_.類別) && string.IsNullOrEmpty(更新資料_.顏色))
                    continue;

                物品資料 物品資料_ = 物品資料管理器.獨體.取得(更新資料_.名稱);
                if(物品資料_.編號是否有值() == false)
                {
                    檢查器_.錯誤(更新資料_, "編號有問題");
                    continue;
                }

                物品資料_.BeginEdit();
                物品資料_.類別 = 更新資料_.類別;
                物品資料_.顏色 = 更新資料_.顏色;
            }

            if (檢查器_.字串列.Count > 0)
            {
                var i = new 錯誤列表視窗(檢查器_, "類別更新錯誤");
                i.Show();
                i.BringToFront();
            }
        }
    }
}
