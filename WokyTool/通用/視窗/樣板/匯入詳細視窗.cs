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
    public class 匯入詳細視窗 : Form, 通用視窗介面, 頁索引上層介面
    {
        protected 頁索引元件 _頁索引元件;
        protected 可編輯資料列管理介面 _資料管理器;

        protected bool _是否關閉 = false;

        public void 初始化(頁索引元件 頁索引元件_, 可編輯資料列管理介面 資料管理器_)
        {
            this._頁索引元件 = 頁索引元件_;
            this._資料管理器 = 資料管理器_;

            this._頁索引元件.初始化(資料管理器_, this);

            this.Activated += new System.EventHandler(this._視窗激活);
            this.Deactivate += new System.EventHandler(this._視窗去活);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._視窗關閉);
        }

        private void _視窗激活(object sender, EventArgs e)
        {
            if (_是否關閉)
                return;

            視窗激活();

            this._頁索引元件.視窗激活();
        }

        protected virtual void 視窗激活()
        {
        }

        private void _視窗去活(object sender, EventArgs e)
        {
            if (_是否關閉)
                return;

            索引切換_異動儲存();
            _資料管理器.資料異動();

            視窗去活();
        }

        protected virtual void 視窗去活()
        {
        }

        private void _視窗關閉(object sender, FormClosingEventArgs e)
        {
            _是否關閉 = true;

            索引切換_異動儲存();

            // 這邊不檢查資料是否合法 等待匯入總覽再做檢查
            _資料管理器.資料異動();

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

        /********************************/
        // 頁索引上層介面

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
            this._是否關閉 = false;

            this.Show();
            this.BringToFront();
        }

        public void 顯現(int 編號_)
        {
            this._是否關閉 = false;
            this._頁索引元件.設定位置(編號_);

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

        public bool 是否顯現()
        {
            return this.Visible;
        }
    }
}
