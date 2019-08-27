using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.通用
{
    public class 更新總覽視窗 : Form, 通用視窗介面
    {
        public virtual 可編輯列舉資料管理介面 更新管理器 { get { throw new Exception(this.GetType().Name + " 未設定更新管理器"); } }
        public virtual MyDataGridView 資料GV { get { throw new Exception(this.GetType().Name + " 未設定資料GV"); } }

        public BindingSource 資料BS { get { return 更新管理器.公用BS; } }

        public int 資料版本 { get; protected set; }
        public bool 是否關閉 { get; protected set; }

        public void 初始化()
        {
            this.資料GV.DataSource = 資料BS;

            this.Activated += new System.EventHandler(this._視窗激活);
            this.Deactivate += new EventHandler(this._視窗凍結);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._視窗關閉);

            資料GV.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this._點擊標頭);
            資料GV.CellDoubleClick += new DataGridViewCellEventHandler(this._雙點擊資料);

            資料GV.AllowUserToAddRows = false;
            資料GV.AllowUserToDeleteRows = 更新管理器.是否可編輯;
            資料GV.ReadOnly = 更新管理器.是否可編輯 == false;

            更新資料();
        }

        private 錯誤訊息檢查器 _更新資料檢查管理器 = new 錯誤訊息檢查器();
        protected void 更新資料()
        {
            資料版本 = 更新管理器.資料版本;
            this.資料BS.DataSource = 更新管理器.資料列舉;

            更新管理器.合法檢查(_更新資料檢查管理器);

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
                bool Result_ = 訊息管理器.獨體.確認(字串.儲存確認, 字串.儲存確認內容);

                try
                {
                    更新管理器.完成編輯(Result_);
                }
                catch (Exception ex)
                {
                    訊息管理器.獨體.通知(字串.操作失敗, ex.Message);
                    e.Cancel = true;
                    是否關閉 = false;
                    return;
                }
            }

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

        protected virtual void _雙點擊資料(object sender, DataGridViewCellEventArgs e)
        {
            if (this.資料BS.Current == null)
                return;

            //視窗管理器.獨體.顯現(編號類型, 列舉.視窗.更新詳細, true);
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

