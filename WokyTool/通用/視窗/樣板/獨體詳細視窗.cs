﻿using System;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public class 獨體詳細視窗 : Form, 通用視窗介面
    {
        public static 列舉.視窗 視窗類型 { get { return 列舉.視窗.詳細; } }
        public virtual 列舉.編號 編號類型 { get { throw new Exception(this.GetType().Name + " 未設定編號類型"); } }

        public virtual 可編輯列舉資料管理介面 編輯管理器 { get { throw new Exception(this.GetType().Name + " 未設定編輯管理器"); } }
        public virtual 新版頁索引元件 頁索引 { get { throw new Exception(this.GetType().Name + " 未設定頁索引"); } }

        public BindingSource 資料BS { get { return 編輯管理器.公用BS; } }

        public int 資料版本 { get; protected set; }
        public bool 是否關閉 { get; protected set; }

        public virtual void 初始化()
        {
            頁索引.初始化(資料BS);

            this.Activated += new System.EventHandler(this._視窗激活);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._視窗關閉);
            this.資料BS.CurrentChanged += new EventHandler(this._選擇改變);

            更新資料();
        }

        private void 更新資料()
        {
            資料版本 = 編輯管理器.資料版本;
            //資料BS.DataSource = 編輯管理器.資料列舉;
            //資料BS.ResetBindings(false);

            var x = 編輯管理器.資料列舉; // 強制更新
        }

        protected void _視窗激活(object sender, EventArgs e)
        {
            if (是否關閉)
                return;

            視窗激活();

            if (資料版本 != 編輯管理器.資料版本)
                更新資料();
        }

        protected virtual void 視窗激活()
        {
        }

        protected void _視窗關閉(object sender, FormClosingEventArgs e)
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

        protected void _選擇改變(object sender, EventArgs e)
        {
            if (false == 是否關閉)
                選擇改變();
        }

        protected virtual void 選擇改變()
        {

        }

        protected void 資料綁定(TextBox 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("Text", 資料BS, 屬性名稱_);
            元件_.ReadOnly |= !編輯管理器.是否可編輯;
        }

        protected void 資料綁定(抽象資料選取元件 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("SelectedItem", 資料BS, 屬性名稱_);
            元件_.ReadOnly |= !編輯管理器.是否可編輯;
        }

        protected void 資料綁定(抽象列舉選取元件 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("SelectedItem", 資料BS, 屬性名稱_);
            元件_.ReadOnly |= !編輯管理器.是否可編輯;
        }

        protected void 資料綁定(NumericUpDown 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("Value", 資料BS, 屬性名稱_);
            元件_.ReadOnly |= !編輯管理器.是否可編輯;
        }

        protected void 資料綁定(MyDateTimePicker 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("Value", 資料BS, 屬性名稱_);
            元件_.Enabled |= 編輯管理器.是否可編輯;
        }

        protected void 資料綁定(CheckBox 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("Checked", 資料BS, 屬性名稱_);
            元件_.Enabled |= 編輯管理器.是否可編輯;
        }

        /********************************/
        // 通用視窗介面

        public void 顯現()
        {
            this.是否關閉 = false;

            this.Show();
            this.BringToFront();

            選擇改變();
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

            選擇改變();
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
