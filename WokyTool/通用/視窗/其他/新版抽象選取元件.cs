using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public class 新版抽象選取元件 : UserControl
    {
        public virtual BindingSource 資料BS { get { throw new Exception(this.GetType().Name + " 未設定資料BS"); } }
        public virtual ComboBox 下拉選單 { get { throw new Exception(this.GetType().Name + " 未設定下拉選單"); } }

        public virtual string 篩選文字
        {
            get { throw new Exception(this.GetType().Name + " 未設定篩選文字"); }
            set { throw new Exception(this.GetType().Name + " 未設定篩選文字"); }
        }

        protected virtual 可清單列舉資料管理介面 取得管理介面實體()
        {
            throw new Exception(this.GetType().Name + " 未複寫 取得管理介面實體");
        }

        public 可清單列舉資料管理介面 管理介面 { get; protected set; }

        public int 資料版本 { get; protected set; }

        private PropertyInfo _呈現屬性;

        public void 初始化()
        {
            管理介面 = 取得管理介面實體();

            Type Type_ = (Type)this.資料BS.DataSource;
            _呈現屬性 = Type_.GetProperty(this.下拉選單.DisplayMember);

            this.下拉選單.DropDown += new System.EventHandler(this._on開啟選單);
            this.下拉選單.TextChanged += new System.EventHandler(this._on文字異動);

            資料版本 = -1;
            更新資料();
        }

        public bool ReadOnly
        {
            get
            {
                return this.下拉選單.DropDownStyle == ComboBoxStyle.Simple;
            }

            set
            {
                if (value == true)
                    this.下拉選單.DropDownStyle = ComboBoxStyle.Simple;
                else
                    this.下拉選單.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        public object SelectedItem
        {
            get
            {
                return this.下拉選單.SelectedItem;
            }

            set
            {
                //@@@@Console.WriteLine("SelectedItem:" + value);
                // 一但有選取物件，移除篩選條件，避免指定的物件找不到
                this.篩選文字 = null;
                更新資料();

                if (this.下拉選單.SelectedItem != value)
                    this.下拉選單.SelectedItem = value;
            }
        }

        private void 更新資料()
        {
            if (資料版本 != 管理介面.資料版本)
            {
                object 舊選取物件_ = this.下拉選單.SelectedItem;

                資料版本 = 管理介面.資料版本;
                資料BS.DataSource = 管理介面.資料列舉;

                this.下拉選單.SelectedItem = 舊選取物件_;
                //@@@@Console.WriteLine("更新資料:" + this.下拉選單.SelectedItem);
            }
        }

        private void _on開啟選單(object sender, EventArgs e)
        {
            //@@@@Console.WriteLine("開啟選單:" + this.GetType().Name);
            更新資料();
        }

        private void _on文字異動(object sender, EventArgs e)
        {
            if (this.下拉選單.SelectedItem != null)
            {
                string 目前物件呈現_ = (string)_呈現屬性.GetValue(this.下拉選單.SelectedItem);
                if (this.下拉選單.Text.Equals(目前物件呈現_))
                {
                    this.篩選文字 = null;
                    return;
                }
            }

            this.篩選文字 = this.下拉選單.Text;
        }
    }
}
