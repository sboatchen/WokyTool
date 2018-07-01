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
    public class 詳細視窗<T> : Form, 通用視窗介面, 頁索引上層介面 where T : MyKeepableData
    {
        protected int _資料版本;

        protected 頁索引元件 _頁索引元件;
        protected 資料管理器<T> _資料管理器;

        protected bool _是否準備關閉 = false;

        public void 初始化(頁索引元件 頁索引元件_, 資料管理器<T> 資料管理器_)
        {
            this._頁索引元件 = 頁索引元件_;
            this._資料管理器 = 資料管理器_;

            this._頁索引元件.初始化<T>(資料管理器_.BList, this);

            this.Activated += new System.EventHandler(this._視窗激活);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._視窗關閉);
        }

        private void _視窗激活(object sender, EventArgs e)
        {
            if (_是否準備關閉)
                return;

            Console.WriteLine("視窗激活");

            視窗激活();

            this._頁索引元件.刷新();
            Console.WriteLine("視窗激活_End");
        }

        protected virtual void 視窗激活()
        {
        }

        private void _視窗關閉(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("視窗關閉");
            _是否準備關閉 = true;

            視窗關閉();

            索引切換_異動儲存();

            if (_資料管理器.IsEditing())
            {
                var result = MessageBox.Show(字串.儲存確認內容, 字串.儲存確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                _資料管理器.UpdateEdit(result == DialogResult.Yes);
            }

            this.Hide();
            
            if(e != null)
                e.Cancel = true;

            _是否準備關閉 = false;

            Console.WriteLine("視窗關閉_END");
        }

        protected virtual void 視窗關閉()
        {
 
        }

        /********************************/
        // 通用視窗介面

        public virtual void 索引切換_異動儲存()
        { 
        }

        public virtual void 索引切換_更新呈現()
        { 
        }

        /********************************/
        // 通用視窗介面

        public void 顯現()
        {
            this.Show();
            this.BringToFront();
        }

        public void 顯現(int Pos_)
        {
            this._頁索引元件.設定索引(Pos_);
            this.Show();
            this.BringToFront();
        }

        public void 隱藏()
        {
            _視窗關閉(null, null);
        }

        public bool 是否顯現()
        {
            return this.Visible;
        }
    }
}
