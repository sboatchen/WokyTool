using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public class 新版抽象選取元件 : UserControl
    {
        protected virtual 可清單列舉資料管理介面 管理介面設定 { get { throw new Exception(this.GetType().Name + " 未設定管理介面設定"); } }

        public virtual BindingSource 資料BS { get { throw new Exception(this.GetType().Name + " 未設定資料BS"); } }
        public virtual ComboBox 下拉選單 { get { throw new Exception(this.GetType().Name + " 未設定下拉選單"); } }

        public virtual string 篩選文字
        {
            get { throw new Exception(this.GetType().Name + " 未設定篩選文字"); }
            set { throw new Exception(this.GetType().Name + " 未設定篩選文字"); }
        }

        public 可清單列舉資料管理介面 管理介面 { get; protected set; }

        public int 資料版本 { get; protected set; }

        public void 初始化()
        {
            管理介面 = 管理介面設定;

            this.下拉選單.DropDown += new System.EventHandler(this._on開啟選單);
            this.下拉選單.TextChanged += new System.EventHandler(this._on文字異動);

            資料版本 = -1;
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
                if (this.下拉選單.SelectedItem != value)
                    this.下拉選單.SelectedItem = value;
            }
        }

        private void _on開啟選單(object sender, EventArgs e)
        {
            if (資料版本 != 管理介面.資料版本)
            {
                資料版本 = 管理介面.資料版本;
                資料BS.DataSource = 管理介面.資料列舉;
            }
        }

        private void _on文字異動(object sender, EventArgs e)
        {
            this.篩選文字 = this.下拉選單.Text;
        }
    }
}
