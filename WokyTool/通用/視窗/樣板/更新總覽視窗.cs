using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.通用
{
    public class 更新總覽視窗 : Form, 通用視窗介面
    {
        public virtual Type 資料類型 { get { throw new Exception(this.GetType().Name + " 未設定資料類型"); } }

        public virtual 可編輯列舉資料管理介面 更新管理器 { get { throw new Exception(this.GetType().Name + " 未設定更新管理器"); } }

        public virtual MyDataGridView 資料GV { get { throw new Exception(this.GetType().Name + " 未設定資料GV"); } }
        public virtual ToolStripMenuItem 樣板MI { get { throw new Exception(this.GetType().Name + " 未設定樣板MI"); } }
        public virtual ToolStripMenuItem 篩選MI { get { throw new Exception(this.GetType().Name + " 未設定篩選MI"); } }
        public virtual ToolStripMenuItem 檢查MI { get { throw new Exception(this.GetType().Name + " 未設定檢查MI"); } }

        public virtual 通用視窗介面 取得篩選視窗實體 { get { return null; } }
        public virtual 通用視窗介面 取得詳細視窗實體 { get { return null; } }

        public BindingSource 資料BS { get { return 更新管理器.公用BS; } }

        public 通用視窗介面 篩選視窗 { get; protected set; }
        public 通用視窗介面 詳細視窗 { get; protected set; }

        public int 資料版本 { get; protected set; }
        public bool 是否關閉 { get; protected set; }

        public virtual void 初始化()
        {
            this.資料GV.DataSource = 資料BS;

            this.Activated += new System.EventHandler(this._視窗激活);
            this.Deactivate += new EventHandler(this._視窗凍結);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._視窗關閉);

            資料GV.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this._點擊標頭);
            資料GV.CellDoubleClick += new DataGridViewCellEventHandler(this._雙點擊資料);

            樣板MI.Click += new EventHandler(this._樣板);
            篩選MI.Click += new EventHandler(this._篩選);
            檢查MI.Click += new EventHandler(this._檢查);

            資料GV.AllowUserToAddRows = false;
            資料GV.AllowUserToDeleteRows = 更新管理器.是否可編輯;
            資料GV.ReadOnly = 更新管理器.是否可編輯 == false;

            更新資料();

            篩選視窗 = 取得篩選視窗實體;
            詳細視窗 = 取得詳細視窗實體;
        }

        protected void 更新資料()
        {
            資料版本 = 更新管理器.資料版本;
            this.資料BS.DataSource = 更新管理器.資料列舉;

            this.資料BS.ResetBindings(false);

            資料GV.AllowUserToDeleteRows = 更新管理器.是否可編輯 && 更新管理器.視窗篩選器.是否篩選 == false; // 含篩選條件時 仍可刪除 擋掉
        }

        private void _視窗激活(object sender, EventArgs e)
        {
            if (是否關閉)
                return;

            視窗激活();

            if (資料版本 != 更新管理器.資料版本)
                更新資料();
        }

        protected virtual void 視窗激活()
        {
        }

        protected void _視窗凍結(object sender, EventArgs e)
        {
            資料GV.凍結();
        }

        private void _視窗關閉(object sender, FormClosingEventArgs e)
        {
            是否關閉 = true;

            if (更新管理器.是否編輯中)
            {
                bool Result_ = 訊息管理器.獨體.確認(字串.更新確認, 字串.更新確認內容);

                try
                {
                    更新管理器.完成編輯(Result_);
                }
                catch (Exception ex)
                {
                    訊息管理器.獨體.通知(字串.更新失敗, ex.Message);
                    e.Cancel = true;
                    是否關閉 = false;
                    return;
                }
            }

            if (篩選視窗 != null)
                篩選視窗.關閉();

            if (詳細視窗 != null)
                詳細視窗.關閉();

            視窗關閉();
        }

        protected virtual void 視窗關閉()
        {

        }

        private void _點擊標頭(object sender, DataGridViewCellMouseEventArgs e)
        {
            資料GV.凍結();

            var col = 資料GV.Columns[e.ColumnIndex];
            更新管理器.視窗篩選器.排序欄位 = col.DataPropertyName;

            _視窗激活(null, null);
        }

        protected void _雙點擊資料(object sender, DataGridViewCellEventArgs e)
        {
            if (this.資料BS.Current == null)
                return;

            if (詳細視窗 != null)
                詳細視窗.顯現();
        }

        private void _樣板(object sender, EventArgs e)
        {
            通用標頭匯出轉換 轉換_ = new 通用標頭匯出轉換(資料類型);
            String 標題_ = String.Format("{0}樣板", 資料類型.Name);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }

        private void _篩選(object sender, EventArgs e)
        {
            if (篩選視窗 != null)
                篩選視窗.顯現();
        }

        private void _檢查(object sender, EventArgs e)
        {
            列表檢查器 檢查器_ = new 列表檢查器();
            更新管理器.合法檢查(檢查器_);

            var i = new 錯誤列表視窗(檢查器_, 資料類型.ToString());
            i.Show();
            i.BringToFront();
        }

        /********************************/
        // 通用視窗介面

        public void 顯現()
        {
            this.是否關閉 = false;

            this.Show();
            this.BringToFront();
        }

        public void 顯現(int 編號_)
        {
            訊息管理器.獨體.錯誤("不支援此功能");
        }

        public void 隱藏()
        {
            _視窗關閉(null, new 視窗隱藏事件());
        }

        public void 關閉()
        {
            _視窗關閉(null, new 視窗關閉事件());
        }

        public bool 是否顯現
        {
            get
            {
                return this.Visible;
            }
        }
    }
}

