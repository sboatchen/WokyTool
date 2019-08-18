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
    public class 新版匯入視窗 : Form, 通用視窗介面
    {
        public virtual 可編輯列舉資料管理介面 管理介面 { get { throw new Exception(this.GetType().Name + " 未設定管理介面"); } }
        public virtual BindingSource 資料BS { get { throw new Exception(this.GetType().Name + " 未設定資料BS"); } }
        public virtual DataGridView 資料GV { get { throw new Exception(this.GetType().Name + " 未設定資料GV"); } }

        public int 資料版本 { get; protected set; }
        public bool 是否關閉 { get; protected set; }

        public void 初始化()
        {
            this.Activated += new System.EventHandler(this._視窗激活);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._視窗關閉);
            資料GV.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._點擊標頭);

            資料GV.AllowUserToAddRows = 管理介面.是否可編輯;
            資料GV.AllowUserToDeleteRows = 管理介面.是否可編輯;
            資料GV.ReadOnly = 管理介面.是否可編輯 == false;

            更新資料();
        }

        private void 更新資料()
        {
            管理介面.合法檢查(new 錯誤訊息處理檢查管理器());

            資料版本 = 管理介面.資料版本;
            this.資料BS.DataSource = 管理介面.資料列舉;
            this.資料BS.ResetBindings(false);

            資料GV.AllowUserToDeleteRows = 管理介面.是否可編輯 && ((可篩選介面_視窗)管理介面.篩選介面).是否篩選 == false; // 含篩選條件時 仍可刪除 擋掉
        }

        private void _視窗激活(object sender, EventArgs e)
        {
            if (是否關閉)
                return;

            視窗激活();

            if (資料版本 != 管理介面.資料版本)
                更新資料();
        }

        protected virtual void 視窗激活()
        {
        }

        protected void 更新資料合法性()
        {
            管理介面.合法檢查(new 錯誤訊息處理檢查管理器());
            //@@ 更新資料版本??
            //@@ 錯誤呈現紅色??
        }

        private void _視窗關閉(object sender, FormClosingEventArgs e)
        {
            是否關閉 = true;

            if (管理介面.是否編輯中)
            {
                bool Result_ = 訊息管理器.獨體.確認(字串.儲存確認, 字串.儲存確認內容);

                try
                {
                    管理介面.完成編輯(Result_);
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
            if (管理介面.是否編輯中)
            {
                bool Result_ = 訊息管理器.獨體.確認(字串.儲存確認, 字串.排序前儲存確認內容);

                try
                {
                    管理介面.完成編輯(Result_);
                }
                catch (Exception ex)
                {
                    訊息管理器.獨體.通知(字串.操作失敗, ex.Message);
                    return;
                }
            }

            var col = 資料GV.Columns[e.ColumnIndex];
            ((可篩選介面_視窗)管理介面.篩選介面).排序欄位 = col.DataPropertyName;

            _視窗激活(null, null);
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

