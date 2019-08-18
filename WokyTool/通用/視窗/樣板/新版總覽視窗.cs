using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.通用
{
    public class 新版總覽視窗 : Form, 通用視窗介面
    {
        public static 列舉.視窗 視窗類型 { get { return 列舉.視窗.總覽; } }
        public virtual 列舉.編號 編號類型 { get { throw new Exception(this.GetType().Name + " 未設定編號類型"); } }

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
            資料GV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._雙點擊資料);
            資料GV.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this._刪除資料);

            資料GV.AllowUserToAddRows = 管理介面.是否可編輯;
            資料GV.AllowUserToDeleteRows = 管理介面.是否可編輯;
            資料GV.ReadOnly = 管理介面.是否可編輯 == false;

            資料版本 = -1;
        }

        protected void _視窗激活(object sender, EventArgs e)
        {
            if (是否關閉)
                return;

            視窗激活();

            if (資料版本 != 管理介面.資料版本)
            {
                資料版本 = 管理介面.資料版本;
                this.資料BS.DataSource = 管理介面.資料列舉;
                this.資料BS.ResetBindings(false);

                資料GV.AllowUserToDeleteRows = 管理介面.是否可編輯 && ((可篩選介面_視窗)管理介面.篩選介面).是否篩選 == false; // 含篩選條件時 仍可刪除 擋掉
            }
        }

        protected virtual void 視窗激活()
        {
        }

        protected void _視窗關閉(object sender, FormClosingEventArgs e)
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

            if (!(e is 視窗關閉事件))
            {
                e.Cancel = true;
                this.Hide();
            }

            視窗關閉();
        }

        protected virtual void 視窗關閉()
        {
 
        }

        protected void _點擊標頭(object sender, DataGridViewCellMouseEventArgs e)
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

        protected virtual void _雙點擊資料(object sender, DataGridViewCellEventArgs e)
        {
            if (this.資料BS.Current == null)
                return;

            可編號介面 資料_ = this.資料BS.Current as 可編號介面;
            if(資料_ == null)
            {
                訊息管理器.獨體.錯誤("資料無法沒有編號:" + 資料_.GetType().Name);
                return;
            }

            視窗管理器.獨體.顯現(編號類型, 列舉.視窗.詳細, 資料_.編號, true);
        }

        private 列表處理檢查管理器 _刪除檢查;
        private int _目前訊息數量;
        private int _剩餘處理數量;

        protected virtual void _刪除資料(object sender, DataGridViewRowCancelEventArgs e)
        {
            if(_刪除檢查 == null)
            {
                _刪除檢查 = new 列表處理檢查管理器();
                _目前訊息數量 = 0;
                _剩餘處理數量 = 資料GV.SelectedRows.Count;
            }

            可刪除檢查介面 資料_ = e.Row.DataBoundItem as 可刪除檢查介面;
            資料_.刪除檢查(_刪除檢查);

            if(_目前訊息數量 != _刪除檢查.字串列.Count)
            {
                _目前訊息數量 = _刪除檢查.字串列.Count;
                e.Cancel = true;
            }

            _剩餘處理數量--;
            if(_剩餘處理數量 == 0)
            {
                if (_目前訊息數量 > 0)
                {
                    var i = new 錯誤列表視窗(_刪除檢查, "刪除失敗，以下資料綁定");
                    i.Show();
                    i.BringToFront();
                }

                _刪除檢查 = null;
            }
        }

        /********************************/
        // 通用視窗介面

        public void 顯現()
        {
            this.是否關閉 = false;

            this.Show();
            this.BringToFront();
        }

        public void 顯現(int Pos_)
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
