using System;
using System.Drawing;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public class 新增詳細視窗 : Form, 通用視窗介面  //@@ TODO rename to 匯入詳細視窗
    {
        public virtual 新版頁索引元件 頁索引 { get { throw new Exception(this.GetType().Name + " 未設定頁索引"); } }

        public 可編輯列舉資料管理介面 更新管理器 { get; protected set; }
        public BindingSource 資料BS { get { return 更新管理器.公用BS; } }

        public int 資料版本 { get; protected set; }
        public bool 是否關閉 { get; protected set; }

        public 新增詳細視窗()
        {
        }

        public 新增詳細視窗(可編輯列舉資料管理介面 更新管理器_)
        {
            更新管理器 = 更新管理器_;
        }

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
            資料版本 = 更新管理器.資料版本;
            //資料BS.DataSource = 更新管理器.資料列舉;
            //資料BS.ResetBindings(false);

            var x = 更新管理器.資料列舉; // 強制更新
        }

        protected void _視窗激活(object sender, EventArgs e)
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

        protected virtual void _選擇改變(object sender, EventArgs e)
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
            元件_.ReadOnly |= !更新管理器.是否可編輯;
        }

        protected void 資料綁定(抽象列舉選取元件 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("SelectedItem", 資料BS, 屬性名稱_);
            元件_.ReadOnly |= !更新管理器.是否可編輯;
        }

        protected void 資料綁定(抽象資料選取元件 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("SelectedItem", 資料BS, 屬性名稱_);
            元件_.ReadOnly |= !更新管理器.是否可編輯;
        }

        protected void 資料綁定(ComboBox 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("SelectedItem", 資料BS, 屬性名稱_);

            if (元件_.DropDownStyle == ComboBoxStyle.Simple || 更新管理器.是否可編輯 == false)
                元件_.DropDownStyle = ComboBoxStyle.Simple;
            else
                元件_.DropDownStyle = ComboBoxStyle.DropDown;
        }

        protected void 資料綁定(NumericUpDown 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("Value", 資料BS, 屬性名稱_);
            元件_.ReadOnly |= !更新管理器.是否可編輯;
        }

        protected void 資料綁定(MyDateTimePicker 元件_, string 屬性名稱_)
        {
            元件_.DataBindings.Add("Value", 資料BS, 屬性名稱_);
            元件_.Enabled |= 更新管理器.是否可編輯;
        }

        protected void 資料異動顯示綁定(抽象資料選取元件 修改元件_, 抽象資料選取元件 參考元件_)
        {
            EventHandler 比較處理_ = new EventHandler(delegate(Object o, EventArgs a)
            {
                if (修改元件_.SelectedItem == 參考元件_.SelectedItem)
                    修改元件_.下拉選單.ForeColor = Color.Black;
                else
                    修改元件_.下拉選單.ForeColor = Color.Red;
            });

            修改元件_.下拉選單.SelectedValueChanged += 比較處理_;
            參考元件_.下拉選單.SelectedValueChanged += 比較處理_;
        }

        protected void 資料異動顯示綁定(TextBox 修改元件_, TextBox 參考元件_)
        {
            EventHandler 比較處理_ = new EventHandler(delegate(Object o, EventArgs a)
            {
                if (修改元件_.Text == 參考元件_.Text)
                    修改元件_.ForeColor = Color.Black;
                else if (修改元件_.ReadOnly)    //https://stackoverflow.com/questions/20688408/how-do-you-change-the-text-color-of-a-readonly-textbox
                {
                    //先將原本的BackColor取出來
                    Color backColor = 修改元件_.BackColor;
                    //設定字的Color
                    修改元件_.ForeColor = Color.Red;
                    //把原本的BackColor Assign回去
                    修改元件_.BackColor = backColor;
                }
                else
                    修改元件_.ForeColor = Color.Red;
            });

            修改元件_.TextChanged += 比較處理_;
            參考元件_.TextChanged += 比較處理_;
        }

        protected void 資料異動顯示綁定(NumericUpDown 修改元件_, NumericUpDown 參考元件_)
        {
            EventHandler 比較處理_ = new EventHandler(delegate(Object o, EventArgs a)
            {
                if (修改元件_.Value == 參考元件_.Value)
                    修改元件_.ForeColor = Color.Black;
                else if (修改元件_.ReadOnly)    //https://stackoverflow.com/questions/20688408/how-do-you-change-the-text-color-of-a-readonly-textbox
                {
                    //先將原本的BackColor取出來
                    Color backColor = 修改元件_.BackColor;
                    //設定字的Color
                    修改元件_.ForeColor = Color.Red;
                    //把原本的BackColor Assign回去
                    修改元件_.BackColor = backColor;
                }
                else
                    修改元件_.ForeColor = Color.Red;
            });

            修改元件_.ValueChanged += 比較處理_;
            參考元件_.ValueChanged += 比較處理_;
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
