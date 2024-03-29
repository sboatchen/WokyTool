﻿using System;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.通用
{
    public class 獨體總覽視窗 : Form, 通用視窗介面
    {
        public static 列舉.視窗 視窗類型 { get { return 列舉.視窗.總覽; } }
        public virtual 列舉.編號 編號類型 { get { throw new Exception(this.GetType().Name + " 未設定編號類型"); } }
        public virtual Type 資料類型 { get { throw new Exception(this.GetType().Name + " 未設定資料類型"); } }

        public virtual 可編輯列舉資料管理介面 編輯管理器 { get { throw new Exception(this.GetType().Name + " 未設定編輯管理器"); } }
        public virtual MyDataGridView 資料GV { get { throw new Exception(this.GetType().Name + " 未設定資料GV"); } }
        public virtual ToolStripMenuItem 篩選MI { get { throw new Exception(this.GetType().Name + " 未設定篩選MI"); } }
        public virtual ToolStripMenuItem 檢查MI { get { throw new Exception(this.GetType().Name + " 未設定檢查MI"); } }
        public virtual ToolStripMenuItem 自訂MI { get { throw new Exception(this.GetType().Name + " 未設定自訂MI"); } }
        public virtual ToolStripMenuItem 新增MI { get { return null; } }

        public BindingSource 資料BS { get { return 編輯管理器.公用BS; } }

        public int 資料版本 { get; protected set; }
        public bool 是否關閉 { get; protected set; }

        private bool _預設是否可刪除資料;

        public virtual void 初始化()
        {
            this.資料GV.DataSource = 資料BS;

            this.Activated += new System.EventHandler(this._視窗激活);
            this.Deactivate += new EventHandler(this._視窗凍結);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._視窗關閉);
            資料GV.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._點擊標頭);
            資料GV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._雙點擊資料);
            資料GV.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this._刪除資料);

            篩選MI.Click += new EventHandler(this._篩選);
            檢查MI.Click += new EventHandler(this._檢查);
            自訂MI.Click += new EventHandler(this._自訂);

            if (新增MI != null)
                新增MI.Click += new EventHandler(this._新增);
            
            資料GV.AllowUserToAddRows = false;

            _預設是否可刪除資料 = 資料GV.AllowUserToDeleteRows;
            資料GV.AllowUserToDeleteRows &= 編輯管理器.是否可編輯;

            資料GV.ReadOnly |= 編輯管理器.是否可編輯 == false;

            更新資料();
        }

        private void 更新資料()
        {
            資料版本 = 編輯管理器.資料版本;
            //資料BS.DataSource = 編輯管理器.資料列舉;
            //資料BS.ResetBindings(false);

            var x = 編輯管理器.資料列舉; // 強制更新

            資料GV.AllowUserToDeleteRows = _預設是否可刪除資料 && 編輯管理器.是否可編輯 && 編輯管理器.視窗篩選器.是否篩選 == false; // 含篩選條件時 仍可刪除 擋掉
        }

        protected void _視窗激活(object sender, EventArgs e)
        {
            if (是否關閉)
                return;

            視窗激活();

            if (資料版本 != 編輯管理器.資料版本)
                更新資料();
        }

        protected void _視窗凍結(object sender, EventArgs e)
        {
            資料GV.凍結();
        }

        protected virtual void 視窗激活()
        {
        }

        protected void _視窗關閉(object sender, FormClosingEventArgs e)
        {
            是否關閉 = true;

            if (編輯管理器.是否編輯中)
            {
                bool Result_ = 訊息管理器.獨體.確認(字串.儲存確認, 字串.儲存確認內容);

                try
                {
                    編輯管理器.完成編輯(Result_);
                }
                catch (Exception ex)
                {
                    訊息管理器.獨體.通知(字串.操作失敗, ex.Message);
                    e.Cancel = true;
                    是否關閉 = false;
                    return;
                }
            }

            if (!(e is 視窗關閉事件))
            {
                e.Cancel = true;
                this.Hide();
            }

            資料版本 = -1;

            視窗關閉();
        }

        protected virtual void 視窗關閉()
        {
 
        }

        protected void _點擊標頭(object sender, DataGridViewCellMouseEventArgs e)
        {
            資料GV.凍結();

            var col = 資料GV.Columns[e.ColumnIndex];
            編輯管理器.視窗篩選器.排序欄位 = col.DataPropertyName;

            _視窗激活(null, null);
        }

        protected virtual void _雙點擊資料(object sender, DataGridViewCellEventArgs e)
        {
            if (this.資料BS.Current == null)
                return;

            視窗管理器.獨體.顯現(編號類型, 列舉.視窗.詳細, true);
        }

        private 列印檢查器 _刪除檢查器;
        private int _目前訊息數量;
        private int _剩餘處理數量;

        protected virtual void _刪除資料(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (_刪除檢查器 == null)
            {
                _刪除檢查器 = new 列印檢查器();
                _目前訊息數量 = 0;
                _剩餘處理數量 = 資料GV.SelectedRows.Count;
            }

            可刪除檢查介面 資料_ = e.Row.DataBoundItem as 可刪除檢查介面;
            資料_.刪除檢查(_刪除檢查器);

            if (_目前訊息數量 != _刪除檢查器.資料書.Count)
            {
                _目前訊息數量 = _刪除檢查器.資料書.Count;
                e.Cancel = true;
            }

            _剩餘處理數量--;
            if(_剩餘處理數量 == 0)
            {
                if (_目前訊息數量 > 0)
                {
                    var i = new 錯誤總覽視窗(_刪除檢查器, "刪除失敗，以下資料綁定");
                    i.Show();
                    i.BringToFront();
                }

                _刪除檢查器 = null;
            }
        }

        private void _篩選(object sender, EventArgs e)
        {
            if (false == 視窗管理器.獨體.顯現(編號類型, 列舉.視窗.篩選, true))
                訊息管理器.獨體.通知("尚未實作篩選視窗");
        }

        private void _檢查(object sender, EventArgs e)
        {
            列印檢查器 檢查器_ = new 列印檢查器();
            編輯管理器.合法檢查(檢查器_);

            var i = new 錯誤總覽視窗(檢查器_, 編號類型.ToString());
            i.Show();
            i.BringToFront();
        }

        private void _新增(object sender, EventArgs e)
        {
            if(編輯管理器.視窗篩選器.是否篩選)
            {
                訊息管理器.獨體.通知("篩選中不能進行新增");
                return;
            }

            var 新資料_ = (資料BS.AddNew()) as 新版可記錄資料;
            新資料_.新增資料();

            _雙點擊資料(null, null);
        }

        private void _自訂(object sender, EventArgs e)
        {
            var i = new 通用匯出視窗(資料類型, 編輯管理器.資料列舉);
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
            this.是否關閉 = false;

            for (int i = 0; i < 資料BS.Count; i++)
            {
                可編號介面 可編號資料_ = 資料BS[i] as 可編號介面;
                if (可編號資料_ == null)
                {
                    訊息管理器.獨體.錯誤("非可編號介面:" + 資料BS[i].GetType().Name);
                    return;
                }

                if (可編號資料_.編號 == 編號_)
                {
                    資料BS.Position = i;
                    break;
                }
            }

            this.Show();
            this.BringToFront();
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
