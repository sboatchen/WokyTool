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
    public class 新版篩選視窗 : Form, 通用視窗介面
    {
        public static 列舉.視窗 視窗類型 { get { return 列舉.視窗.篩選; } }
        public virtual 列舉.編號 編號類型 { get { throw new Exception(this.GetType().Name + " 未設定編號類型"); } }
        public virtual 視窗可篩選介面 視窗篩選器 { get { throw new Exception(this.GetType().Name + " 未設定編號類型"); } }

        public bool 是否關閉 { get; protected set; }

        private List<Action> _視窗凍結工作列 = new List<Action>();

        public void 初始化()
        {
            this.Activated += new System.EventHandler(this._視窗激活);
            this.Deactivate += new EventHandler(this._視窗凍結);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._視窗關閉);
        }

        private void _視窗激活(object sender, EventArgs e)
        {
            if (是否關閉)
                return;

            視窗激活();
        }

        protected virtual void 視窗激活()
        {
        }

        protected void _視窗凍結(object sender, EventArgs e)
        {
            foreach (Action 工作_ in _視窗凍結工作列)
                工作_();
        }

        private void _視窗關閉(object sender, FormClosingEventArgs e)
        {
            是否關閉 = true;

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

        protected void 資料綁定(TextBox 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("Text", 視窗篩選器, 屬性名稱_);

            PropertyInfo 屬性_ = 視窗篩選器.GetType().GetProperty(屬性名稱_);
            _視窗凍結工作列.Add(() => 屬性_.SetValue(視窗篩選器, 元件_.Text));
        }

        protected void 資料綁定(新版抽象選取元件 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("SelectedItem", 視窗篩選器, 屬性名稱_);

            PropertyInfo 屬性_ = 視窗篩選器.GetType().GetProperty(屬性名稱_);
            _視窗凍結工作列.Add(() => 屬性_.SetValue(視窗篩選器, 元件_.SelectedItem));
        }

        protected void 資料綁定(NumericUpDown 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("Value", 視窗篩選器, 屬性名稱_);

            PropertyInfo 屬性_ = 視窗篩選器.GetType().GetProperty(屬性名稱_);
            if (屬性_.PropertyType == typeof(Int32))
                _視窗凍結工作列.Add(() => 屬性_.SetValue(視窗篩選器, (int)元件_.Value));
            else
                _視窗凍結工作列.Add(() => 屬性_.SetValue(視窗篩選器, 元件_.Value));
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

